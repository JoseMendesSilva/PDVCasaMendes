using DocumentFormat.OpenXml.Drawing.Wordprocessing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;

namespace CasaMendes
{
    public class Repository<T> where T : class
    {
        //private readonly string _connectionString;

        //public Repository(string connectionString)
        //{
        //    _connectionString = connectionString;
        //}

        //public void Insert(T entity, string tableName)
        //{
        //    // Reflection para coletar propriedades e valores, excluindo colunas de identidade
        //    var properties = typeof(T).GetProperties()
        //                              .Where(prop => !Attribute.IsDefined(prop, typeof(DatabaseGeneratedAttribute)))
        //                              .ToDictionary(prop => prop.Name, prop => prop.GetValue(entity) ?? DBNull.Value);

        //    var columnNames = string.Join(", ", properties.Keys);
        //    var parameters = string.Join(", ", properties.Keys.Select(key => "@" + key));

        //    string query = $"INSERT INTO {tableName} ({columnNames}) VALUES ({parameters});";

        //    using (SqlConnection connection = new SqlConnection(_connectionString))
        //    {
        //        SqlCommand command = new SqlCommand(query, connection);

        //        foreach (var kvp in properties)
        //        {
        //            command.Parameters.AddWithValue("@" + kvp.Key, kvp.Value);
        //        }

        //        connection.Open();
        //        command.ExecuteNonQuery();
        //    }
        //}

        //public T GetById(int id, string tableName)
        //{
        //    // Implementação para busca pelo ID...
        //}

        //public void Update(T entity, string tableName, int id)
        //{
        //    // Implementação do método de atualização...
        //}

        //public void Delete(int id, string tableName)
        //{
        //    // Implementação do método de exclusão...
        //}
    }
}

    //public class Repository<T> where T : new()
    //{
    //    private readonly string _connectionString;

    //    public Repository(string connectionString)
    //    {
    //        _connectionString = connectionString;
    //    }

    //    private string ProcessarInsert<T>(T entity, ref Dictionary<string, object> DicProperties, ref string keyColumn, bool Inserir = true)
    //    {
    //        var nameIs = entity.GetType().Name.ToString();
    //        foreach (PropertyInfo pi in entity.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance))
    //        {
    //            OpcoesBase pOpcoesBase = (OpcoesBase)pi.GetCustomAttribute(typeof(OpcoesBase));
    //            if (pOpcoesBase != null && pOpcoesBase.ChavePrimaria)
    //            {
    //                if (Inserir)
    //                    continue;
    //                keyColumn = pi.Name;
    //                DicProperties[pi.Name] = pi.GetValue(entity, null);
    //                continue;
    //                //}
    //            }
    //            DicProperties[pi.Name] = pi.GetValue(entity, null);
    //        }
    //        return $"{nameIs}s";
    //    }

    //    public void Insert(T entity, string tableName = "")
    //    {
    //        var columnNames = new List<string>();
    //        var parameterNames = new List<string>();
    //        var parameters = new List<SqlParameter>();

    //        var engoto = "";

    //        var properties = new Dictionary<string, object>();
    //         tableName = this.ProcessarInsert(entity, ref properties, ref engoto);

    //        // Adicionar propriedades e valores aos parâmetros
    //        foreach (var prop in properties)
    //        {
    //            if (prop.Value != null)
    //            {
    //                columnNames.Add(prop.Key);
    //                parameterNames.Add("@" + prop.Key);
    //                //parameters.Add(new SqlParameter("@" + prop.Key, prop.Value));
    //            }
    //        }

    //        // Gerar comando SQL
    //        string query = $"INSERT INTO {tableName} ({string.Join(", ", columnNames)}) VALUES ({string.Join(", ", parameterNames)})";

    //        using (SqlConnection connection = new SqlConnection(_connectionString))
    //        {
    //            SqlCommand command = new SqlCommand(query, connection);
    //            foreach (var property in properties)
    //            {
    //                command.Parameters.AddWithValue("@" + property.Key, property.Value ?? DBNull.Value);
    //            }

    //            connection.Open();
    //            command.ExecuteNonQuery();
    //        }
    //    }

    //    public List<T> GetAll(string tableName)
    //    {
    //        string query = $"SELECT * FROM {tableName};";
    //        List<T> list = new List<T>();

    //        using (SqlConnection connection = new SqlConnection(_connectionString))
    //        {
    //            SqlCommand command = new SqlCommand(query, connection);
    //            connection.Open();
    //            SqlDataReader reader = command.ExecuteReader();

    //            while (reader.Read())
    //            {
    //                T entity = new T();
    //                foreach (var property in typeof(T).GetProperties())
    //                {
    //                    if (reader[property.Name] != DBNull.Value)
    //                    {
    //                        property.SetValue(entity, reader[property.Name]);
    //                    }
    //                }
    //                list.Add(entity);
    //            }
    //        }

    //        return list;
    //    }

    //    public void Update(T entity, string tableName, string keyColumn)
    //    {
    //        var properties = typeof(T).GetProperties();
    //        var setClause = string.Join(", ", properties.Select(p => $"{p.Name} = @{p.Name}"));

    //        string query = $"UPDATE {tableName} SET {setClause} WHERE {keyColumn} = @{keyColumn};";

    //        using (SqlConnection connection = new SqlConnection(_connectionString))
    //        {
    //            SqlCommand command = new SqlCommand(query, connection);
    //            foreach (var property in properties)
    //            {
    //                command.Parameters.AddWithValue("@" + property.Name, property.GetValue(entity) ?? DBNull.Value);
    //            }

    //            connection.Open();
    //            command.ExecuteNonQuery();
    //        }
    //    }

    //    public void Delete(object id, string tableName, string keyColumn)
    //    {
    //        string query = $"DELETE FROM {tableName} WHERE {keyColumn} = @id;";

    //        using (SqlConnection connection = new SqlConnection(_connectionString))
    //        {
    //            SqlCommand command = new SqlCommand(query, connection);
    //            command.Parameters.AddWithValue("@id", id);

    //            connection.Open();
    //            command.ExecuteNonQuery();
    //        }
    //    }

    //}
