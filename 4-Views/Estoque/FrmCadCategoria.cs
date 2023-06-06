using System;
using System.Threading;
using System.Windows.Forms;

namespace CasaMendes
{
    public partial class FrmCadCategoria : Form
    {

        #region FrmCadCategoria

        public FrmCadCategoria()
        {
            InitializeComponent();
        }

        #endregion

        #region variaveis

        BindingSource oBsCategoria;
        Categoria oCategoria;
        int LinhaIndex;
        bool loading;
        private FrmProcessando oProcessamento;

        #endregion

        #region propriedade
        public string StatusLabel { get; set; }
        #endregion

        #region Carregar dados

        private void LerDados()
        {
            oCategoria.CategoriaId = clsGlobal.DeStringParaInt(TxtCategoriaId.Text);
            oCategoria.Nome = TxtNome.Text;
            oCategoria.Descricao = TxtDescricao.Text;
        }

        private void OrganizarColunas()
        {
            DgvCategorias.RowHeadersVisible = false;
            DgvCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            DgvCategorias.Columns["Key"].Visible = false;
            DgvCategorias.Columns["CategoriaId"].Visible = false;

            DgvCategorias.Columns["Nome"].Width = clsGlobal.DimencionarColuna(50, this.Width);
            DgvCategorias.Columns["Descricao"].Width = clsGlobal.DimencionarColuna(45, this.DgvCategorias.Width);
            loading = false;
        }

        private void Carregar()
        {
            if (loading || DgvCategorias.Rows.Count < 1) return;
            oCategoria = (Categoria)DgvCategorias.Rows[LinhaIndex].DataBoundItem;
            TxtCategoriaId.Text = oCategoria.CategoriaId.ToString();
            TxtNome.Text= oCategoria.Nome;
            TxtDescricao.Text= oCategoria.Descricao;
        }

        #endregion

        #region manutenção

        private void Novo()
        {
            oCategoria.CategoriaId = 0;
            oCategoria.Nome = "";
            oCategoria.Descricao = "";

            BtnGravar.Enabled = true;
            BtnNovo.Enabled = false;
            BtnRetornar.Enabled = false;

            TxtCategoriaId.Clear();
            TxtNome.Clear();
            TxtDescricao.Clear();

            TxtNome.Focus();
            TxtNome.SelectAll();
        }

        private void Gravar()
        {
            if (TxtNome.Text == "0" || TxtNome.Text == string.Empty)
            {
                MessageBox.Show("O nome da categoria é obrigatório.");
                TxtNome.Focus();
                TxtNome.SelectAll();
                return;
            }

            LerDados();

            BtnGravar.Enabled = true;
            BtnNovo.Enabled = true;
            BtnRetornar.Enabled = true;
            oCategoria.Salvar();
            DgvCategorias.DataSource = oCategoria.Todos();
            Carregar();
            MessageBox.Show("Cadastro realizado com sucesso!");
            DgvCategorias.Focus();
        }

        private void Excluir()
        {
            var msg = string.Empty;
            try
            {
                if (LinhaIndex != -1)
                {
                    DialogResult dresult = MensagemBox.Mostrar($"Esta ação é definitiva, você deseja excluir o produto '{oCategoria.Nome}'", "Sim", "Não");
                    if (dresult == DialogResult.Yes)
                    {
                        if (TxtCategoriaId.Text == "0" || TxtCategoriaId.Text == string.Empty) { return; }
                        oCategoria.CategoriaId = int.Parse(TxtCategoriaId.Text);
                        oCategoria.Excluir();
                        msg = $"A categoria ' {oCategoria.Nome} ' foi excluido com sucesso.";
                        Carregar();
                    }
                }
                else
                {
                    msg = "Selecione uma categoria para excluir.";
                }
                MessageBox.Show(msg, Application.ProductName);
            }
            catch { }

        }

        #endregion

        #region Events

        private void FrmCadCategoria_Load(object sender, EventArgs e)
        {
            try
            {
                oProcessamento = new FrmProcessando();
                oProcessamento.Show();
                oProcessamento.TopMost = true;

                oCategoria = new Categoria();
                if (oBsCategoria != null) oBsCategoria = null;
                oBsCategoria = new BindingSource { oCategoria };

                oProcessamento.Processo(16, "Formulário.", "iniciando a carga do formulário.");
                loading = true;

                oProcessamento.Processo(32, "Formulário.", "iniciando a carga do formulário.");

                oProcessamento.Processo(48, "Formulário.", "carregondo dados.");
                DgvCategorias.DataSource = oCategoria.Todos();

                oProcessamento.Processo(66, "Formulário.", "organisando a tabela");
                OrganizarColunas();

                oProcessamento.Processo(82, "Formulário.", "exibindo a primeira linha de dados nos controles.");
                Carregar();

                oProcessamento.Processo(100, "Formulário.", "finalisando a carga do formulário.");
                loading = false;
            }
            catch { }
            finally
            {
                oProcessamento.Close();
                oProcessamento.Dispose();
            }
        }

        #endregion

        #region Enter

        private void DgvCategorias_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvCategorias.Rows.Count > 0)
            {
                LinhaIndex = e.RowIndex;
                Carregar();
                BtnGravar.Visible = true;

            }
            else
            {
                BtnGravar.Enabled = false;
            }
        }

        #endregion

        #region TextoChanged

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var oCategory = new Categoria
                {
                    Nome = this.TxtBuscar.Text,
                };
                DgvCategorias.DataSource = oCategory.Busca();
                OrganizarColunas();
            }
            catch { }
        }

        #endregion

        #region Click

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            Gravar();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            Excluir();
        }

        private void BtnRetornar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.oBsCategoria.Dispose();
            this.Dispose();
        }

        #endregion

        private void BtnSubcategorias_Click(object sender, EventArgs e)
        {
            try
            {
                var sc = new FrmCadSubcategoria();
                sc.ShowDialog();
            }
            catch { }
        }

    }
}
