
using CasaMendes.Classes.Estatica;
using System;
using System.Windows.Forms;
using CasaMendes.Classes.Geral;

namespace CasaMendes
{
    public partial class frmCarregarVenda : Form
    {

        #region Variáveis.

        private decimal _Codigo = 0;
        private string _Cliente = "Casa Mendes";
        private bool Arrumado = false;
        private decimal valor_tacha;
        private bool dgvClientesRowEnter;

        #endregion

        public frmCarregarVenda()
        {
            InitializeComponent();
            this.Rbt_Fixa.CheckedChanged += new System.EventHandler(this.Rbt_Fixa_CheckedChanged);
            this.dgvVendas.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVendas_RowEnter);
            this.dgvVendas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvVendas_KeyDown);
            this.Rbt_Diaria.CheckedChanged += new System.EventHandler(this.Rbt_Diaria_CheckedChanged);

            this.Text = clsGlobal.MontarTitulo("Tela principal", "Vendas em aberto");

            try
            {
                clsGlobal.SetUpDataGridView(this.dgvVendas);
                clsGlobal.SetUpDataGridView(this.dgvClientes);

                Cl_PreVenda.CarregarGradeClente(this.dgvClientes);

                //=============================================================================================
                int Espaco = (this.dgvVendas.Width + 6);

                ////=============================================================================================
                dgvVendas.Top = gb.Top + gb.Height + 10;
                int altura = dgvClientes.Height;

                //=============================================================================================
                dgvVendas.Left = dgvClientes.Width + 20;
                dgvVendas.Width = Espaco - 6;
                dgvVendas.Height = altura - (dgvVendas.Top - 12);

                this.btnFechar.Left = this.gbDadosDaConta.Width - (this.btnFechar.Width + 5);

                //=============================================================================================
                this.txtDinheiro.Text = "R$ 0,00";
                this.txtTotalGeral.Text = "R$ 0,00";

                this.txtParcela.Text = "R$ 0,00";
                this.txtParcela.ReadOnly = true;

                this.txtTotalReceber.Text = "R$ 0,00";
                this.txtTroco.Text = "R$ 0,00";

                this.lblResumoDaConta.Text = Status();
                this.btnReceber.Enabled = false;
                this.btnGravarParcela.Enabled = false;

                this.txtDinheiro.Focus();
                this.txtDinheiro.SelectAll();
            }
            catch
            {
            }
        }

        private string Status()
        {
            string sts;
            sts = "ID     : " + _Codigo.ToString() + Environment.NewLine;
            sts += "Cliente: " + _Cliente + ", Estatus: Aberto" + Environment.NewLine;
            sts += "Valor Liquido: " + this.lblLiquido.Text + ", Juros: " + (valor_tacha * 100).ToString() + "%" + Environment.NewLine;
            sts += "Total geral: " + this.txtTotalGeral.Text + ", Parcela: " + Cl_PreVenda._Parcela.ToString("C2") + ", Valor a receber: " + this.txtTotalReceber.Text;// + Environment.NewLine;

            this.dgvClientes.Columns[0].Visible = false;

            return sts;
        }

        private void BuscarAnotado()
        {
            try
            {

                Cl_PreVenda.CarregarGradeAnotado(this.dgvVendas, _Codigo.ToString());

                if (dgvVendas.Rows.Count > 0)
                {

                    decimal valor = 0;
                    decimal valor1 = clsGlobal.Calcular(dgvVendas, 7);
                    decimal valor2 = 0;
                    int dias = 0;
                    string sPorcentagem = "";
                    decimal dPercent = 0;

                    ClsPromocao Opromocao = new ClsPromocao();

                    Opromocao.LeituraXML();

                    //le o códido de barras na grade cupom
                    string codigoDeBarras = "tachaX";

                    valor_tacha = Opromocao.De_String_Para_decimal(Opromocao.Dicionario_de_Promocao[codigoDeBarras.ToString()].ValorDesconto.ToString());

                    lblLiquido.Text = valor1.ToString("C");

                    DateTime _Minimo = DateTime.Parse(dgvVendas.Rows[0].Cells[1].Value.ToString());
                    DateTime _Maximo = DateTime.Parse(dgvVendas.Rows[dgvVendas.Rows.Count - 1].Cells[1].Value.ToString());
                    TimeSpan tSpan = _Maximo - _Minimo;

                    //le a quantidade de itens vendidos na grade cupom

                    if ((tSpan.ToString() == "00:00:00") || (Rbt_Fixa.Checked == true))
                    {
                        valor += valor1 * (1 + valor_tacha);
                    }
                    else
                    {
                        dias = int.Parse(tSpan.ToString().Replace(".00:00:00", "")) + 1;

                        sPorcentagem = (valor_tacha / 30).ToString();
                        dPercent = decimal.Parse(sPorcentagem);

                        dPercent = (dPercent / 100);
                        for (int i = 0; i <= dias; i++)
                        {
                            valor2 = (valor1 * dPercent);
                            valor += valor2;
                        }
                        valor += valor1;
                    }

                    this.txtTotalGeral.Text = valor.ToString("C2");

                    this.txtParcela.Text = Cl_PreVenda._Parcela.ToString("C2");

                    if (this.txtParcela.Text != "R$ 0,00")
                    {
                        this.txtTotalReceber.Text = (Convert.ToDecimal(this.txtTotalGeral.Text.Replace("R$ ", "")) - Convert.ToDecimal(this.txtParcela.Text.Replace("R$ ", ""))).ToString("C2");
                    }
                    else
                    {
                        this.txtTotalReceber.Text = this.txtTotalGeral.Text;
                    }


                }
                else
                {
                    this.txtTotalReceber.Text = "R$ 0.00";
                    this.txtTotalGeral.Text = "R$ 0.00";
                }

                this.lblResumoDaConta.Text = Status();

                this.txtDinheiro.Focus();
                this.txtDinheiro.SelectAll();
            }
            catch (Exception ex)/**/
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        private void txtTotalGeral_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvVendas.Rows.Count > 0)
                {
                    if (this.txtParcela.Text != "0")
                    {
                        this.txtTotalReceber.Text = (Convert.ToDecimal(this.txtTotalGeral.Text) - Convert.ToDecimal(this.txtParcela.Text)).ToString("C2");
                    }
                    else
                    {
                        this.txtTotalReceber.Text = this.txtTotalGeral.Text;
                    }
                }
                else { this.txtTotalReceber.Text = "R$ 0.00"; this.txtTotalGeral.Text = "R$ 0.00"; }
                this.txtParcela.Text = Convert.ToDecimal(this.txtParcela.Text).ToString("C2");
            }
            catch { }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGravarParcela_Click(object sender, EventArgs e)
        {
            if (txtDinheiro.Text != "R$ 0.00") { Cl_PreVenda.GravarParcela(this.txtDinheiro.Text, _Codigo.ToString()); }
            else { txtDinheiro.Text = "R$ 0.00"; this.txtDinheiro.Focus(); this.txtDinheiro.SelectAll(); }
            BuscarAnotado();
        }

        private void btnReceber_Click(object sender, EventArgs e)
        {
            decimal troco = Convert.ToDecimal(txtDinheiro.Text) - Convert.ToDecimal(txtTotalReceber.Text.Replace("R$ ", ""));
            if (troco <= 0) { txtDinheiro.Clear(); txtDinheiro.Focus(); return; }

            if (this.dgvVendas.Rows.Count > 0)
            {
                int iCount = 0;
                do
                {
                    Cl_PreVenda.Receber(_Codigo.ToString(), this.dgvVendas.Rows[iCount].Cells[0].Value.ToString(), clsGlobal.DeStringParadecimal(txtDinheiro.Text.Replace("R$ ", "")), troco);
                    iCount++;
                } while (iCount < this.dgvVendas.Rows.Count - 1);
            }

            BuscarAnotado();
        }

        private void txtDinheiro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvVendas.Rows.Count > 0)
                {
                    decimal _dinheiro = Convert.ToDecimal(this.txtDinheiro.Text.Replace("R$ ", ""));
                    decimal _TotalReceber = Convert.ToDecimal(this.txtTotalReceber.Text.Replace("R$ ", ""));

                    if (_dinheiro < _TotalReceber)
                    {
                        this.btnReceber.Enabled = false;
                        this.btnGravarParcela.Enabled = true;
                        this.txtDinheiro.Focus();
                    }
                    else
                    {
                        this.txtTroco.Text = (Convert.ToDecimal(this.txtDinheiro.Text) - Convert.ToDecimal(this.txtTotalReceber.Text.Replace("R$ ", ""))).ToString("C2");
                        this.btnReceber.Enabled = true;
                        this.btnGravarParcela.Enabled = false;
                    }
                }
                else { this.txtTotalReceber.Text = "R$ 0.00"; this.txtTotalGeral.Text = "R$ 0.00"; }
            }
            catch { }

        }

        private void txtDinheiro_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (this.txtDinheiro.Text.ToString() != "R$ 0,00")
                    {
                        btnReceber_Click(null, null);
                    }
                }
            }
            catch { }

        }

        private void dgvClientes_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (!dgvClientesRowEnter)
                {
                    dgvClientesRowEnter = true;
                    this._Codigo = Convert.ToDecimal(dgvClientes.Rows[e.RowIndex].Cells[0].Value.ToString());
                    this._Cliente = dgvClientes.Rows[e.RowIndex].Cells[1].Value.ToString();
                    BuscarAnotado();
                    this.txtParcela.Text = Cl_PreVenda._Parcela.ToString("C2");

                    if (dgvVendas.Rows.Count == 0 || Rbt_Fixa.Checked == true)
                    {
                        this.txtTotalReceber.Text = "R$ 0.00";
                        this.txtTotalReceber.Text = "R$ 0.00";
                        this.txtTotalReceber.Text = "R$ 0.00";
                        this.txtParcela.Text = "R$ 0.00";
                        this.lblLiquido.Text = "R$ 0.00";
                        this._Codigo = 0;
                        this._Cliente = "Canônico";
                        this.lblResumoDaConta.Text = Status();
                    }
                }
            }
            catch
            {

            }
            finally { dgvClientesRowEnter = false; }

        }

        private void Rbt_Fixa_CheckedChanged(object sender, EventArgs e)
        {
            BuscarAnotado();
        }

        private void Rbt_Diaria_CheckedChanged(object sender, EventArgs e)
        {
            BuscarAnotado();
        }

        private void dgvVendas_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (dgvVendas.Rows.Count > 0)
                {
                    if (e.KeyCode == Keys.Delete)
                    {
                        if ((_Codigo > 0) && (clsGlobal.CodigoVenda > 0))
                        {
                            Cl_PreVenda.Extorno(_Codigo.ToString(), clsGlobal.CodigoVenda.ToString());
                            MessageBox.Show("A venda Código: " + clsGlobal.CodigoVenda + " foi excluida!", Application.ProductName);
                            BuscarAnotado();
                        }
                    }
                }
            }
            catch { }

        }

        private void dgvVendas_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (!Arrumado && this.dgvVendas.Rows.Count > 0)
                {
                    this.dgvVendas.Columns["Data"].Width = clsGlobal.DimencionarColuna(15, this.dgvVendas.Width);
                    this.dgvVendas.Columns["Produtos"].Width = clsGlobal.DimencionarColuna(51, this.dgvVendas.Width);
                    this.dgvVendas.Columns["Quant"].Width = clsGlobal.DimencionarColuna(10, this.dgvVendas.Width);
                    this.dgvVendas.Columns["SubTotal"].Width = clsGlobal.DimencionarColuna(14, this.dgvVendas.Width);

                    this.dgvVendas.Columns["Quant"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    this.dgvVendas.Columns["SubTotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                    this.dgvVendas.Columns["Quant"].DefaultCellStyle.Format = "0000";
                    this.dgvVendas.Columns["SubTotal"].DefaultCellStyle.Format = "R$ 0.00";

                    this.dgvVendas.Columns[0].Visible = false;
                    this.dgvVendas.Columns[4].Visible = false;
                    this.dgvVendas.Columns["Parcela"].Visible = false;
                    this.dgvVendas.Columns["Desconto"].Visible = false;
                    Arrumado = true;
                }
                else
                {
                    clsGlobal.CodigoVenda = Convert.ToInt32(dgvVendas.Rows[e.RowIndex].Cells[0].Value);
                }
                dgvClientesRowEnter = false;
            }
            catch
            {

            }

        }

    }
}
