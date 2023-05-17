using CasaMendes.Classes;
using CasaMendes.Classes.Estatica;
using System;
using System.Collections;
using System.Windows.Forms;

namespace CasaMendes
{
    public partial class FrmBuscarCliente : Form
    {
        //===================================================================================================
        //bool _Fechar = false;

        public int ClienteId { get; set; }
        public string Cliente { get; set; }

        public FrmBuscarCliente()
        {
            InitializeComponent();
        }

        private void RedimencionarGrade()
        {
            try
            {
                //=============================================================================================
                gbBusca.Top = 2;

                //=============================================================================================
                clsGlobal.RedimencionarGrade(this, dgv);

                //=============================================================================================
                this.BtnCancelar.Left = (int)(this.Width - (BtnCancelar.Width + 22));
                this.BtnCancelar.Top = (int)(this.Height - (BtnCancelar.Height + 50));

                //=============================================================================================
                dgv.Columns["Codigo"].Visible = false;

                //=============================================================================================
                dgv.Columns["Nome"].Width = clsGlobal.DimencionarColuna(100, dgv.Width);

                //=============================================================================================
                gbBusca.Width = dgv.Width;
                gbBusca.Left = dgv.Left;

                //=============================================================================================
                txtBusca.Left = gbBusca.Left;
                txtBusca.Width = gbBusca.Width - 15;

                //=============================================================================================
                dgv.Height = BtnCancelar.Top - (dgv.Top + 10);

                //===================================================================================================
                dgv.Top = (gbBusca.Height + 10);

                //=============================================================================================
                this.BtnAceitar.Left = 8;//;
                this.BtnAceitar.Top = BtnCancelar.Top;

                //=============================================================================================
                dgv.Top = (gbBusca.Height + 10);
                dgv.Height = BtnCancelar.Top - (dgv.Top + 10); //this.Height - 150;

                //=============================================================================================
                gbBusca.Width = dgv.Width;
                gbBusca.Left = dgv.Left;

                //=============================================================================================
                txtBusca.Left = gbBusca.Left;
                txtBusca.Width = gbBusca.Width - 15;
            }
            catch
            {

            }
        }

        private void BtnAceitar_Click(object sender, EventArgs e)
        {
            //_Fechar = true;
            this.Close();
        }

        private void dgv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnAceitar.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                BtnCancelar.PerformClick();
            }
        }

        private void dgv_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgv.Rows.Count < 1) { return; }
                ClienteId = 0;
                Cliente = null;
                ClienteId = int.Parse(dgv.Rows[e.RowIndex].Cells[0].Value.ToString());
                Cliente = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
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
                clsGlobal.SetUpDataGridView(dgv);
                var oCliente = new Cliente();
                this.dgv.DataSource = oCliente.Todos();
                if (dgv.Rows.Count > 0)
                {
                    for (int i = 0; i < dgv.Rows.Count; i++)
                    {
                        dgv.Columns[i].Visible = false;
                    }
                    dgv.Columns["Nome"].Visible = true;
                    dgv.Columns["Nome"].Width = dgv.Width - 22;
                    this.dgv.Focus();
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
