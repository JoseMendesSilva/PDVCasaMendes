
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Reflection.Emit;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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
                var oProduto = new Produto();
                List<Produto> ResProduto = new List<Produto>();
                oProduto.CodigoDeBarras = TxtBusca.Text;
                ResProduto = oProduto.Busca();

                if (ResProduto.Count > 0)
                {
                    _achei = true;
                    oProduto = (Produto)ResProduto[0];
                    ResProduto = null;

                    if (!string.IsNullOrEmpty(TxtQuantidade.Text.Trim())) { 
                        oProduto.Quantidade = clsGlobal.DeStringParaInt(TxtQuantidade.Text.Trim()); 
                    }
                    if (!string.IsNullOrEmpty(TxtValor.Text.Trim())) {
                        oProduto.PrecoDeVenda = clsGlobal.DeStringParaDecimal(TxtValor.Text.Trim());
                    }

                    string[] row = { oProduto.ProdutoId.ToString(), oProduto.FornecedorId.ToString(), oProduto.CodigoDeBarras.ToString(), oProduto.Nome.ToString(), oProduto.DataDeValidade.ToString(), oProduto.Quantidade.ToString(), oProduto.ValorCompra.ToString(), oProduto.PrecoUnitario.ToString(), oProduto.PrecoDeVenda.ToString(), oProduto.SubCategoriaId.ToString() };
                    this.DgvProdutos.Rows.Add(row);

                    if (DgvProdutos.Rows.Count > 0)
                    {
                        DgvProdutos.CurrentCell = DgvProdutos.Rows[DgvProdutos.Rows.Count - 1].Cells[8];
                        label4.Text = DgvProdutos.Rows.Count.ToString();
                    }
                }
                if (TxtBusca.Text.Length < 13)
                {
                    this.TxtBusca.Focus();
                }
                else
                {
                    this.TxtBusca.Focus();
                    this.TxtBusca.SelectAll();
                }

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
                if (DgvProdutos.Rows.Count > 0)
                {
                    string message = "Você deseja atualizar o estoque com os dados coletado?";
                    string caption = Application.ProductName;
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(this, message, caption, buttons);

                    if (result == DialogResult.Yes)
                    {

                        for (int i = 0; i < DgvProdutos.Rows.Count; i++)
                        {
                            var oEstoque = new Estoque
                            {
                                EstoqueId = 0,
                                ProdutoId = clsGlobal.DeStringParaInt(this.DgvProdutos.Rows[i].Cells["ProdutoId"].Value.ToString().Trim()),
                                CodigoDeBarras = this.DgvProdutos.Rows[i].Cells["CodigoDeBarras"].Value.ToString().Trim(),
                                Produto = this.DgvProdutos.Rows[i].Cells["Nome"].Value.ToString().Trim(),
                                Quantidade = clsGlobal.DeStringParaInt(this.DgvProdutos.Rows[i].Cells["Quantidade"].Value.ToString().Trim()),
                                PrecoDeVenda = clsGlobal.DeStringParaDecimal(this.DgvProdutos.Rows[i].Cells["PrecoDeVenda"].Value.ToString().Trim()),
                                QuantidadeItemDesconto = 0,
                                ValorDesconto = 0
                            };

                            //Verificando se o nome já existe no estoque e resgata o EstoqueId.
                            var eEstoque = new Estoque
                            {
                                CodigoDeBarras = oEstoque.CodigoDeBarras.Trim()
                            };

                            var lEstoque = new List<Estoque>();
                            lEstoque = eEstoque.Busca();
                            if (lEstoque.Count > 0)
                            {
                                oEstoque.EstoqueId = lEstoque[0].EstoqueId;
                                oEstoque.Quantidade = oEstoque.Quantidade + lEstoque[0].Quantidade;
                            }

                            lEstoque = null;
                            eEstoque = null;

                            //oEstoque.updated_at = DateTime.Now;
                            oEstoque.Salvar();
                            oEstoque = null;
                        }
                        MessageBox.Show($"O processo foi realizado com sucesso em {DgvProdutos.Rows.Count} itens.");
                        DgvProdutos.Rows.Clear();
                        this.Close();
                    }
                }
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
            DgvProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.TxtBusca.Focus();
            this.TxtBusca.SelectAll();
        }

        #endregion

    }
}
