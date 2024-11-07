using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CasaMendes
{
    public class RepositorioPreVenda //: IRepositorioPreVenda<PreVenda>
    {
        private bool disposedValue;
        //public string ClauseCampo { get; set; } = "CodigoDeBarras";
        //public string ClauseValor { get; set; } = "AVISTA";

        //public string whereClause { get => $"{ClauseCampo} = @{ClauseCampo}"; }
        //public string likeClause { get => $"{ClauseCampo} LIKE @%{ClauseValor.ToUpper()}%"; } 


        ////        // Exemplo de uso para buscar categorias com `LIKE`
        ////        // Definir a cláusula LIKE e os parâmetros
        ////        string likeClause = "Nome LIKE @Nome";
        ////        parameters = new Dictionary<string, object>{
        ////            { "Nome", "%ar%" }
        ////        };

        //public Dictionary<string, object> ParametroWhere(string CodigoDeBarras)
        //{
        //    return new Dictionary<string, object> {
        //         { $"{this.ClauseCampo}", this.ClauseValor  }
        //         };
        //}

        //public Dictionary<string, object> ParametroLike(string CodigoDeBarras)
        //{
        //    return new Dictionary<string, object> {
        //         { "Nome", $"%{CodigoDeBarras}%"  }
        //         };
        //}

        //public int Insert(PreVenda Entity)
        //{
        //    var onde = new Dados().Update(Entity);
        //    return onde;
        //}

        //public List<PreVenda> Select(string tableName)
        //{
        //    var todos =  new Dados().Select<PreVenda>(tableName);
        //    return todos;
        //}

        //public List<PreVenda> SelectWithLike(string likeClause, Dictionary<string, object> parameters = null)
        //{
        //    var noMeio =  new Dados().SelectWithLike<PreVenda>("PreVendas", likeClause, parameters);
        //    return noMeio;
        //}

        //public List<PreVenda> SelectWithWhere(string whereClause, Dictionary<string, object> parameters = null)
        //{
        //    var onde =  new Dados().SelectWithWhere<PreVenda>("PreVendas", whereClause, parameters);
        //    return onde;
        //}

        //public int Update(PreVenda Entity)
        //{
        //    var onde = new Dados().Update(Entity);
        //    return onde;
        //}


        //protected virtual void Dispose(bool disposing)
        //{
        //    if (!disposedValue)
        //    {
        //        if (disposing)
        //        {
        //            // TODO: dispose managed state (managed objects)
        //        }

        //        // TODO: free unmanaged resources (unmanaged objects) and override finalizer
        //        // TODO: set large fields to null
        //        disposedValue = true;
        //    }
        //}

        ////TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        //~RepositorioPreVenda()
        //{
        //    // Não altere este código. Coloque o código de limpeza no método 'Dispose(bool disposing)'
        //    Dispose(disposing: false);
        //}

        //public void Dispose()
        //{
        //    // Não altere este código. Coloque o código de limpeza no método 'Dispose(bool disposing)'
        //    Dispose(disposing: true);
        //    GC.SuppressFinalize(this);
        //}

    }
}
