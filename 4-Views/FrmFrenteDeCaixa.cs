using CasaMendes.Classes.Estatica;
using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace CasaMendes
{
    public partial class FrmFrenteDeCaixa : Form
    {

        #region Veriáveis

        private bool Buscando = false;
        private readonly string Funcionario = "José Mendes";//25
        private int count = 1;
        private PreVenda oPreVenda;
        private ClsPromocao Opromocao;

        #endregion

        public FrmFrenteDeCaixa()
        {
            InitializeComponent();

            this.grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellClick);
            this.grid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grid_KeyDown);
            this.grid.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.grid_RowsRemoved);

            Opromocao = new ClsPromocao();

        }

        #region Vendas

        private Boolean CancelarVendaAtual()
        {
            DialogResult resposta = (MessageBox.Show("Você deseja cancelar a venda em andamento?",
                                   Application.ProductName,
                                   MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question));
            return (resposta == DialogResult.Yes ? true : false);
        }

        private void Limpar()
        {
            txtCodigo.Clear();
            txtQuantidade.Text = "1";
            txtUnitario.Text = "0,00";
            txtSubtotal.Text = "0,00";
            txtTotal.Text = "0,00";
            txtLancarValor.Text = "0,00";

            count = 1;

            lblStatusCaixa.Text = "CAIXA DISPONÍVEL";
            lblDescricaoProduto.Text = "CAIXA LIVRE";

            oPreVenda.ClienteId = 0;
            oPreVenda.Produto = string.Empty;
            oPreVenda.Quantidade = 0;
            oPreVenda.PrecoDeVenda = 0;
            oPreVenda.NumeroDaVenda = 0;
            oPreVenda.TipoDeVenda = "A VISTA";// pendura, pg, debito, crédito e pix.
            oPreVenda.Valor = 0;
            oPreVenda.Dinheiro = 0;
            oPreVenda.Troco = 0;
            oPreVenda.Parcela = 0;

            lblCliente.Text = "Cliente: " + oPreVenda.TipoDeVenda;

            grid.Rows.Clear();
            lblOperador.Text = "Operador: " + this.Funcionario;
            lblTerminal.Text = "Terminal: " + 1;

            //string[] row = { "", "", "", "", "", "", "", "", "" };
            //this.grid.Rows.Add(row);

        }

        private void BuscarProduto()
        {
            try
            {

                if (txtCodigo.Text.Length < 8) return;
                if (oPreVenda.NumeroDaVenda == 0) { GerarNumero(); }
                //Quantidade = decimal.Parse(this.txtQuantidade.Text);

                var oEstoque = new Estoque();
                var oProduto = new tProduto();

                List<Estoque> ResEstoque = new List<Estoque>();
                List<tProduto> ResProduto = new List<tProduto>();

                oEstoque.CodigoDeBarras = txtCodigo.Text;

                ResEstoque = oEstoque.Busca();
                oProduto.idProduto = ResEstoque[0].ProdutoId;

                ResProduto = oProduto.Busca();

                ResEstoque[0].Produto = ResProduto[0].Nome;

                oProduto = null;
                ResProduto = null;

                if (ResEstoque[0].Produto != "" && ResEstoque[0].Produto != null)
                {
                    string[] row = { oPreVenda.ClienteId.ToString(), oPreVenda.NumeroDaVenda.ToString(), oPreVenda.TipoDeVenda.ToString(), count.ToString("G"), ResEstoque[0].CodigoDeBarras, ResEstoque[0].Produto, this.txtQuantidade.Text, ResEstoque[0].PrecoDeVenda.ToString("N2"), (int.Parse(txtQuantidade.Text) * ResEstoque[0].PrecoDeVenda).ToString("N2") };
                    this.grid.Rows.Add(row);

                    this.txtUnitario.Text = decimal.Parse(ResEstoque[0].PrecoDeVenda.ToString()).ToString();
                    this.txtSubtotal.Text = (int.Parse(txtQuantidade.Text) * ResEstoque[0].PrecoDeVenda).ToString("C2");
                    this.lblDescricaoProduto.Text = ResEstoque[0].Produto.ToString();

                    if (this.grid.Rows.Count > 0) { this.txtTotal.Text = clsGlobal.Calcular(grid, 8).ToString("C2"); }
                    if (int.Parse(this.txtQuantidade.Text) > 1) { this.txtQuantidade.Text = "1"; }
                    this.Buscando = false;

                    grid.CurrentCell = grid.Rows[grid.Rows.Count - 1].Cells[0];
                    count++;

                    lblStatusCaixa.Text = "CAIXA OCUPADO";


                    this.txtCodigo.Focus();
                    this.txtCodigo.SelectAll();
                }

                oEstoque = null;
                ResEstoque = null;

            }
            catch
            {
            }
        }

        private decimal ProcessarDescontos(decimal CodigoDeBarras, Int32 i)
        {
            decimal descontar = 0;
            //verifica se o código de barras existe na lista e promoção
            if ((Opromocao.Dicionario_de_Promocao.ContainsKey(CodigoDeBarras.ToString().Trim())))
            {
                //le a quantidade e produto na grade cupom
                decimal quantidade = Opromocao.De_String_Para_decimal(grid.Rows[i].Cells[3].Value.ToString().Trim());

                //converte para decimal a porcentagem de desconto o dicionário promoção
                decimal quantidade_desconto = Opromocao.De_String_Para_decimal(Opromocao.Dicionario_de_Promocao[CodigoDeBarras.ToString().Trim()].QuantidadeMinimaParaDesconto.ToString());

                //le a quantidade de itens vendidos na grade cupom
                decimal valor_desconto = Opromocao.De_String_Para_decimal(Opromocao.Dicionario_de_Promocao[CodigoDeBarras.ToString()].ValorDesconto.ToString());

                if (quantidade >= quantidade_desconto)
                {
                    descontar = (valor_desconto / quantidade_desconto) * quantidade;
                }
                else
                {
                    descontar = 0;
                }

            }

            return descontar;
        }

        private void FinalizarVenda()
        {
            try
            {

                int contar = this.grid.Rows.Count;
                int counte = contar;
                if (counte > 0)
                {


                    if (oPreVenda.TipoDeVenda != "PENDURA")
                    {
                        oPreVenda.Valor = decimal.Parse(this.txtTotal.Text.Replace("R$ ", "").ToString()); // Opromocao.De_String_Para_decimal(this.txtTotal.Text.Replace("R$ ", "").ToString());
                        frmFinlizarVendas oFinlizarVenda = new frmFinlizarVendas();
                        oFinlizarVenda.txtTotalGeral.Text = oPreVenda.Valor.ToString("N2");
                        oFinlizarVenda.ShowDialog();
                        oPreVenda.Dinheiro = Convert.ToDecimal(oFinlizarVenda.txtDinheiro.Text.Replace("R$ ", ""));
                        oPreVenda.Troco = Convert.ToDecimal(oFinlizarVenda.txtTroco.Text.Replace("R$ ", ""));
                        if (oFinlizarVenda.CancelarVenda != string.Empty)
                        {
                            this.txtCodigo.Focus();
                            this.txtCodigo.SelectAll();
                            oFinlizarVenda.Dispose();
                            return;
                        }
                        else
                        {
                            oFinlizarVenda.Dispose();
                        }

                    }

                    for (int i = 0; i <= counte - 1; i++)
                    {
                        oPreVenda.ClienteId = int.Parse(grid.Rows[i].Cells[0].Value.ToString());
                        oPreVenda.NumeroDaVenda = int.Parse(grid.Rows[i].Cells[1].Value.ToString());
                        oPreVenda.TipoDeVenda = grid.Rows[i].Cells[2].Value.ToString();
                        oPreVenda.Produto = grid.Rows[i].Cells[5].Value.ToString();
                        oPreVenda.Quantidade = int.Parse(grid.Rows[i].Cells[6].Value.ToString().Trim());
                        oPreVenda.PrecoDeVenda = decimal.Parse(grid.Rows[i].Cells[7].Value.ToString().Replace("R$ ", ""));
                        oPreVenda.Valor = decimal.Parse(grid.Rows[i].Cells[8].Value.ToString().Replace("R$ ", ""));
                        oPreVenda.Salvar();
                    }
                    Limpar();
                }


            }
            catch// (Exception ex)
            {
                // MessageBox.Show(ex.Message);
            }

        }

        private void SelecionarCliente()
        {
            FrmBuscarCliente fc = new FrmBuscarCliente();

            fc.ShowDialog();

            if (fc.DialogResult.Equals(DialogResult.OK))
            {
                oPreVenda.ClienteId = fc.ClienteId;
                this.Text = fc.Cliente;
                lblCliente.Text = "Cliente: " + fc.Cliente;
                oPreVenda.TipoDeVenda = "PENDURA";
                Int32 conte = Convert.ToInt32(grid.Rows.Count);
                //E_ANOTAR = ", ID: " + IdCliente + "." + Environment.NewLine + "Cliente: " + Cliente;
                if (conte == 0 || oPreVenda.NumeroDaVenda == 0) { GerarNumero(); return; }

                for (int i = 0; i< grid.Rows.Count; i++)
                {
                    grid.Rows[i].Cells[0].Value = oPreVenda.ClienteId;
                    grid.Rows[i].Cells[1].Value = oPreVenda.NumeroDaVenda;
                    grid.Rows[i].Cells[2].Value = oPreVenda.TipoDeVenda;
                }

            }
            else { oPreVenda.TipoDeVenda = "A VISTA"; }
            fc.Dispose();
            this.txtCodigo.Focus();
            this.txtCodigo.SelectAll();
        }

        private void GerarNumero()
        {
            var rnd = new Random();
            int Numero = int.Parse(string.Concat( DateTime.Now.Day, DateTime.Now.Month,+ DateTime.Now.Year, rnd.Next(0, 9)).ToString());
            oPreVenda.NumeroDaVenda = Numero;
        }

        #endregion

        #region Evento Key

        private void MenuKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Não implementado.
            }
            else if (e.KeyCode == Keys.Escape)
            {
                if (this.grid.Rows.Count > 0)
                {
                    if (this.CancelarVendaAtual())
                    {
                        this.Close();
                    }
                    else
                    {
                        this.txtCodigo.Focus();
                        this.txtCodigo.SelectAll();
                        e.Handled = false;
                        return;
                    }
                }
                else { this.Close(); }
            }
            else if (e.KeyCode == Keys.F1)
            {
                //Ajuda não implementada.
            }
            else if (e.KeyCode == Keys.F2)
            {
                //Cancela a venda e prepara o formulário para uma nva venda.
                if (this.CancelarVendaAtual()) { this.Limpar(); }
                else { this.txtCodigo.Focus(); this.txtCodigo.SelectAll(); return; }

            }
            else if (e.KeyCode == Keys.F3)
            {
                //Finaliza a venda em andamento.
                FinalizarVenda();
            }
            else if (e.KeyCode == Keys.F4)
            {
                /*
                 * Coloca o focu no dgvBoleto para a exclusão de itens só na grade, 
                 * pois, o produto não foi baixado do estoque ainda. Esta baixa só 
                 * será realiada se a venda for finalizada.
                */
                grid.Focus();
            }
            else if (e.KeyCode == Keys.F5)
            {
            }
            else if (e.KeyCode == Keys.F6)
            {

            }
            else if (e.KeyCode == Keys.F7)
            {
                //apresenta o formulário selecionar clientes no aso de venda para anotar.
                SelecionarCliente();
            }
            else if (e.KeyCode == Keys.F8)
            {
                //Receber anotado.
                frmCarregarVenda f = new frmCarregarVenda();
                f.ShowDialog();
                f.Dispose();
            }
            else if (e.KeyCode == Keys.F9)
            {
                //Abre o formulário para a pesquisa de produos.
                FrmEstoque ffc = new FrmEstoque();
                ffc.ShowDialog();
                if (ffc.DialogResult.Equals(DialogResult.OK))
                {
                    txtCodigo.Text = ffc.CodigoProduto;
                }
                else
                {
                    txtCodigo.Focus();
                    txtCodigo.SelectAll();
                }
                ffc.Dispose();
            }
            else if (e.Control && e.KeyCode == Keys.Q)
            {
                txtQuantidade.ReadOnly = false;
                txtQuantidade.SelectAll();
                txtQuantidade.Focus();
            }
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            MenuKeyDown(e);
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = clsGlobal.SomenteNumeros(e);
        }

        private void txtQuantidade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Q || e.KeyCode == Keys.Enter)
            {
                txtCodigo.SelectAll();
                txtCodigo.Focus();
            }
        }

        private void grid_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {
                    if (this.grid.SelectedRows.Count > 0)
                    {
                        grid.Rows.RemoveAt(this.grid.SelectedRows[0].Index);

                    }
                }
            }
            catch { }
        }

        private void grid_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            //if (this.grid.Rows.Count > 0)
            //{
            //    this.txtTotal.Text = clsGlobal.Calcular(grid, 5).ToString("C2");
            //}
            //else { Limpar(); }

            txtCodigo.Focus();
            txtCodigo.SelectAll();
        }

        #endregion

        #region Eventos

        private void TxtCodigo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Int32 tamanho = txtCodigo.Text.Length;
                string operador = "";
                if (this.Buscando == false)
                { operador = txtCodigo.Text.Substring(tamanho - 1, 1).ToString(); }

                if (operador == "*" || operador == "x" || operador == "X")
                {
                    this.Buscando = true;
                    txtQuantidade.Text = txtCodigo.Text.Substring(0, tamanho - 1);
                    this.txtCodigo.Text = "";
                    this.txtCodigo.Focus();
                    this.txtCodigo.SelectAll();
                    return;
                }
                else
                {
                    Buscando = false;
                    if (txtCodigo.Text.Length < 4)
                    { this.txtCodigo.Focus(); return; }
                }

                this.BuscarProduto();
            }
            catch
            {

            }
        }

        private void FrmPDV_Load(object sender, EventArgs e)
        {
            if(oPreVenda==null) oPreVenda = new PreVenda();
            //oPreVenda.CriarTabela();
            Limpar();

            if (Opromocao.Equals(null)) Opromocao = new ClsPromocao();
            if (Opromocao.LeituraXML() == "o arquivo nao existe")
            {
                FrmPromocao fp = new FrmPromocao();
                fp.Show();
                fp.Visible = false;
                fp.GerarDescontos();
                fp.Close();
                string s = Opromocao.LeituraXML();
            }
            txtCodigo.Select();
            txtCodigo.Focus();
        }

        private void FrmPDV_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                if (!Opromocao.Equals(null)) Opromocao = null;
                GC.Collect();
            }
            catch { }
        }

        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grid.Rows.Count > 0)
            {
                txtCodigo.Text = grid.Rows[grid.CurrentRow.Index].Cells["ProdutosId_"].Value.ToString();
                BuscarProduto();
                txtCodigo.Select();
                txtCodigo.Focus();
            }
        }

        private void TxtQuantidade_Enter(object sender, EventArgs e)
        {
            if (txtQuantidade.Text.Length > 0)
            {
                txtQuantidade.SelectAll();
                txtQuantidade.Focus();
            }
            else { txtQuantidade.Focus(); }
        }

        private void TxtQuantidade_Leave(object sender, EventArgs e)
        {
            try
            {
                txtQuantidade.ReadOnly = true;
                txtCodigo.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cálcular o total do produto! Detalhe técnico:" + ex.Message, "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}

// PreVendaId
// ClienteId
// Produto
// Quantidade
// PrecoDeVenda
// NumeroDaVenda
// TipoDeVenda // pendura, pg, debito, crédito e pix.
// Valor
// Dinheiro
// Troco
// Parcela