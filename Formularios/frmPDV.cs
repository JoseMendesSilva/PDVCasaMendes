using CasaMendes.Classes;
using CasaMendes.Classes.Geral;
using CasaMendes.Classes.Estatica;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace CasaMendes.Formularios
{
    public partial class FrmPDV : Form
    {

        #region Veriáveis

        bool Buscando = false;
        readonly string Funcionario = "José Mendes";//25
        int count = 1;

        #endregion

        public FrmPDV()
        {
            InitializeComponent();
            
            this.grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellClick);
            this.grid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grid_KeyDown);
            this.grid.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.grid_RowsRemoved);
            
            Opromocao = new ClsPromocao();

        }

        #region Instâncias

        public static Cl_FrenteDeCaixa FrenteDeCaixa = new Cl_FrenteDeCaixa();
        public ClsPromocao Opromocao;

        #endregion

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
            FrenteDeCaixa.TipoDeVenda = "A VISTA";
            lblCliente.Text = "Cliente: " + FrenteDeCaixa.TipoDeVenda;
            grid.Rows.Clear();
            lblOperador.Text = "Operador: " + this.Funcionario;
            lblTerminal.Text = "Terminal: " + 1;
        }

        private void BuscarProduto(string Filtro)
        {
            try
            {

                FrenteDeCaixa.Quantidade = decimal.Parse(this.txtQuantidade.Text);
                FrenteDeCaixa.BuscarExibirItem(Filtro);
                if (FrenteDeCaixa.Nome != "" && FrenteDeCaixa.Nome != null)
                {
                    string[] row = { count.ToString("G"), Filtro, FrenteDeCaixa.Nome, this.txtQuantidade.Text, FrenteDeCaixa.Valor.ToString("C2"), FrenteDeCaixa.SubTotal.ToString("C2") };
                    this.grid.Rows.Add(row);

                    this.txtUnitario.Text = FrenteDeCaixa.Valor.ToString("C2");
                    this.txtSubtotal.Text = FrenteDeCaixa.SubTotal.ToString("C2");
                    this.lblDescricaoProduto.Text = FrenteDeCaixa.Produto.ToString();

                    if (this.grid.Rows.Count > 0) { this.txtTotal.Text = clsGlobal.Calcular(grid, 5).ToString("C2"); }
                    if (int.Parse(this.txtQuantidade.Text) > 1) { this.txtQuantidade.Text = "1"; }
                    this.Buscando = false;

                    grid.CurrentCell = grid.Rows[grid.Rows.Count - 1].Cells[0];
                    count++;

                    lblStatusCaixa.Text = "CAIXA OCUPADO";


                    this.txtCodigo.Focus();
                    this.txtCodigo.SelectAll();
                }
                if (Filtro.Length < 14)
                {
                    this.txtCodigo.Focus();
                }
                else
                {
                    this.txtCodigo.Focus();
                    this.txtCodigo.SelectAll();
                }
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


                    if (FrenteDeCaixa.TipoDeVenda.Substring(0, 6) != "ANOTAR")
                    {

                        decimal totalAtual = Opromocao.De_String_Para_decimal(this.txtTotal.Text.Replace("R$ ", "").ToString());
                        decimal novoTotal = 0;

                        for (int i = 0; i <= counte - 1; i++)
                        {
                            //le o códido de barras na grade cupom
                            decimal CodigoDeBarras = Convert.ToDecimal(grid.Rows[i].Cells[1].Value.ToString());
                            novoTotal = totalAtual - ProcessarDescontos(CodigoDeBarras, i);
                            totalAtual = novoTotal;
                        }

                        frmFinlizarVendas finlizarVenda = new frmFinlizarVendas();

                        if (novoTotal > 0)
                            finlizarVenda.txtTotalGeral.Text = novoTotal.ToString("C2");
                        else
                            finlizarVenda.txtTotalGeral.Text = totalAtual.ToString("C2");

                        finlizarVenda.ShowDialog();
                        FrenteDeCaixa.Dinheiro = Convert.ToDecimal(finlizarVenda.txtDinheiro.Text.Replace("R$ ", ""));
                        FrenteDeCaixa.Troco = Convert.ToDecimal(finlizarVenda.txtTroco.Text.Replace("R$ ", ""));

                        if (finlizarVenda.CancelarVenda != string.Empty)
                        {
                            this.txtCodigo.Focus();
                            this.txtCodigo.SelectAll();
                            finlizarVenda.Dispose();
                            return;
                        }
                        else
                        {
                            finlizarVenda.Dispose();
                        }

                    }

                    for (int i = 0; i <= counte - 1; i++)
                    {
                        FrenteDeCaixa.CodigoDeBarras = Convert.ToDecimal(grid.Rows[i].Cells[1].Value.ToString());
                        FrenteDeCaixa.Nome = Convert.ToString(grid.Rows[i].Cells[2].Value);
                        FrenteDeCaixa.Quantidade = Convert.ToDecimal(grid.Rows[i].Cells[3].Value.ToString().Trim());
                        FrenteDeCaixa.Valor = Convert.ToDecimal(grid.Rows[i].Cells[4].Value.ToString().Replace("R$ ", ""));
                        FrenteDeCaixa.DescontoAplicado = ProcessarDescontos(FrenteDeCaixa.CodigoDeBarras, i);
                        FrenteDeCaixa.Gravar(Enumeradores.eAcao.Cadastrar);
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
            FrmBuscarCliente fc = new FrmBuscarCliente
            {
                Tag = "CaixaAberto"
            };

            FrenteDeCaixa.CodigoDoCliente = -1;
            fc.ShowDialog();

            if (FrenteDeCaixa.CodigoDoCliente != -1) lblCliente.Text = "Cliente: " + FrenteDeCaixa.Nome;

            if (FrenteDeCaixa.CodigoDoCliente != -1)
            {
                //Int32 conte = Convert.ToInt32(grid.Rows.Count);
                FrenteDeCaixa.TipoDeVenda = "ANOTAR";
                //E_ANOTAR = ", ID: " + FrenteDeCaixa.CodigoDoCliente + "." + Environment.NewLine + "Cliente: " + FrenteDeCaixa.Nome.ToString();
                //if (conte == 0) { GerarNumero(); return; }
            }
            else { FrenteDeCaixa.TipoDeVenda = "A VISTA"; }
            fc.Dispose();
            this.txtCodigo.Focus();
            this.txtCodigo.SelectAll();
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
                FrmBuscarParaVender ffc = new FrmBuscarParaVender
                {
                    Tag = 0
                };
                clsGlobal.TagForm = "";
                ffc.ShowDialog();
                this.BuscarProduto(ffc.cod);
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
            if (this.grid.Rows.Count > 0)
            {
                this.txtTotal.Text = clsGlobal.Calcular(grid, 5).ToString("C2");
            }
            else { Limpar(); }

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

                this.BuscarProduto(this.txtCodigo.Text);
            }
            catch
            {

            }
        }

        private void FrmPDV_Load(object sender, EventArgs e)
        {
            Limpar();

            if(Opromocao.Equals(null)) Opromocao = new ClsPromocao();
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
                lblDescricaoProduto.Text = grid.Rows[grid.CurrentRow.Index].Cells["Descricao"].Value.ToString().ToUpper();
                txtCodigo.Text = grid.Rows[grid.CurrentRow.Index].Cells["ProdutosId_"].Value.ToString();
                txtQuantidade.Text = grid.Rows[grid.CurrentRow.Index].Cells["Quantidade"].Value.ToString();
                txtUnitario.Text = grid.Rows[grid.CurrentRow.Index].Cells["ValorUnitario"].Value.ToString();
                txtSubtotal.Text = grid.Rows[grid.CurrentRow.Index].Cells["ValorTotal"].Value.ToString();
                txtTotal.Text = grid.Rows[grid.CurrentRow.Index].Cells["ValorTotal"].Value.ToString();
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
                MessageBox.Show("Erro ao cálcular o total do produto!\n\nDetalhe técnico:" + ex.Message, "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}


/*
 * Referência
 * https://docs.microsoft.com/pt-br/dotnet/api/system.xml.xmldocument?view=net-5.0#Find
 */
