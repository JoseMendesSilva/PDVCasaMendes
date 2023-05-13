using CasaMendes.Classes;
using CasaMendes.Classes.Estatica;
using System;
using System.Collections;
using System.Windows.Forms;

namespace CasaMendes.Formularios
{
    public partial class FrmBuscarCliente : Form
    {
        //===================================================================================================
        bool _Fechar = false;
        ArrayList arrCliente = null;

        public FrmBuscarCliente()
        {
            InitializeComponent();

            //===================================================================================================
            //this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmClientes_Paint);

            this.BtnAceitar.Width = 70;//;
            this.BtnAceitar.Height = 53;//;

            _Fechar = true;
            this.Text = clsGlobal.MontarTitulo("Buscar cliente");

            Classes.Cliente.CarregarClienteParaAnotar(this.dgv);
            clsGlobal.SetUpDataGridView(dgv);

            //=============================================================================================
            RedimencionarGrade();
            _Fechar = false;

            //==============================================================
            this.dgv.Focus();

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
            _Fechar = true;
            this.Close();
        }

        private void dgv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnAceitar_Click(sender, null);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                BtnCancelar_Click(sender, e);
            }
        }

        private void dgv_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (_Fechar == true) { return; }
                if (this.Tag != null)
                {
                    FrmPDV.FrenteDeCaixa.CodigoDoCliente = -1;  //
                    FrmPDV.FrenteDeCaixa.Nome = null;  //
                    FrmPDV.FrenteDeCaixa.CodigoDoCliente = Convert.ToDecimal(dgv.Rows[e.RowIndex].Cells[0].Value);  //
                    FrmPDV.FrenteDeCaixa.Nome = Convert.ToString(dgv.Rows[e.RowIndex].Cells[1].Value);  //
                    this.Text = "ID: " + FrmPDV.FrenteDeCaixa.CodigoDoCliente + " - Cliente: " + FrmPDV.FrenteDeCaixa.Nome;
                }
                else
                {
                    arrCliente = new ArrayList();
                    arrCliente.Add(dgv.Rows[e.RowIndex].Cells[0].Value);  //[Codigo
                    arrCliente.Add(dgv.Rows[e.RowIndex].Cells[1].Value);  //[Nome
                }

            }
            catch { }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Tag.ToString() == "CaixaAberto")
                {
                    _Fechar = true;
                    FrmPDV.FrenteDeCaixa.CodigoDoCliente = -1;  //Codigo
                    FrmPDV.FrenteDeCaixa.Nome = null;  //Nome
                }
                this.Close();
                GC.Collect(2, GCCollectionMode.Optimized);
            }
            catch {; }
        }

    }
}
