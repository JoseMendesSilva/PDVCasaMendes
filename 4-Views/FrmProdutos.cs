using CasaMendes.Classes.Estatica;
using CasaMendes.Classes.Geral;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CasaMendes
{
    public partial class FrmProdutos : Form
    {
        int LinhaIndex;
        bool editar;
        tProduto oProduto;
        FrmCadProduto cadProduto;

        #region Propriedades

        public string StatusLabel{ get; set; }

        #endregion

        public FrmProdutos()
        {
            InitializeComponent();
            LinhaIndex = -1;
            editar = false;
        }

        private void Botoes(bool b)
        {
            btnEditar.Enabled = !b;
            btnFechar.Enabled = b;
            btnExcluir.Enabled = !b;
            btnNovo.Enabled = b;
            btnAbrirListaDeesconto.Enabled = b;
        }

        private void Carregar()
        {
            oProduto = new tProduto();
            dgv.DataSource = oProduto.Todos();
            StatusLabel = (dgv.RowCount - 1).ToString();
        }

        #region Métodos auxiliares

        private void RedimencionarGrade()
        {
            try
            {

                if (dgv.Rows.Count > 0)
                {
                    for (int i = 0; i < dgv.Columns.Count; i++)
                    {
                        if ((dgv.Columns[i] == dgv.Columns["idProduto"]) || (dgv.Columns[i] == dgv.Columns["ValorCompra"]) || (dgv.Columns[i] == dgv.Columns["Quantidade"]) || (dgv.Columns[i] == dgv.Columns["CodigoDoFornecedor"]) || (dgv.Columns[i] == dgv.Columns["Foto"]) || (dgv.Columns[i] == dgv.Columns["CodigoDaNotaFiscal"]) || (dgv.Columns[i] == dgv.Columns["Key"]))
                        {
                            dgv.Columns[i].Visible = false;
                        }
                    }

                    dgv.RowHeadersVisible = false;

                    int amanhoDgv = dgv.Width - 22;

                    dgv.Columns["CodigoDeBarras"].HeaderText = "Cód Barras";
                    dgv.Columns["Nome"].HeaderText = "Produto";
                    dgv.Columns["DataDeValidade"].HeaderText = "D. Validade";
                    dgv.Columns["ValorCompra"].HeaderText = "V. Compra";
                    dgv.Columns["Estoque"].HeaderText = "Estoques";
                    dgv.Columns["PrecoUnitario"].HeaderText = "Valor unitário";
                    dgv.Columns["PrecoDeVenda"].HeaderText = "Valor venda";
                    dgv.Columns["Desconto"].HeaderText = "Qtd. Desc";
                    dgv.Columns["ValorDesconto"].HeaderText = "Valor desc";
                    dgv.Columns["created_at"].HeaderText = "Data cadastro";
                    dgv.Columns["updated_at"].HeaderText = "Atualizado";
                    dgv.Columns["deleted_at"].HeaderText = "Inativo";


                    dgv.Columns["CodigoDeBarras"].Width = clsGlobal.DimencionarColuna(8, this.Width);
                    dgv.Columns["Nome"].Width = clsGlobal.DimencionarColuna(21, this.Width);
                    dgv.Columns["DataDeValidade"].Width = clsGlobal.DimencionarColuna(10, this.Width);
                    dgv.Columns["ValorCompra"].Width = clsGlobal.DimencionarColuna(6, this.Width);
                    dgv.Columns["Estoque"].Width = clsGlobal.DimencionarColuna(6, this.Width);
                    dgv.Columns["PrecoUnitario"].Width = clsGlobal.DimencionarColuna(8, this.Width);
                    dgv.Columns["PrecoDeVenda"].Width = clsGlobal.DimencionarColuna(9, this.Width);
                    dgv.Columns["Desconto"].Width = clsGlobal.DimencionarColuna(6, this.Width);
                    dgv.Columns["ValorDesconto"].Width = clsGlobal.DimencionarColuna(6, this.Width);
                    dgv.Columns["created_at"].Width = clsGlobal.DimencionarColuna(6, this.Width);
                    dgv.Columns["updated_at"].Width = clsGlobal.DimencionarColuna(6, this.Width);
                    dgv.Columns["deleted_at"].Width = clsGlobal.DimencionarColuna(6, this.Width);

                }
            }
            catch
            {

            }
        }

        private void Gravar()
        {
            try
            {
                var oEstoque = new Estoque();
                //oEstoque.CriarTabela();
                oEstoque.EstoqueId = 0;
                oEstoque.ProdutoId = cadProduto.oProduto.idProduto;
                oEstoque.CodigoDeBarras = cadProduto.oProduto.CodigoDeBarras;
                oEstoque.Quantidade = cadProduto.oProduto.Quantidade;
                oEstoque.PrecoDeVenda = decimal.Parse(cadProduto.oProduto.PrecoDeVenda.ToString("N2"));
                oEstoque.QuantidadeParaDesconto = cadProduto.oProduto.Desconto;
                oEstoque.ValorDesconto = cadProduto.oProduto.ValorDesconto;

                //Verificando se o nome já existe no estoque e resgata o EstoqueId.
                var e = new Estoque();
                e.CodigoDeBarras = oEstoque.CodigoDeBarras;
                List<Estoque> l = e.Busca();
                if (l.Count > 0)
                {
                    oEstoque.EstoqueId = l[0].EstoqueId;
                    //oEstoque.Quantidade = l[0].Quantidade - 1;
                    //MessageBox.Show("ID: " + oEstoque.EstoqueId);
                }

                cadProduto.oProduto.Salvar();
                oEstoque.Salvar();
                Carregar();
                MessageBox.Show("O cadastro realizado com sucesso.");
            }catch (Exception ex)
            {
                MessageBox.Show("O cadastro não foi realizado com sucesso. Erro: " + ex.Message);
            }
        }

        private void Novo()
        {
            cadProduto = new FrmCadProduto();
            cadProduto.ShowDialog();
            if (cadProduto.DialogResult.Equals(DialogResult.OK)) Gravar();
            cadProduto.Dispose();
        }

        private void Editar()
        {
            if (editar.Equals(true) && LinhaIndex != -1)
            {
                cadProduto = new FrmCadProduto();
                cadProduto.oProduto = (tProduto)dgv.Rows[LinhaIndex].DataBoundItem;
                cadProduto.ShowDialog();
                if (cadProduto.DialogResult.Equals(DialogResult.OK)) Gravar();
                cadProduto.Dispose();
            }
        }

        private void Atualizar()
        {
            if (editar.Equals(true) && LinhaIndex != -1)
            {
                oProduto = (tProduto)dgv.Rows[LinhaIndex].DataBoundItem;

                FrmCadProduto fProduto = new FrmCadProduto();
                fProduto.BsProduto.Add(oProduto);
                fProduto.ShowDialog();
                if (fProduto.DialogResult.Equals(DialogResult.OK)) oProduto.Salvar();
                Carregar();
            }
        }

        private void Excluir()
        {
            try
            {
                if (editar.Equals(true) && LinhaIndex != -1)
                {
                    var oFornecedor = new tFornecedore();
                    oFornecedor = (tFornecedore)dgv.Rows[LinhaIndex].DataBoundItem;
                    oFornecedor.Excluir();
                    oFornecedor.Dispose();
                    Carregar();
                }
            }
            catch {; }
        }

        #endregion

        private void txtCodigoDeBarras_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.txtBusca.Text.Length > 0)
                {
                    this.txtBusca.Clear();
                }
                if (this.txtCodigoDeBarras.Text != "0") oProduto.CodigoDeBarras = txtCodigoDeBarras.Text;
                dgv.DataSource = oProduto.Busca();
            }
            catch { }
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.txtCodigoDeBarras.Text.Length > 0)
                {
                    this.txtCodigoDeBarras.Clear();
                }
                if (this.txtBusca.Text != "0") oProduto.Nome= txtBusca.Text;
                dgv.DataSource = oProduto.Busca();
            }
            catch { }
        }

        private void dgv_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.Rows.Count > 0)
            {
                LinhaIndex = e.RowIndex;
                editar = true;
                btnEditar.Enabled = editar;
                btnExcluir.Enabled = editar;
                return;
            }
            editar = false;
            btnEditar.Enabled = editar;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void FrmProdutos_Load(object sender, EventArgs e)
        {
            Botoes(true);
            Carregar();
            RedimencionarGrade();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
             cadProduto = new FrmCadProduto();
            cadProduto.ShowDialog();
            if (cadProduto.DialogResult.Equals(DialogResult.OK)) Gravar();
            cadProduto.Dispose();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (editar.Equals(true) && LinhaIndex != -1)
            {
                oProduto = (tProduto)dgv.Rows[LinhaIndex].DataBoundItem;
                oProduto.Excluir();
                Carregar();
            }
        }

    }
}
