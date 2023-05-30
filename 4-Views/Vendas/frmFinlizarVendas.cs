using DocumentFormat.OpenXml.Vml;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace CasaMendes
{

    /*
     * +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
     *                                          DADOS PARA CUPOM FISCAL
     * +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
     * O cupom fiscal contém informações, como:
     * nome do estabelecimento que vendeu o produto;
     * endereço do estabelecimento (rua, número, bairro, cidade e estado);
     * CNPJ e IE (Inscrição Estadual) do estabelecimento;
     * CPF/CNPJ do consumidor (quando solicitado);
     * data e horário da emissão;
     * quantidades e descrições das mercadorias;
     * tributos totais relacionados ao produto, como ICMS, PIS e Cofins (obrigatório segundo a Lei nº 12.741/12);
     * valor total a ser pago;
     * forma de pagamento.
    */

    public partial class frmFinlizarVendas : Form
    {

        public decimal Tributos { get; set; }
        public decimal Juros { get; set; }
        public decimal TotalPendura { get; set; }
        public decimal Dinheiro { get; set; }
        public decimal Desconto { get; set; }
        private decimal Total { get; set; }
        public decimal Troco { get; set; }
        public int ClienteId { get; set; }
        public string Cliente { get; set; }
        public string TipoDeVenda { get; set; }

        public frmFinlizarVendas()
        {
            InitializeComponent();
        }

        private void AtribuirValore()
        {
            try
            {
                
                   this.Dinheiro = clsGlobal.DeStringParaDecimal(this.txtDinheiro.Text);
                   this.Desconto = clsGlobal.DeStringParaDecimal(this.TxtDesconto.Text);
                      this.Total = clsGlobal.DeStringParaDecimal(this.txtTotal.Text);
                   this.Tributos = clsGlobal.DeStringParaDecimal(ConfigurationManager.AppSettings["Tributos"]);
                      this.Juros = clsGlobal.DeStringParaDecimal(ConfigurationManager.AppSettings["Juros"]);
                this.TipoDeVenda = CbFormaDePagamento.Text;

                decimal DinheiroMaisDesconto = this.Dinheiro + this.Desconto;
                decimal dinheiro = DinheiroMaisDesconto - this.Total;

                if (this.TipoDeVenda == "PENDURA")
                {
                     decimal encargos = (this.Juros + this.Tributos) / 100;
                             encargos = 1 - encargos;
                    this.TotalPendura = this.Total / encargos;
                }

                    this.txtDinheiro.Text = Dinheiro.ToString("N2");
                    this.TxtDesconto.Text = Desconto.ToString("N2");
                    this.TxtTributos.Text = this.Tributos.ToString("N2");
                       this.txtTotal.Text = Total.ToString("N2");
                       this.TxtJuros.Text = Juros.ToString("N2");
                this.TxtTotalPendura.Text = TotalPendura.ToString("N2");
            }
            catch { }
        }

        private void SelecionarCliente()
        {
            FrmBuscarCliente fc = new FrmBuscarCliente();
            fc.ShowDialog();
            if (fc.DialogResult.Equals(DialogResult.OK))
            {
                this.ClienteId = fc.ClienteId;
                this.Cliente = fc.Cliente;
                this.TipoDeVenda = "PENDURA";
            }
            else
            {
                this.ClienteId = 0;
                this.Cliente = "A VISTA";
                this.TipoDeVenda = this.Cliente;
            }
            fc.Dispose();
            this.LblClienteId.Text = this.ClienteId.ToString();
            this.LblCliente.Text = this.Cliente;
        }

        private void frmFinlizarVendas_Load(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text.ToUpper();
            this.label4.Text = this.label4.Text.ToUpper();
            this.label2.Text = this.label2.Text.ToUpper();
            this.label3.Text = this.label3.Text.ToUpper();
            this.label4.Text = this.label4.Text.ToUpper();
            this.label7.Text = this.label7.Text.ToUpper();
            this.label9.Text = this.label9.Text.ToUpper();
            this.label11.Text = this.label11.Text.ToUpper();

            CbFormaDePagamento.SelectedIndex = 0;
            CbFormaDePagamento.Focus();
            CbFormaDePagamento.SelectAll();
        }

        private void CbFormaDePagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbFormaDePagamento.Text == "PENDURA")
                SelecionarCliente();
            txtDinheiro.Focus();
            txtDinheiro.SelectAll();
        }

        private void txtDinheiro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                AtribuirValore();
                if ((Dinheiro + Desconto) < Total)
                {
                    txtDinheiro.Focus();
                    return;
                }
                else
                {
                }
            }
            catch {; }
        }

        private void TxtDesconto_TextChanged(object sender, EventArgs e)
        {
            AtribuirValore();
        }

        private void txtDinheiro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AtribuirValore();

                if (((Dinheiro + Desconto) < Total) && LblClienteId.Text.Equals("0000"))
                {
                    txtTroco.Text = "0,00";
                    txtDinheiro.Focus();
                    txtDinheiro.SelectAll();
                    return;
                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }

            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Dinheiro = 0;
                this.Desconto = 0;
                this.Total = 0;
                this.Troco = 0;
                this.TipoDeVenda = CbFormaDePagamento.Text;
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }

        }

        private void TxtDesconto_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    AtribuirValore();

                    if ((Dinheiro + Desconto) < Total)
                    {
                        txtDinheiro.Text = this.Desconto.ToString("N2");
                        TxtDesconto.Focus();
                        return;
                    }
                    else
                    {
                        txtDinheiro.Focus();
                        txtDinheiro.SelectAll();
                    }
                }
            }
            catch {; }

        }

        private void CbFormaDePagamento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDinheiro.Focus();
                txtDinheiro.SelectAll();
            }
        }

    }
}
