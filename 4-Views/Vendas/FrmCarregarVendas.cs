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
                this.DgvVendas.Columns["Valor"].Visible = true;
                this.DgvVendas.Columns["created_at"].Visible = true;

                this.DgvVendas.Columns["created_at"].HeaderText = "Data cadastro";

                this.DgvVendas.Columns["Produto"].Width = clsGlobal.DimencionarColuna(40, DgvVendas.Width);
                this.DgvVendas.Columns["Quantidade"].Width = clsGlobal.DimencionarColuna(15, DgvVendas.Width);
                this.DgvVendas.Columns["Valor"].Width = clsGlobal.DimencionarColuna(14, DgvVendas.Width);
                this.DgvVendas.Columns["created_at"].Width = clsGlobal.DimencionarColuna(13, DgvVendas.Width);

                clsGlobal.AlinharElementosNoGridView(DgvVendas, 2, "left");
                clsGlobal.AlinharElementosNoGridView(DgvVendas, 3, "right");
                clsGlobal.AlinharElementosNoGridView(DgvVendas, 7, "right");
                clsGlobal.AlinharElementosNoGridView(DgvVendas, 8, "right");
            }
            catch
            {

            }
        }

        private void CarregarVendas()
        {
            try
            {
                this.DgvVendas.DataSource = null;
                this.DgvVendas.Rows.Clear();
                this.TxtVendas.Text = "0,00";

                oPreVenda.ClienteId = 0;

                  if(DgvVendas.Rows.Count > 0) DgvVendas.Rows.Clear();

                if (oPreVenda.TipoDeVenda == "TODOS")
                    DgvVendas.DataSource = oPreVenda.Todos();
                else // exemplo de busca gerada: select * from PreVendas where created_at BETWEEN FORMAT(CAST('10/10/2024 11:09:42' AS DATETIME2), N'dd-MM-yyyy') and FORMAT(CAST('10/10/2024 11:09:43' AS DATETIME2), N'dd-MM-yyyy') and tipodevenda = 'TODOS';
                    DgvVendas.DataSource = oPreVenda.BuscaSqlQuery($"select * from PreVendas where created_at BETWEEN FORMAT(CAST('{oPreVenda.created_at }' AS DATETIME2), N'dd-MM-yyyy') and FORMAT(CAST('{DateTime.Now}' AS DATETIME2), N'dd-MM-yyyy') and tipodevenda = '{oPreVenda.TipoDeVenda}';");



                if (this.DgvVendas.Rows.Count > 0)
                {
                    RedimencionarColunas();
                    decimal vendas = clsGlobal.Calcular(this.DgvVendas, 4);
                    this.TxtVendas.Text = vendas.ToString("N2");
                    StatusLabel = (DgvVendas.RowCount - 1).ToString();
                }
                else
                {
                    DgvVendas.Rows.Clear();
                    this.TxtVendas.Text = "0,00";
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
                //this.LblCliente.Text = "A VISTA";

                //CarregarVendas();
                //this.RedimencionarColunas();
                //decimal vendas = clsGlobal.Calcular(this.DgvVendas, 4);
                CbTipoDeVenda.SelectedIndex = 5;
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
                oPreVenda.created_at = this.DtpDataCadastro.Value;
                oPreVenda.TipoDeVenda = "";// LblCliente.Text;
                CarregarVendas();
            }
            catch
            {

            }
        }

        private void CbTipoDeVenda_SelectedIndexChanged(object sender, EventArgs e)
        {

            this.LblCliente.Text = CbTipoDeVenda.Text.Replace("É", "E").ToUpper();
            oPreVenda.TipoDeVenda = LblCliente.Text;
            //oPreVenda.created_at = null;// this.DtpDataCadastro.Value;
            this.CarregarVendas();
        }

    }
}

