using CasaMendes.Classes.Estatica;
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

        #region var
        public BindingSource BsProduto;
        public tProduto oProduto;
        private List<TabelaDeMargen> oListaDeMargen;
        #endregion

        #region FrmCadProduto

        public FrmCadProduto()
        {
            InitializeComponent();
        }

        #endregion

        #region métodos

        private void BuscarFotoProduto()
        {

            PicFoto.Image = Image.FromFile(clsGlobal.Abririmagens());
            //MessageBox.Show("OK BuscarFotoProduto()" + oListaDeMargen[0].Despesa);
        }

        private void CalcularPreco()
        {
            MessageBox.Show("OK" + oListaDeMargen[0].Despesa);
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
        }

        #endregion

        #region Click

        private void btnGravar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Load

        private void FrmCadProduto_Load(object sender, EventArgs e)
        {
            Botoes(true);

            if (oProduto.Equals(null)) oProduto = new tProduto();
            if (BsProduto == null)
                BsProduto = new BindingSource { oProduto };
            if (oListaDeMargen == null)
                oListaDeMargen = new List<TabelaDeMargen>();

            if (oProduto.idProduto.Equals(0)) BsProduto.Add(oProduto);
            VincularBindingSource();
            BsProduto.DataSource = oProduto;

            cbFornecedores.DisplayMember = "RazaoSocial";
            cbFornecedores.DataSource = new tFornecedore().Todos();

            CbSubcategoria.DisplayMember = "Nome";
            CbSubcategoria.DataSource = new SubCategoria().Todos();
        }

        #endregion

        #region Evento

        #region SelectedIndexChanged

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

        private void CbSubcategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SubCategoria oSubCategoria = new SubCategoria();
                oSubCategoria.Nome = CbSubcategoria.Text;

                var lista = oSubCategoria.Busca();

                TxtSubCategoriaId.Text = lista[0].SubCategoriaId.ToString();
                oSubCategoria = null;

                TabelaDeMargen oTabelaDeMargen = new TabelaDeMargen();
                oTabelaDeMargen.SubCategoriaId = lista[0].SubCategoriaId;
                oListaDeMargen = oTabelaDeMargen.Busca();
            }
            catch { }
        }

        #endregion

        #region TextChanged

        private void txtEstoque_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtEstoque.Text.Equals("") || txtQuantidade.Text.Equals("") || txtDesconto.Text.Equals("") || TxtValorDesconto.Text.Equals("") || txtPrecoUnitario.Text.Equals("") || txtValorCompra.Text.Equals("")) return;
                CalcularPreco();
            }
            catch { }
        }

        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtEstoque.Text.Equals("") || txtQuantidade.Text.Equals("") || txtDesconto.Text.Equals("") || TxtValorDesconto.Text.Equals("") || txtPrecoUnitario.Text.Equals("") || txtValorCompra.Text.Equals("")) return;
                CalcularPreco();
            }
            catch { }
        }

        private void txtDesconto_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtEstoque.Text.Equals("") || txtQuantidade.Text.Equals("") || txtDesconto.Text.Equals("") || TxtValorDesconto.Text.Equals("") || txtPrecoUnitario.Text.Equals("") || txtValorCompra.Text.Equals("")) return;
                CalcularPreco();
            }
            catch { }
        }

        private void TxtValorDesconto_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtEstoque.Text.Equals("") || txtQuantidade.Text.Equals("") || txtDesconto.Text.Equals("") || TxtValorDesconto.Text.Equals("") || txtPrecoUnitario.Text.Equals("") || txtValorCompra.Text.Equals("")) return;
                CalcularPreco();
            }
            catch { }
        }

        private void txtPrecoUnitario_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtEstoque.Text.Equals("") || txtQuantidade.Text.Equals("") || txtDesconto.Text.Equals("") || TxtValorDesconto.Text.Equals("") || txtPrecoUnitario.Text.Equals("") || txtValorCompra.Text.Equals("")) return;
                CalcularPreco();
            }
            catch { }
        }

        private void txtPrecoDeVenda_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtEstoque.Text.Equals("") || txtQuantidade.Text.Equals("") || txtDesconto.Text.Equals("") || TxtValorDesconto.Text.Equals("") || txtPrecoUnitario.Text.Equals("") || txtValorCompra.Text.Equals("")) return;
                CalcularPreco();
            }
            catch { }
        }

        private void txtValorCompra_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtEstoque.Text.Equals("") || txtQuantidade.Text.Equals("") || txtDesconto.Text.Equals("") || TxtValorDesconto.Text.Equals("") || txtPrecoUnitario.Text.Equals("") || txtValorCompra.Text.Equals("")) return;
                CalcularPreco();
            }
            catch { }
        }

        #endregion

        #endregion

        private void PicFoto_Click(object sender, EventArgs e)
        {
            try
            {
                BuscarFotoProduto();
            }catch { }
        }
    }
}
