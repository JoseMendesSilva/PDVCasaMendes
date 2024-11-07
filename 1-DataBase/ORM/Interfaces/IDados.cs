using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CasaMendes
{
    public interface IDados : IDisposable
    {
        string ClauseCampo { get; set; }
        string ClauseValor { get; set; }

        string whereClause { get; }
        string likeClause { get; }

        Dictionary<string, object> ParametroWhere();
        Dictionary<string, object> ParametroLike();

        int Insert<T>(T entity, bool enableIdentityInsert = false);
        int Update<T>(T entity);

        List<T> Select<T>(string query);
        List<T> Select<T>(string query, string condicao);
        List<T> SelectWithLike<T>(string tableName, string likeClause, Dictionary<string, object> parameters = null);
        List<T> SelectWithWhere<T>(string tableName, string whereClause, Dictionary<string, object> parameters = null);
        List<T> GetPaginatedDataAsync<T>(int pageNumber, int rowsPerPage);
    }
}