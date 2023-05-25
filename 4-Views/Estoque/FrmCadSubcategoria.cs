using System;
using System.Windows.Forms;

namespace CasaMendes
{
    public partial class FrmCadSubcategoria : Form
    {
        #region FrmCadSubcategoria

        public FrmCadSubcategoria()
        {
            InitializeComponent();
        }

        #endregion

        #region variaveis

        BindingSource source;
        SubCategoria oSubcategoria;
        int LinhaIndex;
        bool loading;

        #endregion

        #region propriedade
        public string StatusLabel { get; set; }
        #endregion

        #region Carregar dados

        private void AssociarDataBinding()
        {
            oSubcategoria = new SubCategoria();
            source = new BindingSource{
                oSubcategoria
            };

            TxtSubCategoriaId.DataBindings.Add("Text", source, "SubCategoriaId");
            TxtCategoriaId.DataBindings.Add("Text", source, "CategoriaId");
            TxtNome.DataBindings.Add("Text", source, "Nome");
            TxtDescricao.DataBindings.Add("Text", source, "Descricao");
        }

        private void OrganizarColunas()
        {
            if (DgvSubcategorias.Rows.Count > 0 && loading)
            {
                DgvSubcategorias.RowHeadersVisible = false;
                DgvSubcategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                DgvSubcategorias.Columns["Key"].Visible = false;
                DgvSubcategorias.Columns["SubcategoriaId"].Visible = false;
                DgvSubcategorias.Columns["CategoriaId"].Visible = false;

                DgvSubcategorias.Columns["Nome"].Width = clsGlobal.DimencionarColuna(45, this.DgvSubcategorias.Width);
                DgvSubcategorias.Columns["Descricao"].Width = clsGlobal.DimencionarColuna(45, this.DgvSubcategorias.Width);

                loading = false;
            }
        }

        private void Carregar()
        {
            if (!loading && DgvSubcategorias.Rows.Count > 0)
            {
                oSubcategoria = (SubCategoria)DgvSubcategorias.Rows[LinhaIndex].DataBoundItem;
                source.DataSource = oSubcategoria;
            }
        }

        private void DgvCellEnter(DataGridViewCellEventArgs e)
        {
            if (DgvSubcategorias.Rows.Count > 0 && !loading)
            {
                LinhaIndex = e.RowIndex;
                Carregar();
            }
        }

        #endregion

        #region métodos auxiliares

        private void Novo()
        {
            BtnRetornar.Enabled = false;
            BtnExcluir.Enabled = false;
            BtnCancelar.Enabled = true;
            TxtSubCategoriaId.Clear();
            TxtCategoriaId.Clear();
            TxtNome.Clear();
            TxtDescricao.Clear();
            CbCategorias.Text = string.Empty;

            if (oSubcategoria != null) oSubcategoria = null;
            oSubcategoria = new SubCategoria();
            source.DataSource = oSubcategoria;

            TxtNome.Focus();
            TxtNome.SelectAll();
        }

        private void Cancelar()
        {
            BtnRetornar.Enabled = true;
            BtnExcluir.Enabled = true;
            BtnCancelar.Enabled = false;
            loading = false;
            Carregar();
            loading = true;
            MessageBox.Show("Cadastro cancelado.");
        }

        private void Gravar()
        {
            loading = true;
            BtnRetornar.Enabled = true;
            BtnExcluir.Enabled = true;
            oSubcategoria.CategoriaId = int.Parse(TxtCategoriaId.Text);
            oSubcategoria.Salvar();
            DgvSubcategorias.DataSource = oSubcategoria.Todos();
            DgvSubcategorias.Focus();
            loading = false;
            Carregar();
            loading = true;
            MessageBox.Show("Cadastro realizado com sucesso!");
        }

        private void Excluir()
        {
            loading = true;
            // TODO HERE
            if (!TxtCategoriaId.Text.Equals("0"))
            {
                oSubcategoria.SubCategoriaId = int.Parse(TxtSubCategoriaId.Text);
                oSubcategoria.Excluir();
                MessageBox.Show($"A subcategoria ' {oSubcategoria.Nome} ' foi excluida com sucesso.");
            }
            else
            {
                MessageBox.Show($"Seleciona uma subcategoria para excluir.");
            }
            loading = false; // ao definir esta flag como false os dados poderão serem carregados.
            Carregar();
            loading = true;
        }

        #endregion

        #region Load

        private void FrmLoad()
        {
            try
            {
                loading = true;
                AssociarDataBinding();

                CbCategorias.DisplayMember = "Nome";
                CbCategorias.DataSource = new Categoria().Todos();
                DgvSubcategorias.DataSource = oSubcategoria.Todos();

                if (DgvSubcategorias.Rows.Count > 0)
                {
                    loading = true;
                    OrganizarColunas();
                    DgvSubcategorias.Focus();
                }
                else
                {
                    BtnExcluir.Enabled = false;
                }

                Carregar();

            }
            catch { }
        }

        #endregion

        #region TextChanged

        private void TextChange()
        {
            try
            {
                //loading= true;
                var oCat = new SubCategoria
                {
                    Nome = this.TxtBuscar.Text
                };
                DgvSubcategorias.DataSource = oCat.Busca();
                OrganizarColunas();
            }
            catch { }
        }

        private void SelectedIndexChanged()
        {
            var oCat = new SubCategoria
            {
                Nome = this.TxtBuscar.Text
            };
            var c = oCat.Busca();
            oSubcategoria.CategoriaId = c[0].CategoriaId;
            TxtCategoriaId.Text = oSubcategoria.CategoriaId.ToString();
        }

        #endregion

        #region Events

        private void FrmCadSubcategoria_Load(object sender, EventArgs e)
        {
            FrmLoad();
            loading = false;
        }

        #endregion

        #region Enter

        private void DgvSubcategorias_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (loading) loading = false;
            DgvCellEnter(e);
        }

        #endregion

        #region TextChanged

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.TextChange();
        }

        private void CbCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (loading) { return; }
                SelectedIndexChanged();
            }
            catch { }
        }

        #endregion

        #region Click

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
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
