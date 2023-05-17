
using CasaMendes.Classes.Geral;
using CasaMendes.Classes.Estatica;
using System;
using System.Windows.Forms;
using CasaMendes.Propriedades;

namespace CasaMendes
{
    public partial class FrmResumoDeVendasAtual : Form
    {

        string Intervalo = DateTime.Now.ToString();
        string Inicio = DateTime.Now.ToString();
        PreVenda oPreVenda;

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

                this.dgv.Columns["PreVendaId"].Visible = false;
                this.dgv.Columns["ClienteId"].Visible = false;
                //this.dgv.Columns["Produto"].Visible = false;
                //this.dgv.Columns["Quantidade"].Visible = false;
                //this.dgv.Columns["PrecoDeVenda"].Visible = false;
                //this.dgv.Columns["NumeroDaVenda"].Visible = false;
                //this.dgv.Columns["TipoDeVenda"].Visible = false;
                //this.dgv.Columns["Valor"].Visible = false;
                //this.dgv.Columns["Dinheiro"].Visible = false;
                //this.dgv.Columns["Parcela"].Visible = false;
                //this.dgv.Columns["created_at"].Visible = false;
                this.dgv.Columns["Key"].Visible = false;
                this.dgv.Columns["updated_at"].Visible = false;

                //this.dgv.Columns[0].Width = clsGlobal.DimencionarColuna(13, this.Width);
                //this.dgv.Columns[1].Width = clsGlobal.DimencionarColuna(49, this.Width);
                //this.dgv.Columns[2].Width = clsGlobal.DimencionarColuna(13, this.Width);
                //this.dgv.Columns[3].Width = clsGlobal.DimencionarColuna(10, this.Width);
                //this.dgv.Columns[4].Width = clsGlobal.DimencionarColuna(10, this.Width);

                this.dgv.Columns["Produto"].Width = clsGlobal.DimencionarColuna(55, this.Width);
                this.dgv.Columns["Quantidade"].Width = clsGlobal.DimencionarColuna(15, this.Width);
                this.dgv.Columns["PrecoDeVenda"].Width = clsGlobal.DimencionarColuna(15, this.Width);
                this.dgv.Columns["NumeroDaVenda"].Width = clsGlobal.DimencionarColuna(20, this.Width);
                this.dgv.Columns["TipoDeVenda"].Width = clsGlobal.DimencionarColuna(15, this.Width);
                this.dgv.Columns["Valor"].Width = clsGlobal.DimencionarColuna(20, this.Width);
                this.dgv.Columns["Dinheiro"].Width = clsGlobal.DimencionarColuna(20, this.Width);
                this.dgv.Columns["Parcela"].Width = clsGlobal.DimencionarColuna(15, this.Width);
                this.dgv.Columns["created_at"].Width = clsGlobal.DimencionarColuna(20, this.Width);
                //this.dgv.Columns["updated_at"].Width = clsGlobal.DimencionarColuna(15, this.Width);

                clsGlobal.AlinharElementosNoGridView(dgv, 2, "left");
                clsGlobal.AlinharElementosNoGridView(dgv, 3, "right");
                clsGlobal.AlinharElementosNoGridView(dgv, 4, "right");
                clsGlobal.AlinharElementosNoGridView(dgv, 5, "right");
                clsGlobal.AlinharElementosNoGridView(dgv, 6, "right");
                clsGlobal.AlinharElementosNoGridView(dgv, 7, "right");
                clsGlobal.AlinharElementosNoGridView(dgv, 8, "right");
                clsGlobal.AlinharElementosNoGridView(dgv, 9, "right");
                clsGlobal.AlinharElementosNoGridView(dgv, 10, "right");
                clsGlobal.AlinharElementosNoGridView(dgv, 11, "right");
                //clsGlobal.AlinharElementosNoGridView(dgv, 12, "right");

                // PreVendaId
                // ClienteId
                // Produto
                // Quantidade
                // PrecoDeVenda
                // NumeroDaVenda
                // TipoDeVenda // pendura, pg, debito, crédito e pix.
                // Valor
                // Dinheiro
                // Troco
                // Parcela

                //--------------------------------
                //this.dgv.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
                //this.dgv.Columns[4].DefaultCellStyle.Format = "000000UN";
                //this.dgv.Columns[5].DefaultCellStyle.Format = "C2";

                // PreVendaId
                // ClienteId
                // Produto
                // Quantidade
                // PrecoDeVenda
                // NumeroDaVenda
                // TipoDeVenda // pendura, pg, debito, crédito e pix.
                // Valor
                // Dinheiro
                // Troco
                // Parcela
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
               //PreVenda oPreVenda = new PreVenda();

                dgv.DataSource = oPreVenda.Busca();
                //dgv.DataSource = oPreVenda.Todos();
 

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

                oPreVenda = new PreVenda();
                CarregarResumoDeVendas(Inicio, Intervalo);

                this.RedimencionarGrade();

                //gbBusca.Width = dgv.Width;
                //gbBusca.Left = dgv.Left;

                ////=============================================================================================
                //dgv.Top = (gbBusca.Height + 10);
                //dgv.Height = btnFechar.Top - (dgv.Top + 10);

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
            //try
            //{
            //    if (e.KeyCode == Keys.Delete)
            //    {
            //        if (this.dgv.SelectedRows.Count > 0)
            //        {
            //            DialogResult retorno = (MessageBox.Show("Você confirma a exclusão da venda selecionada?",Application.ProductName, MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation));
            //            if (retorno.Equals(DialogResult.Yes))
            //            {
            //                //oPreVenda.Excluir(dgv.Rows[this.dgv.SelectedRows[0].Index].Cells[0].Value.ToString());
            //                //dgv.Rows.RemoveAt(this.dgv.SelectedRows[0].Index);
            //                //e.Handled = false;
            //            }
            //            else {
            //                e.Handled = true;
            //                return;
            //            }
            //        }
            //    }
            //}
            //catch { }
            //finally
            //{
            //    this.CarregarResumoDeVendas(Inicio, Intervalo);
            //}
        }

        private void FrmResumoDeVendasAtual_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                FazerResumoDoDia(Inicio, Intervalo);
            }
            catch { }
        }

        private void DtpDataCadastro_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                oPreVenda.created_at = DtpDataCadastro.Value;
                CarregarResumoDeVendas("","");
            }catch
            { 
                
            }
        }
    }
}

