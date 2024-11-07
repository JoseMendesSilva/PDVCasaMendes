
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasaMendes
{
    public partial class FrmSuprimento : Form
    {
        //public int id = 0;
        //public FrmSuprimento()
        //{
        //    InitializeComponent();
        //}

        //// verificar se caixa está aberto
        //private async Task<int> CaixaEstaAberto()
        //{
        //    //var aberto = new AbrirCaixa { Status = "Aberto" };
        //    //var result = await aberto.BuscaBase();
        //    return 0;//result.AbrirCaixaId;
        //}

        //private async Task<Suprimento> Buscar()
        //{
        //    var suprimento = new Suprimento { AbrirCaixaId = await CaixaEstaAberto() };
        //    //var result = await suprimento.BuscaBase();
        //    return null;//result;
        //}

        //private async Task<bool> AtualizarValor(decimal Valor)
        //{
        //    try
        //    {
        //        //var result = await Buscar();
        //        //if (result.AbrirCaixaId > 0)
        //        //{
        //        //    result.FuncionarioId = this.id;
        //        //    result.Valor += Valor;
        //        //    new Dados().Update(result);
        //        //    return true;
        //        //}
        //        return false;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}

        //private void BtnCancelar_Click(object sender, System.EventArgs e)
        //{
        //    this.Close();
        //    this.Dispose();
        //}

        //// CÓDIGO: 0001 - ERRO DE ESCRITA NA BASE DE DADOS.
        //private async void BtnOK_Click(object sender, System.EventArgs e)
        //{
        //    var valor = clsGlobal.DeStringParaDecimal(this.TxtValor.Text);
        //    // CÓDIGO: 0001 - ERRO DE ESCRITA NA BASE DE DADOS.
        //    if (await AtualizarValor(valor))
        //    {
        //        MessageBox.Show($"Suprimento no valor de: {valor.ToString("N2")}, foi Adicionando ao caixa.", "Informação do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        this.Dispose();
        //    }
        //    else
        //    {
        //        MessageBox.Show($"Suprimento no valor: {valor.ToString("N2")} não foi daicionado ao caixa.{Environment.NewLine}Informe o código abaixa ao técnico do sistema,{Environment.NewLine}CÓDIGO: 0001", "Informação do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //}

        //private void BtnCancelar_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Escape)
        //        this.BtnCancelar.PerformClick();
        //}

        //private void TxtValor_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Escape)
        //        this.BtnCancelar.PerformClick();
        //    else if (e.KeyCode == Keys.Enter)
        //        this.BtnOK.PerformClick();
        //}

        //private void TxtValor_Leave(object sender, EventArgs e)
        //{
        //    this.TxtValor.Text = clsGlobal.DeStringParaDecimal(this.TxtValor.Text).ToString();
        //}
    }
}
