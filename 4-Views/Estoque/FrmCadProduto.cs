using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CasaMendes
{
    public partial class FrmCadProduto : Form
    {

        #region var

        public BindingSource BsProduto;
        //public Produto oProduto;
        //private List<TabelaDeMargen> oListaDeMargen;

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
            //decimal temp;
            if (string.IsNullOrEmpty(TxtQuantidade.Text) || string.IsNullOrEmpty(TxtValorCompra.Text)) return;

            var valorUnitario = clsGlobal.DeStringParaDecimal(TxtValorCompra.Text) / clsGlobal.DeStringParaDecimal(TxtQuantidade.Text);
            //temp = clsGlobal.DeStringParaDecimal(TxtValorCompra.Text) / clsGlobal.DeStringParaDecimal(TxtQuantidade.Text);
            TxtPrecoUnitario.Text = valorUnitario.ToString("N2");
            valorUnitario = valorUnitario / ( 1 - (25.00m / 100));
            //temp = 1 - temp;
            //valorUnitario = valorUnitario / temp;
            TxtPrecoDeVenda.Text = valorUnitario.ToString("N2");

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

        private bool Gravar()
        {
            try
            {
                using (var dados = new Dados())
                {
                    var rowsAffected = dados.Insert(oProduto);

                    ////Verificando se o nome já existe no estoque e resgata o EstoqueId.
                    //var existeEstoque = await new Estoque
                    //{
                    //    CodigoDeBarras = oProduto.CodigoDeBarras
                    //}.BuscaBase();/*-- Inserir registros na tabela Pedidos, caso não existam para o grupo `created_at` em PreVendas

                    /*
                   * INSERT INTO Pedidos(ClienteID, DataPedido, Total)
                   * SELECT DISTINCT 
                   * NULL AS ClienteID, 
                   * PV.created_at AS DataPedido, 
                   * 0 AS Total --Pode ser calculado posteriormente 
                   * FROM PreVendas PV 
                   * WHERE NOT EXISTS( SELECT 1 FROM Pedidos P 
                   * WHERE P.DataPedido = PV.created_at ); 
                   */

                    /*
                     * IF NOT EXISTS (SELECT 1 FROM Estoque WHERE CodigoBarras = @CodigoBarras) 
                     * BEGIN 
                     * INSERT INTO Estoque (CodigoBarras, NomeProduto, Quantidade, Preco) 
                     * VALUES (@CodigoBarras, @NomeProduto, @Quantidade, @Preco); 
                     * PRINT 'Produto inserido com sucesso.'; 
                     * END 
                     * ELSE 
                     * BEGIN 
                     * PRINT 'Produto com este código de barras já existe no estoque.'; 
                     * END
                     */

                    //var sql = "-- Inserir registros na tabela Pedidos, caso não existam para o grupo `created_at` em PreVendas\r\nINSERT INTO Pedidos (ClienteID, DataPedido, Total)\r\nSELECT DISTINCT\r\n    NULL AS ClienteID,\r\n    PV.created_at AS DataPedido,\r\n    0 AS Total -- Pode ser calculado posteriormente\r\nFROM PreVendas PV\r\nWHERE NOT EXISTS (\r\n    SELECT 1\r\n    FROM Pedidos P\r\n    WHERE P.DataPedido = PV.created_at\r\n);"

                    //var op = dados.Select<Produto>($"select top 1 * from Produtos where  CodigoDeBarras = '{existeEstoque.CodigoDeBarras}' order by ProdutoId desc");

                    //if (existeEstoque.EstoqueId > 0)
                    //    if (op.Count > 0)
                    //        existeEstoque.EstoqueId = op[0].ProdutoId;
                   //// if (rowsAffected > 0)
                   //// {
                   ////     var novoEstoque = new Estoque
                   ////     {
                   ////         //EstoqueId = existeEstoque.EstoqueId > 0 ? existeEstoque.EstoqueId : 0,
                   ////         ProdutoId = oProduto.ProdutoId,
                   ////         Produto = oProduto.Nome,
                   ////         CodigoDeBarras = oProduto.CodigoDeBarras,
                   ////         Quantidade = oProduto.Quantidade,
                   ////         PrecoDeVenda = oProduto.PrecoDeVenda,
                   ////         QuantidadeItemDesconto = clsGlobal.DeStringParaInt(TxtQuantidadeItemDesconto.Text),
                   ////         ValorDesconto = decimal.Parse(TxtValorDesconto.Text),
                   ////     };

                   ////     var existe = dados.Select<Estoque>($"select * from Estoques where CodigoDeBarras = {oProduto.CodigoDeBarras}");
                   ////    if(existe.Count > 0) {
                   ////         novoEstoque = existe.First();
                   ////         novoEstoque.Produto = oProduto.Nome;
                   ////         novoEstoque.CodigoDeBarras = oProduto.CodigoDeBarras;
                   ////         novoEstoque.Quantidade = oProduto.Quantidade;
                   ////         novoEstoque.PrecoDeVenda = oProduto.PrecoDeVenda;
                   ////         novoEstoque.QuantidadeItemDesconto = clsGlobal.DeStringParaInt(TxtQuantidadeItemDesconto.Text);
                   ////         novoEstoque.ValorDesconto = decimal.Parse(TxtValorDesconto.Text);
                   ////         dados.Update(novoEstoque);
                   ////} else
                   ////     {
                   ////         dados.InsertSeNaoExistir(novoEstoque, oProduto.CodigoDeBarras);
                   ////     }
                   //// }
                    return true;//rowAffected > 0;
                }
            }
            catch
            {
                return false;
            }

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
                //oProduto.Foto = clsGlobal.BuscarFotoProduto();
                //PicFoto.Image = Image.FromFile(clsGlobal.AbrirImagem(oProduto.Foto));
            }
            catch { }
        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                //oProduto.PrecoDeVenda = clsGlobal.DeStringParaDecimal(TxtPrecoDeVenda.Text);
                //oProduto.PrecoUnitario = clsGlobal.DeStringParaDecimal(TxtPrecoUnitario.Text);

                //if (string.IsNullOrEmpty(oProduto.Nome) ||
                //string.IsNullOrEmpty(oProduto.FornecedorId.ToString()) ||
                //string.IsNullOrEmpty(oProduto.SubCategoriaId.ToString()) ||
                //string.IsNullOrEmpty(oProduto.PrecoDeVenda.ToString()) ||
                //string.IsNullOrEmpty(oProduto.PrecoUnitario.ToString()) ||
                //string.IsNullOrEmpty(oProduto.Quantidade.ToString()) ||
                //string.IsNullOrEmpty(oProduto.ValorCompra.ToString()) ||
                //string.IsNullOrEmpty(oProduto.DataDeValidade.ToString()) ||
                //string.IsNullOrEmpty(oProduto.CodigoDeBarras.ToString()))
                //{
                //    MessageBox.Show("Todos os campos são obrigatorio.");
                //    return;
                //}

                //if (string.IsNullOrEmpty(TxtQuantidadeItemDesconto.Text))
                //    TxtQuantidadeItemDesconto.Text = "0";
                //if (string.IsNullOrEmpty(TxtValorDesconto.Text))
                //    TxtValorDesconto.Text = "0,00";

                //if (this.Gravar())
                //{
                //    MessageBox.Show("Processo realisado com sucesso.");
                //    this.Close();
                //}
                //else
                //    MessageBox.Show("Processo não foi realisado com sucesso.");
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
            this.Refresh();
        }

        #endregion

        #region SelectedIndexChanged

        private void cbFornecedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //var oFornecedor = new Fornecedore();
                
                //    oFornecedor.RazaoSocial = CbFornecedores.Text;
                //    var codigo = await oFornecedor.BuscaBase();
                //    TxtCodigoDoFornecedor.Text = codigo.FornecedorId.ToString();
                
            }
            catch { }
        }

        private void CbSubcategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //var oSubCategoria = await new SubCategoria
                //{
                //    Nome = CbSubcategoria.Text
                //}.BuscaBase();

                //TxtSubCategoriaId.Text = oSubCategoria.SubCategoriaId.ToString();
                //oSubCategoria.Dispose();

                //using (var oTabelaDeMargen = new TabelaDeMargen())
                //{
                //    oTabelaDeMargen.SubCategoriaId = oSubCategoria.SubCategoriaId;
                //    oListaDeMargen = await oTabelaDeMargen.Busca();
                //    CalcularPreco();
                //}
            }
            catch { }
        }

        #endregion

        #region TextChanged

        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //int quant = clsGlobal.DeStringParaInt(TxtQuantidade.Text);
                //oProduto.Quantidade = quant;
                //CalcularPreco();
            }
            catch { }
        }

        private void txtPrecoUnitario_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //int quant = clsGlobal.DeStringParaInt(TxtQuantidade.Text);
                //oProduto.Quantidade = quant;
                //CalcularPreco();
            }
            catch { }
        }

        #endregion

        #endregion

        private void TxtPrecoDeVenda_Leave(object sender, EventArgs e)
        {
            try
            {
                //oProduto.PrecoDeVenda = clsGlobal.DeStringParaDecimal(TxtPrecoDeVenda.Text); ;
                //TxtPrecoDeVenda.Text = oProduto.PrecoDeVenda.ToString();
            }
            catch { }
        }

        private void FrmCadProduto_Shown(object sender, EventArgs e)
        {
            try
            {
                //this.Refresh();
                //Botoes(true);
                //bool status = true;

                //if (oProduto == null)
                //    oProduto = new Produto();
                //if (BsProduto == null)
                //    BsProduto = new BindingSource { new Produto() };
                //if (oListaDeMargen == null)
                //    oListaDeMargen = new List<TabelaDeMargen>();

                //if (oProduto.ProdutoId.Equals(0)) BsProduto.Add(oProduto);
                //BsProduto.DataSource = oProduto;
                //VincularBindingSource();

                //using (var dados = new Dados())
                //{
                //    CbFornecedores.DisplayMember = "RazaoSocial";
                //    CbFornecedores.DataSource = dados.Select<Fornecedore>("select * from fornecedores");

                //    if (CbFornecedores.Items.Count < 1)
                //    {
                //        MessageBox.Show("Eornecedor não cadastrado.");
                //        status = false;
                //    }

                //    CbSubcategoria.DisplayMember = "Nome";
                //    CbSubcategoria.DataSource = dados.Select<SubCategoria>("select * from subcategorias");  //SubCategoria;

                //    if (CbSubcategoria.Items.Count < 1)
                //    {
                //        MessageBox.Show("Subcategoria não cadastrada.");
                //        status = false;
                //    }
                //}
                //    PicFoto.Image = Properties.Resources.CasaMendes1Jpg;

                //if (!status)
                //{
                //    BtnGravar.Enabled = false;
                //    BtnFechar.Enabled = true;
                //}
            }
            catch { }
        }
 
    }
}
