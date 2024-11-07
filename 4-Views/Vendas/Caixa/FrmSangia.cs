
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasaMendes
{
    public partial class FrmSangia : Form
    {
        //public int id = 0;
        //public FrmSangia()
        //{
        //    InitializeComponent();
        //}

        //// verificar se caixa está aberto
        //private int CaixaEstaAberto()
        //{ 
        //    // Definir a cláusula WHERE e os parâmetros
        //    string whereClause = "Status = @Status";
        //    var parameters = new Dictionary<string, object> {
        //        {"Status", "Aberto" }
        //    };
        //    var aberto = new Dados().SelectWithWhere<AbrirCaixa>("AbrirCaixas", whereClause, parameters);

        //    //var aberto = new AbrirCaixa { Status = "Aberto" };
        //    //var result = await aberto.BuscaBase();
        //    return 0;//result.AbrirCaixaId;
        //}

        //private Sangria Buscar()
        //{
        //    var sangria = new Sangria { AbrirCaixaId = CaixaEstaAberto() };
        //    return null;// await sangria.BuscaBase();
        //}

        //private bool AtualizarValor(decimal Valor)
        //{
        //    try
        //    {
        //        var result = Buscar();
        //        if (result.AbrirCaixaId > 0)
        //        {
        //            result.FuncionarioId = this.id;
        //            result.Valor = Valor;
        //           //new Dados().Update(result);
        //            return true;
        //        }
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

        //private  void BtnOK_Click(object sender, System.EventArgs e)
        //{
        //    var valor = clsGlobal.DeStringParaDecimal(this.TxtValor.Text);
        //    // CÓDIGO: 0001 - ERRO DE ESCRITA NA BASE DE DADOS.
        //    if ( AtualizarValor(valor))
        //    {
        //        MessageBox.Show($"Sangria no valor: {valor.ToString("N2")} foi realizada.", "Informação do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    else
        //    {
        //        MessageBox.Show($"Sangria no valor: {valor.ToString("N2")} não pode ser foi realizada.{Environment.NewLine}Informe o código abaixa ao técnico do sistema,{Environment.NewLine}CÓDIGO: 0001", "Informação do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }BtnCancelar.PerformClick();
        //}

        //private void TxtValor_Leave(object sender, EventArgs e)
        //{
        //    this.TxtValor.Text = clsGlobal.DeStringParaDecimal(this.TxtValor.Text).ToString();
        //}

        //private void BtnOK_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        BtnOK.PerformClick();
        //    }
        //}

        //private void BtnCancelar_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Escape)
        //    {
        //        BtnCancelar.PerformClick();
        //    }
        //}

        //private void TxtValor_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        BtnOK.PerformClick();
        //    }
        //    if (e.KeyCode == Keys.Escape)
        //    {
        //        BtnCancelar.PerformClick();
        //    }
        //}

    }
}
