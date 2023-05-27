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

        BindingSource BsSubcategoria;
        SubCategoria oSubcategoria;
        FrmProcessando oProcessando { get; set; }
        int LinhaIndex;
        bool loading;
        bool editar;

        #endregion

        #region propriedade
        public string StatusLabel { get; set; }
        #endregion

        #region Carregar dados

        private void AssociarDataBinding()
        {
            TxtSubCategoriaId.DataBindings.Add("Text", BsSubcategoria, "SubCategoriaId");
            TxtCategoriaId.DataBindings.Add("Text", BsSubcategoria, "CategoriaId");
            TxtNome.DataBindings.Add("Text", BsSubcategoria, "Nome");
            TxtDescricao.DataBindings.Add("Text", BsSubcategoria, "Descricao");
        }

        private void OrganizarColunas()
        {
            DgvSubcategorias.RowHeadersVisible = false;
            DgvSubcategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            DgvSubcategorias.Columns["Key"].Visible = false;
            DgvSubcategorias.Columns["SubcategoriaId"].Visible = false;
            DgvSubcategorias.Columns["CategoriaId"].Visible = false;

            DgvSubcategorias.Columns["Nome"].Width = clsGlobal.DimencionarColuna(45, this.DgvSubcategorias.Width);
            DgvSubcategorias.Columns["Descricao"].Width = clsGlobal.DimencionarColuna(45, this.DgvSubcategorias.Width);

        }

        private void Carregar()
        {
            if (!loading && DgvSubcategorias.Rows.Count > 0)
            {
                oSubcategoria = (SubCategoria)DgvSubcategorias.Rows[LinhaIndex].DataBoundItem;
                BsSubcategoria.DataSource = oSubcategoria;
            }
        }

        #endregion

        #region manutenção

        private void Novo()
        {
            BtnNovo.Visible = false;
            BtnRetornar.Enabled = false;
            BtnExcluir.Enabled = false;
            BtnCancelar.Visible = !BtnNovo.Visible;
            TxtSubCategoriaId.Clear();
            TxtCategoriaId.Clear();
            TxtNome.Clear();
            TxtDescricao.Clear();
            CbCategorias.Text = string.Empty;
            editar = false;
            if (oSubcategoria != null) oSubcategoria = null;
            oSubcategoria = new SubCategoria();
            BsSubcategoria.DataSource = oSubcategoria;

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
            try
            {
                if (CbCategorias.Items.Count > 0)
                {
                    loading = true;
                    BtnNovo.Visible = true;
                    BtnExcluir.Enabled = true;
                    BtnRetornar.Enabled = true;
                    BtnCancelar.Visible = !BtnNovo.Visible;
                    if (!string.IsNullOrEmpty(TxtCategoriaId.Text)) oSubcategoria.CategoriaId = int.Parse(TxtCategoriaId.Text);
                    oSubcategoria.Salvar();
                    DgvSubcategorias.DataSource = oSubcategoria.Todos();
                    loading = false;
                    loading = true;

                    if(editar && oSubcategoria.SubCategoriaId > 0)
                        MessageBox.Show("Registro atualizado com sucesso!");
                    else
                        MessageBox.Show("Cadastro realizado com sucesso!");

                }
                else
                {
                    MessageBox.Show("Cadastro nçao realizado.");
                }
            }
            catch {; }
        }

        private void Excluir()
        {
            loading = true;
            if (!TxtCategoriaId.Text.Equals("0") && !TxtCategoriaId.Text.Equals(""))
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
                oProcessando = new FrmProcessando();
                oProcessando.Show();
                oProcessando.TopMost = true;

                oProcessando.Processo(12, "Subcategoria.", "iniciando a carga do formulário.");
                oSubcategoria = new SubCategoria();

                oProcessando.Processo(25, "Subcategoria.", "instãnciano objetos.");
                BsSubcategoria = new BindingSource { oSubcategoria };

                oProcessando.Processo(37, "Subcategoria.", "carregando categorias.");
                loading = true;

                CbCategorias.DisplayMember = "Nome";
                CbCategorias.DataSource = new Categoria().Todos();

                oProcessando.Processo(49, "Subcategoria.", "carregando subcategorias.");
                DgvSubcategorias.DataSource = oSubcategoria.Todos();

                oProcessando.Processo(65, "Subcategoria.", "Associando dados.");
                AssociarDataBinding();

                oProcessando.Processo(77, "Subcategoria.", "Tratando colunas da tabela.");
                OrganizarColunas();

                oProcessando.Processo(89, "Subcategoria.", "Priorisando os controles.");
                BtnCancelar.Visible = false;
                BtnExcluir.Enabled = false;
                loading = false;

                if (CbCategorias.Items.Count < 1)
                {
                    oProcessando.Processo(100, "Subcategoria.", "categorias não cadastradas, desativando controles.");
                    BtnNovo.Enabled = false;
                    BtnCancelar.Enabled = false;
                    BtnGravar.Enabled = false;
                }
                else
                {
                    oProcessando.Processo(100, "Subcategoria.", "Mostrando os ados no formulário.");
                    Carregar();
                }
            }
            catch { }
            finally
            {
                oProcessando.Close();
                oProcessando.Dispose();
            }
        }

        #endregion

        #region TextChanged

        private void TextoChange()
        {
            try
            {
                //loading= true;
                var oCat = new SubCategoria
                {
                    Nome = this.TxtBuscar.Text
                };
                DgvSubcategorias.DataSource = oCat.Busca();
                //OrganizarColunas();
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

            if (DgvSubcategorias.Rows.Count > 0 && !loading)
            {
                editar = true;
                LinhaIndex = e.RowIndex;
                Carregar();
            }
        }

        #endregion

        #region TextChanged

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.TextoChange();
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
            this.BsSubcategoria.Dispose();
            this.Dispose();
        }

        #endregion
    }
}
