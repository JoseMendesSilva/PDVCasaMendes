using System;
using System.Windows.Forms;

namespace CasaMendes.Formularios
{
    public partial class frmFinlizarVendas : Form
    {
        decimal Dinheiro;
        decimal TotalGeral;
        decimal troco;

        public string CancelarVenda = "CancelarVenda";
        public frmFinlizarVendas()
        {
            InitializeComponent();
            this.txtDinheiro.Focus();
        }

        private void txtDinheiro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.Dinheiro = Convert.ToDecimal(this.txtDinheiro.Text);
                this.TotalGeral = Convert.ToDecimal(this.txtTotalGeral.Text.Replace("R$ ", ""));

                if (Dinheiro < TotalGeral)
                {
                    txtDinheiro.Focus();
                    return;
                }
                else
                {
                    this.troco = (Dinheiro - TotalGeral);
                    txtTroco.Text = troco.ToString("C2");
                }
            }
            catch {; }
        }

        private void txtDinheiro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Dinheiro < TotalGeral) { txtDinheiro.Focus(); txtDinheiro.SelectAll(); return; }
                CancelarVenda = string.Empty;
                this.Close();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Dinheiro = 0;
                this.TotalGeral = 0;
                this.troco = 0;
                this.CancelarVenda = "CancelarVenda";
                this.Close();
            }

        }

        private void frmFinlizarVendas_Load(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text.ToUpper();
            this.label2.Text = this.label2.Text.ToUpper();
        }
    }
}
