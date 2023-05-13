
using CasaMendes.Classes.Geral;
using CasaMendes.Classes.Estatica;
using System;
using System.Windows.Forms;

namespace CasaMendes.Formularios
{
    public partial class FrmResumoDeVendasAtual : Form
    {

        string Intervalo = DateTime.Now.ToString();
        string Inicio = DateTime.Now.ToString();

        public FrmResumoDeVendasAtual()
        {
            InitializeComponent();

            //===================================================================================================
             this.Text = clsGlobal.MontarTitulo("Resumo e Vendas atual (Diário).");

            //=============================================================================================
           clsGlobal.SetUpDataGridView(dgv);

            //=============================================================================================
            gbBusca.Top = 2;

        }

        private void RedimencionarGrade()
        {
            try
            {
                //=============================================================================================

                //this.dgv.Columns[0].Visible = false;
                //this.dgv.Columns[6].Visible = false;

                this.dgv.Columns[0].Width = clsGlobal.DimencionarColuna(13, this.Width);
                this.dgv.Columns[1].Width = clsGlobal.DimencionarColuna(49, this.Width);
                this.dgv.Columns[2].Width = clsGlobal.DimencionarColuna(13, this.Width);
                this.dgv.Columns[3].Width = clsGlobal.DimencionarColuna(10, this.Width);
                this.dgv.Columns[4].Width = clsGlobal.DimencionarColuna(10, this.Width);

                clsGlobal.AlinharElementosNoGridView(dgv, 0, "left");
                clsGlobal.AlinharElementosNoGridView(dgv, 1, "left");
                clsGlobal.AlinharElementosNoGridView(dgv, 2, "center");
                clsGlobal.AlinharElementosNoGridView(dgv, 3, "right");
                clsGlobal.AlinharElementosNoGridView(dgv, 4, "right");

                //--------------------------------
                this.dgv.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
                this.dgv.Columns[4].DefaultCellStyle.Format = "000000UN";
                this.dgv.Columns[5].DefaultCellStyle.Format = "C2";

                this.dgv.Columns[6].Visible = false;
            }
            catch
            {

            }
        }
        
        private void FazerResumoDoDia(string Inicio, string Intervao)
        {
            try
            {
                Cl_PreVenda.FazerResumoDeVendas(Inicio, Intervalo);
            }
            catch { }
        }

        private void CarregarResumoDeVendas(string Inicio, string Intervao)
        {
            try
            {
                Cl_PreVenda.CarregarResumoDeVendasAtual(this.dgv, Inicio, Intervalo);


                if (this.dgv.Rows.Count > 0)
                {
                    this.RedimencionarGrade();
                    decimal vendas = clsGlobal.Calcular(this.dgv, 4);
                    this.TxtVendas.Text = vendas.ToString("C2");
                }
                else
                    this.TxtVendas.Text = "R$ 0.00";

            }
            catch { }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void FrmDashboardVendas_Load(object sender, EventArgs e)
        {
            try
            {

                clsGlobal.RedimencionarGrade(this, dgv);

                CarregarResumoDeVendas(Inicio, Intervalo);

                this.RedimencionarGrade();

                gbBusca.Width = dgv.Width;
                gbBusca.Left = dgv.Left;

                //=============================================================================================
                dgv.Top = (gbBusca.Height + 10);
                dgv.Height = btnFechar.Top - (dgv.Top + 10);

                decimal vendas = clsGlobal.Calcular(this.dgv, 4);
                
            }
            catch
            {

            }
        }

        private void McInicio_DateSelected(object sender, DateRangeEventArgs e)
        {
            Inicio = e.Start.ToShortDateString();
            CarregarResumoDeVendas(Inicio, Intervalo);

        }

        private void McIntervalo_DateChanged(object sender, DateRangeEventArgs e)
        {
            Intervalo = e.Start.ToShortDateString();
            CarregarResumoDeVendas(Inicio, Intervalo);
        }

        private void dgv_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {
                    if (this.dgv.SelectedRows.Count > 0)
                    {
                        DialogResult retorno = (MessageBox.Show("Você confirma a exclusão da venda selecionada?",Application.ProductName, MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation));
                        if (retorno.Equals(DialogResult.Yes))
                        {
                            Cl_PreVenda.ExcluirVendaRessumo(dgv.Rows[this.dgv.SelectedRows[0].Index].Cells[0].Value.ToString());
                            dgv.Rows.RemoveAt(this.dgv.SelectedRows[0].Index);
                            e.Handled = false;
                        }
                        else {
                            e.Handled = true;
                            return;
                        }
                    }
                }
            }
            catch { }
            finally
            {
                this.CarregarResumoDeVendas(Inicio, Intervalo);
            }
        }

        private void FrmResumoDeVendasAtual_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                FazerResumoDoDia(Inicio, Intervalo);
            }
            catch { }
        }

    }
}

