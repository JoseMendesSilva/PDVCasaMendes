using System.Drawing.Printing;
using System.Drawing;
using System;
using System.Windows.Forms;
using System.Configuration;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Windows.Media;

namespace CasaMendes
{
    public partial class FrmProdutos : Form
    {
        #region variáveis
        int LinhaIndex;
        bool editar;
        Produto oProduto;
        FrmCadProduto cadProduto;

        #endregion

        #region Propriedades

        public string StatusLabel { get; set; }

        #endregion

        #region construtor
        public FrmProdutos()
        {
            InitializeComponent();
            LinhaIndex = -1;
            editar = false;
        }
        #endregion

        #region Métodos

        private void Botoes(bool b)
        {
            BtnEditar.Enabled = !b;
            BtnFechar.Enabled = b;
            BtnExcluir.Enabled = !b;
            BtnNovo.Enabled = b;
            BtnListaDeCompra.Enabled = b;
        }

        private void Carregar()
        {
            DgvProdutos.MultiSelect = true;
            DgvProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            oProduto = new Produto();
            DgvProdutos.DataSource = oProduto.Todos();
            StatusLabel = (DgvProdutos.RowCount).ToString();
            LblProdutosCadastrados.Text = $"Constam: {StatusLabel} produtos cadastrados.".ToUpper();

            //foreach (DataGridViewRow row in DgvProdutos.Rows)
            //{
            //    int quantity;
            //    if (int.TryParse(row.Cells["Quantidade"].Value.ToString(), out quantity))
            //    {
            //        if (quantity < 20)
            //            row.Cells["Quantidade"].Style.BackColor = System.Drawing.Color.Red;
            //        if (quantity < 10)
            //            row.Cells["Quantidade"].Style.BackColor = System.Drawing.Color.Orange;
            //    }
            //}
            //for (int i = 0; i < DgvProdutos.RowCount; i++)
            //{
            //    if (int.Parse(DgvProdutos.Rows[i].Cells["Quantidade"].Value.ToString()) <= 3)
            //    {
            //        DgvProdutos.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.Red;//Color.LightGray;
            //    }
            //    else
            //    {
            //        DgvProdutos.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.Green;//Color.LightGray;
            //    }
            //}
            //this.Refresh();

        }

        private void RedimencionarGrade()
        {
            try
            {
                DgvProdutos.RowHeadersVisible = false;

                for (int i = 0; i < DgvProdutos.Columns.Count; i++)
                {
                    if ((DgvProdutos.Columns[i] == DgvProdutos.Columns["ProdutoId"]) || (DgvProdutos.Columns[i] == DgvProdutos.Columns["ValorCompra"]) || (DgvProdutos.Columns[i] == DgvProdutos.Columns["Quantidade"]) || (DgvProdutos.Columns[i] == DgvProdutos.Columns["FornecedorId"]) || (DgvProdutos.Columns[i] == DgvProdutos.Columns["Foto"]) || (DgvProdutos.Columns[i] == DgvProdutos.Columns["SubCategoriaId"]) || (DgvProdutos.Columns[i] == DgvProdutos.Columns["Key"]))
                    {
                        DgvProdutos.Columns[i].Visible = false;
                    }
                }

                DgvProdutos.Columns["Quantidade"].Visible = true;
                DgvProdutos.Columns["CodigoDeBarras"].HeaderText = "Cód Barras";
                DgvProdutos.Columns["Nome"].HeaderText = "Produto";
                DgvProdutos.Columns["DataDeValidade"].HeaderText = "D. Validade";
                DgvProdutos.Columns["PrecoUnitario"].HeaderText = "Valor unitário";
                DgvProdutos.Columns["PrecoDeVenda"].HeaderText = "Valor venda";
                DgvProdutos.Columns["created_at"].HeaderText = "Data cadastro";
                DgvProdutos.Columns["updated_at"].HeaderText = "Atualizado";
                DgvProdutos.Columns["deleted_at"].HeaderText = "Inativo";

                DgvProdutos.Columns["CodigoDeBarras"].Width = clsGlobal.DimencionarColuna(12, this.Width);
                DgvProdutos.Columns["Nome"].Width = clsGlobal.DimencionarColuna(35, this.Width);
                DgvProdutos.Columns["DataDeValidade"].Width = clsGlobal.DimencionarColuna(10, this.Width);
                DgvProdutos.Columns["Quantidade"].Width = clsGlobal.DimencionarColuna(10, this.Width);
                DgvProdutos.Columns["PrecoUnitario"].Width = clsGlobal.DimencionarColuna(10, this.Width);
                DgvProdutos.Columns["PrecoDeVenda"].Width = clsGlobal.DimencionarColuna(10, this.Width);
                DgvProdutos.Columns["created_at"].Width = clsGlobal.DimencionarColuna(10, this.Width);
                DgvProdutos.Columns["updated_at"].Width = clsGlobal.DimencionarColuna(10, this.Width);
                DgvProdutos.Columns["deleted_at"].Width = clsGlobal.DimencionarColuna(10, this.Width);

            }
            catch
            {

            }
        }

        #endregion

        #region Eventos

        private void FrmProdutos_Load(object sender, EventArgs e)
        {
            var oProcessando = new FrmProcessando();
            oProcessando.Show();
            oProcessando.TopMost = true;
            oProcessando.Processo(15, "Lista de Produtos", "Carregando.");
            Botoes(true);
            oProcessando.Processo(28, "Lista de Produtos", "Carregando.");
            Carregar();
            oProcessando.Processo(56, "Lista de Produtos", "Carregando.");
            RedimencionarGrade();
            oProcessando.Processo(90, "Lista de Produtos", "Carregando.");
            oProcessando.Close();
            oProcessando.Dispose();
            TxtBusca.Focus();
            TxtCodigoDeBarras.SelectAll();
        }

        private void TxtCodigoDeBarras_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.TxtBusca.Text.Length > 0)
                {
                    this.TxtBusca.Clear();
                }
                if (!string.IsNullOrEmpty(this.TxtCodigoDeBarras.Text))
                {
                    oProduto.CodigoDeBarras = this.TxtCodigoDeBarras.Text;
                    DgvProdutos.DataSource = oProduto.BuscaComLike();
                }

            }
            catch { }
        }

        private void TxtBusca_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.TxtCodigoDeBarras.Text.Length > 0)
                {
                    this.TxtCodigoDeBarras.Clear();
                }
                if (!string.IsNullOrEmpty(this.TxtBusca.Text))
                {
                    oProduto.Nome = TxtBusca.Text;
                    DgvProdutos.DataSource = oProduto.BuscaComLike();
                }
            }
            catch { }
        }

        private void Dgv_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvProdutos.Rows.Count > 0)
            {
                LinhaIndex = e.RowIndex;
                editar = true;
                BtnEditar.Enabled = editar;
                BtnExcluir.Enabled = editar;
                return;
            }
            editar = false;
            BtnEditar.Enabled = editar;
            TxtBusca.Focus();
            TxtCodigoDeBarras.SelectAll();
        }

        #endregion

        #region Click

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            cadProduto = new FrmCadProduto();

            if (LinhaIndex != -1)
            {
                cadProduto.oProduto = (Produto)DgvProdutos.Rows[LinhaIndex].DataBoundItem;
                cadProduto.ShowDialog();
                Carregar();
            }
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            cadProduto = new FrmCadProduto();
            cadProduto.ShowDialog();
            Carregar();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {

            try
            {
                if (LinhaIndex != -1)
                {
                    DialogResult dresult = MensagemBox.Mostrar($"Esta ação é definitiva, você deseja excluir o produto '{oProduto.Nome}'", "Sim", "Não");
                    if (dresult == DialogResult.Yes)
                    {
                        oProduto = (Produto)DgvProdutos.Rows[LinhaIndex].DataBoundItem;
                        oProduto.Excluir();
                        MessageBox.Show($"O produro {oProduto.Nome} foi excluido com sucesso.");
                        Carregar();
                    }
                }
                else
                {
                    MessageBox.Show("Selecione um produto para excluir.");
                }
            }
            catch {; }
        }

        #endregion

        private void DgvProdutos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            ////Fetch the value of the second Column.
            //int quantity = int.Parse(DgvProdutos.Rows[e.RowIndex].Cells["Quantidade"].Value.ToString());

            ////Apply Background color based on value.
            //if (quantity <= 6)
            //{
            //    DgvProdutos.Rows[e.RowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.Red;
            //}
            //if (quantity > 6)
            //{
                DgvProdutos.Rows[e.RowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.GreenYellow;
            //}
        }

 
    }

}

