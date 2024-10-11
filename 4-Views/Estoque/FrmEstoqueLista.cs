
using System;
using System.Configuration;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace CasaMendes
{
    public partial class FrmEstoqueLista : Form
    {
        public string StatusLabel { get; set; }
        public string CodigoProduto { get; set; }
        private int LinhaIndex { get; set; }
        private bool frmLoading { get; set; }

        #region Construtor

        public FrmEstoqueLista()
        {
            InitializeComponent();
        }

        private void RedimencionarGrade()
        {
            try
            {

                for (int i = 0; i < DgvProdutos.Columns.Count; i++)
                {
                    //if ((DgvProdutos.Columns[i] == DgvProdutos.Columns["EstoqueId"]) || (DgvProdutos.Columns[i] == DgvProdutos.Columns["ProdutoId"]) || (DgvProdutos.Columns[i] == DgvProdutos.Columns["Foto"]) || (DgvProdutos.Columns[i] == DgvProdutos.Columns["Key"]))
                    //{
                        DgvProdutos.Columns[i].Visible = false;
                    //}
                }

                DgvProdutos.Columns["CodigoDeBarras"].Visible = true;
                DgvProdutos.Columns["Produto"].Visible = true;
                DgvProdutos.Columns["PrecoDeVenda"].Visible = true;

                DgvProdutos.Columns["CodigoDeBarras"].HeaderText = "Código de barras".ToUpper();
                DgvProdutos.Columns["Produto"].HeaderText = "Produto".ToUpper();
                DgvProdutos.Columns["PrecoDeVenda"].HeaderText = "Preço".ToUpper();

                DgvProdutos.Columns["CodigoDeBarras"].Width = clsGlobal.DimencionarColuna(15, DgvProdutos.Width);
                DgvProdutos.Columns["Produto"].Width = clsGlobal.DimencionarColuna(68, DgvProdutos.Width);
                DgvProdutos.Columns["PrecoDeVenda"].Width = clsGlobal.DimencionarColuna(15, DgvProdutos.Width);

                clsGlobal.AlinharElementosNoGridView(DgvProdutos, 2, "right");
                clsGlobal.AlinharElementosNoGridView(DgvProdutos, 5, "right");
                //DgvProdutos.Columns["Produto"].Width = clsGlobal.DimencionarColuna(65, DgvProdutos.Width);
                DgvProdutos.Columns["PrecoDeVenda"].DefaultCellStyle.Format = "N2";

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

                DgvProdutos.RowHeadersVisible = false;

                oProcessando.Close();
                oProcessando.Dispose();
            }
            catch { }
        }

        private void TxtBusca_TextChanged(object sender, EventArgs e)
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

        private void TxtBusca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnAceitar.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                BtnCancelar.PerformClick();
            }
        }

        private void DgvProdutos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnAceitar.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                BtnCancelar.PerformClick();
            }
        }

        private void DgvProdutos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvProdutos.Rows.Count > 0 && !frmLoading)
            {
                LinhaIndex = e.RowIndex;
                CodigoProduto = DgvProdutos.Rows[LinhaIndex].Cells["CodigoDeBarras"].Value.ToString();
                LblEstoqueItens.Text = string.Concat($"Cód: {CodigoProduto}, Prod: ", DgvProdutos.Rows[LinhaIndex].Cells["Produto"].Value.ToString());
            }
        }

        private void BtnAceitar_Click(object sender, EventArgs e)
        {
            try
            {
                if (LinhaIndex > -1) CodigoProduto = DgvProdutos.Rows[LinhaIndex].Cells["CodigoDeBarras"].Value.ToString();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch { }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.CodigoProduto = null;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

    }
}
