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

        private void AssociarDataBinding()
        {
            oCategoria = new Categoria();
            oBsCategoria = new BindingSource{
                oCategoria
            };
            TxtCategoriaId.DataBindings.Add("Text", oBsCategoria, "CategoriaId");
            TxtNome.DataBindings.Add("Text", oBsCategoria, "Nome");
            TxtDescricao.DataBindings.Add("Text", oBsCategoria, "Descricao");
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
            if (loading || DgvCategorias.Rows.Count <= 0) return;
            oCategoria = (Categoria)DgvCategorias.Rows[LinhaIndex].DataBoundItem;
            oBsCategoria.DataSource = oCategoria;
        }

        private void DgvCellEnter(DataGridViewCellEventArgs e)
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

        #region manutenção

        private void Novo()
        {
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
            BtnGravar.Enabled = true;
            BtnNovo.Enabled = true;
            BtnRetornar.Enabled = true;
            oCategoria.Salvar();
            Carregar();
            MessageBox.Show("Cadastro realizado com sucesso!");
            oBsCategoria.DataSource = oCategoria;
            DgvCategorias.Focus();
        }

        private void Excluir()
        {
            if (TxtCategoriaId.Text == "0" || TxtCategoriaId.Text.Length == 0 || TxtCategoriaId.Text == string.Empty) { return; }
            oCategoria.CategoriaId=int.Parse(TxtCategoriaId.Text);
            oCategoria.Excluir();
            MessageBox.Show($"A categoria ' {oCategoria.Nome} ' foi excluido com sucesso.");

        }

        #endregion

        #region Load
 
        private void FrmLoad()
        {
            try
            {
                oProcessamento = new FrmProcessando();
                oProcessamento.Show();
                oProcessamento.TopMost = true;
                oProcessamento.Processo(16, "Formulário.", "iniciando a carga do formulário.");
                loading = true;

                oProcessamento.Processo(32, "Formulário.", "iniciando a carga do formulário.");
                AssociarDataBinding();

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

        #region TextoChanged

        private void TextoChanged()
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

        #region Events

        private void FrmCadCategoria_Load(object sender, EventArgs e)
        {
            FrmLoad();
        }

        #endregion

        #region Enter

        private void DgvCategorias_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DgvCellEnter(e);
        }

        #endregion

        #region TextoChanged

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            TextoChanged();
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

    }
}
