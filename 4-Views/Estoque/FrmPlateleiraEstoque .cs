using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CasaMendes
{
    public partial class FrmAtualizarQuantValorEstoque : Form
    {
        #region Construtor
        public FrmAtualizarQuantValorEstoque()
        {
            InitializeComponent();
        }

        #endregion

        bool _achei { get; set; }
        private void BuscarProduto()
        {
            try
            {
                //using (
                //    var oProduto = new Produto();// { CodigoDeBarras = TxtBusca.Text }.BuscaBase())
                ////{

                //    if (oProduto.ProdutoId > 0)
                //    {
                //        _achei = true;

                //        if (!string.IsNullOrEmpty(TxtQuantidade.Text.Trim()))
                //        {
                //            oProduto.Quantidade = clsGlobal.DeStringParaInt(TxtQuantidade.Text.Trim());
                //        }
                //        if (!string.IsNullOrEmpty(TxtValor.Text.Trim()))
                //        {
                //            oProduto.PrecoDeVenda = clsGlobal.DeStringParaDecimal(TxtValor.Text.Trim());
                //        }

                //        string[] row = { oProduto.ProdutoId.ToString(), oProduto.FornecedorId.ToString(), oProduto.CodigoDeBarras.ToString(), oProduto.Nome.ToString(), oProduto.DataDeValidade.ToString(), oProduto.Quantidade.ToString(), oProduto.ValorCompra.ToString(), oProduto.PrecoUnitario.ToString(), oProduto.PrecoDeVenda.ToString(), oProduto.SubCategoriaId.ToString() };
                //        this.DgvProdutos.Rows.Add(row);

                //        if (DgvProdutos.Rows.Count > 0)
                //        {
                //            DgvProdutos.CurrentCell = DgvProdutos.Rows[DgvProdutos.Rows.Count - 1].Cells[8];
                //            label4.Text = DgvProdutos.Rows.Count.ToString();
                //        }
                //    }
                //    if (TxtBusca.Text.Length <= 14)
                //    {
                //        this.TxtBusca.Focus();
                //        return;
                //    }
                //    this.TxtBusca.Focus();
                //    this.TxtBusca.SelectAll();
                //}
            }
            catch
            {
            }
        }

        #region Click

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //if (DgvProdutos.Rows.Count > 0)
                //{
                //    string message = "Você deseja atualizar o estoque com os dados coletado?";
                //    string caption = Application.ProductName;
                //    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                //    DialogResult result = MessageBox.Show(this, message, caption, buttons);

                //    if (result == DialogResult.Yes)
                //    {

                //        var lista = new List<Estoque>();
                //        for (int i = 0; i < DgvProdutos.Rows.Count; i++)
                //        {
                //            lista.Add(new Estoque
                //            {
                //                EstoqueId = 0,
                //                ProdutoId = clsGlobal.DeStringParaInt(this.DgvProdutos.Rows[i].Cells["ProdutoId"].Value.ToString().Trim()),
                //                CodigoDeBarras = this.DgvProdutos.Rows[i].Cells["CodigoDeBarras"].Value.ToString().Trim(),
                //                Produto = this.DgvProdutos.Rows[i].Cells["Nome"].Value.ToString().Trim(),
                //                Quantidade = clsGlobal.DeStringParaInt(this.DgvProdutos.Rows[i].Cells["Quantidade"].Value.ToString().Trim()),
                //                PrecoDeVenda = clsGlobal.DeStringParaDecimal(this.DgvProdutos.Rows[i].Cells["PrecoDeVenda"].Value.ToString().Trim()),
                //                QuantidadeItemDesconto = 0,
                //                ValorDesconto = 0
                //            });
                //        }

                //        foreach (var item in lista)
                //        {
                //            //Verificando se o nome já existe no estoque e resgata o EstoqueId.
                //            //var eEstoque = await new Estoque
                //            //{
                //            //    CodigoDeBarras = item.CodigoDeBarras.Trim()
                //            //}.BuscaBase();

                //            //eEstoque.EstoqueId = 0;
                //            //eEstoque.ProdutoId = item.ProdutoId;
                //            //eEstoque.CodigoDeBarras = item.CodigoDeBarras.Trim();
                //            //eEstoque.Produto = item.Produto.Trim();
                //            //eEstoque.PrecoDeVenda = item.PrecoDeVenda;

                //            //if (eEstoque.EstoqueId > 0)
                //            //{
                //                //if (eEstoque.Quantidade > 0)
                //                //{
                //                //    eEstoque.Quantidade += item.Quantidade;
                //                //}
                //                //else
                //                //{
                //                //    eEstoque.Quantidade = item.Quantidade;
                //                //}
                //            //}

                //            //oEstoque.updated_at = DateTime.Now;
                //            //var rowsAffected = await eEstoque.Salvar();
                //            //eEstoque.Dispose();
                //        }
                //        MessageBox.Show($"O processo foi realizado com sucesso em {DgvProdutos.Rows.Count} itens.");
                //        DgvProdutos.Rows.Clear();
                //        this.Close();
                //    }
                //}
            }
            catch
            {
                MessageBox.Show("O cadastro não foi realizado com sucesso.");
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region TextoChanged

        private void TxtBusca_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _achei = false;
                Int32 tamanho = TxtBusca.Text.Length;
                string operador = "";
                { operador = TxtBusca.Text.Substring(tamanho - 1, 1).ToString(); }

                if (operador == "*" || operador == "x" || operador == "X")
                {
                    TxtQuantidade.Text = TxtBusca.Text.Substring(0, tamanho - 1);
                    this.TxtBusca.Text = "";
                    this.TxtBusca.Focus();
                    this.TxtBusca.SelectAll();
                    return;
                }
                else
                {
                    if (TxtBusca.Text.Length < 8)
                    { this.TxtBusca.Focus(); return; }
                }

                this.BuscarProduto();

                if (_achei)
                {
                    this.TxtBusca.Focus();
                    this.TxtBusca.SelectAll();
                }
            }
            catch
            {

            }
        }

        #endregion

        #region EstoqueLoad

        private void FrmAtualizarQuantValorEstoque_Load(object sender, EventArgs e)
        {
            this.Refresh();
        }

        #endregion

        private void FrmAtualizarQuantValorEstoque_Shown(object sender, EventArgs e)
        {

            DgvProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.TxtBusca.Focus();
            this.TxtBusca.SelectAll();
        }
    }
}
