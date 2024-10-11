using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CasaMendes
{
    public partial class FrmReceberPendura : Form
    {

        #region Variáveis.

        private int _Codigo { get; set; } = 0;
        private string _Cliente { get; set; }
        private bool Arrumado { get; set; }
        private bool dgvClientesRowEnter { get; set; }
        private int Linha { get; set; }

        #endregion

        #region Construtor.

        public FrmReceberPendura()
        {
            InitializeComponent();
        }

        #endregion

        #region Métodos.

        private void RedimencionarColunas()
        {
            try
            {
                for (int i = 0; i < DgvVendas.ColumnCount; i++)
                {
                    this.DgvVendas.Columns[i].Visible = false;
                }
                this.DgvVendas.Columns["Produto"].Visible = true;
                this.DgvVendas.Columns["Quantidade"].Visible = true;
                this.DgvVendas.Columns["PrecoDeVenda"].Visible = true;
                //this.DgvVendas.Columns["Parcela"].Visible = true;
                this.DgvVendas.Columns["Valor"].Visible = true;
                this.DgvVendas.Columns["created_at"].Visible = true;

                this.DgvVendas.Columns["Produto"].Width = clsGlobal.DimencionarColuna(30, DgvVendas.Width);
                this.DgvVendas.Columns["Quantidade"].Width = clsGlobal.DimencionarColuna(12, DgvVendas.Width);
                this.DgvVendas.Columns["PrecoDeVenda"].Width = clsGlobal.DimencionarColuna(12, DgvVendas.Width);
                //this.DgvVendas.Columns["Parcela"].Width = clsGlobal.DimencionarColuna(8, DgvVendas.Width);
                this.DgvVendas.Columns["Valor"].Width = clsGlobal.DimencionarColuna(15, DgvVendas.Width);
                this.DgvVendas.Columns["created_at"].Width = clsGlobal.DimencionarColuna(16, DgvVendas.Width);

                clsGlobal.AlinharElementosNoGridView(DgvVendas, 2, "left");
                clsGlobal.AlinharElementosNoGridView(DgvVendas, 3, "center");
                clsGlobal.AlinharElementosNoGridView(DgvVendas, 4, "center");
                clsGlobal.AlinharElementosNoGridView(DgvVendas, 5, "center");
                clsGlobal.AlinharElementosNoGridView(DgvVendas, 6, "center");
            }
            catch
            {

            }
        }

        private void BuscarAnotado()
        {
            try
            {
                using (var oPreV = new PreVenda())
                {
                    oPreV.ClienteId = this._Codigo;
                    oPreV.TipoDeVenda = "PENDURA";
                    if (DgvVendas.Rows.Count > 0) DgvVendas.DataSource = null;
                    DgvVendas.DataSource = oPreV.Busca();

                    Arrumado = false;
                    RedimencionarColunas();
                    Arrumado = true;



                    decimal valor = clsGlobal.Calcular(DgvVendas, 7);
                    this.txtTotalGeral.Text = valor.ToString("N2");

                    oPreV.Parcela = clsGlobal.DeStringParaDecimal(DgvVendas.Rows[0].Cells["Parcela"].Value.ToString());
                    this.txtParcela.Text = oPreV.Parcela.ToString("N2");

                    if (oPreV.Parcela != 0)
                    {
                        this.txtTotalReceber.Text = (valor - oPreV.Parcela).ToString("N2");
                    }
                    else
                    {
                        this.txtTotalReceber.Text = this.txtTotalGeral.Text;
                    }
                }
            }
            catch
            {
            }
        }

        #endregion

        #region eventos.

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGravarParcela_Click(object sender, EventArgs e)
        {
            if (txtParcela.Text != "0.00")
            {
                var oPreV = new PreVenda();
                
                this.txtParcela.Text = (clsGlobal.DeStringParaDecimal(this.txtParcela.Text) + clsGlobal.DeStringParaDecimal(this.txtDinheiro.Text)).ToString("N2");

                    //oPreV = (PreVenda)this.DgvVendas.Rows[0].DataBoundItem;
                    string sql = $"UPDATE PreVendas SET Parcela = '{txtParcela.Text.Replace(",", ".")}'";
                    oPreV.SalvarSql(sql); 
                BuscarAnotado();
            }
                txtDinheiro.Text = "0.00";
                this.txtDinheiro.Focus();
                this.txtDinheiro.SelectAll();
        }

        private void BtnReceber_Click(object sender, EventArgs e)
        {
            if (this.DgvVendas.Rows.Count > 0)
            {
                int ClienteId = clsGlobal.DeStringParaInt(this.DgvVendas.Rows[0].Cells["ClienteId"].Value.ToString());
                string TipoDeVenda = this.DgvVendas.Rows[0].Cells["TipoDeVenda"].Value.ToString();
                var fntCaixa = new FrmFrenteDeCaixa();
                this.Close();
                this.Dispose();
                fntCaixa.Show();
                fntCaixa.CarregarPendura(ClienteId, TipoDeVenda);
                fntCaixa.Visible = true;
            }
        }

        private void TxtDinheiro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (DgvVendas.Rows.Count > 0)
                {
                    decimal _dinheiro = Convert.ToDecimal(this.txtDinheiro.Text);
                    decimal _TotalReceber = Convert.ToDecimal(this.txtTotalReceber.Text);

                    if (_dinheiro < _TotalReceber)
                    {
                        this.btnGravarParcela.Enabled = true;
                        this.txtDinheiro.Focus();
                    }
                    else
                    {
                        this.btnGravarParcela.Enabled = false;
                    }
                }
                else { this.txtTotalReceber.Text = "0.00"; this.txtTotalGeral.Text = "0.00"; }
            }
            catch { }

        }

        private void TxtDinheiro_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                decimal dinheiro = clsGlobal.DeStringParaDecimal(txtDinheiro.Text);
                decimal totalReceber = clsGlobal.DeStringParaDecimal(txtTotalReceber.Text);
                if (e.KeyCode == Keys.Enter)
                {
                    if (dinheiro > 0 && dinheiro < totalReceber)
                    {
                        btnGravarParcela.Enabled = true;
                    }
                }
            }
            catch { }
        }

        private void DgvClientes_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this._Codigo = clsGlobal.DeStringParaInt(dgvClientes.Rows[e.RowIndex].Cells[0].Value.ToString());
                this._Cliente = dgvClientes.Rows[e.RowIndex].Cells[1].Value.ToString();
                BuscarAnotado();
            }
            catch { }
        }

        private void frmCarregarVenda_Load(object sender, EventArgs e)
        {
            this.Text = clsGlobal.MontarTitulo("Casa Mendes", "Vendas em aberto");
            try
            {
                //var oCliente =
                    dgvClientes.DataSource = new Cliente().Todos();
                //dgvClientes.DataSource = oCliente.Todos();

                if (!dgvClientesRowEnter)
                {
                    dgvClientesRowEnter = true;

                    for (int i = 0; i < dgvClientes.ColumnCount; i++)
                    {
                        this.dgvClientes.Columns[i].Visible = false;
                    }
                    this.dgvClientes.Columns["Nome"].Visible = true;
                }

                RedimencionarColunas();

                this.txtDinheiro.Text = "0,00";
                this.txtTotalGeral.Text = "0,00";

                this.txtParcela.Text = "0,00";
                this.txtParcela.ReadOnly = true;

                this.txtTotalReceber.Text = "0,00";

                this.btnGravarParcela.Enabled = false;
                this.btnReceber.Enabled = false;

                this.txtDinheiro.Focus();
                this.txtDinheiro.SelectAll();
                Arrumado = false;
            }
            catch
            {
            }
        }

        private void DgvVendas_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.btnReceber.Enabled = false;
                if (DgvVendas.Rows.Count > 0)
                {
                    Linha = e.RowIndex;
                    btnReceber.Enabled = true;
                }
            }
            catch { }
        }

        private void DgvVendas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && Linha>-1)
            {
                string mensagem = $"Você deseja excluir á venda {DgvVendas.Rows[Linha].Cells["Produto"].Value}";
                DialogResult result = MessageBox.Show(mensagem, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    using (var preVenda = new PreVenda())
                    {
                        int quantidade = clsGlobal.DeStringParaInt(DgvVendas.Rows[Linha].Cells["Quantidade"].Value.ToString());
                        preVenda.PreVendaId = clsGlobal.DeStringParaInt(DgvVendas.Rows[Linha].Cells["PreVendaId"].Value.ToString());
                        preVenda.Produto = DgvVendas.Rows[Linha].Cells["Produto"].Value.ToString();
                        preVenda.Excluir();
                        var oEstq = new Estoque();
                        string sql = $"UPDATE Estoques SET Quantidade = (Quantidade + '{quantidade}') WHERE Produto = '{preVenda.Produto}'";
                        oEstq.SalvarSql(sql);
                        BuscarAnotado();
                    }
                }
            }
        }

        #endregion

    }
}
