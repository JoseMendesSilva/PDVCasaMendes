using System;
using System.Windows.Forms;

namespace CasaMendes
{
    public partial class FrmTabelaDeMargen : Form
    {
        public FrmTabelaDeMargen()
        {
            InitializeComponent();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {

        }

        private void FrmTabelaDeMargen_Load(object sender, EventArgs e)
        {
            try
            {

                SubCategoria oSubCategoria = new SubCategoria();
                DgvSubcategorias.DataSource = oSubCategoria.Todos();
            }
            catch { }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
