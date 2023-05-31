
using System;
using System.Windows.Forms;

namespace CasaMendes
{
    public partial class FrmEstoque : Form
    {

        public string StatusLabel { get; set; }
        public string CodigoProduto { get; set; }

        #region Construtor

        public FrmEstoque()
        {
            InitializeComponent();

        }

        private void RedimencionarGrade()
        {
            try
            {
                DgvEstoque.RowHeadersVisible = false;

                for (int i = 0; i < DgvEstoque.Columns.Count; i++)
                {
                    if ((DgvEstoque.Columns[i] == DgvEstoque.Columns["EstoqueId"]) || (DgvEstoque.Columns[i] == DgvEstoque.Columns["ProdutoId"]) || (DgvEstoque.Columns[i] == DgvEstoque.Columns["Key"]))
                    {
                        DgvEstoque.Columns[i].Visible = false;
                    }
                }

               DgvEstoque.Columns["CodigoDeBarras"].HeaderText = "Cód Barras".ToUpper();
                DgvEstoque.Columns["QuantidadeItemDesconto"].HeaderText = "Dsc. Q. Itens".ToUpper();
                DgvEstoque.Columns["ValorDesconto"].HeaderText = "Desc. aplicado".ToUpper();
                DgvEstoque.Columns["Produto"].HeaderText = "Produto".ToUpper();
                DgvEstoque.Columns["Quantidade"].HeaderText = "Estoque".ToUpper();
                DgvEstoque.Columns["PrecoDeVenda"].HeaderText = "Valor venda".ToUpper();
               DgvEstoque.Columns["created_at"].HeaderText = "D. cadastro".ToUpper();
               DgvEstoque.Columns["updated_at"].HeaderText = "Atualizado".ToUpper();
               DgvEstoque.Columns["deleted_at"].HeaderText = "Inativo".ToUpper();

               DgvEstoque.Columns["CodigoDeBarras"].Width = clsGlobal.DimencionarColuna(10, this.Width);
                DgvEstoque.Columns["QuantidadeItemDesconto"].Width = clsGlobal.DimencionarColuna(10, this.Width);
                DgvEstoque.Columns["ValorDesconto"].Width = clsGlobal.DimencionarColuna(11, this.Width);
                DgvEstoque.Columns["Produto"].Width = clsGlobal.DimencionarColuna(20, this.Width);
                DgvEstoque.Columns["Quantidade"].Width = clsGlobal.DimencionarColuna(8, this.Width);
                DgvEstoque.Columns["PrecoDeVenda"].Width = clsGlobal.DimencionarColuna(10, this.Width);
               DgvEstoque.Columns["created_at"].Width = clsGlobal.DimencionarColuna(9, this.Width);
               DgvEstoque.Columns["updated_at"].Width = clsGlobal.DimencionarColuna(9, this.Width);
                DgvEstoque.Columns["deleted_at"].Width = clsGlobal.DimencionarColuna(9, this.Width);

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
                oProcessando.Processo(4,"Liste Estoque.","Carregando.");
                using(var oEstoque = new Estoque())
                {
                    oProcessando.Processo(20, "Liste Estoque.", "Carregando..");
                    DgvEstoque.DataSource = oEstoque.Todos();
                    oProcessando.Processo(33, "Liste Estoque.", "Carregando...");
                    RedimencionarGrade();
                    oProcessando.Processo(45, "Liste Estoque.", "Carregando.");
                }
                if(this.DgvEstoque.Rows.Count > 1)
                {
                    oProcessando.Processo(58, "Liste Estoque.", "Carregando..");
                    txtCodigoDeBarras.Focus();
                    oProcessando.Processo(70, "Liste Estoque.", "Carregando...");
                    txtCodigoDeBarras.SelectAll();
                    oProcessando.Processo(100, "Liste Estoque.", "Carregando.");
                }
                else
                {
                    oProcessando.Processo(58, "Liste Estoque.", "Carregando..");
                    DgvEstoque.Focus();
                    oProcessando.Processo(70, "Liste Estoque.", "Carregando...");
                }
                oProcessando.Processo(100, "Liste Estoque.", "Carregando.");
                oProcessando.Close();
                oProcessando.Dispose();
            }
            catch { }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtCodigoDeBarras_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var oEstoque = new Estoque
                {
                    CodigoDeBarras = txtCodigoDeBarras.Text
                };
                oEstoque.CodigoDeBarras = txtCodigoDeBarras.Text;
                DgvEstoque.DataSource = oEstoque.Busca();
            }
            catch { }
        }

        private void Dgv_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                CodigoProduto = DgvEstoque.Rows[e.RowIndex].Cells["CodigoDeBarras"].Value.ToString();
            }
        }

        private void DgvEstoque_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }else if (e.KeyCode == Keys.Escape) {
                this.DialogResult = DialogResult.Cancel;
                CodigoProduto = "0";
                this.Close();
            }
        }
    }
}
