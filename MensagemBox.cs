using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CasaMendes
{
    public partial class MensagemBox : Form
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

        public MensagemBox()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40));
        }

        public DialogResult Resultado { get; private set; }

        public static DialogResult Mostrar(string mensagem, string textoSim, string textoNao)
        {
            var msgBox = new MensagemBox();
            msgBox.lblMensagem.Text = mensagem;
            msgBox.btnSim.Text = textoSim;
            msgBox.btnNao.Text = textoNao;
            msgBox.ShowDialog();
            return msgBox.Resultado;
        }

        private void btnSim_Click(object sender, EventArgs e)
        {
            Resultado = DialogResult.Yes;
            Close();
        }

        private void btnNao_Click(object sender, EventArgs e)
        {
            Resultado = DialogResult.No;
            Close();
        }

    }
}
