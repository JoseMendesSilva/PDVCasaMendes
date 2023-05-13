using System;
using System.Collections.Generic;
using System.Data;
using oDados = CasaMendes.Classes.ADL.Cl_Dados;

namespace CasaMendes.Classes
{
    public class Cl_FrenteDeCaixa : Propriedades.Cl_pFrenteDeCaixa
    {

        public void BuscarExibirItem(string Filtro = "0")
        {
            try
            {
                string sSql = "SELECT Nome, (PrecoDeVenda * " + Quantidade + ") as SubTotal, PrecoDeVenda as valor FROM tEstoque WHERE CodigoDeBarras = '" + Filtro + "'";

                DataSet oDs = new DataSet("tEstoque");
                //oDados.AdicionarParametro("@CodigoDeBarras", Filtro);
                oDs = oDados.CarregarDataset(sSql, "tEstoque");

                Produto = string.Empty;
                Valor = 0;
                SubTotal = 0;
                Desconto = 0;

                foreach (DataRow Linha in oDs.Tables["tEstoque"].Rows)
                {
                    //===============================================================================
                    Nome = Convert.ToString(Linha["Nome"].ToString());
                    Valor = Convert.ToDecimal(Linha["valor"].ToString());
                    SubTotal = Convert.ToDecimal(Linha["Subtotal"].ToString());
                    Desconto = 0; 
                }

            }
            catch
            {

            }
        }

        void AdicionarParametros()
        {
            if (oDados.Params.Count != 0) oDados.Params.Clear();
            oDados.AdicionarParametro("@CodigoDaVenda", Convert.ToDecimal(this.CodigoDaVenda.ToString()));
            oDados.AdicionarParametro("@CodigoDoCliente", Convert.ToDecimal(this.CodigoDoCliente.ToString()));
            oDados.AdicionarParametro("@CodigoDeBarras", Convert.ToDecimal(this.CodigoDeBarras.ToString().Trim()));
            oDados.AdicionarParametro("@NumeroDaVenda", this.NumeroDaVenda.ToString());
            oDados.AdicionarParametro("@Quantidade", Convert.ToDecimal(this.Quantidade.ToString()));
            oDados.AdicionarParametro("@DataDaVenda", Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd")));
            oDados.AdicionarParametro("@TipoDeVenda", Convert.ToString(this.TipoDeVenda));
            oDados.AdicionarParametro("@StatusDaVenda", Convert.ToBoolean(this.StatusDaVenda.ToString()));
            oDados.AdicionarParametro("@Dinheiro", Convert.ToDecimal(this.Dinheiro.ToString()));
            oDados.AdicionarParametro("@DescontoAplicado", Convert.ToDecimal(this.DescontoAplicado.ToString()));
            oDados.AdicionarParametro("@Troco", Convert.ToDecimal(this.Troco.ToString()));
            oDados.AdicionarParametro("@Parcela", Convert.ToDecimal(this.Parcela.ToString()));
        }

        List<string> ListarCampos()
        {
            List<string> Campo = new List<string>
            { "tPreVendas",
                "CodigoDaVenda",
                "CodigoDoCliente",
                "CodigoDeBarras",
                "NumeroDaVenda",
                "Quantidade",
                "DataDaVenda",
                "TipoDeVenda",
                "StatusDaVenda",
                "Dinheiro",
                "DescontoAplicado",
                "Troco",
                "Parcela"
            };
            return Campo;
        }

        public void Gravar(Enumeradores.eAcao _Acao)
        {
            if (_Acao == Enumeradores.eAcao.Cadastrar)
            {
                CodigoDaVenda = Convert.ToDecimal(oDados.LerMaxima("tPreVendas", "CodigoDaVenda"));
                if (CodigoDaVenda == 0) { CodigoDaVenda = 1; }
                AdicionarParametros();
                oDados.CadastrarVendas(ListarCampos());
                string sSql = "UPDATE tEstoque SET(Estoque - " + this.Quantidade + " ) WHERE CodigoDeBarras = " + this.CodigoDeBarras;
                oDados.ExecutarQueryVendas(sSql, false);
            }
            else
            {
                AdicionarParametros();
                oDados.AtualizarVendas(ListarCampos(), true);

            }
        }
        
    }
}
