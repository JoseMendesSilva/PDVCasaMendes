using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Windows.Forms;

namespace CasaMendes
{
    public partial class FrmTabelaDeMargen : Form
    {

        #region Propriedades

        public string StatusLabel { get;set; }

        #endregion

        #region variáveis

        int LinhaIndex, LinhaIndexMargem;
        private bool Loading;
        private bool Loadining;
        private bool editar;
        private BindingSource BsTabelaDeMargem;
        private TabelaDeMargen oTabelaDeMargen;

        #endregion

        #region construtor

        public FrmTabelaDeMargen()
        {
            InitializeComponent();
        }

        #endregion

        #region métodos

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
                editar = true;
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
                DgvTabelaDeMargem.Columns["PorcentagemPesoPorItem"].Width = clsGlobal.DimencionarColuna(18, this.DgvTabelaDeMargem.Width);
                DgvTabelaDeMargem.Columns["Despesa"].Width = clsGlobal.DimencionarColuna(10, this.DgvTabelaDeMargem.Width);
                DgvTabelaDeMargem.Columns["Custo"].Width = clsGlobal.DimencionarColuna(10, this.DgvTabelaDeMargem.Width);
                DgvTabelaDeMargem.Columns["Encargo"].Width = clsGlobal.DimencionarColuna(10, this.DgvTabelaDeMargem.Width);
                DgvTabelaDeMargem.Columns["MargemDeLucro"].Width = clsGlobal.DimencionarColuna(18, this.DgvTabelaDeMargem.Width);

                DgvTabelaDeMargem.Columns["NumeroDeItensNaLoja"].HeaderText = "Numero de itens";
                DgvTabelaDeMargem.Columns["ValorDeBase"].HeaderText = "Valor base";
                DgvTabelaDeMargem.Columns["PorcentagemPesoPorItem"].HeaderText = "Pesso aplicado";
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
            this.TxtPorcentagemPesoPorItem.DataBindings.Add("Text", BsTabelaDeMargem, "PorcentagemPesoPorItem");
            this.TxtDespesa.DataBindings.Add("Text", BsTabelaDeMargem, "Despesa");
            this.TxtCusto.DataBindings.Add("Text", BsTabelaDeMargem, "Custo");
            this.TxtEncargo.DataBindings.Add("Text", BsTabelaDeMargem, "Encargo");
            this.TxtMargemDeLucro.DataBindings.Add("Text", BsTabelaDeMargem, "MargemDeLucro");
        }

        private void Calcular()
        {
            if (this.TxtCusto.Text.Equals("") || this.TxtMargemDeLucro.Text.Equals("") || this.TxtDespesa.Text.Equals("") || this.TxtEncargo.Text.Equals("")) return;
            decimal d = oTabelaDeMargen.Despesa;
            d = clsGlobal.DeStringParaDecimal(this.TxtValorDeBase.Text) / clsGlobal.DeStringParaDecimal(this.TxtNumeroDeItensNaLoja.Text);


            d += oTabelaDeMargen.Custo;
            d += oTabelaDeMargen.MargemDeLucro;
            d += oTabelaDeMargen.Despesa;
            d += oTabelaDeMargen.Encargo;

            this.TxtPorcentagemPesoPorItem.Text = d.ToString("N2");
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
            TxtNumeroDeItensNaLoja.Text = "67";
            TxtValorDeBase.Text = "1.228,07"; 
            TxtPorcentagemPesoPorItem.Text = oTabelaDeMargen.Porcentagem().ToString("N2");
        }

        private void LoadingTabelaDeMargen()
        {
            try
            {
                if (LinhaIndex.Equals(-1) && !Loading) return;
                int index = clsGlobal.DeStringParaInt(DgvSubcategorias.Rows[LinhaIndex].Cells[0].Value.ToString());
                oTabelaDeMargen.SubCategoriaId = index;
                oTabelaDeMargen.TabelaDeMargenId = 0;
                 DgvTabelaDeMargem.DataSource = oTabelaDeMargen.Busca();
                BsTabelaDeMargem.DataSource = oTabelaDeMargen;
                OrganizarColunasTabelaDeMargen();
            }
            catch { }
        }
  
        #endregion

        #region Load

        private void FrmTabelaDeMargen_Load(object sender, EventArgs e)
        {
            try
            {
                LinhaIndexMargem = LinhaIndex = -1;
                Loading = true;
                Loadining = true;
                VincularDados();

                SubCategoria oSubCategoria = new SubCategoria();
                DgvSubcategorias.DataSource = oSubCategoria.Todos();
                if (DgvSubcategorias.Rows.Count == 0)
                {
                    MessageBox.Show("Não foram encontrado nemhuma subcategoria cadastrada, cadastre subcategorias.");
                    BtnGravar.Enabled = false;
                    BtnExcluir.Enabled = false;
                    BtnNovo.Enabled = false;
                    BtnRetornar.Enabled = true;
                }
                OrganizarColunasSubcategoria();
                //Limpar();
                int tValor = clsGlobal.DeStringParaInt(TxtNumeroDeItensNaLoja.Text);
                if (tValor == 0) TxtNumeroDeItensNaLoja.Text = "67";
                 tValor = clsGlobal.DeStringParaInt(TxtValorDeBase.Text);
                if (TxtValorDeBase.Text.Length > 0) TxtValorDeBase.Text = "1228,07";
            }
            catch { }
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
                LinhaIndexMargem = e.RowIndex;
                if (LinhaIndexMargem > -1 && !Loading)
                {
                    oTabelaDeMargen = (TabelaDeMargen)DgvTabelaDeMargem.Rows[LinhaIndexMargem].DataBoundItem;
                    BsTabelaDeMargem.DataSource = oTabelaDeMargen;
                    Calcular();
                    StatusLabel = (DgvTabelaDeMargem.RowCount - 1).ToString();
                }
            }
            catch { }
        }

        #endregion

        #region TextoChanged

        private void TxtCusto_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.TxtCusto.Text.Equals("")) return;
                oTabelaDeMargen.Custo = clsGlobal.DeStringParaDecimal(this.TxtCusto.Text);
                if (oTabelaDeMargen.Custo > 0) Calcular();
            }catch { }
        }

        private void TxtMargemDeLucro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.TxtMargemDeLucro.Text.Equals("")) return;
                oTabelaDeMargen.MargemDeLucro = clsGlobal.DeStringParaDecimal(this.TxtMargemDeLucro.Text);
                if (oTabelaDeMargen.MargemDeLucro > 0) Calcular();
            }
            catch { }
        }

        private void TxtDespesa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.TxtDespesa.Text.Equals("")) return;
                oTabelaDeMargen.Despesa = clsGlobal.DeStringParaDecimal(this.TxtDespesa.Text);
                if (oTabelaDeMargen.Despesa > 0) Calcular();
            }
            catch { }
        }

        private void TxtEncargo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.TxtEncargo.Text.Equals("")) return;
                oTabelaDeMargen.Encargo = clsGlobal.DeStringParaDecimal(this.TxtEncargo.Text);
                if (oTabelaDeMargen.Encargo > 0) Calcular();
            }
            catch { }
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

        private void TxtValorDeBase_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(TxtNumeroDeItensNaLoja.Text) && !string.IsNullOrEmpty(TxtValorDeBase.Text))
                {
                    TxtPorcentagemPesoPorItem.Text = oTabelaDeMargen.Porcentagem().ToString("N2");
                }
            }
            catch { }
        }

        private void TxtNumeroDeItensNaLoja_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtNumeroDeItensNaLoja.Text) && !string.IsNullOrEmpty(TxtValorDeBase.Text))
            {
                TxtPorcentagemPesoPorItem.Text = oTabelaDeMargen.Porcentagem().ToString("N2");
            }
        }

        #endregion

        #region Click

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            if (BtnNovo.Text.Equals("Cancelar"))
            {
                Botoes(true);
                editar = true;
            }
            else
            {
                Limpar();
                Botoes(false);
                TxtTabelaDeMargenId.Text = "0";
                oTabelaDeMargen.TabelaDeMargenId = 0;
                editar = false;
            }
        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            if (!editar)
            {
                TxtTabelaDeMargenId.Text = "0";
                oTabelaDeMargen.TabelaDeMargenId = 0;
            }
            oTabelaDeMargen.Salvar();
            LoadingTabelaDeMargen();
            MessageBox.Show("Cadastro realizado com sucesso.");
            Botoes(true);
            editar = true;
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult dresult = MensagemBox.Mostrar($"Esta ação é definitiva, você deseja excluir o produto '{oTabelaDeMargen.Encargo}'", "Sim", "Não");
            if (dresult == DialogResult.Yes)
            {
                oTabelaDeMargen = (TabelaDeMargen)DgvTabelaDeMargem.Rows[LinhaIndexMargem].DataBoundItem;
                oTabelaDeMargen.Excluir();
                MessageBox.Show("O registro foi excluido com sucesso.");
                LoadingTabelaDeMargen();
            }
        }

        private void BtnRetornar_Click(object sender, EventArgs e)
        {
            this.Close();
            oTabelaDeMargen=null;
        }

        #endregion

    }
}
