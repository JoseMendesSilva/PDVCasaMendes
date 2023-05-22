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
                if (Dgv.Rows.Count < 1) { return; }
                ClienteId = 0;
                Cliente = null;
                ClienteId = int.Parse(Dgv.Rows[e.RowIndex].Cells[0].Value.ToString());
                Cliente = Dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
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
                    //_Fechar = true;
                    ClienteId = 0;  //Codigo
                    Cliente = null;  //Nome
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
                this.Text = clsGlobal.MontarTitulo("Buscar cliente");
                clsGlobal.SetUpDataGridView(Dgv);
                var oCliente = new Cliente();
                this.Dgv.DataSource = oCliente.Todos();
                if (Dgv.Rows.Count > 0)
                {
                    for (int i = 0; i < Dgv.Rows.Count; i++)
                    {
                        Dgv.Columns[i].Visible = false;
                    }
                    Dgv.Columns["Nome"].Visible = true;
                    Dgv.Columns["Nome"].Width = Dgv.Width - 22;
                    this.Dgv.Focus();
                }
                else
                {
                    MessageBox.Show("Nemhum cliente cadastrado.");
                }
            }
            catch { }
        }

    }
}
