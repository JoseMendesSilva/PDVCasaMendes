using CasaMendes.Classes.Estatica;
using System;
using System.Windows.Forms;

namespace CasaMendes
{
    public partial class FrmCarregarVendas : Form
    {
        PreVenda oPreVenda;
        public int ClienteId { get; set; }
        public string Cliente { get; set; }
        bool TamanhoColuna;

        public FrmCarregarVendas()
        {
            InitializeComponent();
            this.Text = clsGlobal.MontarTitulo("Resumo e Vendas atual (Diário).");
            clsGlobal.SetUpDataGridView(dgv);
        }

        private void SelecionarCliente()
        {
            FrmBuscarCliente fc = new FrmBuscarCliente();
            fc.ShowDialog();
            if (fc.DialogResult.Equals(DialogResult.OK))
            {
                this.ClienteId = fc.ClienteId;
                this.Cliente = fc.Cliente;
            }
            else
            {
                this.ClienteId = 0;
                this.Cliente = "A VISTA";
            }
            fc.Dispose();
            this.oPreVenda.ClienteId = this.ClienteId;
            this.LblCliente.Text = this.Cliente;
        }
        private void RedimencionarColunas()
        {
            try
            {
                if (TamanhoColuna == false)
                {
                    this.dgv.Columns["PreVendaId"].Visible = false;
                    this.dgv.Columns["ClienteId"].Visible = false;
                    this.dgv.Columns["updated_at"].Visible = false;
                    this.dgv.Columns["Key"].Visible = false;

                    this.dgv.Columns["Produto"].Width = clsGlobal.DimencionarColuna(43, this.Width);
                    this.dgv.Columns["Quantidade"].Width = clsGlobal.DimencionarColuna(10, this.Width);
                    this.dgv.Columns["PrecoDeVenda"].Width = clsGlobal.DimencionarColuna(13, this.Width);
                    this.dgv.Columns["NumeroDaVenda"].Width = clsGlobal.DimencionarColuna(10, this.Width);
                    this.dgv.Columns["TipoDeVenda"].Width = clsGlobal.DimencionarColuna(13, this.Width);
                    this.dgv.Columns["Valor"].Width = clsGlobal.DimencionarColuna(10, this.Width);
                    this.dgv.Columns["Dinheiro"].Width = clsGlobal.DimencionarColuna(10, this.Width);
                    this.dgv.Columns["Parcela"].Width = clsGlobal.DimencionarColuna(13, this.Width);
                    this.dgv.Columns["created_at"].Width = clsGlobal.DimencionarColuna(10, this.Width);

                    clsGlobal.AlinharElementosNoGridView(dgv, 2, "left");
                    clsGlobal.AlinharElementosNoGridView(dgv, 3, "right");
                    clsGlobal.AlinharElementosNoGridView(dgv, 4, "right");
                    clsGlobal.AlinharElementosNoGridView(dgv, 5, "center");
                    clsGlobal.AlinharElementosNoGridView(dgv, 6, "center");
                    clsGlobal.AlinharElementosNoGridView(dgv, 7, "right");
                    clsGlobal.AlinharElementosNoGridView(dgv, 8, "right");
                    clsGlobal.AlinharElementosNoGridView(dgv, 9, "right");
                    clsGlobal.AlinharElementosNoGridView(dgv, 10, "right");
                    clsGlobal.AlinharElementosNoGridView(dgv, 11, "center");
                    TamanhoColuna = true;
                }
            }
            catch
            {

            }
        }

        private void CarregarVendas()
        {
            try
            {
                dgv.DataSource = oPreVenda.Busca();

                if (this.dgv.Rows.Count > 0)
                {
                    RedimencionarColunas();
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

        private void FrmCarregarVendas_Load(object sender, EventArgs e)
        {
            try
            {
                TamanhoColuna = false;
                gbBusca.Left = dgv.Left;
                gbBusca.Width = dgv.Width;

                clsGlobal.RedimencionarGrade(this, dgv);
                oPreVenda = new PreVenda();

                this.ClienteId = 0;
                this.Cliente = "A VISTA";

                oPreVenda.ClienteId = this.ClienteId;
                this.LblCliente.Text = this.Cliente;

                CarregarVendas();
                this.RedimencionarColunas();
                decimal vendas = clsGlobal.Calcular(this.dgv, 4);
            }
            catch
            {

            }
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

        private void DtpDataCadastro_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                oPreVenda.created_at = DtpDataCadastro.Value;
                CarregarVendas();
            }
            catch
            {

            }
        }

        private void RbPendura_Click(object sender, EventArgs e)
        {
            SelecionarCliente();
            oPreVenda.TipoDeVenda = RbPendura.Text;
            LblCliente.Text = oPreVenda.TipoDeVenda;
            CarregarVendas();
        }

        private void RbAVista_Click(object sender, EventArgs e)
        {
            oPreVenda.TipoDeVenda = RbAVista.Text;
            LblCliente.Text = oPreVenda.TipoDeVenda;
            CarregarVendas();
        }

    }
}

