using CasaMendes.Classes.Geral;
using System;
using CasaMendes.Classes.Estatica;
using System.Windows.Forms;

namespace CasaMendes.Formularios
{
    public partial class frmCarregaCodigoDeNota : Form
    {

        bool FoiRedimencionado = false;

        public frmCarregaCodigoDeNota()
        {
            InitializeComponent();

            this.TxtBuscar.Width = this.dgv.Width;
            this.TxtBuscar.Left = this.dgv.Left;
            //this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);

            clsGlobal.RedimencionarGrade(this, dgv);

            //this.Refresh();
            //this.TxtBuscar.Text = "000000";
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.TxtBuscar.Text.Length < 6) { return; }
                Cl_Produto.CarregarProdutoPorCodigoDaNota(dgv, this.TxtBuscar.Text);

                RedimencionarGradeProdutos();
                if (this.dgv.Rows.Count > 0)
                {
                    double total = double.Parse(this.dgv.Rows[0].Cells["Total"].Value.ToString());
                    this.TxtTotal.Text = total.ToString("R$ 0.00");
                }
                    this.TxtBuscar.Focus();
                TxtBuscar.SelectAll();

            }
            catch { }

        }

        private void RedimencionarGradeProdutos()
        {
            try
            {

                this.TxtBuscar.Focus();
                TxtBuscar.SelectAll();

                //=============================================================================================
                if (this.dgv.Rows.Count > 0 && FoiRedimencionado == false)
                {
                    FoiRedimencionado = true;
                    //=============================================================================================
                    dgv.Columns["Total"].Visible = false;

                    clsGlobal.AlinharElementosNoGridView(dgv, 0, "right");
                    clsGlobal.AlinharElementosNoGridView(dgv, 2, "center");
                    clsGlobal.AlinharElementosNoGridView(dgv, 3, "left");
                    clsGlobal.AlinharElementosNoGridView(dgv, 4, "right");
                    clsGlobal.AlinharElementosNoGridView(dgv, 5, "right");

                    //s===================================================================================================
                    dgv.Columns["Total"].DefaultCellStyle.Format = "R$ 0.00";
                    dgv.Columns["V. compra"].DefaultCellStyle.Format = "R$ 0.00";
                    dgv.Columns["P. venda"].DefaultCellStyle.Format = "R$ 0.00";
                    //dgv.Columns[9].DefaultCellStyle.Format = "R$ 0.00";
                    //dgv.Columns[10].DefaultCellStyle.Format = ""; 105671

                    //===================================================================================================
                    dgv.Columns["#Linha"].Width = clsGlobal.DimencionarColuna(9, dgv.Width);
                    dgv.Columns["CodigoDeBarras"].Width = clsGlobal.DimencionarColuna(18, dgv.Width);
                    dgv.Columns["Produto"].Width = clsGlobal.DimencionarColuna(44, dgv.Width);
                    dgv.Columns["V. compra"].Width = clsGlobal.DimencionarColuna(15, dgv.Width);
                    dgv.Columns["P. venda"].Width = clsGlobal.DimencionarColuna(13, dgv.Width);

                    this.TxtBuscar.Width=this.dgv.Width;
                    this.TxtBuscar.Left=this.dgv.Left;

                }
            }
            catch
            {
            }

        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCarregaCodigoDeNota_Load(object sender, EventArgs e)
        {
            RedimencionarGradeProdutos();
        }

        private void frmCarregaCodigoDeNota_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                if(FoiRedimencionado == true && dgv.Rows.Count > 0)
                {
                    FoiRedimencionado = false;

                    RedimencionarGradeProdutos();
                }
            }catch { }
        }

    }
}
