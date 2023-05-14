using System;
using System.Windows.Forms;

namespace CasaMendes
{
    public partial class frmFornecedores : Form/*frmBuscarProduto*/
    {

        #region Variáveis

        //BindingSource BsFornecedor;
        tFornecedore oFornecedore;
        int LinhaIndex;
        public string StatusLabel;

        #endregion

        //private string sTabele;//{ get; set; }
        //private string sId;//{ get; set; }
        //private string sFiltro = null;// { get; set; }

        //private ArrayList arr = new ArrayList();
        //frmCadastrarFornecedores cf;

        public frmFornecedores()
        {
            InitializeComponent();
            oFornecedore = new tFornecedore();
            LinhaIndex = -1;
            //BsFornecedor = new BindingSource { oFornecedore };
        }

        private void RedimencionarGrade()
        {
            try
            {

            }
            catch
            {

            }
        }

        private void Editar()
        {
            try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        private void Novo()
        {

        }

        private void Gravar()
        {
            try
            {

            }
            catch
            {

            }
        }

        private void Excluir()
        {
            try
            {

            }
            catch
            {

            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmFornecedores_Load(object sender, EventArgs e)
        {
           dgv.DataSource = oFornecedore.Todos();
        }

    }
}
