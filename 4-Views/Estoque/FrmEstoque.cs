
using DocumentFormat.OpenXml.Drawing;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Threading;
//using System.Reflection.Emit;
using System.Windows.Forms;

namespace CasaMendes
{
    public partial class FrmEstoque : Form
    {

        public string StatusLabel { get; set; }
        public string CodigoProduto { get; set; }
        private int LinhaIndex;
        private int Count;
        private bool frmLoading;

        #region Construtor

        public FrmEstoque()
        {
            InitializeComponent();
            this.Count = 0;
            this.LinhaIndex = -1;
            this.frmLoading = true;
        }

        private void RedimencionarGrade()
        {
            try
            {
                DgvProdutos.RowHeadersVisible = false;

                for (int i = 0; i < DgvProdutos.Columns.Count; i++)
                {
                    if ((DgvProdutos.Columns[i] == DgvProdutos.Columns["EstoqueId"]) || (DgvProdutos.Columns[i] == DgvProdutos.Columns["ProdutoId"]) || (DgvProdutos.Columns[i] == DgvProdutos.Columns["Foto"]) || (DgvProdutos.Columns[i] == DgvProdutos.Columns["Key"]))
                    {
                        DgvProdutos.Columns[i].Visible = false;
                    }
                }

                DgvProdutos.Columns["CodigoDeBarras"].HeaderText = "Cód Barras".ToUpper();
                DgvProdutos.Columns["QuantidadeItemDesconto"].HeaderText = "Dsc. Q. Itens".ToUpper();
                DgvProdutos.Columns["ValorDesconto"].HeaderText = "Desc. aplicado".ToUpper();
                DgvProdutos.Columns["Produto"].HeaderText = "Produto".ToUpper();
                DgvProdutos.Columns["Quantidade"].HeaderText = "Estoque".ToUpper();
                DgvProdutos.Columns["PrecoDeVenda"].HeaderText = "Valor venda".ToUpper();
                DgvProdutos.Columns["created_at"].HeaderText = "D. cadastro".ToUpper();
                DgvProdutos.Columns["updated_at"].HeaderText = "Atualizado".ToUpper();
                DgvProdutos.Columns["deleted_at"].HeaderText = "Inativo".ToUpper();

                DgvProdutos.Columns["CodigoDeBarras"].Width = clsGlobal.DimencionarColuna(9, this.Width);
                DgvProdutos.Columns["QuantidadeItemDesconto"].Width = clsGlobal.DimencionarColuna(10, this.Width);
                DgvProdutos.Columns["ValorDesconto"].Width = clsGlobal.DimencionarColuna(11, this.Width);
                DgvProdutos.Columns["Produto"].Width = clsGlobal.DimencionarColuna(20, this.Width);
                DgvProdutos.Columns["Quantidade"].Width = clsGlobal.DimencionarColuna(8, this.Width);
                DgvProdutos.Columns["PrecoDeVenda"].Width = clsGlobal.DimencionarColuna(9, this.Width);
                DgvProdutos.Columns["created_at"].Width = clsGlobal.DimencionarColuna(9, this.Width);
                DgvProdutos.Columns["updated_at"].Width = clsGlobal.DimencionarColuna(9, this.Width);
                DgvProdutos.Columns["deleted_at"].Width = clsGlobal.DimencionarColuna(7, this.Width);
                DgvProdutos.Columns["Listar"].Width = clsGlobal.DimencionarColuna(6, this.Width);

            }
            catch
            {

            }
        }

        #endregion

        private void FrmEstoque_Load(object sender, EventArgs e)
        {
            var oProcessando = new FrmProcessando();
            try
            {
                oProcessando.Show();
                oProcessando.TopMost = true;
                oProcessando.Processo(4, "Liste Estoque.", "Carregando.");
                DgvProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                using (var oEstoque = new Estoque())
                {
                    oProcessando.Processo(20, "Liste Estoque.", "Carregando..");
                    //this.Refresh();
                    DgvProdutos.DataSource = oEstoque.Todos();
                    oProcessando.Processo(33, "Liste Estoque.", "Carregando...");
                    RedimencionarGrade();
                    oProcessando.Processo(45, "Liste Estoque.", "Carregando.");
                }
                if (this.DgvProdutos.Rows.Count > 1)
                {
                    oProcessando.Processo(58, "Liste Estoque.", "Carregando..");
                    TxtBusca.Focus();
                    oProcessando.Processo(70, "Liste Estoque.", "Carregando...");
                    TxtBusca.SelectAll();
                    oProcessando.Processo(100, "Liste Estoque.", "Carregando.");
                }
                else
                {
                    oProcessando.Processo(58, "Liste Estoque.", "Carregando..");
                    DgvProdutos.Focus();
                    oProcessando.Processo(70, "Liste Estoque.", "Carregando...");
                }
                ////DgvProdutos.CurrentCell = DgvProdutos.Rows[DgvProdutos.Rows.Count - 1].Cells[3];
                LblEstoqueItens.Text = DgvProdutos.RowCount.ToString();
                LblEstoqueMinimo.Text = string.Concat(this.Count.ToString("0000"), " Produtos passiveis de reposição.").ToString();
                oProcessando.Processo(100, "Liste Estoque.", "Carregando.");

                oProcessando.Close();
                oProcessando.Dispose();

                frmLoading = false;
                this.Count = 0;
            }
            catch { }
            finally
            {
            }

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.CodigoProduto = null;
            DgvProdutos.DataSource = null;
            this.Close();
        }

        private void TxtCodigoDeBarras_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var oEstoque = new Estoque
                {
                    Produto = TxtBusca.Text
                };
                DgvProdutos.DataSource = oEstoque.BuscaComLike();
            }
            catch { }
        }

        private void DgvProdutos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvProdutos.Rows.Count > 0 && !frmLoading)
            {
                LinhaIndex = e.RowIndex;
                CodigoProduto = DgvProdutos.Rows[LinhaIndex].Cells["CodigoDeBarras"].Value.ToString();
                BtnExcluir.Enabled = true;
            }
            else { BtnExcluir.Enabled = false; }
        }

        private void DgvProdutos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
                CodigoProduto = "0";
                this.Close();
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                var oEstoque = new Estoque();
                oEstoque = (Estoque)DgvProdutos.Rows[LinhaIndex].DataBoundItem;
                if (LinhaIndex != -1)
                {
                    DialogResult dresult = MensagemBox.Mostrar($"Esta ação é definitiva, você deseja excluir o produto '{oEstoque.Produto}'", "Sim", "Não");
                    if (dresult == DialogResult.Yes)
                    {
                        oEstoque.Excluir();
                        MessageBox.Show($"O produro {oEstoque.Produto} foi excluido com sucesso do estoque.");
                        DgvProdutos.DataSource = oEstoque.Todos();
                    }
                    else
                        return;
                }
                else
                {
                    MessageBox.Show("Selecione um produto para excluir.");
                }
                oEstoque.CodigoDeBarras = TxtBusca.Text;

            }
            catch {; }
        }

        private void DgvProdutos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int quantity = clsGlobal.DeStringParaInt(DgvProdutos.Rows[e.RowIndex].Cells["Quantidade"].Value.ToString());
            int EstoqueMinimo = clsGlobal.DeStringParaInt(ConfigurationManager.AppSettings["EstoqueMinimo"]);
            int EmbalagemMaisQueQuarentaUnidades = clsGlobal.DeStringParaInt(ConfigurationManager.AppSettings["EmbalagemMaisQueQuarentaUnidades"]);

            //Apply Background color based on value.
            if (quantity <= EstoqueMinimo)
            {
                DgvProdutos.Rows[e.RowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                DgvProdutos.Rows[e.RowIndex].DefaultCellStyle.ForeColor = System.Drawing.Color.White;
               if (frmLoading)
                {
                    DgvProdutos.Rows[e.RowIndex].Cells["Listar"].Value = checked(true);
                    LblEstoqueMinimo.Text = string.Concat((this.Count++).ToString("0000"), " Produtos passiveis de reposição.");
                }
            }
            else if (quantity <= EmbalagemMaisQueQuarentaUnidades && quantity > EstoqueMinimo)
            {
                DgvProdutos.Rows[e.RowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.Orange;
                DgvProdutos.Rows[e.RowIndex].DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            }
            else //(quantity > EstoqueMinimo)
            {
                DgvProdutos.Rows[e.RowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.GreenYellow;
            }
        }

        private void BtnListaDeCompra_Click(object sender, EventArgs e)
        {
            try
            {
                frmLoading=false;
                var lista = new List<string>();
                DgvProdutos.CurrentCell = DgvProdutos.Rows[0].Cells[3];
                    this.Refresh();
                bool b;
                for (int i = 0; i < DgvProdutos.RowCount; i++)
                {

                    DgvProdutos.CurrentCell = DgvProdutos.Rows[i].Cells["Listar"];
                    //Thread.Sleep(25);
                    //string v = DgvProdutos.Rows[i].Cells["Listar"].Value.ToString();
                    b = (bool)DgvProdutos.Rows[i].Cells["Listar"].Value;
                    if (b == true)
                    {
                        lista.Add(DgvProdutos.Rows[i].Cells["Produto"].Value.ToString());
                    }
                }
                //b = false;
                ImprimerListaDeCompra oListaDeCompra = new ImprimerListaDeCompra(DgvProdutos);
                oListaDeCompra.Print();
            }
            catch { }
        }

    }
}
