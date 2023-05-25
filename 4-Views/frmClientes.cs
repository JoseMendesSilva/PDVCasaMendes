using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CasaMendes
{
    public partial class FrmClientes : Form
    {

        #region Variáveis

        Cliente oCliente;
        private readonly BindingSource BsCliente;
        bool editar;
        int LinhaIndex;
        private FrmCadClientes cadastrarClientes;

        #endregion

        #region propriedades

        public string StatusLabel { get; set; }

        #endregion

        #region construtor

        public FrmClientes()
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
            this.DgvClientes.Focus();
        }

        #endregion

        #region Métodos auxiliares

        private void RedimencionarGrade()
        {
            try
            {
                if (DgvClientes.Rows.Count > 0)
                {
                    for (int i = 0; i < DgvClientes.Columns.Count; i++)
                    {
                        DgvClientes.Columns[i].Visible = false;
                    }
                    DgvClientes.Columns["Nome"].Visible = true;
                    DgvClientes.RowHeadersVisible = false;
                    DgvClientes.Columns["Nome"].HeaderText = "Clientes";
                    int tamanho = DgvClientes.Width - 22;
                    DgvClientes.Columns["Nome"].Width = tamanho;
                }
            }
            catch
            {

            }
        }

        private void Carregar()
        {
            DgvClientes.DataSource = oCliente.Todos();
            StatusLabel = (DgvClientes.RowCount - 1).ToString();
        }

        private void Gravar()
        {
            //Verificando se o nome já existe.
            if (oCliente.ClienteId == 0)
            {
                var cli = new Cliente
                {
                    Nome = oCliente.Nome
                };
                List<Cliente> cliente = cli.Busca();
                if (cliente.Count > 0)
                {
                    MessageBox.Show($"Cliente {cliente[0].Nome} já existe!");
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
                oCliente = (Cliente)DgvClientes.Rows[LinhaIndex].DataBoundItem;

                cadastrarClientes = new FrmCadClientes
                {
                    oCliente = oCliente
                };

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
                    oCliente = (Cliente)DgvClientes.Rows[LinhaIndex].DataBoundItem;
                    oCliente.Excluir();
                    Carregar();
                }
            }
            catch {; }
        }

        private void Botoes(bool b)
        {
            BtnEditar.Enabled = !b;
            BtnFechar.Enabled = b;
            BtnExcluir.Enabled = !b;
            BtnNovo.Enabled = b;
        }

        #endregion

        #region KeyDown

        private void Dgv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Close();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                BtnFechar.PerformClick();
            }
        }

        #endregion

        #region Click

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Atualizar();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            Excluir();
        }

        #endregion

        #region Load

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            try
            {
                Botoes(true);
                Carregar();
                RedimencionarGrade();
            }
            catch { }
        }

        #endregion

        #region Enter

        private void Dgv_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvClientes.Rows.Count > 0)
            {
                LinhaIndex = e.RowIndex;
                editar = true;
                BtnEditar.Enabled = editar;
                BtnExcluir.Enabled = editar;
                return;
            }
            editar = false;
            BtnEditar.Enabled = editar;
        }

        #endregion

        #region TextChanged

        private void TxtBusca_TextChanged(object sender, EventArgs e)
        {
            oCliente.Nome = TxtBusca.Text;
            DgvClientes.DataSource = oCliente.Busca();
        }

        #endregion

    }
}
