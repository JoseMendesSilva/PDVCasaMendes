using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasaMendes
{
    public partial class FrmCasaMendes : Form
    {

        public FrmCasaMendes()
        {
            InitializeComponent();
            this.btnlogoInicio.Click += new System.EventHandler(this.btnlogoInicio_Click);
            this.btnprod.Click += new System.EventHandler(this.btnprod_Click);
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            this.btnVendasDia.Click += new System.EventHandler(this.btnVendas_Click);
            this.btnFornecedores.Click += new System.EventHandler(this.btnFornecedores_Click);
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            this.BtnCategorias.Click += new System.EventHandler(this.BtnCategorias_Click);

            this.iconcerrar.Click += new System.EventHandler(this.iconcerrar_Click);
            this.iconmaximizar.Click += new System.EventHandler(this.iconmaximizar_Click);
            this.iconminimizar.Click += new System.EventHandler(this.iconminimizar_Click);
            this.iconrestaurar.Click += new System.EventHandler(this.iconrestaurar_Click);
            this.iconcerrar.Click += new System.EventHandler(this.iconcerrar_Click);
  
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 70;
            }
            else
                MenuVertical.Width = 250;
        }

        private void iconcerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconrestaurar.Visible = true;
            iconmaximizar.Visible = false;
        }

        private void iconrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconrestaurar.Visible = false;
            iconmaximizar.Visible = true;
        }

        private void iconminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void AbrirFormEnPanel(object Formhijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void btnprod_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmProdutos());
        }

        private void btnlogoInicio_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new InicioResumen());
        }

        private void FrmCasaMendes_Load(object sender, EventArgs e)
        {
            //temp temp = new temp();
            //temp.ShowDialog();
            //AbrirFormEnPanel(new temp());
            CriarTabelasDoSistema.CriarTabelas();
            btnlogoInicio_Click(null, e);
            this.Refresh();
            //Thread.Sleep(500);
            //this.btnPdv.PerformClick();
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmCarregarVendas());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmProdutos());
        }

        private void btnFornecedores_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmFornecedores());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmClientes());
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmEstoque());
        }

        private void btnPdv_Click(object sender, EventArgs e)
        {
            FrmFrenteDeCaixa frenteDeCaixa = new FrmFrenteDeCaixa();
            // Set the Parent Form of the Child window.
            //frenteDeCaixa.MdiParent = this;
            frenteDeCaixa.Text = "FrenteDeCaixa ";
            // Display the new form.
            frenteDeCaixa.ShowDialog();
        }

        private void PicConfiguracoes_Click(object sender, EventArgs e)
        {
            MyPrinters myPrinters = new MyPrinters();
            // Set the Parent Form of the Child window.
            //frenteDeCaixa.MdiParent = this;
            myPrinters.Text = "Configuracoes ";
            // Display the new form.
            myPrinters.ShowDialog();
            //AbrirFormEnPanel(new MyPrinters());
        }

        private void BtnCategorias_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmCadCategoria());
        }

        private void BtnReceberPendura_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmReceberPendura());
        }

        private void BtnProcessarDados_Click(object sender, EventArgs e)
        {
            var temp = new temp();
            temp.ShowDialog();
            temp.Dispose();
        }

        private void BtnTabelaDeMargens_Click(object sender, EventArgs e)
        {
            FrmTabelaDeMargen frmTabelaDeMargen = new FrmTabelaDeMargen();
            frmTabelaDeMargen.ShowDialog();
        }
    }
}
