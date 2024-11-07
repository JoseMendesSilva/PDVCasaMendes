using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace CasaMendes
{
    public partial class FrmPagamento : Form
    {
        private decimal valorTotalVenda;
        public int ClienteId { get; set; } = 0;
        public string Cliente { get; set; } = "PENDURA";

        //public List<Pagamento> listaPagamentos;

        public FrmPagamento(decimal totalVenda)
        {
            //    InitializeComponent();
            //    valorTotalVenda = totalVenda;
            //    listaPagamentos = new List<Pagamento>();

            //    //Inicializa ComboBox com formas de pagamento
            //    LstFormaPagamento.Items.AddRange(new object[]
            //    {
            //    "Dinheiro".ToUpper(),
            //    "Cartão de Crédito".ToUpper(),
            //    "Cartão de Débito".ToUpper(),
            //    "Pix".ToUpper(),
            //    "Pendura".ToUpper(),
            //    });

            //    LstFormaPagamento.SelectedIndex = 0; // Seleciona o primeiro item por padrão
            //    TxtValorPagamento.Text = "0,00";
            //    TxtDesconto.Text = "0,00";
            //    TxtTroco.Text = "0,00"; 
            //    BtnFinalizarVenda.Enabled = false;
        }

    private void SelecionarCliente()
        {
            //    var fc = new FrmBuscarCliente();
            //    fc.ShowDialog();
            //    if (fc.DialogResult.Equals(DialogResult.OK))
            //    {
            //        this.ClienteId = fc.ClienteId;
            //        this.Cliente = fc.Cliente;
            //        this.TxtValorPagamento.Text = valorTotalVenda.ToString();
            //        this.BtnAdicionarPagamento.PerformClick();
            //    }
            //    else
            //    {
            //        this.ClienteId = 0;
            //        this.Cliente = "CONSUMIDOR";
            //    }
            //    fc.Dispose();
            //    //this.LblClienteId.Text = this.ClienteId.ToString();
            //    //this.LblCliente.Text = this.Cliente;
            //    this.LblClienteId.Text = $"ID: {this.ClienteId.ToString("G4")}";
            //    this.LblCliente.Text = $"Cliente: {this.Cliente}";
        }

    private void AdicionarPagamento()
        {
            //    var valor = clsGlobal.DeStringParaDecimal(TxtValorPagamento.Text); 

            //    // 178400924

            //    if (valor > 0.00m || LstFormaPagamento.SelectedItem.ToString() == "PENDURA")
            //    {
            //        var pagamento = new Pagamento
            //        {
            //            FormaPagamento = LstFormaPagamento.SelectedItem.ToString(),
            //            Valor = valor,
            //            Desconto = clsGlobal.DeStringParaDecimal(TxtDesconto.Text),
            //            Troco = clsGlobal.DeStringParaDecimal(TxtTroco.Text),
            //            ClienteId = clsGlobal.DeStringParaInt(this.ClienteId.ToString())
            //        };

            //        listaPagamentos.Add(pagamento);
            //        AtualizarGridPagamentos();
            //        TxtValorPagamento.Clear();
            //        VerificarFinalizacao();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Por favor, insira um valor válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
        }

    private void AtualizarGridPagamentos()
        {
            //    DgvPagamentos.DataSource = null;
            //    DgvPagamentos.DataSource = listaPagamentos;
            //    DgvPagamentos.Columns["FormaPagamento"].HeaderText = "Forma de Pagamento";
            //    DgvPagamentos.Columns["Valor"].HeaderText = "Valor";
        }

        private void VerificarFinalizacao()
        {
            //    decimal totalPago = 0;
            //    decimal desconto = 0;
            //    decimal troco = 0;

            //    foreach (var pagamento in listaPagamentos)
            //    {
            //        totalPago += pagamento.Valor;
            //        desconto += pagamento.Desconto;
            //        troco += pagamento.Troco;
            //    }

            //    totalPago += desconto;

            //    BtnFinalizarVenda.Enabled = totalPago >= valorTotalVenda;

            //    if (BtnFinalizarVenda.Enabled)
            //    {
            //        MessageBox.Show("Valor suficiente para finalizar a venda.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
        }

        private void BtnFinalizarVenda_Click(object sender, EventArgs e)
        {// Implementa a lógica de finalização, como salvar no banco de dados
            MessageBox.Show("Venda finalizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void BtnAdicionarPagamento_Click(object sender, EventArgs e)
        {
            try
            {
                AdicionarPagamento();
            }
            catch { }
        }

        // Evento para capturar o texto digitado no TextBox
        private void TxtValorPagamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite apenas números e a tecla de backspace
            clsGlobal.ApenasNumeros_e_TeclaBackspace(sender, ref e);
        }

        // Evento para formatar o valor em tempo real ao digitar
        private void TxtValorPagamento_TextChanged(object sender, EventArgs e)
        {
            try
            {
                clsGlobal.TextChangedFormat(ref sender, e);

                var valor = clsGlobal.DeStringParaDecimal(TxtValorPagamento.Text);
                var desconto = clsGlobal.DeStringParaDecimal(TxtDesconto.Text);
                var troco = 0.00m;

                if (valor > 0.00m)
                    troco = valorTotalVenda - (valor + desconto);
                else
                    troco = 0.00m;

                this.TxtTroco.Text = troco.ToString();
            }
            catch { }
        }

        private void TxtDesconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite apenas números e a tecla de backspace
            clsGlobal.ApenasNumeros_e_TeclaBackspace(sender,ref e);
        }

        private void TxtDesconto_TextChanged(object sender, EventArgs e)
        {
            try
            {
                clsGlobal.TextChangedFormat(ref sender, e);

                var valor = clsGlobal.DeStringParaDecimal(TxtValorPagamento.Text);
                var desconto = clsGlobal.DeStringParaDecimal(TxtDesconto.Text);

                var troco = valorTotalVenda - (valor + desconto);
                this.TxtTroco.Text = troco.ToString();
            }
            catch { }
        }

        private void TxtTroco_TextChanged(object sender, EventArgs e)
        {
            clsGlobal.TextChangedFormat(ref sender, e);
        }

        private void TxtTroco_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite apenas números e a tecla de backspace 78400924
            clsGlobal.ApenasNumeros_e_TeclaBackspace(sender, ref e);
        }

        private void TxtValorPagamento_KeyDown(object sender, KeyEventArgs e)
        {
            clsGlobal.TxtKeyDownChnangeFocus(ref TxtDesconto, ref e);
        }

        private void TxtDesconto_KeyDown(object sender, KeyEventArgs e)
        {
            clsGlobal.BtnKeyDownChnangeFocus(ref BtnAdicionarPagamento , ref e);
        }

        private void LstFormaPagamento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Control && e.KeyCode == Keys.V)
            { TxtValorPagamento.Focus(); }
           else if (e.KeyCode == Keys.Escape)
            { if(BtnFinalizarVenda.Enabled) BtnFinalizarVenda.PerformClick(); }
            else {
                TxtValorPagamento.Focus();
            }
        }

        private void LstFormaPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var text = LstFormaPagamento.SelectedItem.ToString();
                if (text == "Pendura".ToUpper())
                {
                    this.SelecionarCliente(); // 178400924
                }
            }
            catch { }
        }
    }
}
