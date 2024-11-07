using CasaMendes.Servicos;
using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Vml.Office;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Reflection;
using System.Threading.Tasks;

namespace CasaMendes
{
    public sealed class DatabaseHelperContext : IDatabaseHelperContext
    {
        private readonly string _connectionString;

        public DatabaseHelperContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        // Retorna a propriedades ChavePrimaria e seu valor de uma entity
        private Dictionary<string, object> GetKey<T>(T entity)
        {
            Type entityType = typeof(T);
            var properties = entityType.GetProperties();
            var parameters = new Dictionary<string, object>();

            foreach (var prop in properties)
            {
                var value = prop.GetValue(entity, null);

                OpcoesBase pOpcoesBase = (OpcoesBase)prop.GetCustomAttribute(typeof(OpcoesBase));
                if (value != null && pOpcoesBase != null && pOpcoesBase.ChavePrimaria)
                {
                    parameters[prop.Name] = value;
                }
            }
            return parameters;
        }

        /// <summary>
        /// Retorna todas as propriedades que podem serem 
        /// usadas para efetuar busca no banco de dados.
        /// </summary>
        /// <typeparam name="T">Entidade que representa a tabela.</typeparam>
        /// <param name="entity">Objeto com as propriedades que vão gerar a consulta</param>
        /// <returns>Dictionary<string(key), object(value)></returns>
        private Dictionary<string, object> GetFieldsAnValues<T>(T entity)
        {
            Type entityType = typeof(T);
            var properties = entityType.GetProperties();
            var obj = new Dictionary<string, object>();

            foreach (var prop in properties)
            {
                var value = prop.GetValue(entity, null);

                OpcoesBase pOpcoesBase = (OpcoesBase)prop.GetCustomAttribute(typeof(OpcoesBase));
                if (value != null && pOpcoesBase != null && pOpcoesBase.UsarParaBuscar)
                {
                    if (value.ToString() != "0")
                        obj[prop.Name] = value;
                }
            }
            return obj;
        }

        /// <summary>
        /// Gera uma consulta Where.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>String</returns>
        private string GetWhere(Dictionary<string, object> obj)
        {
            var y = 0;
            var tmp = "";
            string whereClause = "";

            foreach (var item in obj)
            {
                //if (y == 0 && obj.Count > 1)
                //{
                tmp = $"{item.Key} = '{item.Value}'";
                //}
                //else
                //{
                //    tmp += $" and {item.Key} = '{item.Value}'";
                //}
            }
            return whereClause = tmp;
        }

        private string GetLike(Dictionary<string, object> obj)
        {
            //var y = 0;
            var tmp = "";
            string whereClause = "";

            foreach (var item in obj)
            {
                //if (y == 0 && obj.Count > 1)
                //{
                tmp = $"{item.Key} like '%{item.Value}%'";
                //}
                //else
                //{
                //    tmp += $" and {item.Key} = '{item.Value}'";
                //}
            }
            return whereClause = tmp;
        }

        public async Task<bool> Insert<T>(T entity, bool enableIdentityInsert = false)
        {
            var result = false;

            Type entityType = typeof(T);
            var properties = entityType.GetProperties();
            string tableName = entityType.Name;
            // Criar listas para colunas e parâmetros
            var columnNames = new List<string>();
            var parameterNames = new List<string>();
            var parameters = new List<SqlParameter>();

            // Adicionar propriedades e valores aos parâmetros
            foreach (var prop in properties)
            {
                var value = prop.GetValue(entity, null);

                OpcoesBase pOpcoesBase = (OpcoesBase)prop.GetCustomAttribute(typeof(OpcoesBase));
                if (value != null && !pOpcoesBase.ChavePrimaria)
                {
                    columnNames.Add(prop.Name);
                    parameterNames.Add("@" + prop.Name);
                    parameters.Add(new SqlParameter("@" + prop.Name, value));
                }
            }

            // Gerar comando SQL
            string sql = $"INSERT INTO {tableName} ({string.Join(", ", columnNames)}) VALUES ({string.Join(", ", parameterNames)})";

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Ativar IDENTITY_INSERT se necessário
                        if (enableIdentityInsert)
                        {
                            var identityOnCommand = new SqlCommand($"SET IDENTITY_INSERT {tableName} ON;", connection, transaction);
                            result = identityOnCommand.ExecuteNonQuery() > 0;
                        }

                        // Comando de inserção
                        using (var command = new SqlCommand(sql, connection, transaction))
                        {
                            command.Parameters.AddRange(parameters.ToArray());
                            result = await command.ExecuteNonQueryAsync() > 0;
                        }

                        // Desativar IDENTITY_INSERT se ativado
                        if (enableIdentityInsert)
                        {
                            var identityOffCommand = new SqlCommand($"SET IDENTITY_INSERT {tableName} OFF;", connection, transaction);
                            result = await identityOffCommand.ExecuteNonQueryAsync() > 0;
                        }

                        transaction.Commit();
                        return result;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception("Erro ao inserir no banco de dados", ex);
                    }
                }
            }
        }

        public async Task<bool> Update<T>(T entity)
        {
            var result = false;

            Type entityType = typeof(T);
            var properties = entityType.GetProperties();

            var tableName = entityType.Name;

            var s = tableName.Substring(tableName.Length - 1, 1);
            if (s != "s" || s != "S")
                tableName += "s";

            var key = GetKey(entity);
            var keyColumn = "";
            // Listas para armazenar os pares coluna=valor e os parâmetros
            var setClauses = new List<string>();
            var parameters = new List<SqlParameter>();
            SqlParameter keyParameter = null;

            foreach (var param in key)
            {
                //command.Parameters.AddWithValue("@" + param.Key, param.Value ?? DBNull.Value);
                keyColumn = param.Key;
                var keyValue = param.Value;

                foreach (var prop in properties)
                {
                    var value = prop.GetValue(entity, null);

                    // Evitar adicionar a coluna chave no SET, ela será usada na cláusula WHERE
                    if (prop.Name.Equals(keyColumn, StringComparison.OrdinalIgnoreCase))
                    {
                        keyParameter = new SqlParameter("@" + keyColumn, keyValue);
                        continue;
                    }

                    if (value != null)
                    {
                        setClauses.Add($"{prop.Name} = @{prop.Name}");
                        parameters.Add(new SqlParameter("@" + prop.Name, value));
                    }
                }
            }

            // Gerar comando SQL de update
            string sql = $"UPDATE {tableName} SET {string.Join(", ", setClauses)} WHERE {keyColumn} = @{keyColumn}";

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Comando de atualização
                        using (var command = new SqlCommand(sql, connection, transaction))
                        {
                            // Adicionar parâmetros (colunas a serem atualizadas)
                            command.Parameters.AddRange(parameters.ToArray());
                            // Adicionar o parâmetro da coluna chave
                            command.Parameters.Add(keyParameter);

                            // Executar o comando
                            result = await command.ExecuteNonQueryAsync() > 0;
                        }

                        transaction.Commit();
                        return result;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception("Erro ao atualizar o banco de dados", ex);
                    }
                }
            }
        }

        public async Task<List<T>> Select<T>(T entity)
        {
            var results = new List<T>();
            Type entityType = typeof(T);

            var tableName = entityType.Name;
            var parameters = GetFieldsAnValues(entity);
            var whereClause = GetWhere(parameters);

            var s = tableName.Substring(tableName.Length - 1, 1);
            if (s != "s" || s != "S")
                tableName += "s";

            var key = GetKey(entity);
            //var keyColumn = "";

            // Gerar a query SELECT
            string sql = $"SELECT * FROM {tableName} WHERE {whereClause}";

            Console.WriteLine("---------Query gerada pelo sistema----------");
            Console.WriteLine(sql);

            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    using (var command = new SqlCommand(sql, connection))
                    {
                        // Adicionar parâmetros se fornecidos
                        if (parameters != null)
                        {
                            foreach (var param in parameters)
                            {
                                command.Parameters.AddWithValue("@" + param.Key, param.Value ?? DBNull.Value);
                            }
                        }

                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            // Mapear os resultados para a lista de entidades
                            while (reader.Read())
                            {
                                var entitys = Activator.CreateInstance<T>();
                                foreach (var prop in entityType.GetProperties())
                                {
                                    if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                                    {
                                        prop.SetValue(entitys, reader[prop.Name]);
                                    }
                                }
                                results.Add(entity);
                            }
                        }
                    }
                }
                return results;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        //public async Task<List<T>> SelectWithLike<T>(string tableName, string likeClause, Dictionary<string, object> parameters = null)
        public async Task<List<T>> SelectWithLike<T>(T entity)
        {
            var results = new List<T>();
            Type entityType = typeof(T);
            var tableName = entityType.Name;
            var parameters = GetFieldsAnValues(entity);
            var likeClause = GetLike(parameters);

            var s = tableName.Substring(tableName.Length - 1, 1);
            if (s != "s" || s != "S")
                tableName += "s";

            var key = GetKey(entity);

            // Gerar a query SELECT com LIKE
            string sql = $"SELECT * FROM {tableName} WHERE {likeClause}";
            Console.WriteLine("---------Query gerada pelo sistema----------");
            Console.WriteLine(sql);

            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    using (var command = new SqlCommand(sql, connection))
                    {
                        // Adicionar parâmetros se fornecidos
                        if (parameters != null)
                        {
                            foreach (var param in parameters)
                            {
                                command.Parameters.AddWithValue("@" + param.Key, param.Value ?? DBNull.Value);
                            }
                        }

                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            // Mapear os resultados para a lista de entidades
                            while (reader.Read())
                            {
                                var entitys = Activator.CreateInstance<T>();
                                foreach (var prop in entityType.GetProperties())
                                {
                                    if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                                    {
                                        prop.SetValue(entitys, reader[prop.Name]);
                                    }
                                }
                                results.Add(entity);
                            }
                        }
                    }
                }

                return results;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> CriarTabela()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    string chavePrimaria = "";
                    List<string> campos = new List<string>();

                    foreach (PropertyInfo pi in this.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance))
                    {
                        OpcoesBase pOpcoesBase = (OpcoesBase)pi.GetCustomAttribute(typeof(OpcoesBase));
                        if (pOpcoesBase != null && pOpcoesBase.UsarNoBancoDeDados && !pOpcoesBase.AutoGenerantor)
                        {
                            if (pOpcoesBase.ChavePrimaria)
                            {
                                chavePrimaria = pi.Name + " int identity(1, 1) , ";
                            }
                            else
                            {
                                //campos.Add(pi.Name + " " + TipoPropriedade(pi) + " ");
                            }
                        }
                    }

                    string tabelaExiste = "IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[" + this.GetType().Name + "s]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) DROP TABLE " + this.GetType().Name + "s";
                    SqlCommand command = new SqlCommand(tabelaExiste, connection);
                    command.Connection.Open();
                    int rowsAffected = await command.ExecuteNonQueryAsync();

                    string queryString = "CREATE TABLE " + this.GetType().Name + "s (";
                    queryString += chavePrimaria;
                    queryString += string.Join(",", campos.ToArray());
                    queryString += ");";

                    command.Connection.Open();
                    rowsAffected = await command.ExecuteNonQueryAsync();
                    command.Connection.Close();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> TabelaExiste()
        {
            // Versão: Microsoft SQL Server 2019 (RTM-CU12) (KB5004524) - 15.0.4153.1 (X64)   Jul 19 2021 15:37:34   Copyright (C) 2019 Microsoft Corporation  Express Edition (64-bit) on Windows 10 Pro 10.0 <X64> (Build 19045: ) (Hypervisor) 
            SqlCommand command = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    string Existe = $"IF OBJECT_ID (N'dbo.{this.GetType().Name}s', N'U') IS NOT NULL SELECT 1;";
                    command = new SqlCommand(Existe, connection);
                    command.Connection.Open();
                    var result = 0;
                    SqlDataReader reader = await command.ExecuteReaderAsync();
                    while (reader.Read())
                    {
                        result = int.Parse(reader[0].ToString());
                    }
                    command.Connection.Close();
                    return result > 0;
                }
            }
            catch
            {
                if (command != null) command.Connection.Close();
                return false;
            }
        }

        private bool disposed = false;
        internal void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    this.Dispose();
                }
            }
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
