
using CasaMendes.Classes;
using CasaMendes.Classes.Estatica;
using DocumentFormat.OpenXml.Bibliography;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CasaMendes
{
    public partial class frmClientes : Form
    {

        #region Variáveis

        Cliente oCliente;
        BindingSource BsCliente;
        bool editar;
        int LinhaIndex;
        private FrmCadClientes cadastrarClientes;

        #endregion

        #region propriedades

        public string StatusLabel { get; set; }

        #endregion

        #region construtor

        public frmClientes()
        {
            InitializeComponent();
            editar = false;
            LinhaIndex = -1;
            oCliente = new Cliente();
            BsCliente = new BindingSource
            {
                oCliente
            };
            BsCliente.DataSource = oCliente;
            this.Text = clsGlobal.MontarTitulo("Clientes");
            RedimencionarGrade();
            this.dgv.Focus();
        }

        #endregion

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
                    dgv.Columns["Nome"].Visible = true;
                    dgv.RowHeadersVisible = false;
                    dgv.Columns["Nome"].HeaderText = "Clientes";
                    int tamanho = dgv.Width - 22;
                    dgv.Columns["Nome"].Width = tamanho;
                }
            }
            catch
            {

            }
        }

        private void Carregar()
        {
            dgv.DataSource = oCliente.Todos();
            StatusLabel = (dgv.RowCount - 1).ToString();
        }

        private void Gravar()
        {
            //Verificando se o nome já existe.
            if (oCliente.ClienteId == 0)
            {
                var cli = new Cliente();
                cli.Nome = oCliente.Nome;
                List<Cliente> cliente = cli.Busca();
                if (cliente.Count > 0)
                {
                    MessageBox.Show("O cadastro já existe!");
                    return;
                }
            }
            oCliente.Salvar();
            Carregar();
        }

        private void Novo()
        {
            cadastrarClientes = new FrmCadClientes();
            cadastrarClientes.ShowDialog();
            this.BsCliente.DataSource = cadastrarClientes.oCliente;
            this.oCliente = cadastrarClientes.oCliente;
            cadastrarClientes.Dispose();
            if (cadastrarClientes.DialogResult.Equals(DialogResult.OK)) Gravar();

        }

        private void Atualizar()
        {
            if (editar.Equals(true) && LinhaIndex != -1)
            {
                oCliente = (Cliente)dgv.Rows[LinhaIndex].DataBoundItem;

                cadastrarClientes = new FrmCadClientes();
                cadastrarClientes.oCliente = oCliente;
                cadastrarClientes.ShowDialog();
                cadastrarClientes.Dispose();
                if (cadastrarClientes.DialogResult.Equals(DialogResult.OK)) Gravar();
            }
        }

        private void Excluir()
        {
            try
            {
                if (editar.Equals(true) && LinhaIndex != -1)
                {
                    oCliente = (Cliente)dgv.Rows[LinhaIndex].DataBoundItem;
                    oCliente.Excluir();
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

        #region KeyDown

        private void dgv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Close();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                btnFechar.PerformClick();
            }
        }

        #endregion

        #region Click

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
            Atualizar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Excluir();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            try
            {
                Botoes(true);
                Carregar();

                //BsCliente.DataSource = oCliente.Todos();
                //dgv.DataSource = BsCliente.DataSource;

                RedimencionarGrade();
            }
            catch { }
        }

        #endregion

        #region Enter

        private void dgv_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                LinhaIndex = e.RowIndex;
            }
            catch { }
        }

        private void dgv_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.Rows.Count > 0)
            {
                LinhaIndex = e.RowIndex;
                editar = true;
                btnEditar.Enabled = editar;
                btnExcluir.Enabled = editar;
                return;
            }
            editar = false;
            btnEditar.Enabled = editar;
        }

        #endregion

        #region TextChanged

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            oCliente.Nome=txtBusca.Text;
            dgv.DataSource = oCliente.Busca();
        }

        #endregion

    }
}
