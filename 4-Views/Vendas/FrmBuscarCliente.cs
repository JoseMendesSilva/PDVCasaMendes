using System;
using System.Windows.Forms;

namespace CasaMendes
{
    public partial class FrmBuscarCliente : Form
    {
        public int ClienteId { get; set; }
        public string Cliente { get; set; }
        bool Aceitar;
        public FrmBuscarCliente()
        {
            InitializeComponent();
        }

        private void BtnAceitar_Click(object sender, EventArgs e)
        {
            Aceitar = true;
            this.Close();
        }

        private void DgvClientes_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (Aceitar) { return; }
                ClienteId = 0;
                Cliente = null;
                if (DgvClientes.Rows.Count < 1) { return; }
                ClienteId = int.Parse(DgvClientes.Rows[e.RowIndex].Cells[0].Value.ToString());
                Cliente = DgvClientes.Rows[e.RowIndex].Cells[1].Value.ToString();
                this.Text = "ID: " + ClienteId + " - Cliente: " + Cliente;
            }
            catch { }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.Equals(DialogResult.Cancel))
                {
                    ClienteId = 0;
                    Cliente = null;
                }
                this.Close();
                GC.Collect(2, GCCollectionMode.Optimized);
            }
            catch {; }
        }

        private void FrmBuscarCliente_Load(object sender, EventArgs e)
        {
            try
            {
                FrmProcessando oProcessando = new FrmProcessando();
                oProcessando.Show();
                oProcessando.TopMost = true;
                oProcessando.Processo(3, "Lista de clientes", "Garregando.");
                this.Text = clsGlobal.MontarTitulo("Clientes");
                oProcessando.Processo(9, "Lista de clientes", "Garregando..");
                clsGlobal.RedimencionarGrade(this, ref DgvClientes);
                oProcessando.Processo(19, "Lista de clientes", "Garregando...");
                var oCliente = new Cliente();
                oProcessando.Processo(27, "Lista de clientes", "Garregando.");
                this.DgvClientes.DataSource = oCliente.Todos();
                oProcessando.Processo(36, "Lista de clientes", "Garregando..");
                if (DgvClientes.Rows.Count > 0)
                {
                    for (int i = 0; i < DgvClientes.Rows.Count; i++)
                    {
                        oProcessando.Processo(45, "Lista de clientes", "Garregando...");
                        DgvClientes.Columns[i].Visible = false;
                        oProcessando.Processo(36, "Lista de clientes", "Garregando...");
                    }
                    oProcessando.Processo(45, "Lista de clientes", "Garregando...");
                    DgvClientes.Columns["Nome"].Visible = true;
                    oProcessando.Processo(56, "Lista de clientes", "Garregando.");
                    DgvClientes.Columns["Nome"].Width = DgvClientes.Width - 22;
                    oProcessando.Processo(65, "Lista de clientes", "Garregando..");
                    txtBusca.Focus();
                    oProcessando.Processo(74, "Lista de clientes", "Garregando..");
                    txtBusca.SelectAll();
                    oProcessando.Processo(83, "Lista de clientes", "Garregando...");
                }
                else
                {
                    oProcessando.Processo(163, "Lista de clientes", "Garregando...");
                    MessageBox.Show("Nenhum cliente cadastrado.");
                }
                oProcessando.Processo(100, "Lista de clientes", "Garregado.");
                oProcessando.Close();
                oProcessando.Dispose();
                Aceitar = false;
            }
            catch { }
        }

        private void DgvClientes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnAceitar.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                BtnCancelar.PerformClick();
            }
            else return;
        }

    }
}
