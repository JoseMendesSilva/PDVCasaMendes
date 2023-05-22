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
        /*
         * Carrega uma imagem selecionada e copia, se ela não, para a pasta dentro do diretório
         * padrão do sistema.
         */
        private void BuscarFotoProduto()
        {
            string sourceDir = clsGlobal.Abririmagens();
            string backupDir = @ConfigurationManager.AppSettings["DiretorioFotos"];
            // Remove path from the file name.
            string fName = "", t, tm;

            //separa o nome da imagem com sua extenção com ordem invertida.
            for (int i = sourceDir.Length - 1; i > 0; i--)
            {
                t = sourceDir.Substring(i, 1);
                if (@t == @"\")
                    break;
                fName += t;
            }

            tm = fName;
            fName = "";

            //re ordena o nome da imagem.
            for (int i = tm.Length; i > 0; i--)
            {
                t = tm.Substring(i - 1, 1);
                fName += t;
            }

            //remove o nome da imagem do diretório.
            sourceDir = sourceDir.Substring(0, sourceDir.Length + 2 - fName.Length - 2);

            try
            {
                //verifica se o diretório existe, se não, cria
                if (!Directory.Exists(backupDir))
                {
                    Directory.CreateDirectory(backupDir);
                }

                //verifica se a imagem existe no diretório, se não existir, copia para o diretório.
                if (!File.Exists(Path.Combine(backupDir, fName)))
                {
                    File.Copy(Path.Combine(sourceDir, fName), Path.Combine(backupDir, fName), true);
                }

                //carrega a imagem na tela.
                PicFoto.Image = Image.FromFile(sourceDir + fName);
            }

            // Catch exception if the file was already copied.
            catch 
            {
            }

        }

        //calcula o preço de venda de acordo com os dados informado no formulário.
        private void CalcularPreco()
        {
            double temp;
            if (!txtQuantidade.Text.Equals("") && !txtValorCompra.Text.Equals(""))
            {
                temp = double.Parse(txtValorCompra.Text) / double.Parse(txtQuantidade.Text);
                txtPrecoUnitario.Text=temp.ToString("N2");
            }
            if (!txtPrecoUnitario.Text.Equals(""))
            {
                temp = (oListaDeMargen[0].Despesa + oListaDeMargen[0].MargemDeLucro + oListaDeMargen[0].Custo + oListaDeMargen[0].Encargo + oListaDeMargen[0].PorcentagemPesoPorItem);
                temp /= 100;
                temp = 1 - temp;
                temp = double.Parse(txtPrecoUnitario.Text) / temp;
                txtPrecoDeVenda.Text = temp.ToString("N2");
            }
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

        private void PicFoto_Click(object sender, EventArgs e)
        {
            try
            {
                BuscarFotoProduto();
            }
            catch { }
        }

        #endregion

        #region Load

        private void FrmCadProduto_Load(object sender, EventArgs e)
        {
            Botoes(true);

            if (oProduto.Equals(null))
                oProduto = new Produto();
            if (BsProduto == null)
                BsProduto = new BindingSource { oProduto };
            if (oListaDeMargen == null)
                oListaDeMargen = new List<TabelaDeMargen>();

            if (oProduto.idProduto.Equals(0)) BsProduto.Add(oProduto);
            VincularBindingSource();
            BsProduto.DataSource = oProduto;

            cbFornecedores.DisplayMember = "RazaoSocial";
            cbFornecedores.DataSource = new Fornecedore().Todos();

            CbSubcategoria.DisplayMember = "Nome";
            CbSubcategoria.DataSource = new SubCategoria().Todos();
            
            if (oProduto.Foto != null)
               PicFoto.Image=Image.FromFile(oProduto.Foto);
            else
                PicFoto.Image = Properties.Resources.CasaMendes1Jpg;

        }

        #endregion

        #region Evento

        #region SelectedIndexChanged

        private void cbFornecedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Fornecedore oFornecedor = new Fornecedore
                {
                    RazaoSocial = cbFornecedores.Text
                };
                var codigo = oFornecedor.Busca();
                txtCodigoDoFornecedor.Text = codigo[0].FornecedorId.ToString();
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
                //if (txtEstoque.Text.Equals("") || txtQuantidade.Text.Equals("") || txtDesconto.Text.Equals("") || TxtValorDesconto.Text.Equals("") || txtPrecoUnitario.Text.Equals("") || txtValorCompra.Text.Equals("")) return;
                CalcularPreco();
            }
            catch { }
        }

        private void txtPrecoUnitario_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //if (txtEstoque.Text.Equals("") || txtQuantidade.Text.Equals("") || txtDesconto.Text.Equals("") || TxtValorDesconto.Text.Equals("") || txtPrecoUnitario.Text.Equals("") || txtValorCompra.Text.Equals("")) return;
                CalcularPreco();
            }
            catch { }
        }

        #endregion

        #endregion

    }
}
