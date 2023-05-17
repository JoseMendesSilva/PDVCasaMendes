using System;
using System.Windows.Forms;

namespace CasaMendes
{
    public partial class frmFinlizarVendas : Form
    {

        public decimal Dinheiro { get; set; }
        public decimal TotalGeral { get; set; }
        public decimal Troco { get; set; }
        public int ClienteId { get; set; }
        public string Cliente { get; set; }
        public string TipoDeVenda { get; set; }
        public string CancelarVenda { get; set; }

        public frmFinlizarVendas()
        {
            InitializeComponent();
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

        private void txtDinheiro_TextChanged(object sender, EventArgs e)
        {
            try
            {

                this.Dinheiro = Convert.ToDecimal(this.txtDinheiro.Text);
                this.TotalGeral = Convert.ToDecimal(this.txtTotal.Text.Replace("R$ ", ""));

                if (Dinheiro < TotalGeral)
                {
                    txtDinheiro.Focus();
                    return;
                }
                else
                {
                    this.Troco = (Dinheiro - TotalGeral);
                    txtTroco.Text = Troco.ToString("N2");
                }
            }
            catch {; }
        }

        private void txtDinheiro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Dinheiro < TotalGeral)
                {
                    txtDinheiro.Focus();
                    txtDinheiro.SelectAll();
                    return;
                }

                CancelarVenda = string.Empty;
                this.Close();

            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Dinheiro = 0;
                this.TotalGeral = 0;
                this.Troco = 0;
                this.CancelarVenda = "CancelarVenda";
                this.Close();
            }

        }

        private void frmFinlizarVendas_Load(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text.ToUpper();
            this.label2.Text = this.label2.Text.ToUpper();
            this.label3.Text = this.label3.Text.ToUpper();
            this.label4.Text = this.label4.Text.ToUpper();
            this.label7.Text = this.label7.Text.ToUpper();
            this.label9.Text = this.label9.Text.ToUpper();
            this.label11.Text = this.label11.Text.ToUpper();
            this.label15.Text = this.label15.Text.ToUpper();

            CbFormaDePagamento.SelectedText = LblCliente.Text;
            this.txtDinheiro.Focus();
        }

        private void CbFormaDePagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbFormaDePagamento.Text == "PENDURA")
                SelecionarCliente();
            txtDinheiro.Focus();
            txtDinheiro.SelectAll();
        }

    }
}
