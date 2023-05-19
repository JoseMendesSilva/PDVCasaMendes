using CasaMendes.Classes.Estatica;
using DocumentFormat.OpenXml.Drawing.Charts;
using System;
using System.Windows.Forms;

namespace CasaMendes
{
    public partial class FrmTabelaDeMargen : Form
    {
        #region variáveis

        int LinhaIndex, LinhaIndexMargem;
        private bool Loading;
        private bool Loadining;
        private BindingSource BsTabelaDeMargem;
        private TabelaDeMargen oTabelaDeMargen;

        #endregion

        #region construtor

        public FrmTabelaDeMargen()
        {
            InitializeComponent();
        }

        #endregion

        #region métodos auxiliares

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

                DgvTabelaDeMargem.Columns["NumeroDeItensNaLoja"].Width = clsGlobal.DimencionarColuna(18, this.DgvTabelaDeMargem.Width);
                DgvTabelaDeMargem.Columns["ValorDeBase"].Width = clsGlobal.DimencionarColuna(15, this.DgvTabelaDeMargem.Width);
                DgvTabelaDeMargem.Columns["PorcentagemPessoPorItem"].Width = clsGlobal.DimencionarColuna(18, this.DgvTabelaDeMargem.Width);
                DgvTabelaDeMargem.Columns["Despesa"].Width = clsGlobal.DimencionarColuna(10, this.DgvTabelaDeMargem.Width);
                DgvTabelaDeMargem.Columns["Custo"].Width = clsGlobal.DimencionarColuna(10, this.DgvTabelaDeMargem.Width);
                DgvTabelaDeMargem.Columns["Encargo"].Width = clsGlobal.DimencionarColuna(10, this.DgvTabelaDeMargem.Width);
                DgvTabelaDeMargem.Columns["MargemDeLucro"].Width = clsGlobal.DimencionarColuna(18, this.DgvTabelaDeMargem.Width);

                DgvTabelaDeMargem.Columns["NumeroDeItensNaLoja"].HeaderText = "Numero de itens";
                DgvTabelaDeMargem.Columns["ValorDeBase"].HeaderText = "Valor base";
                DgvTabelaDeMargem.Columns["PorcentagemPessoPorItem"].HeaderText = "Pesso aplicado";
                DgvTabelaDeMargem.Columns["Despesa"].HeaderText = "Despesa";
                DgvTabelaDeMargem.Columns["Custo"].HeaderText = "Custo";
                DgvTabelaDeMargem.Columns["Encargo"].HeaderText = "Encargo";
                DgvTabelaDeMargem.Columns["MargemDeLucro"].HeaderText = "Margem de lucro";

                Loadining = false;
            }
        }

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
            oTabelaDeMargen.Salvar();
            Botoes(true);
            LoadingTabelaDeMargen();
            oTabelaDeMargen.Excluir(); MessageBox.Show("Cadastro realizado com sucesso.");
        }

        private void Excluir()
        {
            oTabelaDeMargen = (TabelaDeMargen)DgvTabelaDeMargem.Rows[LinhaIndexMargem].DataBoundItem;
            oTabelaDeMargen.Excluir();MessageBox.Show("O registro foi excluido com sucesso.");
        }

        private void LoadingTabelaDeMargen()
        {
            try
            {
                if (LinhaIndex.Equals(-1)) return;
                int index = int.Parse(DgvSubcategorias.Rows[LinhaIndex].Cells[0].Value.ToString());
                oTabelaDeMargen.SubCategoriaId = index;
                DgvTabelaDeMargem.DataSource = oTabelaDeMargen.Busca();
                OrganizarColunasTabelaDeMargen();
                BsTabelaDeMargem.DataSource = oTabelaDeMargen;
            }
            catch { }
        }

        private void LoadingForm()
        {
            try
            {
                LinhaIndexMargem = LinhaIndex = -1;
                //oTabelaDeMargen.CriarTabela();
                Loading = true;
                Loadining = true;
                VincularDados();

                SubCategoria oSubCategoria = new SubCategoria();
                DgvSubcategorias.DataSource = oSubCategoria.Todos();
                OrganizarColunasSubcategoria();
                if (TxtPorcentagemPessoPorItem.Text.Length > 0) { Calcular(); }
            }
            catch { }
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
            LinhaIndex = e.RowIndex;
            LoadingTabelaDeMargen();
            TxtSubCategoria.Text = DgvSubcategorias.Rows[LinhaIndex].Cells[2].Value.ToString();
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
            if (this.TxtCusto.Text.Equals("")) return;
            oTabelaDeMargen.Custo = double.Parse(this.TxtCusto.Text);
            if (oTabelaDeMargen.Custo > 0) Calcular();
        }

        private void TxtMargemDeLucro_TextChanged(object sender, EventArgs e)
        {
            if (this.TxtMargemDeLucro.Text.Equals("")) return;
            oTabelaDeMargen.MargemDeLucro = double.Parse(this.TxtMargemDeLucro.Text);
            if (oTabelaDeMargen.MargemDeLucro > 0) Calcular();
        }

        private void TxtDespesa_TextChanged(object sender, EventArgs e)
        {
            if (this.TxtDespesa.Text.Equals("")) return;
            oTabelaDeMargen.Despesa = double.Parse(this.TxtDespesa.Text);
            if (oTabelaDeMargen.Despesa > 0) Calcular();
        }

        private void TxtEncargo_TextChanged(object sender, EventArgs e)
        {
            if (this.TxtEncargo.Text.Equals("")) return;
            oTabelaDeMargen.Encargo = double.Parse(this.TxtEncargo.Text);
            if (oTabelaDeMargen.Encargo > 0) Calcular();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SubCategoria oSubCategoria = new SubCategoria();
                oSubCategoria.Nome = this.TxtBuscar.Text;
                DgvSubcategorias.DataSource = oSubCategoria.Busca();
            }catch{ }
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
            this.Close();
            oTabelaDeMargen=null;
        }

        #endregion
  
    }
}
