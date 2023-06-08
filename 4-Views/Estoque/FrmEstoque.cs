
using System;
using System.Configuration;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace CasaMendes
{
    public partial class FrmEstoque : Form
    {

        public string StatusLabel { get; set; }
        public string CodigoProduto { get; set; }
        private int LinhaIndex;
        private bool frmLoading;
        #region Construtor

        public FrmEstoque()
        {
            InitializeComponent();
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
            try
            {
                var oProcessando = new FrmProcessando();
                oProcessando.Show();
                oProcessando.TopMost = true;
                oProcessando.Processo(4, "Liste Estoque.", "Carregando.");
                LinhaIndex = -1;
                frmLoading = true;
                using (var oEstoque = new Estoque())
                {
                    oProcessando.Processo(20, "Liste Estoque.", "Carregando..");
                    DgvProdutos.DataSource = oEstoque.Todos();
                    frmLoading = false;
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
                oProcessando.Processo(100, "Liste Estoque.", "Carregando.");
                LblEstoqueItens.Text = DgvProdutos.RowCount.ToString();
                oProcessando.Close();
                oProcessando.Dispose();
            }
            catch { }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.CodigoProduto=null;
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

            //Apply Background color based on value.
            if (quantity <= EstoqueMinimo)
            {
                DgvProdutos.Rows[e.RowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                DgvProdutos.Rows[e.RowIndex].DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            }
            if (quantity > EstoqueMinimo)
            {
                DgvProdutos.Rows[e.RowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.GreenYellow;
            }
        }

        private void BtnListaDeCompra_Click(object sender, EventArgs e)
        {
            ImprimerListaDeCompra oListaDeCompra = new ImprimerListaDeCompra(DgvProdutos);
            oListaDeCompra.Print();
        }

    }
}
