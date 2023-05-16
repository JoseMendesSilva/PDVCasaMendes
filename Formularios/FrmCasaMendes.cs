
using CasaMendes.Classes.Estatica;
using System;
using System.Windows.Forms;

using oVenda = CasaMendes.Classes.Geral.Cl_PreVenda;

namespace CasaMendes.Formularios
{

    public partial class FrmCasaMendes : Form
    {
        public FrmCasaMendes()
        {
            //===================================================================================================
            InitializeComponent();

            //===================================================================================================
 
            this.Left = 10;
            this.Top = 10;

            this.Text = clsGlobal.MontarTitulo("Casa Mendes");

            this.btnSair.Top = this.Height - this.btnSair.Height - 50;
            this.btnClientes.Left = this.btnEstoque.Left = this.btnFornecedores.Left = this.btnFuncionario.Left = this.btnPdv.Left = this.btnReceber.Left = this.BtnVendas.Left = this.btnSair.Left = this.BtnCargaPorCodigo.Left = 24;

            this.Width = (this.btnSair.Left + this.btnSair.Width + 40);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Dispose();
            GC.Collect(2, GCCollectionMode.Optimized);
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            FrmCadFuncionario f = new FrmCadFuncionario();
            f.ShowDialog();
            if (f != null) { f.Dispose(); }
        }

        private void btnFornecedores_Click(object sender, EventArgs e)
        {
            frmFornecedores f = new frmFornecedores();
            f.ShowDialog();
            if (f != null) { f.Dispose(); }
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmClientes f = new frmClientes();
            f.ShowDialog();
            if (f != null) { f.Dispose(); }
        }

        private void btnCarregarVendas_Click(object sender, EventArgs e)
        {
            frmCarregarVenda fc = new frmCarregarVenda();
            fc.ShowDialog();
            if (fc != null) { fc.Dispose(); }
        }

        private void btnPdv_Click(object sender, EventArgs e)
        {
            FrmFrenteDeCaixa f = new FrmFrenteDeCaixa();
            f.ShowDialog();
            if (f != null) { f.Dispose(); }
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            FrmEstoque f = new FrmEstoque();

            clsGlobal.TagForm = "FrmCasaMendes";
            f.ShowDialog();
            if (f != null) { f.Dispose(); }
        }

        private void BtnVendas_Click(object sender, EventArgs e)
        {
            FrmResumoDeVendasAtual f = new FrmResumoDeVendasAtual();
            f.ShowDialog();
            if (f != null) { f.Dispose(); }
        }

        private void FrmCasaMendes_FormClosed(object sender, FormClosedEventArgs e)
        {

            try
            {
                oVenda.FazerResumoDeVendas(DateTime.Now.ToShortDateString(), DateTime.Now.ToShortDateString());
            }
            catch
            {

            }
        }

        private void BtnCargaPorCodigo_Click(object sender, EventArgs e)
        {

            frmCarregaCodigoDeNota f = new frmCarregaCodigoDeNota();
            f.ShowDialog();
            if (f != null) { f.Dispose(); }

        }

        private void FrmCasaMendes_MouseClick(object sender, MouseEventArgs e)
        {
            FrmProdutos frmProdutos = new FrmProdutos();
            frmProdutos.ShowDialog();
        }

        private void FrmCasaMendes_Load(object sender, EventArgs e)
        {

        }
    }
}
