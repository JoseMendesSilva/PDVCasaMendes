
using System;
using System.Windows.Forms;

namespace CasaMendes
{
    public partial class FrmEstoque : Form
    {

        public string StatusLabel { get; set; }
        public string CodigoProduto { get; set; }

        #region Construtor

        public FrmEstoque()
        {
            InitializeComponent();

        }



        #endregion

        private void FrmEstoque_Load(object sender, EventArgs e)
        {
            try
            {
                using(var oEstoque = new Estoque())
                {
                    dgv.DataSource = oEstoque.Todos();
                }
            }catch { }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCodigoDeBarras_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var oEstoque = new Estoque();
                oEstoque.CodigoDeBarras = txtCodigoDeBarras.Text;
                dgv.DataSource = oEstoque.Busca();
            }
            catch { }
        }

        private void dgv_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                CodigoProduto = dgv.Rows[e.RowIndex].Cells["CodigoDeBarras"].Value.ToString();
            }
        }
    }
}
