using CasaMendes.Classes;
using CasaMendes.Formularios;
using DocumentFormat.OpenXml.Bibliography;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CasaMendes
{
    public partial class frmFornecedores : Form/*frmBuscarProduto*/
    {

        #region Variáveis

        //BindingSource BsFornecedor;
        //tFornecedore oFornecedor;
        int LinhaIndex;
        bool editar;
        public string StatusLabel;
        frmCadastrarFornecedores cadFornecedor;

        #endregion

        public frmFornecedores()
        {
            InitializeComponent();
            LinhaIndex = -1;
            editar = false;
        }

        #region Métodos auxiliares

        private void RedimencionarGrade()
        {
            try
            {
                if (dgv.Rows.Count > 0)
                {
                    for (int i = 0; i < dgv.Columns.Count; i++)
                    {
                        dgv.Columns[i].Visible = false;
                    }

                    dgv.RowHeadersVisible = false;
                    dgv.Columns["RazaoSocial"].Visible = true;
                    int t = dgv.Width - 22;
                    dgv.Columns["RazaoSocial"].Width = t;
                    dgv.Columns["RazaoSocial"].HeaderText = "Fornecedores";
                }
            }
            catch
            {

            }
        }

        private void Carregar()
        {
            using (tFornecedore oFornecedor = new tFornecedore())
            {
                dgv.DataSource = oFornecedor.Todos();
                StatusLabel = (dgv.RowCount - 1).ToString();
            }
        }

        private void Gravar()
        {
            //Verificando se o nome já existe.
            if (cadFornecedor.oFornecedor.CodigoDoFornecedor == "0")
            {
                var forn = new tFornecedore();
                forn.RazaoSocial = cadFornecedor.oFornecedor.RazaoSocial;
                List<tFornecedore> fornecedor = forn.Busca();
                if (fornecedor.Count > 0)
                {
                    MessageBox.Show("O cadastro já existe!");
                    return;
                }
            }
            cadFornecedor.oFornecedor.Salvar();
            Carregar();
        }

        private void Novo()
        {
            cadFornecedor = new frmCadastrarClientes();
            cadFornecedor.ShowDialog();
            if (cadFornecedor.DialogResult.Equals(DialogResult.OK)) Gravar();
            cadFornecedor.Dispose();
        }

        private void Editar()
        {
            if (editar.Equals(true) && LinhaIndex != -1)
            {
                cadFornecedor = new frmCadastrarFornecedores();
                cadFornecedor.oFornecedor = (tFornecedore)dgv.Rows[LinhaIndex].DataBoundItem;
                cadFornecedor.ShowDialog();
                if (cadFornecedor.DialogResult.Equals(DialogResult.OK)) Gravar();
                cadFornecedor.Dispose();
            }
        }

        private void Excluir()
        {
            try
            {
                if (editar.Equals(true) && LinhaIndex != -1)
                {
                    var oFornecedor = new tFornecedore();
                    oFornecedor = (tFornecedore)dgv.Rows[LinhaIndex].DataBoundItem;
                    oFornecedor.Excluir();
                    oFornecedor.Dispose();
                    Carregar();
                }
            }
            catch {; }
        }

        private void Botoes(bool b)
        {
            btnEditar.Enabled = !b;
            btnFechar.Enabled = b;
            btnExcluir.Enabled = !b;
            btnNovo.Enabled = b;
        }

        #endregion

        private void frmFornecedores_Load(object sender, EventArgs e)
        {
            using (tFornecedore oFornecedor = new tFornecedore())
            {
                dgv.DataSource = oFornecedor.Todos();
                StatusLabel = (dgv.RowCount - 1).ToString();

                RedimencionarGrade();
                //Botoes(true);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Excluir();
        }

        private void dgv_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(dgv.Rows.Count > 0)
            {
                editar=true; 
                LinhaIndex=e.RowIndex;
            }
        }
    }
}
