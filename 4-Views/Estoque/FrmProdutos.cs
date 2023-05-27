using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CasaMendes
{
    public partial class FrmProdutos : Form
    {
        #region variáveis
        int LinhaIndex;
        bool editar;
        Produto oProduto;
        FrmCadProduto cadProduto;
        #endregion

        #region Propriedades

        public string StatusLabel{ get; set; }

        #endregion

        #region construtor
        public FrmProdutos()
        {
            InitializeComponent();
            LinhaIndex = -1;
            editar = false;
        }
        #endregion

        #region Métodos auxiliares
 
        private void Botoes(bool b)
        {
            BtnEditar.Enabled = !b;
            BtnFechar.Enabled = b;
            BtnExcluir.Enabled = !b;
            BtnNovo.Enabled = b;
            BtnAbrirListaDeesconto.Enabled = b;
        }

        private void Carregar()
        {
            oProduto = new Produto();
            DgvProdutos.DataSource = oProduto.Todos();
            StatusLabel = (DgvProdutos.RowCount - 1).ToString("N2");
        }

        private void RedimencionarGrade()
        {
            try
            {
                    DgvProdutos.RowHeadersVisible = false;

                    for (int i = 0; i < DgvProdutos.Columns.Count; i++)
                    {
                        if ((DgvProdutos.Columns[i] == DgvProdutos.Columns["ProdutoId"]) || (DgvProdutos.Columns[i] == DgvProdutos.Columns["ValorCompra"]) || (DgvProdutos.Columns[i] == DgvProdutos.Columns["Quantidade"]) || (DgvProdutos.Columns[i] == DgvProdutos.Columns["FornecedorId"]) || (DgvProdutos.Columns[i] == DgvProdutos.Columns["Foto"]) || (DgvProdutos.Columns[i] == DgvProdutos.Columns["Key"]))
                        {
                            DgvProdutos.Columns[i].Visible = false;
                        }
                    }

                    DgvProdutos.Columns["CodigoDeBarras"].HeaderText = "Cód Barras";
                    DgvProdutos.Columns["Nome"].HeaderText = "Produto";
                    DgvProdutos.Columns["DataDeValidade"].HeaderText = "D. Validade";
                    //DgvProdutos.Columns["ValorCompra"].HeaderText = "V. Compra";
                    //DgvProdutos.Columns["Estoque"].HeaderText = "Estoques";
                    DgvProdutos.Columns["PrecoUnitario"].HeaderText = "Valor unitário";
                    DgvProdutos.Columns["PrecoDeVenda"].HeaderText = "Valor venda";
                    //DgvProdutos.Columns["Desconto"].HeaderText = "Qtd. Desc";
                    //DgvProdutos.Columns["ValorDesconto"].HeaderText = "Valor desc";
                    DgvProdutos.Columns["created_at"].HeaderText = "Data cadastro";
                    DgvProdutos.Columns["updated_at"].HeaderText = "Atualizado";
                    DgvProdutos.Columns["deleted_at"].HeaderText = "Inativo";

                    DgvProdutos.Columns["CodigoDeBarras"].Width = clsGlobal.DimencionarColuna(10, this.Width);
                    DgvProdutos.Columns["Nome"].Width = clsGlobal.DimencionarColuna(21, this.Width);
                    DgvProdutos.Columns["DataDeValidade"].Width = clsGlobal.DimencionarColuna(10, this.Width);
                    //DgvProdutos.Columns["ValorCompra"].Width = clsGlobal.DimencionarColuna(6, this.Width);
                    //DgvProdutos.Columns["Estoque"].Width = clsGlobal.DimencionarColuna(6, this.Width);
                    DgvProdutos.Columns["PrecoUnitario"].Width = clsGlobal.DimencionarColuna(8, this.Width);
                    DgvProdutos.Columns["PrecoDeVenda"].Width = clsGlobal.DimencionarColuna(9, this.Width);
                    //DgvProdutos.Columns["Desconto"].Width = clsGlobal.DimencionarColuna(6, this.Width);
                    //DgvProdutos.Columns["ValorDesconto"].Width = clsGlobal.DimencionarColuna(6, this.Width);
                    DgvProdutos.Columns["created_at"].Width = clsGlobal.DimencionarColuna(6, this.Width);
                    DgvProdutos.Columns["updated_at"].Width = clsGlobal.DimencionarColuna(6, this.Width);
                    DgvProdutos.Columns["deleted_at"].Width = clsGlobal.DimencionarColuna(6, this.Width);

            }
            catch
            {

            }
        }

        private void Gravar()
        {
            try
            {
                cadProduto = new FrmCadProduto();

                if (editar.Equals(true) && LinhaIndex != -1)
                {
                   cadProduto.oProduto = (Produto)DgvProdutos.Rows[LinhaIndex].DataBoundItem;
                }

                cadProduto.ShowDialog();
                
                if( string.IsNullOrEmpty(cadProduto.oProduto.Nome) || 
                    string.IsNullOrEmpty(cadProduto.oProduto.FornecedorId.ToString()) || 
                    string.IsNullOrEmpty(cadProduto.oProduto.PrecoDeVenda.ToString()) || 
                    string.IsNullOrEmpty(cadProduto.oProduto.PrecoUnitario.ToString()) || 
                    string.IsNullOrEmpty(cadProduto.oProduto.Quantidade.ToString()) || 
                    string.IsNullOrEmpty(cadProduto.oProduto.ValorCompra.ToString()) || 
                    string.IsNullOrEmpty(cadProduto.oProduto.DataDeValidade.ToString()) ||
                    string.IsNullOrEmpty(cadProduto.oProduto.CodigoDeBarras.ToString())) {
                    MessageBox.Show("Todos os campos são obrigatorio."); 
                    return; 
                }

                if (cadProduto.DialogResult.Equals(DialogResult.OK))
                {
                    if (string.IsNullOrEmpty(cadProduto.TxtQuantidadeItemDesconto.Text)) cadProduto.TxtQuantidadeItemDesconto.Text = "0";
                    if (string.IsNullOrEmpty(cadProduto.TxtValorDesconto.Text)) cadProduto.TxtValorDesconto.Text = "0";

                    var oEstoque = new Estoque
                    {
                       EstoqueId = 0,
                        ProdutoId = cadProduto.oProduto.ProdutoId,
                        CodigoDeBarras = cadProduto.oProduto.CodigoDeBarras,
                        Quantidade = cadProduto.oProduto.Quantidade,
                        PrecoDeVenda = decimal.Parse(cadProduto.oProduto.PrecoDeVenda.ToString("N2")),
                        QuantidadeItemDesconto = int.Parse(cadProduto.TxtQuantidadeItemDesconto.Text),
                        ValorDesconto = decimal.Parse(cadProduto.TxtValorDesconto.Text)
                    };
                    //Verificando se o nome já existe no estoque e resgata o EstoqueId.
                    var e = new Estoque
                    {
                        CodigoDeBarras = oEstoque.CodigoDeBarras
                    };

                    List<Estoque> l = e.Busca();
                    if (l.Count > 0)
                    {
                        oEstoque.EstoqueId = l[0].EstoqueId;
                    }

                    cadProduto.oProduto.Salvar();
                    oEstoque.Salvar();
                    Carregar();
                    MessageBox.Show("O cadastro realizado com sucesso.");
                }
                else
                {
                    string msg = "O cadastro";
                    if (editar) { msg = "A edição"; }
                    MessageBox.Show($"{msg} foi cancelado(a).");
                }
            }
            catch 
            {
                MessageBox.Show("O cadastro não foi realizado com sucesso.");
            }

        }

        private void Novo()
        {
            editar = false;
            Gravar();
        }

        private void Excluir()
        {
            try
            {
                if (LinhaIndex != -1)
                {
                    oProduto = (Produto)DgvProdutos.Rows[LinhaIndex].DataBoundItem;
                    oProduto.Excluir();
                    Carregar();
                    MessageBox.Show($"O produro {oProduto.Nome} foi excluido com sucesso.");
                }
                else
                {
                    MessageBox.Show("Selecione um produto para excluir.");
                }
            }
            catch {; }
        }
 
        #endregion

        #region Eventos

        private void FrmProdutos_Load(object sender, EventArgs e)
        {
            Botoes(true);
            Carregar();
            RedimencionarGrade();
        }

        private void TxtCodigoDeBarras_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.TxtBusca.Text.Length > 0)
                {
                    this.TxtBusca.Clear();
                }
                if (this.TxtCodigoDeBarras.Text != "0") oProduto.CodigoDeBarras = TxtCodigoDeBarras.Text;
                DgvProdutos.DataSource = oProduto.Busca();
            }
            catch { }
        }

        private void TxtBusca_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.TxtCodigoDeBarras.Text.Length > 0)
                {
                    this.TxtCodigoDeBarras.Clear();
                }
                if (this.TxtBusca.Text != "0") oProduto.Nome= TxtBusca.Text;
                DgvProdutos.DataSource = oProduto.Busca();
            }
            catch { }
        }

        private void Dgv_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvProdutos.Rows.Count > 0)
            {
                LinhaIndex = e.RowIndex;
                editar = true;
                BtnEditar.Enabled = editar;
                BtnExcluir.Enabled = editar;
                return;
            }
            editar = false;
            BtnEditar.Enabled = editar;
        }

        #endregion

        #region Click

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Gravar();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            Excluir();
        }

        #endregion
    }
}
