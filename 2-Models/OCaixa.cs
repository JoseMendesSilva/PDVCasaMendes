using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaMendes
{
    public class OCaixa
    {
        //private AbrirCaixa caixaAberto;

        //public string whereClause { get; } = "AbrirCaixaId = @AbrirCaixaId";

        //public Dictionary<string, object> Parametro(int AbrirCaixaId)
        //{
        //    return new Dictionary<string, object> {
        //         {"AbrirCaixaId", AbrirCaixaId  }
        //         };
        //}

        //private T Buscar<T>(string tabela) where T : class, new()
        //{
        //    caixaAberto = new AbrirCaixa();
        //    caixaAberto = EstaAberto();
        //    var result = new Dados().SelectWithWhere<T>(tabela, whereClause, Parametro(caixaAberto.AbrirCaixaId));
        //    if (result.Count > 0)
        //    {
        //        return result.First();
        //    }
        //    return null;
        //}

        ///// <summary>
        ///// O código 1002 representa falha ao verificar se o caixa esta aberto.
        ///// </summary>
        ///// <returns>AbrirCaixa</returns>
        ///// <exception cref="Exception">1002</exception>
        //public AbrirCaixa EstaAberto()
        //{
        //    try
        //    {
        //        using (var dados = new Dados())
        //        {
        //            dados.ClauseCampo = "Status";
        //            dados.ClauseValor = "Aberto";
        //            string whereClause = "Status = @Status";
        //            var parameters = new Dictionary<string, object> { { "Status", "Aberto" } };
        //            var result = dados.SelectWithWhere<AbrirCaixa>("AbrirCaixas", whereClause, dados.ParametroWhere());
        //            if (result.Any())
        //            {
        //                caixaAberto = result.First();
        //                return caixaAberto;
        //            }
        //            return null;
        //        }
        //    }
        //    catch
        //    {
        //        throw new Exception("Código: 1002: ");
        //    }
        //}

        //public bool RegistrarCaixa(decimal valor, decimal desconto)
        //{
        //    try
        //    {
        //        caixaAberto = EstaAberto();
        //        var retorno = 0;
        //        var caixa = Buscar<Caixa>("Caixas");


        //        if (caixa != null)
        //        {
        //            caixa.AbrirCaixaId = caixaAberto.AbrirCaixaId;
        //            caixa.Desconto += desconto;
        //            caixa.Valor += valor;
        //            retorno = new Dados().Update(caixa);
        //        }
        //        else
        //        {
        //            caixa = new Caixa();
        //            caixa.AbrirCaixaId = caixaAberto.AbrirCaixaId;
        //            caixa.Desconto = desconto;
        //            caixa.Valor = valor;
        //            retorno = new Dados().Insert(caixa);
        //        }
        //        return retorno > 0;

        //    }
        //    catch
        //    {
        //        throw new Exception("Código: 1003");
        //    }
        //}

        //public bool RegistrarSuprimento(decimal valor)
        //{
        //    try
        //    {
        //        var retorno = 0;
        //        var suprimento = Buscar<Suprimento>("Suprimentos");

        //        if (suprimento.AbrirCaixaId > 0)
        //        {
        //            suprimento.AbrirCaixaId = caixaAberto.AbrirCaixaId;
        //            suprimento.FuncionarioId = caixaAberto.FuncionarioId;
        //            suprimento.Valor += valor;
        //            retorno = new Dados().Update(suprimento);
        //        }
        //        else
        //        {
        //            suprimento.AbrirCaixaId = caixaAberto.AbrirCaixaId;
        //            suprimento.FuncionarioId = caixaAberto.FuncionarioId;
        //            suprimento.Valor = valor;
        //            retorno = new Dados().Insert(suprimento);
        //        }
        //        return retorno > 0;

        //    }
        //    catch
        //    {
        //        throw new Exception("Código: 1003");
        //    }
        //}

        //public bool RegistrarSangria(decimal valor)
        //{
        //    try
        //    {
        //        var retorno = 0;
        //        var sangria = Buscar<Sangria>("Sangrias");

        //        if (sangria.AbrirCaixaId > 0)
        //        {
        //            sangria.AbrirCaixaId = caixaAberto.AbrirCaixaId;
        //            sangria.FuncionarioId = caixaAberto.FuncionarioId;
        //            sangria.Valor += valor;
        //            retorno = new Dados().Update(sangria);
        //        }
        //        else
        //        {
        //            sangria.AbrirCaixaId = caixaAberto.AbrirCaixaId;
        //            sangria.FuncionarioId = caixaAberto.FuncionarioId;
        //            sangria.Valor = valor;
        //            retorno = new Dados().Insert(sangria);
        //        }
        //        return retorno > 0;

        //    }
        //    catch
        //    {
        //        throw new Exception("Código: 1003");
        //    }
        //}

        //public bool FecharCaixa(decimal valor, int funcionarioId)
        //{
        //    try
        //    {
        //        var retorno = 0;
        //        using (var Aberto = EstaAberto())
        //        {
        //            var caixaAberto = Buscar<FecharCaixa>("FecharCaixas");

        //            var fecharCaixa = new FecharCaixa
        //            {
        //                AbrirCaixaId = Aberto.AbrirCaixaId,
        //                FuncionarioId = Aberto.FuncionarioId,
        //                Valor = valor,
        //                Status = $"Fechado",
        //                DataHora = DateTime.Now
        //            };

        //            retorno = new Dados().Insert(fecharCaixa);

        //            //caixaAberto.Valor = valor;
        //            Aberto.Status = $"Fechado";
        //            Aberto.DataHora = Aberto.DataHora;
        //            retorno = new Dados().Update(Aberto);
        //        }
        //        return retorno > 0;
        //    }
        //    catch
        //    {
        //        throw new Exception("Código: 1003");
        //    }
        //}

    }
}
