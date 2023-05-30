using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CasaMendes
{
    public partial class FrmClientes : Form
    {

        #region Variáveis

        Cliente oCliente;
        private BindingSource BsCliente;
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
                FrmProcessando oProcessando = new FrmProcessando();
                oProcessando.Show();
                oProcessando.TopMost = true;
                oProcessando.Processo(1, "Lista de clientes", "Garregando.");
                this.Text = clsGlobal.MontarTitulo("Clientes");
                oProcessando.Processo(6, "Lista de clientes", "Garregando..");
                editar = false;
                oProcessando.Processo(13, "Lista de clientes", "Garregando...");
                LinhaIndex = -1;
                oProcessando.Processo(18, "Lista de clientes", "Garregando.");
                oCliente = new Cliente();
                oProcessando.Processo(27, "Lista de clientes", "Garregando..");
                BsCliente = new BindingSource { oCliente };
                oProcessando.Processo(33, "Lista de clientes", "Garregando...");
                BsCliente.DataSource = oCliente;
                oProcessando.Processo(39, "Lista de clientes", "Garregando.");
                this.Text = clsGlobal.MontarTitulo("Clientes");
                oProcessando.Processo(46, "Lista de clientes", "Garregando..");
                RedimencionarGrade();
                oProcessando.Processo(53, "Lista de clientes", "Garregando...");
                this.DgvClientes.Focus();
                oProcessando.Processo(59, "Lista de clientes", "Garregando.");
                Botoes(true);
                oProcessando.Processo(66, "Lista de clientes", "Garregando..");
                Carregar();
                oProcessando.Processo(73, "Lista de clientes", "Garregando...");
                RedimencionarGrade();
                oProcessando.Processo(80, "Lista de clientes", "Garregado.");
                oProcessando.Processo(87, "Lista de clientes", "Garregando..");
                oProcessando.Processo(100, "Lista de clientes", "Garregado...");
                oProcessando.Close();
                oProcessando.Dispose();
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
