using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace CasaMendes
{
    public partial class FrmProcessando : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        public void Processo(int valor, string lblTitulo, string lblMensagem)
        {
            this.barra1.Value = valor;
            LblTitulo.Text = lblTitulo;
            LblMensagem.Text = lblMensagem;
            this.Refresh();
            //Thread.Sleep(20);
        }

        public FrmProcessando()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 35, 35));
        }

        ~FrmProcessando()
        {
            //Thread.Sleep(200);
            this.Dispose(disposing: false);
        }

    }
}
