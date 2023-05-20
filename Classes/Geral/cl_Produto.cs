
using CasaMendes.Classes.ADL;
using CasaMendes.Classes.Estatica;
using CasaMendes.Propriedades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

/*
 Executing a stored procedure
To execute a stored procedure, you use the CALL statement:
CALL stored_procedure_name(argument_list);
*/

namespace CasaMendes.Classes.Geral
{
    public class Cl_Produto : Cl_pProduto
    {

        #region Variáveis


        private string sCodigoDaNota;

        #endregion

        #region Manutenção de dados

        private void AdicionarParrametosProduto(string barCode = null)
        {
            if(!string.IsNullOrEmpty(barCode)) Cl_Dados.AdicionarParametro("@CodigoDeBarras2", barCode);

            Cl_Dados.AdicionarParametro("@CodigoDeBarras", CodigoDeBarras);

            Cl_Dados.AdicionarParametro("@DataAtualizacao", DateTime.Now);
            Cl_Dados.AdicionarParametro("@DataDaCompra", DateTime.Now);
            Cl_Dados.AdicionarParametro("@DataDeValidade", DateTime.Now);

            Cl_Dados.AdicionarParametro("@RazaoSocial", RazaoSocial);
            Cl_Dados.AdicionarParametro("@Nome", Nome);

            Cl_Dados.AdicionarParametro("@Quantidade", Quantidade);
            Cl_Dados.AdicionarParametro("@Estoque", Estoque);
            Cl_Dados.AdicionarParametro("@Desconto", Desconto);
            
            Cl_Dados.AdicionarParametro("@ValorCompra", ValorCompra);
            Cl_Dados.AdicionarParametro("@PrecoUnitario", PrecoUnitario);
            Cl_Dados.AdicionarParametro("@PrecoDeVenda", PrecoDeVenda);
            Cl_Dados.AdicionarParametro("@ValorDesconto", ValorDesconto);
            
            Cl_Dados.AdicionarParametro("@CodigoDaNotaFiscal", CodigoDaNotaFiscal);
            Cl_Dados.AdicionarParametro("@Foto", string.Concat(Application.StartupPath, "imagens\\apagar.png"));
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
                AdicionarParrametosProduto(filtro);
                Cl_Dados.ExecutarProcedimento("AtualizarProduto");}
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
                clsGlobal.RegistrarLogDeErros(0, clsMensagens.M00003 + ": " + ex.Message);
            }
        }
 
        public void AtualizarLote(string filtro, double valor)
        {
            try
            {              
                string sSql = $"UPDATE [dbo].[tProdutos] set [PrecoDeVenda] = {valor.ToString("0.00")}  WHERE Nome like '%{filtro}%';";
                Cl_Dados.AtualizarLote(sSql.Replace(",","."));

                sSql = $"UPDATE [dbo].[tEstoque] set [PrecoDeVenda] = { valor}  WHERE Nome like '%{filtro}%';";
                Cl_Dados.AtualizarLote(sSql.Replace(",", "."));
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

        public static List<Cl_pProduto> CarregarProduto(string Filtro = "-1")
        {
            string sSql = "";
            try
            {
                if (Filtro == "*")
                {
                    sSql = "SELECT";
                    sSql += "  idProduto";
                    sSql += ", CodigoDeBarras";
                    sSql += ", tFornecedores.CodigoDoFornecedor";
                    sSql += ", tFornecedores.RazaoSocial AS Fornecedor";
                    sSql += ", Nome";
                    sSql += ", DataDeValidade AS [D. validade]";
                    sSql += ", ValorCompra AS [V. compra]";
                    sSql += ", Quantidade";
                    sSql += ", Estoque";
                    sSql += ", PrecoUnitario AS [P. Unitário]";
                    sSql += ", PrecoDeVenda AS [P. venda]";
                    sSql += ", Desconto";
                    sSql += ", ValorDesconto AS [V. desconto]";
                    sSql += ", CodigoDaNotaFiscal";
                    sSql += " FROM [tProdutos] inner join tFornecedores on tProdutos.CodigoDoFornecedor = tFornecedores.CodigoDoFornecedor where [deleted_at] IS NULL";
                }
                else
                {
                    if (Filtro != "-1")
                    {
                        sSql = "SELECT";
                        sSql += "  idProduto";
                        sSql += ", CodigoDeBarras";
                        sSql += ", tFornecedores.CodigoDoFornecedor";
                        sSql += ", tFornecedores.RazaoSocial AS Fornecedor";
                        sSql += ", Nome";
                        sSql += ", DataDeValidade AS [D. validade]";
                        sSql += ", ValorCompra AS [V. compra]";
                        sSql += ", Quantidade";
                        sSql += ", Estoque";
                        sSql += ", PrecoUnitario AS [Unitário]";
                        sSql += ", PrecoDeVenda AS [P. venda]";
                        sSql += ", Desconto";
                        sSql += ", ValorDesconto AS [V. desconto]";
                        sSql += ", CodigoDaNotaFiscal";
                        sSql += " FROM [tProdutos] inner join tFornecedores on tProdutos.CodigoDoFornecedor = tFornecedores.CodigoDoFornecedor WHERE tProdutos.CodigoDeBarras = @CodigoDeBarras AND [deleted_at] IS NULL";

                        //sSql = "SELECT  tProdutos.ID_Produto, tProdutos.CodigoDeBarras, tFornecedores.CodigoDoFornecedor, tFornecedores.RazaoSocial AS Fornecedor, tProdutos.Produto, DataDeValidade AS [D. validade], ValorCompra AS [V. compra], Quantidade, Estoque, PrecoUnitario AS [Unitário], PrecoDeVenda AS [P. venda], Desconto, ValorDesconto AS [V. desconto] FROM [tProdutos] inner join tFornecedores on tProdutos.CodigoDoFornecedor = tFornecedores.CodigoDoFornecedor WHERE tProdutos.ID_Produto  = @ID_Produto";
                    }
                }

                ArrayList arr = new ArrayList();
                arr = Cl_Dados.ListarDados(sSql, "CodigoDeBarras", Filtro);
                if (arr != null)
                {
                    List<Cl_pProduto> pL = new List<Cl_pProduto>();
                    Cl_pProduto p = new Cl_pProduto();
                    p.CodigoDeBarras = arr[1].ToString();
                    p.RazaoSocial = arr[3].ToString();
                    p.Nome = arr[4].ToString();
                    p.DataDeValidade = DateTime.Parse(arr[5].ToString());
                    p.ValorCompra = decimal.Parse(arr[6].ToString());
                    p.Quantidade = int.Parse(arr[7].ToString());
                    p.Estoque = int.Parse(arr[8].ToString());
                    p.PrecoUnitario = decimal.Parse(arr[9].ToString());
                    p.PrecoDeVenda = decimal.Parse(arr[10].ToString());
                    p.Desconto = int.Parse(arr[11].ToString());
                    p.ValorDesconto = decimal.Parse(arr[12].ToString());

                    pL.Add(p);

                    return pL;
                }
                else { return null; }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void CarregarParaVender(DataGridView dgv, string Filtro = "-1", string FiltrarPorCodigoDeBarras = "-1")
        {
            string sSql = "";
            try
            {
                
                    sSql = "SELECT";
                    sSql += "  idEstoque";
                    sSql += ", CodigoDeBarras";
                    sSql += ", Nome";
                    sSql += ", PrecoDeVenda AS [Preco de venda]";
                    sSql += " FROM [tEstoque] ORDER BY Nome";
                
                if (Filtro != "*")
                {
                    if (FiltrarPorCodigoDeBarras == "-1")
                    {
                        sSql = "SELECT";
                        sSql += "  idEstoque";
                        sSql += ", CodigoDeBarras";
                        sSql += ", Nome";
                        sSql += ", PrecoDeVenda AS [Preco de venda]";
                        sSql += " FROM [tEstoque] WHERE  Nome LIKE '%" + Filtro + "%' ORDER BY Nome";
                    }
                    else
                    {
                        sSql = "SELECT";
                        sSql += "  idEstoque";
                        sSql += ", CodigoDeBarras";
                        sSql += ", Nome";
                        sSql += ", PrecoDeVenda AS [Preco de venda]";
                        sSql += " FROM [tEstoque] WHERE CodigoDeBarras = '" + FiltrarPorCodigoDeBarras + "'";
                    }
                }
                dgv.DataSource = Cl_Dados.PegarDados(sSql);
                clsGlobal.SetUpDataGridView(dgv);

            }
            catch { }
        }

        public string CodigoDaNota(string Filtro)
        {
             sCodigoDaNota = Cl_Dados.RetornoEscalarDeUmRegistro("SELECT CodigoDaNotaFiscal FROM [tProdutos] where CodigoDeBarras = '" + Filtro + "'").ToString();
             return sCodigoDaNota;
        }
             
        public static void CarregarProdutoPorCodigoDaNota(DataGridView dgv, string Filtro)
        {
            string sSql = "";
            try
            {
                sSql = "SELECT";
                sSql += $" ROW_NUMBER() OVER(ORDER BY idProduto ASC) AS #Linha,";
                sSql += $" (SELECT  SUM(ValorCompra) AS [V. compra] FROM [tProdutos] WHERE CodigoDaNotaFiscal = '{Filtro}' AND [deleted_at] IS NULL) as Total";
                sSql += ", CodigoDeBarras";
                sSql += ", Nome";
                sSql += ", DataDeValidade AS [D. validade]";
                sSql += ", ValorCompra AS [V. compra]";
                sSql += ", Quantidade";
                sSql += ", Estoque";
                sSql += ", PrecoUnitario AS [P. Unitário]";
                sSql += ", PrecoDeVenda AS [P. venda]";
                sSql += ", Desconto";
                sSql += ", ValorDesconto AS [V. desconto]";
                sSql += $" FROM [tProdutos] WHERE CodigoDaNotaFiscal like '%{Filtro}%' AND [deleted_at] IS NULL";
                dgv.DataSource = Cl_Dados.PegarDados(sSql);
            }
            catch { }
        }

        public static void CarregarDoEstoque(DataGridView dgv, string Filtro = "null", string CodigoDeBarras = "null")
        {
            string sSql = "";
            try
            {
                //sSql = " SELECT * FROM tEstoque WHERE Nome LIKE '%" + Filtro + "%' OR CodigoDeBarras = '" + CodigoDeBarras + "'ORDER BY tEstoque.Produto";

                sSql = " SELECT";
                sSql += " [idEstoque]";
                sSql += ",[CodigoDeBarras]";
                sSql += ",[Nome]";
                sSql += ",[DataDeValidade]";
                sSql += ",[Quantidade]";
                sSql += ",[ValorCompra]";
                sSql += ",[PrecoUnitario]";
                sSql += ",[PrecoDeVenda]";
                sSql += ",[Estoque]";
                sSql += ",[Desconto]";
                sSql += ",[ValorDesconto]";
                sSql += " FROM [tEstoque] WHERE Nome LIKE '%" + Filtro + "%' OR CodigoDeBarras = '" + CodigoDeBarras + "'ORDER BY tEstoque.Nome";
                dgv.DataSource = Cl_Dados.PegarDados(sSql);

            }
            catch { }
        }

        public void CarregarCaixaCombo(ComboBox cb, string sItem, string sTabela)
        {
            try
            {
                cb.Items.Clear();
                cb.DataSource = Cl_Dados.PegarArrayListDados("SELECT " + sItem + " FROM " + sTabela);
            }
            catch
            {
            }
        }

        #endregion

        #region dispose

        //private bool _disposed;
        //public new void Dispose()
        //{
        //    // Dispose of unmanaged resources.
        //    Dispose(true);
        //    // Suppress finalization.
        //    GC.SuppressFinalize(this);
        //}

        //protected virtual new void Dispose(bool disposing)
        //{
        //    if (_disposed)
        //    {
        //        return;
        //    }

        //    if (disposing)
        //    {
        //        // TODO: dispose managed state (managed objects).
        //    }

        //    // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
        //    // TODO: set large fields to null.

        //    _disposed = true;
        //}

        #endregion

    }

}
