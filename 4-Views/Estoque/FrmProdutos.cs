using System.Drawing.Printing;
using System.Drawing;
using System;
using System.Windows.Forms;
using System.Configuration;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Windows.Media;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace CasaMendes
{
    public partial class FrmProdutos : Form
    {
        #region variáveis
        int LinhaIndex;
        bool editar;
        //Produto oProduto;
        //FrmCadProduto cadProduto;

        #endregion

        #region Propriedades

        public string StatusLabel { get; set; }

        #endregion

        #region construtor
        public FrmProdutos()
        {
            InitializeComponent();
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
            //using (var dados = new Dados())
            //{
            //    DgvProdutos.DataSource = dados.Select<Produto>("Select * from produtos");
            //    StatusLabel = (DgvProdutos.RowCount).ToString();
            //    LblProdutosCadastrados.Text = $"Constam: {StatusLabel} produtos cadastrados.".ToUpper();
            //}
            ////foreach (DataGridViewRow row in DgvProdutos.Rows)
            ////{
            ////    int quantity;
            ////    if (int.TryParse(row.Cells["Quantidade"].Value.ToString(), out quantity))
            ////    {
            ////        if (quantity < 20)
            ////            row.Cells["Quantidade"].Style.BackColor = System.Drawing.Color.Red;
            ////        if (quantity < 10)
            ////            row.Cells["Quantidade"].Style.BackColor = System.Drawing.Color.Orange;
            ////    }
            ////}
            ////for (int i = 0; i < DgvProdutos.RowCount; i++)
            ////{
            ////    if (int.Parse(DgvProdutos.Rows[i].Cells["Quantidade"].Value.ToString()) <= 3)
            ////    {
            ////        DgvProdutos.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.Red;//Color.LightGray;
            ////    }
            ////    else
            ////    {
            ////        DgvProdutos.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.Green;//Color.LightGray;
            ////    }
            ////}
            ////this.Refresh();

        }

        private void RedimencionarGrade()
        {
            try
            {
                if(DgvProdutos.Rows.Count < 1) return;

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

                DgvProdutos.MultiSelect = true;
                DgvProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            }
            catch
            {

            }
        }

        #endregion

        #region Eventos

        private void FrmProdutos_Load(object sender, EventArgs e)
        {
            this.Refresh();
            LinhaIndex = -1;
            editar = false;
        }

        private void TxtCodigoDeBarras_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //if (!string.IsNullOrEmpty(this.TxtCodigoDeBarras.Text))
                //{
                //    using (var dados = new Dados())
                //    {
                //        dados.ClauseValor = this.TxtCodigoDeBarras.Text;
                //        dados.ClauseCampo = "CodigoDeBarras";

                //        var result = dados.SelectWithLike<Produto>("Produtos", dados.likeClause, dados.ParametroLike());
                //        DgvProdutos.DataSource = null;
                //        DgvProdutos.DataSource = result;
                //    }
                //}
            }
            catch { }
        }

        private void TxtBusca_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //if (!string.IsNullOrEmpty(this.TxtBusca.Text))
                //{
                //    using (var dados = new Dados())
                //    {
                //        dados.ClauseValor = this.TxtBusca.Text;
                //        dados.ClauseCampo = "Nome";

                //        var result = dados.SelectWithLike<Produto>("Produtos", dados.likeClause, dados.ParametroLike());
                //        DgvProdutos.DataSource = null;
                //        DgvProdutos.DataSource = result;
                //    }
                //    RedimencionarGrade();
                //    this.Refresh();
                //}
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
            //cadProduto = new FrmCadProduto();

            //if (LinhaIndex != -1)
            //{
            //    cadProduto.oProduto = (Produto)DgvProdutos.Rows[LinhaIndex].DataBoundItem;
            //    cadProduto.ShowDialog();
            //    Carregar();
            //}
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            //cadProduto = new FrmCadProduto();
            //if (LinhaIndex != -1)
            //{
            //    cadProduto.oProduto = (Produto)DgvProdutos.Rows[LinhaIndex].DataBoundItem;
            //    //cadProduto.oProduto.ProdutoId = 0;
            //}
            //cadProduto.ShowDialog();
            //Carregar();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {

            try
            {
                if (LinhaIndex != -1)
                {
                    //DialogResult dresult = MensagemBox.Mostrar($"Ação definitiva, você deseja excluir o produto '{oProduto.Nome}'", "Sim", "Não");
                    //if (dresult == DialogResult.Yes)
                    //{
                    //    oProduto = (Produto)DgvProdutos.Rows[LinhaIndex].DataBoundItem;
                    //    //var rowsAffected = oProduto.Excluir();
                    //    //MessageBox.Show($"O produro {oProduto.Nome} foi excluido com sucesso.");
                    //    Carregar();
                    //}
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
            //Fetch the value of the second Column.
            int quantity = int.Parse(DgvProdutos.Rows[e.RowIndex].Cells["Quantidade"].Value.ToString());

            //Apply Background color based on value.
            if (quantity <= 6)
            {
                DgvProdutos.Rows[e.RowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.Red;
            }
            else//if (quantity > 6)
            {
                DgvProdutos.Rows[e.RowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.GreenYellow;
            }
        }

        private void TxtCodigoDeBarras_Enter(object sender, EventArgs e)
        {
            if (this.TxtBusca.Text.Length > 0)
            {
                this.TxtBusca.Clear();
            }
        }

        private void TxtBusca_Enter(object sender, EventArgs e)
        {
            if (this.TxtCodigoDeBarras.Text.Length > 0)
            {
                this.TxtCodigoDeBarras.Clear();
            }
        }

        private void TxtBusca_Leave(object sender, EventArgs e)
        {
            if (this.TxtCodigoDeBarras.Text.Length > 0)
            {
                this.TxtCodigoDeBarras.Clear();
            }
        }

        private void TxtCodigoDeBarras_Leave(object sender, EventArgs e)
        {
            if (this.TxtBusca.Text.Length > 0)
            {
                this.TxtBusca.Clear();
            }
        }

        private void FrmProdutos_Shown(object sender, EventArgs e)
        {
            try
            {
                //var oProcessando = new FrmProcessando();
                //oProcessando.Show();
                //oProcessando.TopMost = true;
                //oProcessando.Processo(15, "Lista de Produtos", "Carregando.");
                Botoes(true);
                //oProcessando.Processo(28, "Lista de Produtos", "Carregando.");
                Carregar();
                //oProcessando.Processo(56, "Lista de Produtos", "Carregando.");
                RedimencionarGrade();
                //oProcessando.Processo(90, "Lista de Produtos", "Carregando.");
                //oProcessando.Close();
                //oProcessando.Dispose();
                TxtBusca.Focus();
                TxtCodigoDeBarras.SelectAll();
            }
            catch { }
        }
    }

}

