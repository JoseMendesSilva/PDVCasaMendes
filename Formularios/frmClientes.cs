
using CasaMendes.Classes;
using CasaMendes.Classes.Estatica;
using System;
using System.Collections;
using System.Windows.Forms;

namespace CasaMendes.Formularios
{
    public partial class frmClientes : Form
    {
        bool _Fechar = false;
        //ArrayList arrCliente = null;

        public frmClientes()
        {
            InitializeComponent();
            //===================================================================================================
            //this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmClientes_Paint);
            //this.Resize += new System.EventHandler(this.FrmClientes_Resize);
            //this.btnInadimplentes.Click += new System.EventHandler(this.btnInadimplentes_Click);

            this.btnNovo.Width = 70;//;
            this.btnNovo.Height = 53;//;

            this.btnEditar.Width = 70;//;
            this.btnEditar.Height = 53;//;

            this.btnExcluir.Width = 70;//;
            this.btnExcluir.Height = 53;//;

            _Fechar = true;
            this.Text = clsGlobal.MontarTitulo("Clientes");

            Classes.Cliente.CarregarDataGridCliente(this.dgv);
            clsGlobal.SetUpDataGridView(dgv);

            //=============================================================================================
            //dgv.Columns["Status"].Visible = false;
            dgv.Columns["Codigo"].Visible = false;
            dgv.Columns["Rg"].Visible = false;
            dgv.Columns["Cpf"].Visible = false;
            dgv.Columns["InscricaoEstadual"].Visible = false;
            dgv.Columns["Cnpj"].Visible = false;
            dgv.Columns["Email"].Visible = false;
            dgv.Columns["Endereco"].Visible = false;
            dgv.Columns["Cep"].Visible = false;
            dgv.Columns["Cidade"].Visible = false;
            dgv.Columns["Bairro"].Visible = false;
            dgv.Columns["Estado"].Visible = false;
            dgv.Columns["Pais"].Visible = false;
            dgv.Columns["Site"].Visible = false;
            //=============================================================================================

            RedimencionarGrade();
            _Fechar = false;

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
                this.btnFechar.Left = (int)(this.Width - (btnFechar.Width + 22));
                this.btnFechar.Top = (int)(this.Height - (btnFechar.Height + 50));

                if (dgv.Rows.Count == 0) { btnEditar.Enabled = false; btnExcluir.Enabled = false; } else { btnEditar.Enabled = true; btnExcluir.Enabled = true; }
                //=============================================================================================
                //dgv.Columns["Status"].Visible = false;
                dgv.Columns["Codigo"].Visible = false;
                dgv.Columns["Rg"].Visible = false;
                dgv.Columns["Cpf"].Visible = false;
                dgv.Columns["InscricaoEstadual"].Visible = false;
                dgv.Columns["Cnpj"].Visible = false;
                dgv.Columns["Email"].Visible = false;
                dgv.Columns["Site"].Visible = false;

                dgv.Columns["Nome"].Width = clsGlobal.DimencionarColuna(55, dgv.Width);
                dgv.Columns["DataCadastro"].Width = clsGlobal.DimencionarColuna(15, dgv.Width);
                dgv.Columns["Telefone"].Width = clsGlobal.DimencionarColuna(15, dgv.Width);
                dgv.Columns["Celular"].Width = clsGlobal.DimencionarColuna(15, dgv.Width);
                //=============================================================================================

                gbBusca.Width = dgv.Width;
                gbBusca.Left = dgv.Left;

                //=============================================================================================
                txtBusca.Left = gbBusca.Left;
                txtBusca.Width = gbBusca.Width - 15;

                //=============================================================================================
                //=============================================================================================
                dgv.Height = btnFechar.Top - (dgv.Top + 10);

                //===================================================================================================
                dgv.Top = (gbBusca.Height + 10);


                //=============================================================================================
                this.btnNovo.Left = 8;//;
                this.btnNovo.Top = btnFechar.Top;

                //=============================================================================================
                this.btnEditar.Left = 120;//
                this.btnEditar.Top = btnFechar.Top;

                //=============================================================================================
                this.btnExcluir.Left = 241;//
                this.btnExcluir.Top = btnFechar.Top;

                //=============================================================================================
                this.btnInadimplentes.Left = 466;//;

                //=============================================================================================
                dgv.Top = (gbBusca.Height + 10);
                dgv.Height = btnFechar.Top - (dgv.Top + 10); //this.Height - 150;

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

        private void dgv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _Fechar = true;
                this.Close();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                btnFechar_Click(sender, e);
            }
        }

        private void dgv_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (_Fechar == true) { return; }

                //if (dgv.Rows.Count > 0)
                //{
                    //arrCliente = new ArrayList();
                    //arrCliente.Add(dgv.Rows[e.RowIndex].Cells[0].Value);  //[Codigo
                    //arrCliente.Add(dgv.Rows[e.RowIndex].Cells[1].Value);  //[Nome
                    //arrCliente.Add(dgv.Rows[e.RowIndex].Cells[2].Value);  //[Endereco
                    //arrCliente.Add(dgv.Rows[e.RowIndex].Cells[3].Value);  //[Cep
                    //arrCliente.Add(dgv.Rows[e.RowIndex].Cells[4].Value);  //[Cidade
                    //arrCliente.Add(dgv.Rows[e.RowIndex].Cells[5].Value);  //[Bairro
                    //arrCliente.Add(dgv.Rows[e.RowIndex].Cells[6].Value);  //[Estado
                    //arrCliente.Add(dgv.Rows[e.RowIndex].Cells[7].Value);  //[Pais
                    //arrCliente.Add(dgv.Rows[e.RowIndex].Cells[8].Value);  //[DataCadastro
                    //arrCliente.Add(dgv.Rows[e.RowIndex].Cells[9].Value);  //[Rg 
                    //arrCliente.Add(dgv.Rows[e.RowIndex].Cells[10].Value); //[Cpf
                    //arrCliente.Add(dgv.Rows[e.RowIndex].Cells[11].Value); //[InscricaoEstadual
                    //arrCliente.Add(dgv.Rows[e.RowIndex].Cells[12].Value); //[Cnpj
                    //arrCliente.Add(dgv.Rows[e.RowIndex].Cells[13].Value); //[Telefone
                    //arrCliente.Add(dgv.Rows[e.RowIndex].Cells[14].Value); //[Celular 
                    //arrCliente.Add(dgv.Rows[e.RowIndex].Cells[15].Value); //[Email 
                    //arrCliente.Add(dgv.Rows[e.RowIndex].Cells[16].Value); //[Site

                //    this.btnEditar.Enabled = true;
                //}
                //else { this.btnEditar.Enabled = false; }
            }
            catch { }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            //arrCliente = new ArrayList();
            //arrCliente.Clear();
            //arrCliente.Add(-1);
            //frmCadastrarClientes frm = new frmCadastrarClientes(arrCliente);
            //frm.ShowDialog();
            //frm.Dispose();
            //Classes.Cliente.CarregarDataGridCliente(this.dgv);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //frmCadastrarClientes frm = new frmCadastrarClientes(arrCliente);
            //frm.ShowDialog();
            //frm.Dispose();
            //Classes.Cliente.CarregarDataGridCliente(this.dgv);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                //Classes.Cliente.Excluir(arrCliente[0].ToString());
                //Classes.Cliente.CarregarDataGridCliente(this.dgv);
            }
            catch {; }
        }

    }
}
