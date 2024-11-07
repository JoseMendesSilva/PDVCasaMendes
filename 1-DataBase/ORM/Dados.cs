using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Reflection;

namespace CasaMendes
{
    public class Dados : IDados
    {
        private readonly string _connectionString = Conexao.GetConnectionString();

        private bool disposed = false;

        public virtual string ClauseCampo { get; set; } = "";
        public virtual string ClauseValor { get; set; } = "";

        public virtual string likeClause { get => string.Concat(ClauseCampo, " LIKE @", ClauseCampo); }
        public virtual string whereClause { get => string.Concat(ClauseCampo, " = @", ClauseCampo); }

        //        string likeClause = "Nome LIKE @Nome";
        public virtual Dictionary<string, object> ParametroWhere()
        {
            return new Dictionary<string, object> {
                 { $"{this.ClauseCampo}", this.ClauseValor  }
                 };
        }

        public virtual Dictionary<string, object> ParametroLike()
        {
            return new Dictionary<string, object> {
                 { $"{this.ClauseCampo}", $"%{this.ClauseValor}%"  }
                 };
        }

        private string ProcessarInsert<T>(T entity, ref Dictionary<string, object> DicProperties, ref string keyColumn, bool Inserir = true)
        {
            var nameIs = entity.GetType().Name.ToString();
            foreach (PropertyInfo pi in entity.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance))
            {
                //OpcoesBase pOpcoesBase = (OpcoesBase)pi.GetCustomAttribute(typeof(OpcoesBase));
                //if (pOpcoesBase != null && pOpcoesBase.ChavePrimaria)
                //{
                //    if (Inserir)
                //        continue;
                //    keyColumn = pi.Name;
                //    DicProperties[pi.Name] = pi.GetValue(entity, null);
                //    continue;
                //    //}
                //}
                DicProperties[pi.Name] = pi.GetValue(entity, null);
            }
            return $"{nameIs}s";
        }

        public virtual int Insert<T>(T entity, bool enableIdentityInsert = false)
        {
            // Criar listas para colunas e parâmetros
            var columnNames = new List<string>();
            var parameterNames = new List<string>();
            var parameters = new List<SqlParameter>();

            var engoto = "";

            var DicProperties = new Dictionary<string, object>();
            var tableName = this.ProcessarInsert(entity, ref DicProperties, ref engoto);

            // Adicionar propriedades e valores aos parâmetros
            foreach (var prop in DicProperties)
            {
                if (prop.Value != null)
                {
                    columnNames.Add(prop.Key);
                    parameterNames.Add("@" + prop.Key);
                    //parameters.Add(new SqlParameter("@" + prop.Key, prop.Value));
                }
            }

            // Gerar comando SQL
            string sql = $"INSERT INTO {tableName} ({string.Join(", ", columnNames)}) VALUES ({string.Join(", ", parameterNames)})";

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var retorno = 0;

                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Ativar IDENTITY_INSERT se necessário
                        if (enableIdentityInsert)
                        {
                            var identityOnCommand = new SqlCommand($"SET IDENTITY_INSERT {tableName} ON;", connection, transaction);
                            identityOnCommand.ExecuteNonQuery();
                        }

                        // Comando de inserção
                        using (var command = new SqlCommand(sql, connection, transaction))
                        {
                            command.Parameters.AddRange(parameters.ToArray());
                            retorno = command.ExecuteNonQuery();
                        }

                        // Desativar IDENTITY_INSERT se ativado
                        if (enableIdentityInsert)
                        {
                            var identityOffCommand = new SqlCommand($"SET IDENTITY_INSERT {tableName} OFF;", connection, transaction);
                            identityOffCommand.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        return retorno;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception("Erro ao inserir no banco de dados", ex);
                    }
                }
            }
        }

        public virtual int InsertSeNaoExistir<T>(T entity, string Filtro)
        {
            // Criar listas para colunas e parâmetros
            var columnNames = new List<string>();
            var parameterNames = new List<string>();
            var parameters = new List<SqlParameter>();

            var engoto = "";

            var DicProperties = new Dictionary<string, object>();
            var tableName = this.ProcessarInsert(entity, ref DicProperties, ref engoto);

            // Adicionar propriedades e valores aos parâmetros
            foreach (var prop in DicProperties)
            {
                if (prop.Value != null)
                {
                    columnNames.Add(prop.Key);
                    parameterNames.Add("@" + prop.Key);
                    parameters.Add(new SqlParameter("@" + prop.Key, prop.Value));
                }
            }
            //parameters.Add(new SqlParameter("@CodigoBarras", Filtro));

           // Gerar comando SQL
            string sql = $"INSERT INTO {tableName} ({string.Join(", ", columnNames)}) VALUES ({string.Join(", ", parameterNames)})";

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var retorno = 0;

                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Comando de inserção
                        using (var command = new SqlCommand(sql, connection, transaction))
                        {
                            command.Parameters.AddRange(parameters.ToArray());
                            retorno = command.ExecuteNonQuery();
                        }
                        transaction.Commit();
                        return retorno;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception("Erro ao inserir no banco de dados", ex);
                    }
                }
            }
        }

        public virtual int Update<T>(T entity)
        {
            // Listas para armazenar os pares coluna=valor e os parâmetros
            var setClauses = new List<string>();
            var parameters = new List<SqlParameter>();
            SqlParameter keyParameter = null;

            string keyColumn = "";
            var DicProperties = new Dictionary<string, object>();
            var tableName = this.ProcessarInsert(entity, ref DicProperties, ref keyColumn, false);

            foreach (var prop in DicProperties)
            {
                // Evitar adicionar a coluna chave no SET, ela será usada na cláusula WHERE
                if (prop.Key.Equals(keyColumn, StringComparison.OrdinalIgnoreCase))
                {
                    keyParameter = new SqlParameter("@" + keyColumn, prop.Value);
                    continue;
                }

                if (prop.Value != null)
                {
                    setClauses.Add($"{prop.Key} = @{prop.Key}");
                    parameters.Add(new SqlParameter("@" + prop.Key, prop.Value));
                }
            }

            // Gerar comando SQL de update
            string sql = $"UPDATE {tableName} SET {string.Join(", ", setClauses)} WHERE {keyColumn} = @{keyColumn}";

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var retorno = 0;

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
                            retorno = command.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        return retorno;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception("Erro ao atualizar o banco de dados", ex);
                    }
                }
            }
        }

        public virtual int UpdateSql(string Sql)
        {
            
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var retorno = 0;

                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Comando de atualização
                        using (var command = new SqlCommand(Sql, connection, transaction))
                        {
                            // Executar o comando
                            retorno = command.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        return retorno;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception("Erro ao atualizar o banco de dados", ex);
                    }
                }
            }
        }

        public virtual List<T> Select<T>(string query)
        {
            try
            {
                var results = new List<T>();
                Type entityType = typeof(T);

                // Gerar a query SELECT
                string sql = $"{query}";

                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    using (var command = new SqlCommand(sql, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            // Mapear os resultados para a lista de entidades
                            while ( reader.Read())
                            {
                                var entity = Activator.CreateInstance<T>();
                                foreach (var prop in entityType.GetProperties())
                                {
                                    if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                                    {
                                        SetProperty(ref entity, reader);
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

        public virtual List<T> Select<T>(string query, string condicao = null)
        {
            try
            {
                var results = new List<T>();
                Type entityType = typeof(T);

                // Gerar a query SELECT
                string sql = $"{query} {condicao}";

                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    using (var command = new SqlCommand(sql, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            // Mapear os resultados para a lista de entidades
                            while (reader.Read())
                            {
                                var entity = Activator.CreateInstance<T>();
                                foreach (var prop in entityType.GetProperties())
                                {
                                    if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                                    {
                                        //if (prop.PropertyType == typeof(DateTime))
                                        //{
                                        var value = reader[prop.Name].ToString();
                                        //    if (DateTime.TryParse(valor, out DateTime data))
                                        //        prop.SetValue(entity, valor);
                                        //    continue;
                                        //}
                                        if (prop != null && prop.PropertyType == typeof(DateTime))
                                        {
                                            if (string.IsNullOrEmpty(value))
                                            {
                                                // Definindo um valor padrão para DateTime
                                                prop.SetValue(entity, DateTime.MinValue); // ou DateTime.Now, se preferir
                                                continue;
                                            }
                                            else
                                            {
                                                DateTime dateValue = DateTime.Parse(value);
                                                prop.SetValue(entity, dateValue);
                                                continue;
                                            }
                                        }
                                        else if (prop != null && prop.PropertyType == typeof(DateTime?))
                                        {
                                            DateTime? dateValue = string.IsNullOrEmpty(value) ? (DateTime?)null : DateTime.Parse(value);
                                            prop.SetValue(entity, dateValue);
                                            continue;
                                        }

                                        prop.SetValue(entity, reader[prop.Name]);
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

        public virtual List<T> SelectWithWhere<T>(string tableName, string whereClause, Dictionary<string, object> parameters = null)
        {
            var results = new List<T>();
            Type entityType = typeof(T);
            try
            {


                // Gerar a query SELECT
                string sql = $"SELECT * FROM {tableName} WHERE {whereClause}";

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
                        //Stopwatch stopwatch = Stopwatch.StartNew();
                        //stopwatch.Start();

                        //using (var reader = await command.ExecuteReaderAsync(CommandBehavior.SequentialAccess))
                        //{
                        // Continue o mapeamento
                        //var propertyMap = entityType.GetProperties().Where(prop => !reader.IsDBNull(reader.GetOrdinal(prop.Name))).ToDictionary(prop => prop.Name);

                        //while (await reader.ReadAsync())
                        //{
                        //    var entity = Activator.CreateInstance<T>();
                        //    foreach (var kvp in propertyMap)
                        //    {
                        //        kvp.Value.SetValue(entity, reader[kvp.Key]);
                        //    }
                        //    results.Add(entity);
                        //}

                        using (var reader = command.ExecuteReader())
                        {
                            // Mapear os resultados para a lista de entidades
                            while (reader.Read())
                            {
                                var entity = Activator.CreateInstance<T>();
                                foreach (var prop in entityType.GetProperties())
                                {
                                    if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                                    {
                                        prop.SetValue(entity, reader[prop.Name]);
                                        //SetProperty(ref entity, reader);
                                    }
                                }
                                results.Add(entity);
                            }
                        }
                        //}

                        //stopwatch.Stop();
                        //var elapsed = stopwatch.ElapsedMilliseconds;
                        //MessageBox.Show($"Tempo decorrido: {elapsed}");
                    }

                    return results;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public virtual List<T> SelectWithLike<T>(string tableName, string likeClause, Dictionary<string, object> parameters = null)
        {
            try
            {
                var results = new List<T>();
                Type entityType = typeof(T);

                // Gerar a query SELECT com LIKE
                string sql = $"SELECT * FROM {tableName} WHERE {likeClause}";

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

                        using (var reader = command.ExecuteReader())
                        {
                            // Mapear os resultados para a lista de entidades
                            while (reader.Read())
                            {
                                var entity = Activator.CreateInstance<T>();
                                foreach (var prop in entityType.GetProperties())
                                {
                                    if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                                    {
                                        SetProperty(ref entity, reader);
                                        //prop.SetValue(entity, reader[prop.Name]);
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
                throw new Exception(ex.Message);
            }
        }

        public virtual List<T> GetPaginatedDataAsync<T>(int pageNumber, int rowsPerPage)
        {
            var results = new List<T>();
            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand(@"SELECT * FROM PreVendas ORDER BY created_at DESC OFFSET (@PageNumber - 1) * @RowsPerPage ROWS FETCH NEXT @RowsPerPage ROWS ONLY", connection))
            {
                command.Parameters.AddWithValue("@PageNumber", pageNumber);
                command.Parameters.AddWithValue("@RowsPerPage", rowsPerPage);

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var entity = Activator.CreateInstance<T>();
                        foreach (var prop in typeof(T).GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {
                                SetProperty(ref entity, reader);  //prop.SetValue(entity, reader[prop.Name]);
                            }
                        }
                        results.Add(entity);
                    }
                }
            }
            return results;
        }

        public virtual List<T> GetPaginatedDataAsync<T>(string query, int pageNumber, int rowsPerPage)
        {
            try
            {
                var results = new List<T>();
                //query = $@"{query}

                using (var connection = new SqlConnection(_connectionString))
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PageNumber", pageNumber);
                    command.Parameters.AddWithValue("@RowsPerPage", rowsPerPage);

                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var entity = Activator.CreateInstance<T>();
                            foreach (var prop in typeof(T).GetProperties())
                            {
                                if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                                {
                                    SetProperty(ref entity, reader);  //prop.SetValue(entity, reader[prop.Name]);
                                }
                            }
                            results.Add(entity);
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

        //--------------------------------------------------------------------
        private void SetProperty<T>(ref T obj, SqlDataReader reader)
        {
            foreach (PropertyInfo pi in obj.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance))
            {
                //OpcoesBase pOpcoesBase = (OpcoesBase)pi.GetCustomAttribute(typeof(OpcoesBase));
                //if (pOpcoesBase != null && pOpcoesBase.UsarNoBancoDeDados)
                //{
                string value;
                switch (pi.PropertyType.Name)
                {
                    case "String":
                        value = reader[pi.Name].ToString();
                        if (value == "") { continue; }
                        pi.SetValue(obj, value);
                        break;

                    case "Int32":
                        value = reader[pi.Name].ToString();
                        if (value == "") { continue; }
                        pi.SetValue(obj, int.Parse(reader[pi.Name].ToString()));
                        break;

                    case "bigint":
                        pi.SetValue(obj, Int64.Parse(reader[pi.Name].ToString()));
                        break;

                    case "Double":
                        double valor;// = 0;
                        value = reader[pi.Name].ToString();
                        if (value == "") { continue; }
                        if (Double.TryParse(value, out valor))
                            pi.SetValue(obj, valor);
                        else
                            pi.SetValue(obj, value);
                        break;

                    case "Decimal":
                        value = reader[pi.Name].ToString();
                        if (value == "") { continue; }
                            pi.SetValue(obj, clsGlobal.AplicarFormato(value));
                        break;

                    case "DateTime":
                        value = reader[pi.Name].ToString();
                        if (value == "") { continue; }
                        value = reader[pi.Name].ToString();
                        DateTime dateTime = clsGlobal.DeStringParaData(value);
                            pi.SetValue(obj, dateTime);
                        break;
                   
                    case "tinyint":
                        pi.SetValue(obj, bool.Parse(reader[pi.Name].ToString()));
                        break;
                    case "DBNull":
                        continue;
                    default:
                        break;
                }
            }
        }

        //-----------------------------------------------
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {

                }
            }
            disposed = true;
        }

        public virtual void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    
    }
}

/*
 
// Definir a cláusula WHERE e os parâmetros
string whereClause = "IdCategoria = @IdCategoria";
var parameters = new Dictionary<string, object>
{
    { "IdCategoria", 1 }
};

// Buscar as categorias que atendem ao critério
var categorias = dbHelper.Select<TesteCategorias>("TesteCategorias", whereClause, parameters);
*/

//-----------------------------------------------------------------------------
/*
 
// Definir a cláusula LIKE e os parâmetros
string likeClause = "NomeCategoria LIKE @NomeCategoria";
var parameters = new Dictionary<string, object>
{
    { "NomeCategoria", "%Teste%" }
};

// Buscar as categorias que contenham "Teste" no nome
var categorias = dbHelper.SelectWithLike<TesteCategorias>("TesteCategorias", likeClause, parameters);
*/
//---------------------------------------------------------------------------
