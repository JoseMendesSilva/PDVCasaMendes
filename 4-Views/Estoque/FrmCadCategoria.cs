using System;
using System.Windows.Forms;

namespace CasaMendes
{
    public partial class FrmCadCategoria : Form
    {

        #region
        public FrmCadCategoria()
        {
            InitializeComponent();
        }
        #endregion

        #region variaveis

        BindingSource source;
        Categoria categoria;
        int LinhaIndex;
        bool loading;

        #endregion

        #region propriedade
        public string StatusLabel { get; set; }
        #endregion

        #region Carregar dados

        private void AssociarDataBinding()
        {
            categoria = new Categoria();
            source = new BindingSource{
                categoria
            };
            TxtCategoriaId.DataBindings.Add("Text", source, "CategoriaId");
            TxtNome.DataBindings.Add("Text", source, "Nome");
            TxtDescricao.DataBindings.Add("Text", source, "Descricao");
        }

        private void OrganizarColunas()
        {
            if (DgvCategorias.Rows.Count > 0 && loading)
            {
                DgvCategorias.RowHeadersVisible = false;
                DgvCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                DgvCategorias.Columns["Key"].Visible = false;
                DgvCategorias.Columns["CategoriaId"].Visible = false;

                DgvCategorias.Columns["Nome"].Width = clsGlobal.DimencionarColuna(78, this.Width);
                DgvCategorias.Columns["Descricao"].Width = clsGlobal.DimencionarColuna(180, this.DgvCategorias.Width);
                loading = false;
            }
        }

        private void Carregar()
        {
            categoria = (Categoria)DgvCategorias.Rows[LinhaIndex].DataBoundItem;
            source.DataSource = categoria;
        }

        private void DgvCellEnter(DataGridViewCellEventArgs e)
        {
            if (DgvCategorias.Rows.Count > 0)
            {
                LinhaIndex = e.RowIndex;
                Carregar();
            }
            else
            {
                BtnGravar.Enabled = false;
                BtnNovo.Enabled = true;
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
            categoria.Salvar();
            Carregar();
            MessageBox.Show("Cadastro realizado com sucesso!");
            source.DataSource = categoria;
            DgvCategorias.Focus();
        }

        private void Excluir()
        {

            BtnGravar.Enabled = true;
            BtnNovo.Enabled = false;
            BtnRetornar.Enabled = false;

        }

        #endregion

        #region Load
        private void FrmLoad()
        {
            loading = true;
            AssociarDataBinding();
            //categoria.CriarTabela();
            DgvCategorias.DataSource = categoria.Todos();
            Carregar();
            if (DgvCategorias.Rows.Count > 0)
            {
                OrganizarColunas();
                DgvCategorias.Focus();
            }
            else
            {
                BtnGravar.Enabled = false;
                BtnNovo.Enabled = true;
            }
        }

        #endregion

        #region TextChanged

        private void TextChange()
        {
            try
            {
                var oCat = new Categoria
                {
                    Nome = this.TxtBuscar.Text,
                };
                DgvCategorias.DataSource = oCat.Busca();
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

        #region TextChanged

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            TextChange();
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
            this.source.Dispose();
            this.Dispose();
        }

        #endregion

    }
}
