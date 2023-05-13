using CasaMendes.Classes.ADL;
using CasaMendes.Classes.Estatica;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace CasaMendes
{
    public delegate void ProcessProdutoCallback(tProduto produto);
    public class ProdutoController : tProduto, IDisposable
    {
        #region Variáveis

        private Dados oDados;

        #endregion

        public ProdutoController()
        {
            oDados = new Dados();

        }

        #region Manutenção de dados

        private void AdicionarParrametosProduto()
        {
            //if (!string.IsNullOrEmpty(barCode)) Cl_Dados.AdicionarParametro("@CodigoDeBarras2", barCode);

            //Cl_Dados.AdicionarParametro("@CodigoDeBarras", CodigoDeBarras);

            //Cl_Dados.AdicionarParametro("@DataDaCompra", DateTime.Now.ToString("AAAA-MM-DD hh:mm:ss"));
            //Cl_Dados.AdicionarParametro("@DataDeValidade", DateTime.Now.ToString("AAAA-MM-DD hh:mm:ss"));

            //Cl_Dados.AdicionarParametro("@RazaoSocial", RazaoSocial);
            //Cl_Dados.AdicionarParametro("@Nome", Nome);

            //Cl_Dados.AdicionarParametro("@Quantidade", Quantidade);
            //Cl_Dados.AdicionarParametro("@Estoque", Estoque);
            //Cl_Dados.AdicionarParametro("@Desconto", Desconto);

            //Cl_Dados.AdicionarParametro("@ValorCompra", ValorCompra);
            //Cl_Dados.AdicionarParametro("@PrecoUnitario", PrecoUnitario);
            //Cl_Dados.AdicionarParametro("@PrecoDeVenda", PrecoDeVenda);
            //Cl_Dados.AdicionarParametro("@ValorDesconto", ValorDeDesconto);

            //Cl_Dados.AdicionarParametro("@CodigoDaNotaFiscal", CodigoDaNotaFiscal);
            //Cl_Dados.AdicionarParametro("@Foto", string.Concat(Application.StartupPath, "imagens\\apagar.png"));
        }

        public void Novo()
        {
            try
            {
                AdicionarParrametosProduto();
                Cl_Dados.ExecutarProcedimento("CadastrarProduto");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Classes.Estatica.clsGlobal.RegistrarLogDeErros(0, clsMensagens.M00003 + ": " + ex.Message);
            }
        }

        public void Atualizar(string filtro)
        {
            try
            {
                AdicionarParrametosProduto();
                Cl_Dados.ExecutarProcedimento("AtualizarProduto");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
                clsGlobal.RegistrarLogDeErros(0, clsMensagens.M00003 + ": " + ex.Message);
            }
        }

        public void Excluir(string sTabela, string sId, string sFiltro)
        {
            Cl_Dados.Excluir(sTabela, sId, sFiltro);
        }

        #endregion

        #region Baixar dados

        public void Carregar(DataGridView dgv, string Procedimento)
        {

            try
            {
                oDados.AdicionarParametro("@CodigoDeBarras", this.CodigoDeBarras);
                oDados.AdicionarParametro("@Nome", this.Nome);
                dgv.DataSource = oDados.Carregar(Procedimento);

                //this.ProdutoId = int.Parse(list[0].ToString());
                //this.CodigoDeBarras = list[1].ToString();
                //this.CodigoDoFornecedor = int.Parse(list[2].ToString());
                //this.RazaoSocial = list[3].ToString();
                //this.Nome = list[4].ToString();
                //this.DataDeValidade = DateTime.Parse(list[5].ToString());
                //this.ValorCompra = decimal.Parse(list[6].ToString());
                //this.Quantidade = int.Parse(list[7].ToString());
                //this.Estoque = int.Parse(list[8].ToString());
                //this.PrecoUnitario = decimal.Parse(list[9].ToString());
                //this.PrecoDeVenda = decimal.Parse(list[10].ToString());
                //this.Desconto = int.Parse(list[11].ToString());
                //this.ValorDeDesconto = decimal.Parse(list[12].ToString());
                //this.CodigoDaNotaFiscal = int.Parse(list[13].ToString());

                //return list;
            }
            catch /*(Exception ex)*/
            {
                //return null;
            }
        }

        #endregion

        #region dispose

        private bool _disposed;
        public void Dispose()
        {
            // Dispose of unmanaged resources.
            Dispose(true);
            // Suppress finalization.
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
            {
                return;
            }

            if (disposing)
            {
                // TODO: dispose managed state (managed objects).
            }

            // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
            // TODO: set large fields to null.

            _disposed = true;
        }

        #endregion

    }

}


        //public void Carregar2()
        //{

        //    try
        //    {
        //        //ProdutoId = null;
        //        CodigoDeBarras = "7840092411111";
        //        Nome = null;
        //        //sp = "GO";

        //        var sp ="spCarregarProduto";
        //        oDados.AdicionarParametro("@CodigoDeBarras", this.CodigoDeBarras);
        //        oDados.AdicionarParametro("@Nome", this.Nome);

        //        var list = new ArrayList();
        //        list = oDados.Selecionar(sp);

        //        this.ProdutoId = int.Parse(list[0].ToString());
        //        this.CodigoDeBarras = list[1].ToString();
        //        this.CodigoDoFornecedor = int.Parse(list[2].ToString());
        //        this.RazaoSocial = list[3].ToString();
        //        this.Nome = list[4].ToString();
        //        this.DataDeValidade = DateTime.Parse(list[5].ToString());
        //        this.ValorCompra = decimal.Parse(list[6].ToString());
        //        this.Quantidade = int.Parse(list[7].ToString());
        //        this.Estoque = int.Parse(list[8].ToString());
        //        this.PrecoUnitario = decimal.Parse(list[9].ToString());
        //        this.PrecoDeVenda = decimal.Parse(list[10].ToString());
        //        this.Desconto = int.Parse(list[11].ToString());
        //        this.ValorDeDesconto = decimal.Parse(list[12].ToString());
        //        this.CodigoDaNotaFiscal = int.Parse(list[13].ToString());

        //    }
        //    catch /*(Exception ex)*/
        //    {
                
        //    }
        //}

        //public ArrayList Carregar()
        //{

        //    try
        //    {
        //        //ProdutoId = null;
        //        CodigoDeBarras = "7840092411111";
        //        Nome = "null";
        //        //sp = "GO";

        //        var sp = "";
        //        sp = "spCarregarProduto";
        //        //sp = "SELECT [idProduto] ,[CodigoDeBarras] ,[CodigoDoFornecedor],[Nome],[DataDeValidade],[ValorCompra],[Quantidade],[Estoque],[PrecoUnitario] ,[PrecoDeVenda],[Desconto],[DataDaCompra],[ValorDesconto],[CodigoDaNotaFiscal],[created_at] ,[updated_at],[deleted_at] FROM [dbo].[tProdutos]";
        //        //sp = $"DECLARE @RC int EXECUTE @RC = [dbo].[spCarregarProduto] {this.CodigoDeBarras}, {this.Nome}";

        //        //oDados.AdicionarParametro("@idProduto", this.ProdutoId);
        //        oDados.AdicionarParametro("@CodigoDeBarras", this.CodigoDeBarras);
        //        oDados.AdicionarParametro("@Nome", this.Nome);

        //        //Dados oDados = new Dados();
        //        //var p = new Produto();

        //        var list = new ArrayList();
        //        list = oDados.Selecionar(sp);

        //        //ProcessistabackBooks(p);

        //        //this.ProdutoId = int.Parse(list[0].ToString());
        //        //this.CodigoDeBarras = list[1].ToString();
        //        //this.CodigoDoFornecedor = int.Parse(list[2].ToString());
        //        //this.RazaoSocial = list[3].ToString();
        //        //this.Nome = list[4].ToString();
        //        //this.DataDeValidade = DateTime.Parse(list[5].ToString());
        //        //this.ValorCompra = decimal.Parse(list[6].ToString());
        //        //this.Quantidade = int.Parse(list[7].ToString());
        //        //this.Estoque = int.Parse(list[8].ToString());
        //        //this.PrecoUnitario = decimal.Parse(list[9].ToString());
        //        //this.PrecoDeVenda = decimal.Parse(list[10].ToString());
        //        //this.Desconto = int.Parse(list[11].ToString());
        //        //this.ValorDeDesconto = decimal.Parse(list[12].ToString());
        //        //this.CodigoDaNotaFiscal = int.Parse(list[13].ToString());

        //        return list;
        //    }
        //    catch /*(Exception ex)*/
        //    {
        //        return null;
        //    }
        //}