using CasaMendes.Classes;
using CasaMendes.Classes.Geral;
using CasaMendes.Classes.Estatica;
using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace CasaMendes
{
    public partial class FrmEstoque2 : Form
    {
        //ArrayList arr = new ArrayList();
        //frmCadastrarProdutos fc;

        //static string sFiltro { get; set; }

        #region Construtor

        public string cod;
        public FrmEstoque2()
        {
            InitializeComponent();

            this.Text = clsGlobal.MontarTitulo("Estoque");

            this.dgv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv_KeyDown);

            //=============================================================================================
            try
            {
                Cl_Produto.CarregarDoEstoque(this.dgv, "");
           
            clsGlobal.SetUpDataGridView(this.dgv);

                RedimencionarGradeProdutos();
            }
            catch { }


        }

        #endregion

        private void RedimencionarGradeProdutos()
        {
            //try
            //{

            //    //=============================================================================================
            //    clsGlobal.RedimencionarGrade(this, dgv);

            //    this.btnFechar.Left = (int)(this.Width - (btnFechar.Width + 22));
            //    this.btnFechar.Top = (int)(this.Height - (btnFechar.Height + 50));

            //    //=============================================================================================
            //    dgv.Columns[0].Visible = false;//ocultar 0
            //    dgv.Columns[5].Visible = false;//ocultar 5
            //    dgv.Columns[6].Visible = false;//ocultar 6

            //    clsGlobal.AlinharElementosNoGridView(dgv, 1, "right");
            //    clsGlobal.AlinharElementosNoGridView(dgv, 2, "left");
            //    clsGlobal.AlinharElementosNoGridView(dgv, 3, "center");
            //    clsGlobal.AlinharElementosNoGridView(dgv, 4, "center");
            //    clsGlobal.AlinharElementosNoGridView(dgv, 7, "right");
            //    clsGlobal.AlinharElementosNoGridView(dgv, 8, "right");
            //    clsGlobal.AlinharElementosNoGridView(dgv, 9, "right");
            //    clsGlobal.AlinharElementosNoGridView(dgv, 10, "right");

            //    //s===================================================================================================
            //    dgv.Columns[1].DefaultCellStyle.Format = "";
            //    dgv.Columns[4].DefaultCellStyle.Format = "";
            //    dgv.Columns[7].DefaultCellStyle.Format = "R$ 0.00";
            //    dgv.Columns[8].DefaultCellStyle.Format = "";
            //    dgv.Columns[9].DefaultCellStyle.Format = "R$ 0.00";
            //    dgv.Columns[10].DefaultCellStyle.Format = "";

            //    //CodigoDeBarras    ]";//1
            //    //Produto]";        //2
            //    //DataDeValidade]";//3
            //    //Quantidade]";//4
            //    //PrecoDeVenda]";//7
            //    //Estoque]";//8
            //    //Desconto]";//9
            //    //ValorDesconto]";//10

            //    //===================================================================================================
            //    dgv.Columns[1].Width = clsGlobal.DimencionarColuna(10, dgv.Width);
            //    dgv.Columns[2].Width = clsGlobal.DimencionarColuna(35, dgv.Width);
            //    dgv.Columns[3].Width = clsGlobal.DimencionarColuna(10, dgv.Width);
            //    dgv.Columns[4].Width = clsGlobal.DimencionarColuna(9, dgv.Width);
            //    dgv.Columns[7].Width = clsGlobal.DimencionarColuna(8, dgv.Width);
            //    dgv.Columns[8].Width = clsGlobal.DimencionarColuna(9, dgv.Width);
            //    dgv.Columns[9].Width = clsGlobal.DimencionarColuna(8, dgv.Width);
            //    dgv.Columns[10].Width = clsGlobal.DimencionarColuna(10, dgv.Width);

            //    gbBusca.Width = dgv.Width;
            //    gbBusca.Left = dgv.Left;

            //    //===================================================================================================
            //    dgv.Top = (gbBusca.Height + 10);

            //    //===================================================================================================
            //    this.btnNovo.Left = 8;//;
            //    this.btnNovo.Top = btnFechar.Top;

            //    //=============================================================================================
            //    this.btnEditar.Left = 120;//
            //    this.btnEditar.Top = btnFechar.Top;

            //    //=============================================================================================
            //    this.btnExcluir.Left = 241;//
            //    this.btnExcluir.Top = btnFechar.Top;

            //    //=============================================================================================
            //    this.btnAbrirListaDeesconto.Left = 369;//
            //    this.btnAbrirListaDeesconto.Top = btnFechar.Top;

            //    this.dgv.Top = (gbBusca.Height + 10);
            //    this.dgv.Height = btnFechar.Top - (dgv.Top + 10);
            //}
            //catch
            //{
            //}

        }

        private void dgv_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Escape)
            //{
            //    sFiltro = "null";
            //    cod = "null";
            //    this.Close();
            //}
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void dgv_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //    if (dgv.Rows.Count > 0)
            //    {
            //        cod = Convert.ToString(dgv.Rows[e.RowIndex].Cells[1].Value);
            //        sFiltro = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
            //        btnEditar.Enabled = true; btnExcluir.Enabled = true;
            //        btnNovo.Enabled = true;
            //        btnEditar.Enabled = true;
            //        //BtnAtualizarLote.Visible = false;
            //        //label3.Visible = true;
            //        //TxtValor.Visible = true;
            //        arr.Clear();

            //        arr.Add(sFiltro);
            //     }
            //    else
            //    {
            //        sFiltro = "null";
            //        btnEditar.Enabled = false;
            //        btnExcluir.Enabled = false;
            //        btnNovo.Enabled = false;
            //        //BtnAtualizarLote.Visible = false;
            //        //label3.Visible = false;
            //        //TxtValor.Visible = false;
            //    }
            //}
            //catch { }
        }
        
        private void txtBusca_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    this.Close();
            //}
            //else if (e.KeyCode == Keys.Escape)
            //{
            //    sFiltro = "null";
            //    cod = "null";
            //    this.Close();
            //}
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    fc = new frmCadastrarProdutos();
            //    clsGlobal.TagForm = "editar";
            //    fc.txtCodigoDeBarras.Text = this.cod;//this.arr[1].ToString();
            //    fc.Text = clsGlobal.MontarTitulo("Cadastro de produtos", "Atualizar");

            //    fc.ShowDialog();
            //    fc.Dispose();
            //    //=============================================================================================
            //    if (txtBusca.Text != "") { Cl_Produto.CarregarDoEstoque(this.dgv, txtBusca.Text); }
            //    else if (txtCodigoDeBarras.Text != "") { Cl_Produto.CarregarDoEstoque(this.dgv, "null", txtCodigoDeBarras.Text); }
            //    else Cl_Produto.CarregarDoEstoque(this.dgv, "");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message,Application.ProductName);
            //}
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            //fc = new frmCadastrarProdutos();
            //clsGlobal.TagForm = "Novo";
            //    fc.txtCodigoDeBarras.Text = this.cod;//this.arr[1].ToString();
            //fc.Text = clsGlobal.MontarTitulo("Cadastar produto", "Cadastrar");
            //fc.ShowDialog();
            //fc.Dispose();
            ////txtCodigoDeBarras.Text = this.cod;
            ////=============================================================================================
            //if (txtBusca.Text != "") { Cl_Produto.CarregarDoEstoque(this.dgv, txtBusca.Text); }
            //else if (this.cod != "") { Cl_Produto.CarregarDoEstoque(this.dgv, "null", this.cod); }
            //else Cl_Produto.CarregarDoEstoque(this.dgv, "");

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (this.dgv.Rows.Count > 0)
            //    {
            //        Cl_Produto oProduto = new Cl_Produto();
            //        oProduto.Excluir("tEstoque", "idEstoque", sFiltro);
            //        Cl_Produto.CarregarDoEstoque(this.dgv, "*");
            //        oProduto.Dispose();
            //    }
            //}
            //catch
            //{

            //}
        }

        private void txtCodigoDeBarras_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    if (this.txtBusca.Text.Length > 0) {
            //        string s = this.txtCodigoDeBarras.Text;
            //        txtBusca.Clear();
            //        this.txtCodigoDeBarras.Text = s;
            //        txtCodigoDeBarras.SelectionStart = txtCodigoDeBarras.TextLength;
            //    }
            //    if (this.txtCodigoDeBarras.TextLength > 4) {
            //        Cl_Produto.CarregarDoEstoque(dgv, "null", txtCodigoDeBarras.Text);
            //    }
            //    else { return; }
            //}
            //catch
            //{
            //}
        }

        private void txtCodigoDeBarras_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    this.Close();
            //}
            //else if (e.KeyCode == Keys.Escape)
            //{
            //    sFiltro = "null";
            //    cod = "null";
            //    this.Close();
            //}
        }

        private void frmBuscarProduto_Shown(object sender, EventArgs e)
        {
            //try
            //{
            //    this.CbAtualizarLote.Checked = false;
            //    BtnAtualizarLote.Visible = false;
            //    label3.Visible = false;
            //    TxtValor.Visible = false;

            //    if (clsGlobal.TagForm == "frmMenu")
            //    {
            //        this.txtCodigoDeBarras.Focus();
            //        this.txtCodigoDeBarras.SelectAll();
            //    }
            //    else
            //    {
            //        this.txtBusca.Focus();
            //        this.txtBusca.SelectAll();
            //    }
            //}
            //catch
            { }
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    if (this.txtCodigoDeBarras.Text.Length > 4) {
            //        string s = this.txtBusca.Text;
            //        this.txtCodigoDeBarras.Clear();
            //        this.txtBusca.Text = s;
            //        this.txtBusca.SelectionStart = this.txtBusca.TextLength;
            //    }

            //    if (this.txtBusca.Text.Length > 0) {
            //        Cl_Produto.CarregarDoEstoque(dgv, txtBusca.Text, "null");
            //    }
            //    else { Cl_Produto.CarregarDoEstoque(dgv, "", "null"); }
            //}
            //catch
            //{

            //}
        }

        private void btnAbrirListaDeesconto_Click(object sender, EventArgs e)
        {
            //FrmPromocao fp = new FrmPromocao();
            //fp.ShowDialog();
            //fp.Dispose();
            //GC.Collect();
        }

        private void BtnAtualizarLote_Click(object sender, EventArgs e)
        {
            //try {
            //    if ((this.txtBusca.Text.Length > 0) && (this.TxtValor.Text.Length > 0) && (this.dgv.Rows.Count > 0))
            //    {
            //        Cl_Produto _Produto = new Cl_Produto();
            //        _Produto.AtualizarLote(this.txtBusca.Text, double.Parse(this.TxtValor.Text));
            //        Cl_Produto.CarregarDoEstoque(dgv, txtBusca.Text, "null");
            //    }

            //    this.CbAtualizarLote.Checked = false;
            //    this.BtnAtualizarLote.Visible = false;
            //    this.label3.Visible = false;
            //    this.TxtValor.Visible = false;

            //}
            //catch { }
        }

        private void CbAtualizarLote_CheckedChanged(object sender, EventArgs e)
        {
            //txtBusca.Focus();
            //txtBusca.SelectAll();
        }

        private void CbAtualizarLote_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if ((this.txtBusca.Text.Length > 0) && (this.dgv.Rows.Count > 0) && this.CbAtualizarLote.Checked)
            //    {
            //        BtnAtualizarLote.Visible = true;
            //        label3.Visible = true;
            //        TxtValor.Visible = true;
            //        TxtValor.Focus();
            //        TxtValor.SelectAll();
            //    }
            //    else
            //    {
            //        BtnAtualizarLote.Visible = false;
            //        label3.Visible = false;
            //        TxtValor.Visible = false;
            //    }
            //}
            //catch { }


        }

        private void FrmEstoque_Load(object sender, EventArgs e)
        {

        }
    }
}
