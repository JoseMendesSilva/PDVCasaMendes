
using CasaMendes.Classes;
using CasaMendes.Classes.Estatica;
using System;
using System.Collections;
using System.Windows.Forms;

namespace CasaMendes.Formularios
{
    public partial class frmFornecedores : Form/*frmBuscarProduto*/
    {

        private string sTabele;//{ get; set; }
        private string sId;//{ get; set; }
        private string sFiltro = null;// { get; set; }

        private ArrayList arr = new ArrayList();
        frmCadastrarFornecedores cf;

        public frmFornecedores()
        {
            InitializeComponent();
            try
            {
                this.Text = clsGlobal.MontarTitulo("Fornecedores");
                //this.dgv.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellEnter);
                //this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
                //this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
                //this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);

                sTabele = "tFornecedores";
                sId = "CodigoDoFornecedor";

                //Classes.Estatica.//clsGlobal.Posicao(this);
                cl_Fornecedores.CarregarDataGridProdutos(this.dgv);

                RedimencionarGrade();

                //=============================================================================================
                dgv.Columns["CodigoDoFornecedor"].Visible = false;
                dgv.Columns["Endereco"].Visible = false;
                dgv.Columns["Cep"].Visible = false;
                dgv.Columns["Cidade"].Visible = false;
                dgv.Columns["Bairro"].Visible = false;
                dgv.Columns["Estado"].Visible = false;
                dgv.Columns["Cnpj"].Visible = false;
                dgv.Columns["InscricaoEstadual"].Visible = false;
                dgv.Columns["Site"].Visible = false;
                dgv.Columns["Email"].Visible = false;
                //===================================================================================================
            }
            catch {; }
        }

        private void RedimencionarGrade()
        {
            try
            {
                gbBusca.Top = 2;
                clsGlobal.RedimencionarGrade(this, dgv);

                this.Text = clsGlobal.MontarTitulo("Fornecedores");

                this.btnFechar.Left = (int)(this.Width - (btnFechar.Width + 22));
                this.btnFechar.Top = (int)(this.Height - (btnFechar.Height + 50));

                //=============================================================================================
                dgv.Columns["RazaoSocial"].Width = clsGlobal.DimencionarColuna(55, dgv.Width);
                //dgv.Columns["Cnpj"].Width = Classes.Estatica.clsGlobal.DimencionarColuna(10, dgv.Width);
                //dgv.Columns["InscricaoEstadual"].Width = Classes.Estatica.clsGlobal.DimencionarColuna(15, dgv.Width);
                dgv.Columns["DataCadastro"].Width = clsGlobal.DimencionarColuna(15, dgv.Width);
                dgv.Columns["Telefone"].Width = clsGlobal.DimencionarColuna(15, dgv.Width);
                dgv.Columns["Celular"].Width = clsGlobal.DimencionarColuna(15, dgv.Width);
                //=============================================================================================

                gbBusca.Width = dgv.Width;
                gbBusca.Left = dgv.Left;

                txtBusca.Left = gbBusca.Left;
                txtBusca.Width = gbBusca.Width - 15;

                //=============================================================================================
                dgv.Height = btnFechar.Top - (dgv.Top + 10);

                //===================================================================================================
                dgv.Top = (gbBusca.Height + 10);

                //===================================================================================================
                this.btnNovo.Left = 8;//;
                this.btnNovo.Top = btnFechar.Top;

                //=============================================================================================
                this.btnEditar.Left = 120;//
                this.btnEditar.Top = btnFechar.Top;

                //=============================================================================================
                this.btnExcluir.Left = 241;//
                this.btnExcluir.Top = btnFechar.Top;


            }
            catch
            {

            }
        }

        private void frmFornecedores_Paint(object sender, PaintEventArgs e)
        {
            //=============================================================================================
            try
            {
                //clsGlobal.Posicao(this);
            }
            catch
            {
            }//=============================================================================================
        }

        private void frmFornecedores_Move(object sender, EventArgs e)
        {
            //=============================================================================================
            try
            {
                //clsGlobal.Posicao(this);
            }
            catch
            {
            }//=============================================================================================
        }

        private void frmFornecedores_Resize(object sender, EventArgs e)
        {
            //=============================================================================================
            try
            {
                //clsGlobal.Posicao(this);
                RedimencionarGrade();
            }
            catch
            {
            }//=============================================================================================
        }

        private void dgv_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgv.Rows.Count > 0)
                {
                    btnNovo.Enabled = true;
                    arr.Clear();
                    if (this.dgv.Rows[e.RowIndex].Cells[0].Value.ToString() == "") { arr.Add(-1); } else { arr.Add(this.dgv.Rows[e.RowIndex].Cells[0].Value.ToString()); } // [CodigoDoFornecedor]
                    arr.Add(this.dgv.Rows[e.RowIndex].Cells[1].Value.ToString());   //,[RazaoSocial]
                    arr.Add(this.dgv.Rows[e.RowIndex].Cells[2].Value.ToString());   //,[Endereco]
                    arr.Add(this.dgv.Rows[e.RowIndex].Cells[3].Value.ToString());   //,[Cep]
                    arr.Add(this.dgv.Rows[e.RowIndex].Cells[4].Value.ToString());   //,[Cidade]
                    arr.Add(this.dgv.Rows[e.RowIndex].Cells[5].Value.ToString());   //,[Bairro]
                    arr.Add(this.dgv.Rows[e.RowIndex].Cells[6].Value.ToString());   //,[Estado]
                    arr.Add(this.dgv.Rows[e.RowIndex].Cells[7].Value.ToString());   //,[Cnpj]
                    arr.Add(this.dgv.Rows[e.RowIndex].Cells[8].Value.ToString());   //,[InscricaoEstadual]
                    arr.Add(this.dgv.Rows[e.RowIndex].Cells[9].Value.ToString());   //,[DataCadastro]
                    arr.Add(this.dgv.Rows[e.RowIndex].Cells[10].Value.ToString());  //,[Telefone]
                    arr.Add(this.dgv.Rows[e.RowIndex].Cells[11].Value.ToString());  //,[Celular]
                    arr.Add(this.dgv.Rows[e.RowIndex].Cells[12].Value.ToString());  //,[Site]
                    arr.Add(this.dgv.Rows[e.RowIndex].Cells[13].Value.ToString());  //,[Email]
                }
                else
                {
                    btnNovo.Enabled = false;
                    btnEditar.Enabled = false;
                }

            }
            catch {; }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                cf = new frmCadastrarFornecedores(this.arr);

                cf.Text = clsGlobal.MontarTitulo("Cadastro de Fornecedores", "Atualizar");
                cf.ShowDialog();

                cl_Fornecedores.CarregarDataGridProdutos(this.dgv);
                //=============================================================================================
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            cf = new frmCadastrarFornecedores();
            cf.Text = clsGlobal.MontarTitulo("Cadastro de fornecedores", "Cadastrar");
            cf.ShowDialog();

            cl_Fornecedores.CarregarDataGridProdutos(this.dgv);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgv.Rows.Count > 0)
                {
                    Classes.ADL.Cl_Dados.Excluir(sTabele, sId, sFiltro);
                    cl_Fornecedores.CarregarDataGridProdutos(this.dgv);
                }
            }
            catch
            {

            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
