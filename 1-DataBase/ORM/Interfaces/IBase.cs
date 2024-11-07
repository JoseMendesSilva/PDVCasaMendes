using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading.Tasks;

namespace CasaMendes
{
    [ComVisible(true)]
    public interface IBase
    {
        int Key { get; }

        [MethodImpl(MethodImplOptions.InternalCall)]
        Task<int> Salvar();

        //void Insert<T>(T entity, string tableName, bool enableIdentityInsert = false);

        //void Update<T>(T entity, string tableName, string keyColumn);

        [MethodImpl(MethodImplOptions.InternalCall)]
        Task<int> SalvarSql(string Query);

        [MethodImpl(MethodImplOptions.InternalCall)]
        Task<int> Excluir();

        [MethodImpl(MethodImplOptions.InternalCall)]
        [SecurityCritical]
        Task<bool> CriarTabela();

        [MethodImpl(MethodImplOptions.InternalCall)]
        [SecurityCritical]
        Task<bool> TabelaExiste();

        [MethodImpl(MethodImplOptions.InternalCall)]
        Task<List<IBase>> Todos();

        [MethodImpl(MethodImplOptions.InternalCall)]
        Task<List<IBase>> Busca();

        [MethodImpl(MethodImplOptions.InternalCall)]
        Task<IBase> BuscaBase();

        [MethodImpl(MethodImplOptions.InternalCall)]
        Task<List<IBase>> BuscaComLike();

        [MethodImpl(MethodImplOptions.InternalCall)]
        Task<List<IBase>> BuscaMaiorIgual();

        [MethodImpl(MethodImplOptions.InternalCall)]
        Task<List<IBase>> BuscaSqlQuery(string Sql);
    }

}
