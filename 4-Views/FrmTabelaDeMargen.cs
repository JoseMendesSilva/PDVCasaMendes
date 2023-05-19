using CasaMendes.Classes.Estatica;
using System;
using System.Windows.Forms;

namespace CasaMendes
{
    public partial class FrmTabelaDeMargen : Form
    {
        bool Loading, Loadining;
        BindingSource BsTabelaDeMargem;
        TabelaDeMargen oTabelaDeMargen;

        public FrmTabelaDeMargen()
        {
            InitializeComponent();
        }

        #region métodos auxiliares

        private void VincularDados()
        {
            oTabelaDeMargen = new TabelaDeMargen();
            BsTabelaDeMargem = new BindingSource
            {
                oTabelaDeMargen
            };

            this.TxtTabelaDeMargenId.DataBindings.Add("Text", BsTabelaDeMargem, "TabelaDeMargenId");
            this.TxtSubCategoriaId.DataBindings.Add("Text", BsTabelaDeMargem, "SubCategoriaId");
            this.TxtNumeroDeItensNaLoja.DataBindings.Add("Text", BsTabelaDeMargem, "NumeroDeItensNaLoja");
            this.TxtValorDeBase.DataBindings.Add("Text", BsTabelaDeMargem, "ValorDeBase");
            this.TxtPorcentagemPessoPorItem.DataBindings.Add("Text", BsTabelaDeMargem, "PorcentagemPessoPorItem");
            this.TxtDespesa.DataBindings.Add("Text", BsTabelaDeMargem, "Despesa");
            this.TxtCusto.DataBindings.Add("Text", BsTabelaDeMargem, "Custo");
            this.TxtEncargo.DataBindings.Add("Text", BsTabelaDeMargem, "Encargo");
            this.TxtMargemDeLucro.DataBindings.Add("Text", BsTabelaDeMargem, "MargemDeLucro");
        }

        private void Calcular()
        {
            if (this.TxtCusto.Text.Equals("") || this.TxtMargemDeLucro.Text.Equals("") || this.TxtDespesa.Text.Equals("") || this.TxtEncargo.Text.Equals("")) return;
            double d = oTabelaDeMargen.Despesa;
            d = double.Parse(this.TxtValorDeBase.Text) / double.Parse(this.TxtNumeroDeItensNaLoja.Text);

            TxtPorcentagemPessoPorItem.Text = d.ToString("N2");

            d += oTabelaDeMargen.Custo;
            d += oTabelaDeMargen.MargemDeLucro;
            d += oTabelaDeMargen.Despesa;
            d += oTabelaDeMargen.Encargo;

            this.TxtTotal.Text = d.ToString("N2");

        }

        private void Botoes(bool b)
        {
            if (BtnNovo.Text == "Novo")
            {
                BtnExcluir.Enabled = b;
                BtnNovo.Text = "Cancelar";
                BtnRetornar.Enabled = b;
            }
            else
            {
                BtnNovo.Text = "Novo";
                BtnExcluir.Enabled = b;
                BtnRetornar.Enabled = b;
            }
        }

        private void Limpar()
        {
            TxtCusto.Clear();
            TxtMargemDeLucro.Clear();
            TxtDespesa.Clear();
            TxtEncargo.Clear();
        }

        private void Novo()
        {
            Botoes(false);
        }

        private void Cancelar()
        {
            Botoes(true);
        }

        private void Gravar()
        {
            Botoes(true);
        }

        private void Excluir()
        {

        }

        private void LoadingForm()
        {
            try
            {
                //oTabelaDeMargen.CriarTabela();
                Loading = Loadining = true;
                VincularDados();

                SubCategoria oSubCategoria = new SubCategoria();
                DgvSubcategorias.DataSource = oSubCategoria.Todos();
                OrganizarColunasSubcategoria();
                if (TxtPorcentagemPessoPorItem.Text.Length > 0) { Calcular(); }
                Loading = false;
            }
            catch { }
        }

        private void OrganizarColunasSubcategoria()
        {
            if (DgvSubcategorias.Rows.Count > 0 && Loading)
            {
                DgvSubcategorias.RowHeadersVisible = false;
                DgvSubcategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                DgvSubcategorias.Columns["Key"].Visible = false;
                DgvSubcategorias.Columns["SubcategoriaId"].Visible = false;
                DgvSubcategorias.Columns["CategoriaId"].Visible = false;
                DgvSubcategorias.Columns["Descricao"].Visible = false;

                DgvSubcategorias.Columns["Nome"].Width = clsGlobal.DimencionarColuna(100, this.DgvSubcategorias.Width);

                Loading = false;
            }
        }

        private void OrganizarColunasTabelaDeMargen()
        {
            if (DgvTabelaDeMargem.Rows.Count > 0 && Loadining)
            {
                DgvTabelaDeMargem.RowHeadersVisible = false;
                DgvTabelaDeMargem.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                DgvTabelaDeMargem.Columns["Key"].Visible = false;
                DgvTabelaDeMargem.Columns["TabelaDeMargenId"].Visible = false;
                DgvTabelaDeMargem.Columns["SubcategoriaId"].Visible = false;
                DgvTabelaDeMargem.Columns["NumeroDeItensNaLoja"].Visible = false;
                DgvTabelaDeMargem.Columns["ValorDeBase"].Visible = false;
                DgvTabelaDeMargem.Columns["PorcentagemPessoPorItem"].Visible = false;
                DgvTabelaDeMargem.Columns["Despesa"].Visible = false;
                DgvTabelaDeMargem.Columns["Custo"].Visible = false;
                DgvTabelaDeMargem.Columns["Encargo"].Visible = false;
                DgvTabelaDeMargem.Columns["MargemDeLucro"].Visible = false;

                DgvTabelaDeMargem.Columns["NumeroDeItensNaLoja"].Width = clsGlobal.DimencionarColuna(18, this.DgvTabelaDeMargem.Width);
                DgvTabelaDeMargem.Columns["ValorDeBase"].Width = clsGlobal.DimencionarColuna(18, this.DgvTabelaDeMargem.Width);
                DgvTabelaDeMargem.Columns["PorcentagemPessoPorItem"].Width = clsGlobal.DimencionarColuna(78, this.DgvTabelaDeMargem.Width);
                DgvTabelaDeMargem.Columns["Despesa"].Width = clsGlobal.DimencionarColuna(18, this.DgvTabelaDeMargem.Width);
                DgvTabelaDeMargem.Columns["Custo"].Width = clsGlobal.DimencionarColuna(18, this.DgvTabelaDeMargem.Width);
                DgvTabelaDeMargem.Columns["Encargo"].Width = clsGlobal.DimencionarColuna(18, this.DgvTabelaDeMargem.Width);
                DgvTabelaDeMargem.Columns["MargemDeLucro"].Width = clsGlobal.DimencionarColuna(18, this.DgvTabelaDeMargem.Width);

                Loading = false;
            }
        }

        #endregion

        #region Load

        private void FrmTabelaDeMargen_Load(object sender, EventArgs e)
        {
            LoadingForm();
        }

        #endregion

        #region CellEnter

        private void DgvSubcategorias_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if ((e.RowIndex > -1) && !Loading)
                {
                    int index = int.Parse(DgvSubcategorias.Rows[e.RowIndex].Cells[0].Value.ToString());
                    oTabelaDeMargen.SubCategoriaId = index;
                    DgvTabelaDeMargem.DataSource = oTabelaDeMargen.Busca();
                    TxtSubCategoria.Text = DgvSubcategorias.Rows[e.RowIndex].Cells[2].Value.ToString();
                    OrganizarColunasTabelaDeMargen();
                    if (DgvTabelaDeMargem.Rows.Count > 0)
                        Loadining = false;
                    else
                        Loadining = true;
                }
            }
            catch { }
        }
  
        private void DgvTabelaDeMargem_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    oTabelaDeMargen = (TabelaDeMargen)DgvTabelaDeMargem.Rows[e.RowIndex].DataBoundItem;
                    BsTabelaDeMargem.DataSource = oTabelaDeMargen;
                    Calcular();
                }
            }
            catch { }
        }

        #endregion

        #region TextChanged

        private void TxtCusto_TextChanged(object sender, EventArgs e)
        {
            oTabelaDeMargen.Custo = double.Parse(this.TxtCusto.Text);
            if (oTabelaDeMargen.Custo > 0) Calcular();
        }

        private void TxtMargemDeLucro_TextChanged(object sender, EventArgs e)
        {
            oTabelaDeMargen.MargemDeLucro = double.Parse(this.TxtMargemDeLucro.Text);
            if (oTabelaDeMargen.MargemDeLucro > 0) Calcular();
        }

        private void TxtDespesa_TextChanged(object sender, EventArgs e)
        {
            oTabelaDeMargen.Despesa = double.Parse(this.TxtDespesa.Text);
            if (oTabelaDeMargen.Despesa > 0) Calcular();
        }

        private void TxtEncargo_TextChanged(object sender, EventArgs e)
        {
            oTabelaDeMargen.Encargo = double.Parse(this.TxtEncargo.Text);
            if (oTabelaDeMargen.Encargo > 0) Calcular();
        }

        #endregion

        #region Click

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            if (BtnNovo.Text.Equals("Cancelar"))
            {
                Cancelar();
            }
            else
            {
                Limpar();
                Novo();
            }
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

        }
 
        #endregion

    }
}
