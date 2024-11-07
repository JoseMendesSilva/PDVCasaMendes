
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasaMendes
{
    public partial class FrmAbrirCaixa : Form
    {
        public bool CaixaAberto = false;

        //public Funcionario oFuncionario { get; set; } = new Funcionario();

        ////private readonly Dados dados;
        //private AbrirCaixa Aberto { get; set; }

        public FrmAbrirCaixa()
        {
            InitializeComponent();
        }

        private bool CaixaEstaAberto()
        {
            //using (Aberto = new OCaixa().EstaAberto())
            //{
            //    using (Aberto = new AbrirCaixa())
            //    {
            //        // se sim, mostrar, no formulario o valor e exibir a mensagem,
            //        if (Aberto.AbrirCaixaId > 0)
            //        {
            //            this.TxtValor.Text = Aberto.Valor.ToString("N2");//aberto.Valor.ToString();
            //            return this.CaixaAberto = true;
            //        }
            return true;//this.CaixaAberto = false;
            //    }
            //}
        }

        private void FrmAbrirCaixa_Load(object sender, EventArgs e)
        {
            this.Refresh();
        }
       
        private bool AbrirCaixaAsync(decimal valor)
        {
            try
            {
                //using (var dados = new Dados())
                //{
                //    // abrir o caixa
                //    using (var abrirCaixa = new AbrirCaixa())
                //    {
                //        abrirCaixa.AbrirCaixaId = 0;
                //        abrirCaixa.FuncionarioId = oFuncionario.FuncionarioId;
                //        abrirCaixa.DataHora = DateTime.Now;
                //        abrirCaixa.Valor = valor;
                //        abrirCaixa.Status = "Aberto";
                //        var retorno = dados.Insert(abrirCaixa);

                //        if (retorno > 0)
                //        {
                //            var caixa = new Caixa();
                //                caixa.AbrirCaixaId = abrirCaixa.AbrirCaixaId;
                //                caixa.DataHora = abrirCaixa.DataHora;
                //                caixa.Desconto = 0.00m;
                //                retorno =  dados.Insert(caixa);
                //        }
                return true;//this.CaixaAberto = true;//178400924
                //    }
                //}
            }
            catch
            {
                return this.CaixaAberto = false;
            }
        }

        private void TxtValor_Leave(object sender, EventArgs e)
        {
            this.TxtValor.Text = clsGlobal.DeStringParaDecimal(this.TxtValor.Text).ToString("N2");
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.CaixaAberto = false;
            this.Close();
        }

        private  void BtnOK_Click(object sender, EventArgs e)
        {
            // usar o usuário carregado no formulário principal.
            // verificar se já não esta aberto
            var res = CaixaEstaAberto();
            if (res)
            { this.Close(); return; }

            var valor = clsGlobal.DeStringParaDecimal(this.TxtValor.Text);

            if (valor <= 0.00m)
            {
                MessageBox.Show("Informe um valor para abrir o caixa!", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.TxtValor.Focus();
                this.TxtValor.SelectAll();
                return;
            }
            // abrir o caixa
           if(AbrirCaixaAsync(valor)) { MessageBox.Show($"O caixa foi aberto com o valor de {valor.ToString("C2")}."); }
            // fechar formulário abrir caixa
            this.Close();
        }

        #region KeyDown
        private void BtnOK_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.BtnOK.PerformClick();
        }

        private void BtnCancelar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.BtnCancelar.PerformClick();
        }

        private void TxtValor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.BtnCancelar.PerformClick();
            else if (e.KeyCode == Keys.Enter)
                this.BtnOK.PerformClick();
        }

        private void FrmAbrirCaixa_Shown(object sender, EventArgs e)
        {
            try
            {
                ////// verificar se caixa está aberto
                ////// se sim, mostrar, no formulario o valor e exibir a mensagem,
                //if (this.CaixaAberto)
                //{
                //    // 'O caixa esta aberto com o valor X, dezeja altera este valor?'
                //    DialogResult res = MessageBox.Show($"O caixa esta aberto com o valor {Aberto.Valor}, dezeja altera o valor?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //    // se não, fechar o formulario e exibir a tela de vendas.
                //    if (res == DialogResult.No)
                //    {
                //        this.Close();
                //        this.CaixaAberto = true;
                //        return;
                //    }
                //}
            }
            catch { }
        }
        #endregion
    }
}


//var CaixaAberto = await abrirCaixa.BuscaBase();

//var caixa = new Caixa { AbrirCaixaId = CaixaAberto.AbrirCaixaId };
//await dados.Insert(caixa);

//var sangria = new Sangria { AbrirCaixaId = CaixaAberto.AbrirCaixaId };
//await dados.Insert(sangria);

//var suprimento = new Suprimento { AbrirCaixaId = CaixaAberto.AbrirCaixaId };
//await dados.Insert(suprimento);

//var fecharCaixa = new FecharCaixa { AbrirCaixaId = CaixaAberto.AbrirCaixaId };
//await dados.Insert(fecharCaixa);

/*

// Definir a cláusula WHERE e os parâmetros
string whereClause = "IdCategoria = @IdCategoria";
var parameters = new Dictionary<string, object>
{
    { "IdCategoria", 1 }
};

// Buscar as categorias que atendem ao critério
var categorias = dbHelper.Select<TesteCategorias>("TesteCategorias", whereClause, parameters);
*/

//-----------------------------------------------------------------------------
/*

// Definir a cláusula LIKE e os parâmetros
string likeClause = "NomeCategoria LIKE @NomeCategoria";
var parameters = new Dictionary<string, object>
{
    { "NomeCategoria", "%Teste%" }
};

// Buscar as categorias que contenham "Teste" no nome
var categorias = dbHelper.SelectWithLike<TesteCategorias>("TesteCategorias", likeClause, parameters);
*/
//---------------------------------------------------------------------------

