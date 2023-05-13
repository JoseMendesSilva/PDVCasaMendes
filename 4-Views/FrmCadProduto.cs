using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasaMendes
{
    public partial class FrmCadProduto : Form
    {
        public BindingSource BsProduto;
        private tProduto oProduto;


        public FrmCadProduto()
        {
            InitializeComponent();
            Botoes(true);
            oProduto = new tProduto();
            BsProduto = new BindingSource { oProduto };
            if (oProduto.idProduto.Equals(0)) BsProduto.Add(oProduto);
        }

        private void VincularBindingSource()
        {
            txtID_Produto.DataBindings.Add("Text", BsProduto, "idProduto");
            txtCodigoDoFornecedor.DataBindings.Add("Text", BsProduto, "CodigoDoFornecedor");
            txtCodigoDeBarras.DataBindings.Add("Text", BsProduto, "CodigoDeBarras");
            txtNome.DataBindings.Add("Text", BsProduto, "Nome");
            dtpDataDeValidade.DataBindings.Add("Value", BsProduto, "DataDeValidade");
            txtDesconto.DataBindings.Add("Text", BsProduto, "Desconto");
            txtEstoque.DataBindings.Add("Text", BsProduto, "Estoque");
            txtPrecoDeVenda.DataBindings.Add("Text", BsProduto, "PrecoDeVenda");
            txtPrecoUnitario.DataBindings.Add("Text", BsProduto, "PrecoUnitario");
            txtQuantidade.DataBindings.Add("Text", BsProduto, "Quantidade");
            txtValorCompra.DataBindings.Add("Text", BsProduto, "ValorCompra");
            TxtCodigoDaNotaFiscal.DataBindings.Add("Text", BsProduto, "CodigoDaNotaFiscal");
            TxtValorDesconto.DataBindings.Add("Text", BsProduto, "ValorDesconto");
        }

        private void Botoes(bool b)
        {
            btnGravar.Enabled = b;
            btnFechar.Enabled = b;
            btnExcluir.Enabled = b;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCadProduto_Load(object sender, EventArgs e)
        {
            VincularBindingSource();

            cbFornecedores.DisplayMember = "RazaoSocial";
            cbFornecedores.DataSource = new tFornecedore().Todos();
        }

        private void cbFornecedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                tFornecedore oFornecedor = new tFornecedore();
                oFornecedor.RazaoSocial = cbFornecedores.Text;
                var codigo = oFornecedor.Busca();
                txtCodigoDoFornecedor.Text = codigo[0].CodigoDoFornecedor.ToString();
                oFornecedor = null;
            }
            catch { }
        }

    }
}

//Fornecedor fornecedor = new Fornecedor();

// fornecedor.CriarTabela();

//fornecedor.RazaoSocial = "hh";
//fornecedor.Endereco = "hh";
//fornecedor.Cep = "88888-000";
//fornecedor.Cidade = "hh";
//fornecedor.Bairro = "hh";
//fornecedor.Estado = "hh";
//fornecedor.DataCadastro=DateTime.Now;
//fornecedor.Celular = "55555555555";
//fornecedor.Telefone = "5555555555";
//fornecedor.Email = "email";
//fornecedor.SITE = "site";
//fornecedor.Cnpj = "00.009.999/0001-88";
//fornecedor.InscricaoEstadual = "00.009.998";
//fornecedor.Salvar();