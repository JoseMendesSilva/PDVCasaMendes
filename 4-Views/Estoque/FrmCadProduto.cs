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
        public BindingSource BsProduto;
        public Produto oProduto;
        private List<TabelaDeMargen> oListaDeMargen;
        #endregion

        #region FrmCadProduto

        public FrmCadProduto()
        {
            InitializeComponent();
        }

        #endregion

        #region métodos
  
        private void CalcularPreco()
        {
            double temp;
            if (!TxtQuantidade.Text.Equals("") && !TxtValorCompra.Text.Equals(""))
            {
                temp = double.Parse(TxtValorCompra.Text) / double.Parse(TxtQuantidade.Text);
                TxtPrecoUnitario.Text=temp.ToString("N2");
            }
            if (!TxtPrecoUnitario.Text.Equals(""))
            {
                temp = (oListaDeMargen[0].Despesa + oListaDeMargen[0].MargemDeLucro + oListaDeMargen[0].Custo + oListaDeMargen[0].Encargo + oListaDeMargen[0].PorcentagemPesoPorItem);
                temp /= 100;
                temp = 1 - temp;
                temp = double.Parse(TxtPrecoUnitario.Text) / temp;
                TxtPrecoDeVenda.Text = temp.ToString("N2");
            }
        }

        private void VincularBindingSource()
        {
            TxtProdutoId.DataBindings.Add("Text", BsProduto, "ProdutoId");
            TxtCodigoDoFornecedor.DataBindings.Add("Text", BsProduto, "FornecedorId");
            TxtCodigoDeBarras.DataBindings.Add("Text", BsProduto, "CodigoDeBarras");
            TxtNome.DataBindings.Add("Text", BsProduto, "Nome");
            DtpDataDeValidade.DataBindings.Add("Value", BsProduto, "DataDeValidade");
            TxtPrecoDeVenda.DataBindings.Add("Text", BsProduto, "PrecoDeVenda");
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

        private void btnGravar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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
            VincularBindingSource();
            BsProduto.DataSource = oProduto;

            CbFornecedores.DisplayMember = "RazaoSocial";
            CbFornecedores.DataSource = new Fornecedore().Todos();

            if (CbFornecedores.Items.Count < 1)
            {
                MessageBox.Show("Não foram encontrado nemhum fornecedor cadastrado, cadastre fornecedores.");
                status = false;
            }
            
            CbSubcategoria.DisplayMember = "Nome";
            CbSubcategoria.DataSource = new SubCategoria().Todos();

            if (CbSubcategoria.Items.Count < 1) { 
                MessageBox.Show("Não foram encontrado nemhuma subcategoria cadastrada, cadastre subcategorias.");
                status = false;
            }
            if (oProduto.Foto != null)
               PicFoto.Image=Image.FromFile(oProduto.Foto);
            else
                PicFoto.Image = Properties.Resources.CasaMendes1Jpg;

            if (!status)
            {
                BtnGravar.Enabled = false;
                BtnFechar.Enabled = true;
            }
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

    }
}
