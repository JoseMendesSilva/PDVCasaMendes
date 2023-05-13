
using CasaMendes.Classes.Geral;
using CasaMendes.Classes.Estatica;
using CasaMendes.Propriedades;
using System.Collections.Generic;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CasaMendes.Formularios
{
    public partial class frmCadastrarProdutos : Form
    {

        #region Variáveis.

        Cl_Produto oProduto;
        private bool _Editar;
        private bool EstaCarregando = false;
        //private Color CorDaPena = Color.Red;
        private string barCode;

        #endregion

        #region Construtor.

        public frmCadastrarProdutos()
        {
            InitializeComponent();
            oProduto = new Cl_Produto();
            oProduto.CarregarCaixaCombo(this.cbFornecedores, "RazaoSocial", "tFornecedores");
        }

        #endregion

        #region Manutenção.

        private void PrepararParaUmNovoRegistro()
        {
            try
            {
                this.txtCodigoDeBarras.Enabled = true;
                this.txtCodigoDoFornecedor.Enabled = false;
                this.cbFornecedores.Enabled = false;

                this.TxtValorDesconto.Enabled = false;
                this.txtDesconto.Enabled = false;
                this.txtEstoque.Enabled = false;
                this.txtPrecoDeVendaVista.Enabled = false;
                this.txtPrecoUnitario.Enabled = false;
                this.txtProduto.Enabled = false;
                this.txtQuantidade.Enabled = false;
                this.txtValorCompra.Enabled = false;
                this.dtpDataDeValidade.Enabled = false;

                string Img = clsGlobal.ValidarDiretorio(clsGlobal.sCaminho, @"imagens\apagar.png");
                this.PicFoto.Image = Image.FromFile(Img);
            }
            catch {; }
        }

        private void AtribuirValores()
        {
            this.oProduto.CodigoDeBarras = this.txtCodigoDeBarras.Text;
            //if(_Editar == true) this.oProduto.CodigoDoFornecedor = Convert.ToInt16(this.txtCodigoDoFornecedor.Text);
            //if (_Editar == true) this.oProduto.ID_Produto = Convert.ToDecimal(this.txtID_Produto.Text);
            this.oProduto.RazaoSocial = this.cbFornecedores.Text;
            this.oProduto.Nome = this.txtProduto.Text;

            this.oProduto.DataDeValidade = DateTime.Parse(this.dtpDataDeValidade.Value.ToString());
            
            this.oProduto.ValorCompra = decimal.Parse(this.txtValorCompra.Text.Replace("R$ ", ""));
            this.oProduto.PrecoDeVenda = decimal.Parse(this.txtPrecoDeVendaVista.Text.Replace("R$ ", ""));
            this.oProduto.PrecoUnitario = decimal.Parse(this.txtPrecoUnitario.Text.Replace("R$ ", ""));

            this.oProduto.Quantidade = int.Parse(this.txtQuantidade.Text.ToString());
            this.oProduto.Estoque = int.Parse(this.txtEstoque.Text.ToString());

            this.oProduto.CodigoDaNotaFiscal = int.Parse(this.TxtCodigoDaNotaFiscal.Text);

            this.oProduto.Desconto = int.Parse(this.txtDesconto.Text);             
            this.oProduto.ValorDesconto =decimal.Parse( TxtValorDesconto.Text.Replace("R$ ", ""));
        }

        void CalcularPrecos()
        {
            string sTemp;
            decimal Cem = 100;
            decimal Porcentagem = 1;

            decimal MargemDeLucro = 14;
            decimal Imposto = 8;
            decimal CustoFixo = 1;
            decimal Frete = 1;
            decimal OutrosEncargos = 1;

            sTemp = txtPrecoUnitario.Text.Replace("R$ ", "").ToString();
            decimal PrecoUnitario = Convert.ToDecimal(sTemp);

            Porcentagem = (Cem - ((MargemDeLucro + Imposto + CustoFixo + Frete + OutrosEncargos))) / Cem;

            decimal PrecoDeVendaVista = PrecoUnitario / Porcentagem;

            txtPrecoDeVendaVista.Text = PrecoDeVendaVista.ToString("C2");

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
                                                {
                this.AtribuirValores();

                switch (_Editar)
                {
                    case false:
                        oProduto.Novo();
                        break;
                    case true:
                        if(barCode != null)
                        {
                            oProduto.Atualizar(this.barCode);
                        }
                        this.Close();
                        break;
                }
            }
            catch
            {

            }
        }

        private void lblPicFoto_Click(object sender, EventArgs e)
        {
            clsGlobal.Abririmagens(this.PicFoto);
        }

        #endregion

        #region Fechar formulário

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            GC.Collect();
        }

        #endregion

        #region KeyDown

        private void TxtCodigoDaNotaFiscal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.TxtCodigoDaNotaFiscal.Text.Length > 0)
                {
                    this.txtCodigoDeBarras.Enabled = true;
                    this.txtCodigoDeBarras.Focus();
                    this.txtCodigoDeBarras.SelectAll();
                }
                else
                {
                    this.TxtCodigoDaNotaFiscal.Focus();
                }
            }

        }

        private void txtCodigoDeBarras_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.txtCodigoDeBarras.Text.Length > 0)
                {
                    this.txtProduto.Enabled = true;
                    this.txtProduto.Focus();
                    this.txtProduto.SelectAll();
                }
                else
                {
                    this.txtCodigoDeBarras.Focus();
                }
            }

        }

        private void txtProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.txtProduto.Text.Length > 0)
                {
                    this.cbFornecedores.Enabled = true;
                    this.cbFornecedores.Focus();
                    this.cbFornecedores.SelectAll();
                }
                else
                {
                    this.cbFornecedores.Focus();
                }
            }
        }

        private void dtpDataDeValidade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                    if (this.dtpDataDeValidade.Text.Length > 0)
                    {
                        this.txtValorCompra.Enabled = true;
                        this.txtValorCompra.Focus();
                        this.txtValorCompra.SelectAll();
                    }
                    else
                    {
                        this.dtpDataDeValidade.Focus();
                    }
                }
        }

        private void txtValorCompra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.txtValorCompra.Text.Length > 0)
                {
                    this.txtQuantidade.Enabled = true;
                    this.txtQuantidade.Focus();
                    this.txtQuantidade.SelectAll();
                }
                else
                {
                    this.txtValorCompra.Focus();
                }
            }

        }

        private void txtQuantidade_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (this.txtQuantidade.Text.Length > 0)
                    {
                        this.txtPrecoUnitario.Enabled = true;
                        this.txtPrecoUnitario.Focus();
                        this.txtPrecoUnitario.SelectAll();
                    }
                    else
                    {
                        this.txtQuantidade.Focus();
                    }
                }
                else
                {
                    decimal q = Convert.ToDecimal(txtQuantidade.Text.Replace("R$ ", ""));
                    decimal v = Convert.ToDecimal(txtValorCompra.Text.Replace("R$ ", ""));
                    if (q > 0 && v > 0)
                    {
                        this.txtPrecoUnitario.Text = (v / q).ToString("C2");
                        CalcularPrecos();
                    }
                }
            }
            catch {; }
        }

        private void txtPrecoUnitario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.txtPrecoUnitario.Text.Length > 0)
                {
                    this.txtEstoque.Enabled = true;
                    this.txtEstoque.Focus();
                    this.txtEstoque.SelectAll();
                }
                else
                {
                    this.txtPrecoUnitario.Focus();
                }
            }
        }

        private void txtEstoque_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                if (this.txtEstoque.Text.Length > 0)
                {
                    this.txtPrecoDeVendaVista.Enabled = true;
                    this.txtPrecoDeVendaVista.Focus();
                    this.txtPrecoDeVendaVista.SelectAll();
                }
                else
                {
                    this.txtEstoque.Focus();
                }
            }
        }

        private void txtPrecoDeVendaVista_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.txtPrecoDeVendaVista.Text.Length > 0)
                {
                    this.txtDesconto.Enabled = true;
                    this.txtDesconto.Focus();
                    this.txtDesconto.SelectAll();
                }
                else
                {
                    this.txtPrecoDeVendaVista.Focus();
                }
            }
        }

        private void cbFornecedores_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.cbFornecedores.Text.Length > 0)
                {
                    this.dtpDataDeValidade.Enabled = true;
                    this.dtpDataDeValidade.Focus();
                    this.cbFornecedores.SelectAll();
                }
                else
                {
                    this.cbFornecedores.Focus();
                }
            }
        }

        private void txtDesconto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (this.txtDesconto.Text.Length <= 0)
                {
                    this.txtDesconto.Text = "0";
                }

                this.TxtValorDesconto.Enabled = true;
                this.TxtValorDesconto.Focus();
                this.TxtValorDesconto.SelectAll();

            }
        }

        private void TxtValorDesconto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.btnGravar.Focus();
            }
        }

        #endregion

        #region Efeito visual de BackColor e formatação.

        #region Enter.

        //private void txtCodigoDeBarras_Enter(object sender, EventArgs e)
        //{
        //    this.txtCodigoDeBarras.BackColor = Color.Gold;
        //}

        //private void txtProduto_Enter(object sender, EventArgs e)
        //{
        //    this.txtProduto.BackColor = Color.Gold;
        //}

        //private void cbFornecedores_Enter(object sender, EventArgs e)
        //{
        //    this.cbFornecedores.BackColor = Color.Gold;
        //}

        //private void dtpDataDeValidade_Enter(object sender, EventArgs e)
        //{
        //    this.dtpDataDeValidade.BackColor = Color.Gold;
        //}

        //private void txtValorCompra_Enter(object sender, EventArgs e)
        //{
        //    this.txtValorCompra.BackColor = Color.Gold;
        //}

        //private void TxtQuantidade_Enter(object sender, EventArgs e)
        //{
        //    this.txtQuantidade.BackColor = Color.Gold;
        //}

        //private void txtPrecoUnitario_Enter(object sender, EventArgs e)
        //{
        //    this.txtPrecoUnitario.BackColor = Color.Gold;
        //}

        //private void txtEstoque_Enter(object sender, EventArgs e)
        //{
        //    this.txtEstoque.BackColor = Color.Gold;
        //}

        //private void txtDesconto_Enter(object sender, EventArgs e)
        //{
        //    this.txtDesconto.BackColor = Color.Gold;
        //}

        //private void txtPrecoDeVendaVista_Enter(object sender, EventArgs e)
        //{
        //    this.txtPrecoDeVendaVista.BackColor = Color.Gold;
        //}

        #endregion

        #region Leave.

        private void txtCodigoDeBarras_Leave(object sender, EventArgs e)
        {
            try
            {
                this.txtCodigoDeBarras.BackColor = Color.GreenYellow;
                string dCodigo = this.txtCodigoDeBarras.Text.Trim();
                this.txtCodigoDeBarras.Text = dCodigo;
            }
            catch {; }
        }

        private void txtProduto_Leave(object sender, EventArgs e)
        {
            this.txtProduto.BackColor = Color.GreenYellow;
        }

        private void cbFornecedores_Leave(object sender, EventArgs e)
        {
            this.cbFornecedores.BackColor = Color.GreenYellow;
        }

        private void dtpDataDeValidade_Leave(object sender, EventArgs e)
        {
            this.dtpDataDeValidade.BackColor = Color.GreenYellow;
        }

        private void txtValorCompra_Leave(object sender, EventArgs e)
        {
            try
            {
                this.txtValorCompra.BackColor = Color.GreenYellow;
                decimal dValor = Convert.ToDecimal(this.txtValorCompra.Text.Replace("R$ 0,", "0."));
                this.txtValorCompra.Text = dValor.ToString("C2");
            }
            catch {; }
        }

        private void TxtQuantidade_Leave(object sender, EventArgs e)
        {
            try
            {
                this.txtQuantidade.BackColor = Color.GreenYellow;
                int dValor = Convert.ToInt16(this.txtQuantidade.Text.Replace("R$ 0,", "0."));
                this.txtQuantidade.Text = dValor.ToString("0");
            }
            catch {; }
        }

        private void txtPrecoUnitario_Leave(object sender, EventArgs e)
        {
            try
            {
                this.txtPrecoUnitario.BackColor = Color.GreenYellow;
                decimal dValor = Convert.ToDecimal(this.txtPrecoUnitario.Text.Replace("R$ 0,", "0."));
                this.txtPrecoUnitario.Text = dValor.ToString("C2");
            }
            catch {; }
        }

        private void txtEstoque_Leave(object sender, EventArgs e)
        {
            try
            {
                this.txtEstoque.BackColor = Color.GreenYellow;
                int dValor = Convert.ToInt16(this.txtEstoque.Text.Replace("R$ 0,", "0."));
                this.txtEstoque.Text = dValor.ToString("0");
            }
            catch {; }
        }

        private void txtDesconto_Leave(object sender, EventArgs e)
        {
            try
            {
                this.txtDesconto.BackColor = Color.GreenYellow;
                int dValor = Convert.ToInt16(this.txtDesconto.Text.Replace("R$ 0,", "0."));
                this.txtDesconto.Text = dValor.ToString("0");
            }
            catch {; }
        }
        private void TxtValorDesconto_Leave(object sender, EventArgs e)
        {
            this.TxtValorDesconto.BackColor = Color.GreenYellow;
            decimal dValor = decimal.Parse(this.TxtValorDesconto.Text.Replace("R$ 0,","0."));
            this.TxtValorDesconto.Text = dValor.ToString("C2");

        }

        private void txtPrecoDeVendaVista_Leave(object sender, EventArgs e)
        {
            try
            {
                this.txtPrecoDeVendaVista.BackColor = Color.GreenYellow;
                decimal dValor = Convert.ToDecimal(this.txtPrecoDeVendaVista.Text.Replace("R$ 0,", "0."));
                this.txtPrecoDeVendaVista.Text = dValor.ToString("C2");
            }
            catch {; }
        }

        #endregion

        #endregion

        #region Formulário.

        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {
            if (EstaCarregando.Equals(true)) return;
            try
            {
                int q = Convert.ToInt16(txtQuantidade.Text);
                decimal v = Convert.ToDecimal(txtValorCompra.Text.Replace("R$ ", ""));
                if (q > 0 && v > 0)
                {
                    this.txtPrecoUnitario.Text = (v / q).ToString("C2");
                    CalcularPrecos();
                }
            }
            catch { }
        }

        private void txtPrecoUnitario_TextChanged(object sender, EventArgs e)
        {
            if (EstaCarregando.Equals(true)) return;
            try
            {
                int q = Convert.ToInt16(txtQuantidade.Text);
                decimal v = Convert.ToDecimal(txtValorCompra.Text.Replace("R$ ", ""));
                if (q > 0 && v > 0)
                {
                    CalcularPrecos();
                }
            }
            catch { }
        }

        private void frmCadastrarProdutos_Shown(object sender, EventArgs e)
        {
            try
            {

                clsGlobal.CorDaPenaDosControles((ControlCollection)this.Controls);

                if (EstaCarregando.Equals(true)) return;
                if (clsGlobal.TagForm.ToString() == "Novo")
                {
                    _Editar = false;
                    clsGlobal.LimparControles((ControlCollection)this.Controls);
                    PrepararParaUmNovoRegistro();
                }
                else
                {
                    EstaCarregando = true;
                   _Editar = true;

                    barCode = this.txtCodigoDeBarras.Text;
                }
                List<Cl_pProduto> pL = Cl_Produto.CarregarProduto(this.txtCodigoDeBarras.Text);

                    if(pL != null)
                    {
                        this.txtProduto.Text             = pL[0].Nome.ToString();
                        //this.cbFornecedores.SelectedItem = pL[0].RazaoSocial.ToString();
                        this.txtValorCompra.Text         = pL[0].ValorCompra.ToString();
                        this.txtQuantidade.Text          = pL[0].Quantidade.ToString();
                        this.txtPrecoUnitario.Text       = pL[0].PrecoUnitario.ToString();
                        this.txtEstoque.Text             = pL[0].Estoque.ToString();
                        this.txtPrecoDeVendaVista.Text   = pL[0].PrecoDeVenda.ToString();
                        this.txtDesconto.Text            = pL[0].Desconto.ToString();
                        this.TxtValorDesconto.Text       = pL[0].ValorDesconto.ToString();
                        this.dtpDataDeValidade.Text      = pL[0].DataDeValidade.ToString();
                        this.txtCodigoDeBarras.Text      = pL[0].CodigoDeBarras.ToString();

                        if (pL[0].CodigoDaNotaFiscal.Equals(0)){
                            string cnf = oProduto.CodigoDaNota(pL[0].CodigoDeBarras);
                            if (!cnf.Equals(""))
                            {
                                pL[0].CodigoDaNotaFiscal = int.Parse(cnf.ToString());
                            }
                        }

                       this.TxtCodigoDaNotaFiscal.Text = pL[0].CodigoDaNotaFiscal.ToString();
                   
                }

                this.btnExcluir.Enabled = _Editar;
                EstaCarregando = false;
            }
            catch //(Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }

        }

        private void frmCadastrarProdutos_Load(object sender, EventArgs e)
        {
            barCode = this.txtCodigoDeBarras.Text;
        }

        #endregion

        #region KeyPress

        private void TxtCodigoDaNotaFiscal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
            }

        }

        private void txtCodigoDeBarras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
            }

        }

        private void txtProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
            }

        }

        private void cbFornecedores_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
            }

        }

        private void dtpDataDeValidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
            }

        }

        private void txtValorCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
            }

        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
            }

        }

        private void txtPrecoUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
            }

        }

        private void txtEstoque_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
            }

        }

        private void txtPrecoDeVendaVista_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
            }

        }

        private void txtDesconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
            }

        }

        private void TxtValorDesconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
            }

        }

        #endregion KeyPress

    }
}
