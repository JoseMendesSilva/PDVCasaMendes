using System;
using System.Windows.Forms;

namespace CasaMendes
{
    public partial class FrmBuscarCliente : Form
    {
        public int ClienteId { get; set; }
        public string Cliente { get; set; }

        public FrmBuscarCliente()
        {
            InitializeComponent();
        }

        private void BtnAceitar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dgv_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DgvClientes.Rows.Count < 1) { return; }
                ClienteId = 0;
                Cliente = null;
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
                this.Text = clsGlobal.MontarTitulo("Clientes");
                clsGlobal.RedimencionarGrade(this, ref DgvClientes);
                var oCliente = new Cliente();
                this.DgvClientes.DataSource = oCliente.Todos();
                if (DgvClientes.Rows.Count > 0)
                {
                    for (int i = 0; i < DgvClientes.Rows.Count; i++)
                    {
                        DgvClientes.Columns[i].Visible = false;
                    }
                    DgvClientes.Columns["Nome"].Visible = true;
                    DgvClientes.Columns["Nome"].Width = DgvClientes.Width - 22;
                    this.DgvClientes.Focus();
                }
                else
                {
                    MessageBox.Show("Nenhum cliente cadastrado.");
                }
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
