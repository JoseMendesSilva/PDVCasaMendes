using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Windows.Forms;

namespace CasaMendes
{
    public partial class FrmTabelaDeMargen : Form
    {

        #region Propriedades

        public string StatusLabel { get; set; }

        #endregion

        #region variáveis

        private bool Loading;
        private bool Loadining;
        private bool editar;
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

                DgvSubcategorias.Columns["Nome"].Width = clsGlobal.DimencionarColuna(95, this.DgvSubcategorias.Width);

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

                DgvTabelaDeMargem.Columns["NumeroDeItensNaLoja"].DefaultCellStyle.Format = "G";
                DgvTabelaDeMargem.Columns["ValorDeBase"].DefaultCellStyle.Format = "N2";
                DgvTabelaDeMargem.Columns["PorcentagemPesoPorItem"].DefaultCellStyle.Format = "N2";
                DgvTabelaDeMargem.Columns["Despesa"].DefaultCellStyle.Format = "N2";
                DgvTabelaDeMargem.Columns["Custo"].DefaultCellStyle.Format = "N2";
                DgvTabelaDeMargem.Columns["Encargo"].DefaultCellStyle.Format = "N2";
                DgvTabelaDeMargem.Columns["MargemDeLucro"].DefaultCellStyle.Format = "N2";

                Loadining = false;
            }
        }

        private void LerDados()
        {
            oTabelaDeMargen.TabelaDeMargenId = clsGlobal.DeStringParaInt(this.TxtTabelaDeMargenId.Text);
            oTabelaDeMargen.SubCategoriaId = clsGlobal.DeStringParaInt(this.TxtSubCategoriaId.Text);
            oTabelaDeMargen.NumeroDeItensNaLoja = clsGlobal.DeStringParaInt(this.TxtNumeroDeItensNaLoja.Text);
            oTabelaDeMargen.ValorDeBase = clsGlobal.DeStringParaDecimal(this.TxtValorDeBase.Text);
            oTabelaDeMargen.PorcentagemPesoPorItem = clsGlobal.DeStringParaDecimal(this.TxtPorcentagemPesoPorItem.Text);
            oTabelaDeMargen.Despesa = clsGlobal.DeStringParaDecimal(this.TxtDespesa.Text);
            oTabelaDeMargen.Custo = clsGlobal.DeStringParaDecimal(this.TxtCusto.Text);
            oTabelaDeMargen.Encargo = clsGlobal.DeStringParaDecimal(this.TxtEncargo.Text);
            oTabelaDeMargen.MargemDeLucro = clsGlobal.DeStringParaDecimal(this.TxtMargemDeLucro.Text);
        }

        private void CarregarDados()
        {
            this.TxtTabelaDeMargenId.Text = oTabelaDeMargen.TabelaDeMargenId.ToString();
            this.TxtSubCategoriaId.Text = oTabelaDeMargen.SubCategoriaId.ToString();
            this.TxtNumeroDeItensNaLoja.Text = oTabelaDeMargen.NumeroDeItensNaLoja.ToString();
            this.TxtValorDeBase.Text = oTabelaDeMargen.ValorDeBase.ToString();
            this.TxtPorcentagemPesoPorItem.Text = oTabelaDeMargen.PorcentagemPesoPorItem.ToString();
            this.TxtDespesa.Text = oTabelaDeMargen.Despesa.ToString();
            this.TxtCusto.Text = oTabelaDeMargen.Custo.ToString();
            this.TxtEncargo.Text = oTabelaDeMargen.Encargo.ToString();
            this.TxtMargemDeLucro.Text = oTabelaDeMargen.MargemDeLucro.ToString();
        }

        private void Calcular()
        {
            if (this.TxtCusto.Text.Equals("") || this.TxtMargemDeLucro.Text.Equals("") || this.TxtDespesa.Text.Equals("") || this.TxtEncargo.Text.Equals("")) return;
            decimal d = 0;

            d += oTabelaDeMargen.Custo;
            d += oTabelaDeMargen.MargemDeLucro;
            d += oTabelaDeMargen.Despesa;
            d += oTabelaDeMargen.Encargo;
            d += oTabelaDeMargen.PorcentagemPesoPorItem;

            this.TxtTotal.Text = d.ToString("N2");
        }

        private void CalcularPorcentagemPeso()
        {
            try
            {
                if (!string.IsNullOrEmpty(TxtNumeroDeItensNaLoja.Text) && !string.IsNullOrEmpty(TxtValorDeBase.Text))
                {
                    oTabelaDeMargen.NumeroDeItensNaLoja = clsGlobal.DeStringParaInt(this.TxtNumeroDeItensNaLoja.Text);
                    oTabelaDeMargen.ValorDeBase = clsGlobal.DeStringParaDecimal(this.TxtValorDeBase.Text);
                    TxtPorcentagemPesoPorItem.Text = oTabelaDeMargen.PorcentagemPesoPorItem.ToString("N2");
                }
            }
            catch { }
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
            TxtValorDeBase.Text = "1228,07";
            TxtPorcentagemPesoPorItem.Text = oTabelaDeMargen.PorcentagemPesoPorItem.ToString("N2");
        }

        #endregion

        #region Load

        private void FrmTabelaDeMargen_Load(object sender, EventArgs e)
        {
            try
            {
                Loading = true;
                Loadining = true;
                oTabelaDeMargen = new TabelaDeMargen();
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
                Loading = false;
                Loadining = false;
                TxtNumeroDeItensNaLoja.Text = "67";
                TxtValorDeBase.Text = "1228,07";
                CalcularPorcentagemPeso();
            }
            catch { }
        }

        #endregion

        #region CelulaEnter

        private void DgvSubcategorias_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 && !Loading) return;
            oTabelaDeMargen.SubCategoriaId = clsGlobal.DeStringParaInt(DgvSubcategorias.Rows[e.RowIndex].Cells[0].Value.ToString());
            oTabelaDeMargen.TabelaDeMargenId = 0;
            DgvTabelaDeMargem.DataSource = oTabelaDeMargen.Busca();
            TxtSubCategoriaId.Text = oTabelaDeMargen.SubCategoriaId.ToString();
            TxtSubCategoria.Text = DgvSubcategorias.Rows[e.RowIndex].Cells[2].Value.ToString();
            OrganizarColunasTabelaDeMargen();
        }

        private void DgvTabelaDeMargem_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1 && !Loading)
                {
                    oTabelaDeMargen = (TabelaDeMargen)DgvTabelaDeMargem.Rows[e.RowIndex].DataBoundItem;
                    CarregarDados();
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
            }
            catch { }
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
            }
            catch { }
        }

        private void TxtValorDeBase_TextChanged(object sender, EventArgs e)
        {
            CalcularPorcentagemPeso();
        }

        private void TxtNumeroDeItensNaLoja_TextChanged(object sender, EventArgs e)
        {
            CalcularPorcentagemPeso();
        }

        private void TxtPorcentagemPesoPorItem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(TxtPorcentagemPesoPorItem.Text))
                {
                    Calcular();
                }

            }
            catch { }
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
            LerDados();
            oTabelaDeMargen.Salvar();
            DgvTabelaDeMargem.DataSource = oTabelaDeMargen.Busca();
            MessageBox.Show("Cadastro realizado com sucesso.");
            Botoes(true);
            editar = true;
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (oTabelaDeMargen.TabelaDeMargenId > 0)
            {
                DialogResult dresult = MensagemBox.Mostrar($"Esta ação é definitiva, você deseja excluir o produto '{oTabelaDeMargen.Encargo}'", "Sim", "Não");
                if (dresult == DialogResult.Yes)
                {
                    oTabelaDeMargen.Excluir();
                    MessageBox.Show("O registro foi excluido com sucesso.");
                    CarregarDados();
                }
            }
        }

        private void BtnRetornar_Click(object sender, EventArgs e)
        {
            this.Close();
            oTabelaDeMargen = null;
        }

        #endregion

    }
}
