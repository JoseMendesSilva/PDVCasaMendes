using System;
using System.Windows.Forms;

namespace CasaMendes
{
    public partial class FrmCarregarVendas : Form
    {

        #region propriedades

        public string StatusLabel { get; set; }

        #endregion

        PreVenda oPreVenda;
        //bool TamanhoColuna;

        public FrmCarregarVendas()
        {
            InitializeComponent();
            this.Text = clsGlobal.MontarTitulo("Vendas (Diário).");
        }

        private void RedimencionarColunas()
        {
            try
            {
                
                    for (int i = 0; i < DgvVendas.ColumnCount; i++)
                    {
                        DgvVendas.Columns[i].Visible = false;
                    }

                    this.DgvVendas.Columns["Produto"].Visible = true;
                    this.DgvVendas.Columns["Quantidade"].Visible = true;
                    this.DgvVendas.Columns["PrecoDeVenda"].Visible = true;
                    this.DgvVendas.Columns["Valor"].Visible = true;
                    this.DgvVendas.Columns["created_at"].Visible = true;

                    this.DgvVendas.Columns["Produto"].Width = clsGlobal.DimencionarColuna(40, DgvVendas.Width);
                    this.DgvVendas.Columns["Quantidade"].Width = clsGlobal.DimencionarColuna(15, DgvVendas.Width);
                    this.DgvVendas.Columns["PrecoDeVenda"].Width = clsGlobal.DimencionarColuna(15, DgvVendas.Width);
                    this.DgvVendas.Columns["Valor"].Width = clsGlobal.DimencionarColuna(15, DgvVendas.Width);
                    this.DgvVendas.Columns["created_at"].Width = clsGlobal.DimencionarColuna(15, DgvVendas.Width);
                    this.DgvVendas.Columns["created_at"].HeaderText = "Data cadastro";

                    clsGlobal.AlinharElementosNoGridView(DgvVendas, 2, "left");
                    clsGlobal.AlinharElementosNoGridView(DgvVendas, 3, "right");
                    clsGlobal.AlinharElementosNoGridView(DgvVendas, 4, "right");
                    clsGlobal.AlinharElementosNoGridView(DgvVendas, 7, "right");
                    clsGlobal.AlinharElementosNoGridView(DgvVendas, 8, "right");
            }
            catch
            {

            }
        }

        private void CarregarVendas(string filtro = null)
        {
            try
            {
                DgvVendas.DataSource = null;
                DgvVendas.Rows.Clear();
                if (filtro == null)
                {
                    oPreVenda.ClienteId = 0;
                    DgvVendas.DataSource = oPreVenda.Todos();
                }
                else
                {
                    oPreVenda.created_at = null;
                    oPreVenda.ClienteId = 0;
                    oPreVenda.TipoDeVenda = filtro;
                    DgvVendas.DataSource = oPreVenda.Busca();
                }

                if (this.DgvVendas.Rows.Count > 0)
                {
                    RedimencionarColunas();
                    decimal vendas = clsGlobal.Calcular(this.DgvVendas, 4);
                    if (oPreVenda.ClienteId > 0)
                    {
                        decimal porcentagemPendura = clsGlobal.DeStringParaDecimal(DgvVendas.Rows[0].Cells["Tributos"].Value.ToString());
                        porcentagemPendura += clsGlobal.DeStringParaDecimal(DgvVendas.Rows[0].Cells["Juros"].Value.ToString());
                        porcentagemPendura = 1 - (porcentagemPendura / 100);
                        decimal totalPendura = vendas;
                        vendas = (totalPendura / porcentagemPendura) - oPreVenda.Parcela;
                    }

                    this.TxtVendas.Text = vendas.ToString("N2");
                    StatusLabel = (DgvVendas.RowCount - 1).ToString();
                }
                else
                {
                    DgvVendas.Rows.Clear();
                    this.TxtVendas.Text = "R$ 0.00";
                }
            }
            catch { }
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void FrmCarregarVendas_Load(object sender, EventArgs e)
        {
            try
            {
                //TamanhoColuna = false;
                gbBusca.Left = DgvVendas.Left;
                gbBusca.Width = DgvVendas.Width;

                clsGlobal.RedimencionarGrade(this, ref DgvVendas);
                oPreVenda = new PreVenda();

                oPreVenda.ClienteId = 0;
                this.LblCliente.Text = "A VISTA";

                CarregarVendas();
                this.RedimencionarColunas();
                decimal vendas = clsGlobal.Calcular(this.DgvVendas, 4);
            }
            catch
            {

            }
        }

        private void Dgv_KeyDown(object sender, KeyEventArgs e)
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
            LblCliente.Text = RbPendura.Text;
            CarregarVendas(RbPendura.Text);
        }

        private void RbAVista_Click(object sender, EventArgs e)
        {
            LblCliente.Text = RbAVista.Text;
            CarregarVendas(RbAVista.Text);
        }

        private void RbTodos_Click(object sender, EventArgs e)
        {
            LblCliente.Text = RbTodos.Text;
            CarregarVendas();
        }
    }
}

