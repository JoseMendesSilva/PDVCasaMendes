using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaMendes
{
    public interface IRepositorioBase<T> : IDisposable
    {
        int Insert(T Entity);
        List<T> Select(string tableName);
        List<T> SelectWithLike(string likeClause, Dictionary<string, object> parameters = null);
        List<T> SelectWithWhere(string whereClause, Dictionary<string, object> parameters = null);
        int Update(T Entity);
    }
}
