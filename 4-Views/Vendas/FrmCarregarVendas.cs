using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;

namespace CasaMendes
{
    public partial class FrmCarregarVendas : Form
    {

        #region propriedades

        public string StatusLabel { get; set; }

        #endregion

        //PreVenda oPreVenda;

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

        //// ----------------------------------- paginando registros no SqlServer -----------------------------------
        //int currentPage = 1;
        //const int rowsPerPage = 100;

        bool TravarBusca = false;
        private void LoadPage()
        {
            try
            {
                if (TravarBusca)
                    return;

                TravarBusca = true;

                oPreVenda.ClienteId = 0;
                var text = "";
                text = $"{CbTipoDeVenda.Text} {StatusLabel} vendas de {DtpDataCadastroInicio.Value} até {DtpDataCadastroFim.Value}. Total bruto: {TxtVendas.Text}";// : $" vendas a {CbTipoDeVenda.Text}: {StatusLabel}, vendas do dia {DtpDataCadastroInicio.Value.ToString("dd/MM/yyyy")} ao dia {DtpDataCadastroFim.Value.ToString("dd/MM/yyyy")}. Valor total: {TxtVendas.Text}";

                using (var dados = new Dados())
                {
                    var tVenda = CbTipoDeVenda.Text.Trim();
                    //var sql = $"SELECT * FROM PreVendas WHERE created_at >= '{DtpDataCadastroInicio.Value}' ORDER BY PreVendaId DESC";
                    // //sql = $"SELECT * FROM PreVendas  WHERE created_at BETWEEN '{DtpDataCadastroInicio.Value}' and '{DtpDataCadastroFim.Value.ToString("dd-MM-yyyy 11:59:59")}' ORDER BY created_at DESC";// OFFSET (@PageNumber - 1) * @RowsPerPage ROWS FETCH NEXT @RowsPerPage ROWS ONLY".Trim();
                    //if (!string.IsNullOrEmpty(tVenda) && tVenda != "TODOS")
                    //     sql = $"SELECT * FROM PreVendas WHERE created_at >= '{DtpDataCadastroInicio.Value}' and TipoDeVenda = '{tVenda}' ORDER BY PreVendaId DESC";

                    //var result = dados.Select<PreVenda>(sql);

                    //var result = await Task.Run(() => dados.Select<PreVenda>(sql));
                    //var result = await Task.Run(() => dados.GetPaginatedDataAsync<PreVenda>(sql, pageNumber, rowsPerPage));

                    //// Código para exibir os dados na interface
                    //decimal vendas = result.Sum(x => x.Valor);
                    //this.TxtVendas.Text = vendas.ToString("N2");


                    string whereClause = "created_at >= @created_at and TipoDeVenda = @TipoDeVenda";
                    var parameters = new Dictionary<string, object>{
                { "created_at", DtpDataCadastroInicio.Value },
                { "TipoDeVenda", tVenda }
            };

                    var result = dados.SelectWithWhere<PreVenda>("PreVendas", whereClause, parameters);

                    DgvVendas.DataSource = result; if (this.DgvVendas.Rows.Count > 0)
                    {
                        RedimencionarColunas();
                    }
                }
                StatusLabel = (DgvVendas.RowCount).ToString();

                text = $"{CbTipoDeVenda.Text}: {StatusLabel} vendas de {DtpDataCadastroInicio.Value.ToString("dd/MM/yyyy")} até {DtpDataCadastroFim.Value.ToString("dd/MM/yyyy")}. Total bruto: {TxtVendas.Text}";// : $" vendas a {CbTipoDeVenda.Text}: {StatusLabel}, vendas do dia {DtpDataCadastroInicio.Value.ToString("dd/MM/yyyy")} ao dia {DtpDataCadastroFim.Value.ToString("dd/MM/yyyy")}. Valor total: {TxtVendas.Text}";
                this.LblCliente.Text = text.ToUpper();
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
            finally
            {
                TravarBusca = false;
            }
        }

        private void NextPage_Click(object sender, EventArgs e)
        {
            //currentPage++;
            //LoadPage(currentPage);
        }

        private void PreviousPage_Click(object sender, EventArgs e)
        {
            //if (currentPage > 1)
            //{
            //    currentPage--;
            //    LoadPage(currentPage);
            //}
        }

        //private async Task CarregarVendasAsync()
        //{
        //    try
        //    {
        //        this.DgvVendas.DataSource = null;
        //        this.TxtVendas.Text = "0,00";
        //        oPreVenda.ClienteId = 0; var text = "";
        //        text = $"{CbTipoDeVenda.Text}: {StatusLabel} vendas de {DtpDataCadastroInicio.Value.ToString("dd/MM/yyyy")} até {DtpDataCadastroFim.Value.ToString("dd/MM/yyyy")}. Total bruto: {TxtVendas.Text}";// : $" vendas a {CbTipoDeVenda.Text}: {StatusLabel}, vendas do dia {DtpDataCadastroInicio.Value.ToString("dd/MM/yyyy")} ao dia {DtpDataCadastroFim.Value.ToString("dd/MM/yyyy")}. Valor total: {TxtVendas.Text}";


        //        using (var dados = new Dados())
        //        {
        //            var sql = $"SELECT * FROM PreVendas WHERE (created_at BETWEEN '{DtpDataCadastroInicio.Value.ToString("dd-MM-yyyy 00:00:00")}' and '{DtpDataCadastroFim.Value.ToString("dd-MM-yyyy 11:59:59")}') and TipoDeVenda = '{this.CbTipoDeVenda.Text}';";
        //            if (oPreVenda.TipoDeVenda == "TODOS")
        //                sql = $"SELECT * FROM PreVendas WHERE (created_at BETWEEN '{DtpDataCadastroInicio.Value.ToString("dd-MM-yyyy 00:00:00")}' and '{DtpDataCadastroFim.Value.ToString("dd-MM-yyyy 11:59:59")}'";
        //            //DgvVendas.DataSource = dados.Select<PreVenda>(sql);
        //            //var result = await dados.Select<PreVenda>(sql);

        //            var result = await Task.Run(() => dados.Select<PreVenda>(sql));

        //            DgvVendas.DataSource = result;
        //            decimal vendas = result.Sum(x => x.Valor);
        //            this.TxtVendas.Text = vendas.ToString("N2");
        //        }

        //        if (this.DgvVendas.Rows.Count > 0)
        //        {
        //            RedimencionarColunas();
        //            //decimal vendas = clsGlobal.Calcular(this.DgvVendas, 4);
        //        }
        //        //else
        //        //{
        //        //    //StatusLabel = "";
        //        //    //DgvVendas.DataSource = null;
        //        //    //this.TxtVendas.Text = "0,00";
        //        //}
        //        ////this.TxtVendas.Text = vendas.ToString("N2");
        //        StatusLabel = (DgvVendas.RowCount).ToString();

        //        text = $"{CbTipoDeVenda.Text}: {StatusLabel} vendas de {DtpDataCadastroInicio.Value.ToString("dd/MM/yyyy")} até {DtpDataCadastroFim.Value.ToString("dd/MM/yyyy")}. Total bruto: {TxtVendas.Text}";// : $" vendas a {CbTipoDeVenda.Text}: {StatusLabel}, vendas do dia {DtpDataCadastroInicio.Value.ToString("dd/MM/yyyy")} ao dia {DtpDataCadastroFim.Value.ToString("dd/MM/yyyy")}. Valor total: {TxtVendas.Text}";
        //        this.LblCliente.Text = text.ToUpper();
        //    }
        //    catch { }
        //}

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void FrmCarregarVendas_Load(object sender, EventArgs e)
        {
            try
            {
                gbBusca.Left = DgvVendas.Left;
                gbBusca.Width = DgvVendas.Width;

                clsGlobal.RedimencionarGrade(this, ref DgvVendas);
                oPreVenda = new PreVenda();// { ClienteId = 0 };
                                           // Configurar o DateTimePicker para o primeiro dia do mês atual
                DtpDataCadastroInicio.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                DtpDataCadastroFim.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 30);
                LoadPage();
                this.Refresh();
            }
            catch { }
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

        private void DtpDataCadastroInicio_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                // oPreVenda.created_at = this.DtpDataCadastroInicio.Value;
                // oPreVenda.TipoDeVenda = "";
                // // Execução em segundo plano
                //await CarregarVendasAsync();
                LoadPage();
                //await CarregarVendas();
            }
            catch
            {

            }
        }

        private void CbTipoDeVenda_SelectedIndexChanged(object sender, EventArgs e)
        {
            //oPreVenda.TipoDeVenda = CbTipoDeVenda.Text.Replace("É", "E").ToUpper();
            //await this.CarregarVendasAsync();
            LoadPage();
        }

        private void FrmCarregarVendas_Shown(object sender, EventArgs e)
        {
            try
            {
                CbTipoDeVenda.SelectedIndex = 1;
            }
            catch { }
        }

    }
}

