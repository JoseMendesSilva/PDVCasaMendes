using DocumentFormat.OpenXml.Bibliography;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CasaMendes
{
    public partial class FrmCadProduto : Form
    {

        #region var

#pragma warning disable CS0414 // O campo "FrmCadProduto.Loading" é atribuído, mas seu valor nunca é usado
        bool Loading;
#pragma warning restore CS0414 // O campo "FrmCadProduto.Loading" é atribuído, mas seu valor nunca é usado
        public BindingSource BsProduto;
        public Produto oProduto;
        private List<TabelaDeMargen> oListaDeMargen;

        #endregion

        #region FrmCadProduto

        public FrmCadProduto()
        {
            InitializeComponent();
            Loading = true;
        }

        #endregion

        #region métodos

        private void CalcularPreco()
        {
            decimal temp;
            if (TxtQuantidade.Text.Equals("") || TxtValorCompra.Text.Equals("")) return;
            
                temp = clsGlobal.DeStringParaDecimal(TxtValorCompra.Text) / clsGlobal.DeStringParaDecimal(TxtQuantidade.Text);
                TxtPrecoUnitario.Text = temp.ToString("N2");
                temp = (oListaDeMargen[0].Despesa + oListaDeMargen[0].MargemDeLucro + oListaDeMargen[0].Custo + oListaDeMargen[0].Encargo + oListaDeMargen[0].PorcentagemPesoPorItem);
                temp /= 100;
                temp = 1 - temp;
                temp = clsGlobal.DeStringParaDecimal(TxtPrecoUnitario.Text) / temp;
                TxtPrecoDeVenda.Text = temp.ToString("N2");
            
        }

        private void VincularBindingSource()
        {
            TxtProdutoId.DataBindings.Add("Text", BsProduto, "ProdutoId");
            TxtCodigoDoFornecedor.DataBindings.Add("Text", BsProduto, "FornecedorId");
            TxtCodigoDeBarras.DataBindings.Add("Text", BsProduto, "CodigoDeBarras");
            TxtNome.DataBindings.Add("Text", BsProduto, "Nome");
            DtpDataDeValidade.DataBindings.Add("Value", BsProduto, "DataDeValidade");
            TxtPrecoUnitario.DataBindings.Add("Text", BsProduto, "PrecoUnitario");
            TxtQuantidade.DataBindings.Add("Text", BsProduto, "Quantidade");
            TxtValorCompra.DataBindings.Add("Text", BsProduto, "ValorCompra");
        }

        private void Botoes(bool b)
        {
            BtnGravar.Enabled = b;
            BtnFechar.Enabled = b;
        }

        #endregion

        #region Evento

        #region Click

        private void PicFoto_Click(object sender, EventArgs e)
        {
            try
            {
                PicFoto.Image = Image.FromFile(clsGlobal.BuscarFotoProduto());
            }
            catch { }
            try
            {
                oProduto.Foto = clsGlobal.BuscarFotoProduto();
                PicFoto.Image = Image.FromFile(clsGlobal.AbrirImagem(oProduto.Foto));
            }
            catch { }
        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                oProduto.PrecoDeVenda = clsGlobal.DeStringParaDecimal(TxtPrecoDeVenda.Text);
                oProduto.PrecoUnitario = clsGlobal.DeStringParaDecimal(TxtPrecoUnitario.Text);

                if (string.IsNullOrEmpty(oProduto.Nome) ||
                string.IsNullOrEmpty(oProduto.FornecedorId.ToString()) ||
                string.IsNullOrEmpty(oProduto.SubCategoriaId.ToString()) ||
                string.IsNullOrEmpty(oProduto.PrecoDeVenda.ToString()) ||
                string.IsNullOrEmpty(oProduto.PrecoUnitario.ToString()) ||
                string.IsNullOrEmpty(oProduto.Quantidade.ToString()) ||
                string.IsNullOrEmpty(oProduto.ValorCompra.ToString()) ||
                string.IsNullOrEmpty(oProduto.DataDeValidade.ToString()) ||
                string.IsNullOrEmpty(oProduto.CodigoDeBarras.ToString()))
                {
                    MessageBox.Show("Todos os campos são obrigatorio.");
                    return;
                }

                if (string.IsNullOrEmpty(TxtQuantidadeItemDesconto.Text)) 
                    TxtQuantidadeItemDesconto.Text = "0";
                if (string.IsNullOrEmpty(TxtValorDesconto.Text)) 
                    TxtValorDesconto.Text = "0,00";

                //oProduto.CodigoDeBarras = oProduto.CodigoDeBarras;

                var oEstoque = new Estoque
                {
                    EstoqueId = 0,
                    ProdutoId = oProduto.ProdutoId,
                    Produto = oProduto.Nome,
                    CodigoDeBarras = oProduto.CodigoDeBarras,
                    Quantidade = oProduto.Quantidade,
                    PrecoDeVenda = oProduto.PrecoDeVenda,
                    QuantidadeItemDesconto = clsGlobal.DeStringParaInt(TxtQuantidadeItemDesconto.Text),
                    Foto = oProduto.Foto,
                    ValorDesconto = decimal.Parse(TxtValorDesconto.Text)
                };

                //Verificando se o nome já existe no estoque e resgata o EstoqueId.
                var eEstoque = new Estoque
                {
                    CodigoDeBarras = oEstoque.CodigoDeBarras
                };

                List<Estoque> lEstoque = eEstoque.Busca();
                if (lEstoque.Count > 0)
                {
                    oEstoque.EstoqueId = lEstoque[0].EstoqueId;
                }

                oProduto.Salvar();
                oEstoque.Salvar();
                MessageBox.Show("Processo realisado com sucesso.");
            }
            catch
            {
                MessageBox.Show("O cadastro não foi realizado com sucesso.");
            }

        }

        #endregion

        #region Load

        private void FrmCadProduto_Load(object sender, EventArgs e)
        {
            Botoes(true);
            bool status = true;

            if (oProduto == null)
                oProduto = new Produto();
            if (BsProduto == null)
                BsProduto = new BindingSource { oProduto };
            if (oListaDeMargen == null)
                oListaDeMargen = new List<TabelaDeMargen>();

            if (oProduto.ProdutoId.Equals(0)) BsProduto.Add(oProduto);
            BsProduto.DataSource = oProduto;
            VincularBindingSource();

            CbFornecedores.DisplayMember = "RazaoSocial";
            CbFornecedores.DataSource = new Fornecedore().Todos();

            if (CbFornecedores.Items.Count < 1)
            {
                MessageBox.Show("Não foram encontrado nemhum fornecedor cadastrado, cadastre fornecedores.");
                status = false;
            }

            CbSubcategoria.DisplayMember = "Nome";
            CbSubcategoria.DataSource = new SubCategoria().Todos();

            if (CbSubcategoria.Items.Count < 1)
            {
                MessageBox.Show("Não foram encontrado nemhuma subcategoria cadastrada, cadastre subcategorias.");
                status = false;
            }
            if (oProduto.Foto != null)
                PicFoto.Image = Image.FromFile(oProduto.Foto);
            else
                PicFoto.Image = Properties.Resources.CasaMendes1Jpg;

            if (!status)
            {
                BtnGravar.Enabled = false;
                BtnFechar.Enabled = true;
            }
            Loading = false;
        }

        #endregion

        #region SelectedIndexChanged

        private void cbFornecedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Fornecedore oFornecedor = new Fornecedore
                {
                    RazaoSocial = CbFornecedores.Text
                };
                var codigo = oFornecedor.Busca();
                TxtCodigoDoFornecedor.Text = codigo[0].FornecedorId.ToString();
                oFornecedor = null;
            }
            catch { }
        }

        private void CbSubcategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SubCategoria oSubCategoria = new SubCategoria
                {
                    Nome = CbSubcategoria.Text
                };

                var lista = oSubCategoria.Busca();

                TxtSubCategoriaId.Text = lista[0].SubCategoriaId.ToString();
                oSubCategoria = null;

                using (var oTabelaDeMargen = new TabelaDeMargen())
                {
                    oTabelaDeMargen.SubCategoriaId = lista[0].SubCategoriaId;
                    oListaDeMargen = oTabelaDeMargen.Busca();
                    CalcularPreco();
                }
            }
            catch { }
        }

        #endregion

        #region TextChanged

        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int quant = clsGlobal.DeStringParaInt(TxtQuantidade.Text);
                oProduto.Quantidade = quant;
                CalcularPreco();
            }
            catch { }
        }

        private void txtPrecoUnitario_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CalcularPreco();
            }
            catch { }
        }

        #endregion

        #endregion

        private void TxtPrecoDeVenda_Leave(object sender, EventArgs e)
        {
            try
            {
                oProduto.PrecoDeVenda = clsGlobal.DeStringParaDecimal(TxtPrecoDeVenda.Text); ;
                TxtPrecoDeVenda.Text = oProduto.PrecoDeVenda.ToString();
            }
            catch { }
        }

    }
}
