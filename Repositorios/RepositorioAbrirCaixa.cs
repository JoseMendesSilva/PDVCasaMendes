using CasaMendes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JoseMendes
{

    internal class RepositorioAbrirCaixa// : IRepositorioAbrirCaixa<AbrirCaixa>
    {
        //private readonly IDados context;
        //private bool disposed = false;

        //public RepositorioAbrirCaixa()
        //{
        //  this.context = new Dados();
        //}

        ///// <summary>
        ///// O código 1002 representa falha ao verificar se o caixa esta aberto.
        ///// </summary>
        ///// <returns>AbrirCaixa</returns>
        ///// <exception cref="Exception">1002</exception>
        //public static AbrirCaixa OCaixaEstaAberto()
        //{
        //    try
        //    {
        //        string whereClause = "Status = @Status";
        //        var parameters = new Dictionary<string, object> {
        //        {"Status", "Aberto" }
        //    };
        //        var result =  new Dados().SelectWithWhere<AbrirCaixa>("AbrirCaixas", whereClause, parameters);

        //        return result.First();
        //    }
        //    catch
        //    {
        //        throw new Exception("Códiga: 1002");
        //    }
        //}

        //public bool Insert<T>(T entity, bool enableIdentityInsert = false)
        //{
        //    var result = context.Insert(entity); //.Where(m => m.MovimentoId == TEntity.MovimentoId).AsNoTracking().FirstOrDefault();
        //    return result > 0;
        //}

        //public List<T> SelectWithWhere<T>(string tableName, string likeClause, Dictionary<string, object> parameters = null)
        //{
        //    var result = context.SelectWithWhere<T>(tableName, likeClause, parameters); //.Where(m => m.MovimentoId == TEntity.MovimentoId).AsNoTracking().FirstOrDefault();
        //    return result;
        //}

        //public List<T> SelectWithLike<T>(string tableName, string likeClause, Dictionary<string, object> parameters)
        //{
        //    var result = context.SelectWithLike<T>(tableName, likeClause, parameters = null); //.Where(m => m.MovimentoId == TEntity.MovimentoId).AsNoTracking().FirstOrDefault();
        //    return result;
        //}

        //public bool Update<T>(T entity)
        //{
        //    var result = context.Update(entity);
        //    return result > 0;
        //}

        //protected virtual void Dispose(bool disposing)
        //{
        //    if (!disposed)
        //    {
        //        if (disposing)
        //        {
        //            context.Dispose();
        //        }
        //    }
        //    disposed = true;
        //}

        //public void Dispose()
        //{
        //    Dispose(true);
        //    GC.SuppressFinalize(this);
        //}

    }
}


//// O modificador, new, oculta o método do repositório principal.
//public new async Task<bool> AtualizarAsync(MovimentoDiario TEntity)
//{
//    var result = context.Movimentos.Where(m => m.MovimentoId == TEntity.MovimentoId).AsNoTracking().FirstOrDefault();
//    if (result == null) return false;
//    context.Update(TEntity);
//    return await context.SaveChangesAsync() > 0;
//}

//public new async Task<MovimentoDiario> BuscaPorIdAsync(int id)
//{
//    return await context.Movimentos.FindAsync(id);
//}

//public async Task<IEnumerable<MovimentoDiario>> BuscaPorDataAsync(DateTime dataInicio, DateTime dataFim)
//{
//    using (var context = new MovimentoContexto())
//    {
//        return await context.Movimentos.Where(x => x.DataCadastro >= dataInicio && x.DataCadastro <= dataFim).OrderBy(o => o.DataCadastro).AsNoTracking().ToListAsync();
//        //return busca;
//    }
//}

//public int BuscarUltimoIdAsync()
//{
//    return context.Movimentos.OrderByDescending(x => x.MovimentoId).Max(x => x.MovimentoId);
//}

//public new async Task<bool> ExcluirAsync(int id)
//{
//    var res = await context.Movimentos.FindAsync(id);
//    return await context.SaveChangesAsync() > 0;
//}

//public new async Task<IEnumerable<MovimentoDiario>> BuscarTodos()
//{
//    return await context.Movimentos.ToListAsync();
//}

//public new async Task<bool> InserirAsync(MovimentoDiario TEntity)
//{
//    context.Movimentos.Add(TEntity);
//    return await context.SaveChangesAsync() > 0;
//}

//public async Task<bool> AtualizarCaixaAtualAsync(decimal ValorCaixaAtual)
//{
//    try
//    {
//        using (var context = new MovimentoContexto())
//        {
//            var result = await context.Movimentos.OrderByDescending(o => o.MovimentoId).Take(1).FirstAsync();//.Where(x => x.CaixaAtual != ValorCaixaAtual).AsNoTracking().ToListAsync();
//            result.CaixaAtual = ValorCaixaAtual;
//            context.Update(result);
//            context.SaveChanges();
//            return true;
//        }
//    }
//    catch
//    { return false; }
//}

//public async Task<decimal> BuscararUltimoCaixaAtualAsync()
//{
//    try
//    {
//        using (var context = new MovimentoContexto())
//        {
//            //LinqPad
//            //var result = await (from m in context.Movimentos
//            //                    let c = m.CaixaAtual
//            //                    orderby m.CaixaAtual
//            //                    orderby m.CaixaAtual descending
//            //                    select m.CaixaAtual).Take(1).FirstAsync();//context.Movimentos.OrderBy(o => o.CaixaAtual).LastAsync();//.Where(x => x.CaixaAtual != ValorCaixaAtual).AsNoTracking().ToListAsync();
//            var result = await context.Movimentos.OrderByDescending(o => o.MovimentoId).Take(1).FirstAsync();//.Where(x => x.CaixaAtual != ValorCaixaAtual).AsNoTracking().ToListAsync();
//            return (result.CaixaAtual is not null) ? (decimal)result.CaixaAtual : 0;
//        }
//    }
//    catch
//    { return 0; }
//}


//public async Task<IEnumerable<MovimentoDiario>> SomatoriaPorDataAsync(DateTime dataInicio, DateTime dataFim)
//{
//    using (var context = new MovimentoContexto())
//    {
//        //var busca = await context.Movimentos.Where(x => x.DataCadastro >= dataInicio && x.DataCadastro <= dataFim).OrderBy(o => o.DataCadastro).AsNoTracking().ToListAsync();
//        var query = context.Movimentos
//                .Where(m => m.DataCadastro >= dataInicio && m.DataCadastro <= dataFim)
//                .GroupBy(m => new
//                {
//                    m.MovimentoId,
//                    m.DataCadastro,
//                    m.Descricao,
//                    m.SaldoInicialDoDia,
//                    m.SaldoFinalDoDia,
//                    m.SaidaPessoal,
//                    m.SaidaEmpresa,
//                    m.ValorTotalBruto,
//                    m.ValorTotalLiquido
//                })
//                .Select(g => new
//                {
//                    g.Key.MovimentoId,
//                    g.Key.DataCadastro,
//                    g.Key.Descricao,
//                    g.Key.SaldoInicialDoDia,
//                    g.Key.SaldoFinalDoDia,
//                    g.Key.SaidaPessoal,
//                    g.Key.SaidaEmpresa,
//                    g.Key.ValorTotalBruto,
//                    g.Key.ValorTotalLiquido
//                })
//                .ToList();

//        var r = query;
//        //return (IEnumerable<MovimentoDiario>)query;

//        var result = query
//            .GroupBy(x => 1)
//            .Select(g => new
//            {
//                SaldoInicialDoDia = g.Sum(x => x.SaldoInicialDoDia),
//                SaldoFinalDoDia = g.Sum(x => x.SaldoFinalDoDia),
//                SaidaPessoal = g.Sum(x => x.SaidaPessoal),
//                SaidaEmpresa = g.Sum(x => x.SaidaEmpresa),
//                ValorTotalBruto = g.Sum(x => x.ValorTotalBruto),
//                ValorTotalLiquido = g.Sum(x => x.ValorTotalLiquido)
//            })
//            .FirstOrDefault();
//        var mov = new MovimentoDiario
//        {
//            Descricao = $"Resultados obtidos no intervalo de {dataInicio} até {dataFim}",
//            SaldoInicialDoDia = result!.SaldoInicialDoDia,
//            SaldoFinalDoDia = result.SaldoFinalDoDia,
//            SaidaPessoal = result.SaidaPessoal,
//            SaidaEmpresa = result.SaidaEmpresa,
//            ValorTotalBruto = result.ValorTotalBruto,
//            ValorTotalLiquido = result.ValorTotalLiquido
//        };

//        return (IEnumerable<MovimentoDiario>)mov;
//    }
//}

//public async Task<MovimentoDiario> SomatoriaPorDataAsync2(DateTime dataInicio, DateTime dataFim)
//{
//    using (var context = new MovimentoContexto())
//    {
//        var query = context.Movimentos
//                .Where(m => m.DataCadastro >= dataInicio && m.DataCadastro <= dataFim)
//                .GroupBy(m => new
//                {
//                    m.MovimentoId,
//                    m.DataCadastro,
//                    m.Descricao,
//                    m.SaldoInicialDoDia,
//                    m.SaldoFinalDoDia,
//                    m.SaidaPessoal,
//                    m.SaidaEmpresa,
//                    m.ValorTotalBruto,
//                    m.ValorTotalLiquido
//                })
//                .Select(g => new
//                {
//                    g.Key.MovimentoId,
//                    g.Key.DataCadastro,
//                    g.Key.Descricao,
//                    g.Key.SaldoInicialDoDia,
//                    g.Key.SaldoFinalDoDia,
//                    g.Key.SaidaPessoal,
//                    g.Key.SaidaEmpresa,
//                    g.Key.ValorTotalBruto,
//                    g.Key.ValorTotalLiquido
//                })
//                .ToList();

//        var result = query
//            .GroupBy(x => 1)
//            .Select(g => new
//            {
//                SaldoInicialDoDia = g.Sum(x => x.SaldoInicialDoDia),
//                SaldoFinalDoDia = g.Sum(x => x.SaldoFinalDoDia),
//                SaidaPessoal = g.Sum(x => x.SaidaPessoal),
//                SaidaEmpresa = g.Sum(x => x.SaidaEmpresa),
//                ValorTotalBruto = g.Sum(x => x.ValorTotalBruto),
//                ValorTotalLiquido = g.Sum(x => x.ValorTotalLiquido)
//            })
//            .FirstOrDefault();
//        var mov = new MovimentoDiario
//        {
//            Descricao = $"Resultados obtidos no intervalo de {dataInicio} até {dataFim}",
//            SaldoInicialDoDia = result!.SaldoInicialDoDia,
//            SaldoFinalDoDia = result.SaldoFinalDoDia,
//            SaidaPessoal = result.SaidaPessoal,
//            SaidaEmpresa = result.SaidaEmpresa,
//            ValorTotalBruto = result.ValorTotalBruto,
//            ValorTotalLiquido = result.ValorTotalLiquido
//        };

//        //var esperar = 0;
//        //esperar = 0;

//        return mov;
//    }
//}
