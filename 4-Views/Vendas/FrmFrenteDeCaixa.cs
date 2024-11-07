using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.ComponentModel;
//using CasaMendes._2_Models.Vendas;


namespace CasaMendes
{
    public partial class FrmFrenteDeCaixa : Form
    {

        private string NumeroPedido { get; set; } = string.Empty;

        #region Veriáveis

        //public Funcionario oFuncionario;

        private bool Buscando = false;
        private int Id = 0;
        private int count = 1;
        //private PreVenda oPreVenda;
        //private List<Pagamento> pagamentos = null;

#endregion

        private Timer _typingTimer;
        public FrmFrenteDeCaixa()
        {
            InitializeComponent();

            //oFuncionario = new Funcionario();

            // Configuração do timer
            //_typingTimer = new Timer();
            //_typingTimer.Interval = 800; // 500 milissegundos
            //_typingTimer.Tick += TypingTimer_Tick;

            // Evento TextChanged do TextBox
            //TxtCodigo.TextChanged += TxtCodigo_TextChanged1;

            this.backgroundWorker1.DoWork += new DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);

        }

        #region Metodos

        private void Limpar()
        {
            TxtCodigo.Clear();
            TxtQuantidade.Text = "1";
            TxtUnitario.Text = "0,00";
            TxtSubTotal.Text = "0,00";
            TxtTotal.Text = "0,00";
            TxtLancarValor.Text = "0,00";

            count = 1;

            lblStatusCaixa.Text = "CAIXA DISPONÍVEL";
            lblDescricaoProduto.Text = "CAIXA LIVRE";

            ////oPreVenda.ClienteId = 0;
            //oPreVenda.Produto = string.Empty;
            //oPreVenda.Quantidade = 0;
            //oPreVenda.PrecoDeVenda = 0;
            //oPreVenda.NumeroDaVenda = "0";
            //oPreVenda.TipoDeVenda = "A VISTA";// pendura, pg, debito, crédito e pix.
            //oPreVenda.Valor = 0;
            //oPreVenda.Dinheiro = 0;
            //oPreVenda.Troco = 0;
            //oPreVenda.Parcela = 0;
            //oPreVenda.Tributos = 0;
            //oPreVenda.Juros = 0;

            grid.Rows.Clear();

            lblOperador.Text = "Operador: " + this.oFuncionario.Nome;
            lblTerminal.Text = "Terminal: " + 1;
            this.PicLogoTipo.Image = Properties.Resources.CasaMendes1Jpg;
        }

        public void CarregarPendura(int ClienteId, string TipoDeVenda)
        {

            try
            {
                //Buscando = true;

                //this.oPreVenda.ClienteId = ClienteId;
                //this.oPreVenda.TipoDeVenda = TipoDeVenda;

                //this.oPreVenda.NumeroDaVenda = null;

                //var ListaPreVenda = new List<PreVenda>();
                //using (var dados = new Dados())
                //{
                //    dados.ClauseCampo = "TipoDeVenda";
                //    dados.ClauseCampo = oPreVenda.TipoDeVenda.ToString().ToUpper();
                //    //var result = await dados.Select<EstoqueBusca>($"SELECT EstoqueId, ProdutoId, CodigoDeBarras, Produto, Quantidade, PrecoDeVenda, created_at, updated_at, deleted_at, convert(decimal(18, 2), PrecoDeVenda), ({this.TxtQuantidade.Text}) * convert(decimal(8,2), PrecoDeVenda) as SubTotal, QuantidadeItemDesconto, ValorDesconto FROM Estoques where deleted_at = '' and CodigoDeBarras = '{filtro}';");
                //    ListaPreVenda = dados.Select<PreVenda>($"select * from PreVendas where TipoDeVenda = '{oPreVenda.TipoDeVenda.ToString().ToUpper()}' and ClienteId = {this.oPreVenda.ClienteId};");
                //}

                //if (ListaPreVenda.Count > 0)
                //{
                //    //GerarNumero();
                //    lblStatusCaixa.Text = "CAIXA OCUPADO";

                //    for (int i = 0; i < ListaPreVenda.Count; i++)
                //    {
                //        this.oPreVenda = (PreVenda)ListaPreVenda[i];
                //        if (this.oPreVenda.Produto != "" && oPreVenda.Produto != null)
                //        {
                //            string[] row = { "0", this.oPreVenda.ClienteId.ToString(), this.oPreVenda.NumeroDaVenda.ToString(), this.oPreVenda.TipoDeVenda.ToString(), this.oPreVenda.Desconto.ToString(), this.oPreVenda.Tributos.ToString(), this.oPreVenda.Juros.ToString(), string.Format("{0,4:#0000}", count), this.oPreVenda.PreVendaId.ToString(), this.oPreVenda.Produto, this.oPreVenda.Quantidade.ToString(), this.oPreVenda.PrecoDeVenda.ToString("N2"), this.oPreVenda.Valor.ToString("N2"), this.oPreVenda.PreVendaId.ToString() };
                //            this.grid.Rows.Add(row);
                //            count++;
                //        }
                //    }

                //    decimal total = clsGlobal.Calcular(grid, 11) - oPreVenda.Parcela;
                //    this.TxtTotal.Text = total.ToString("N2");

                //    if (grid.Rows.Count > 0)
                //    {
                //        grid.CurrentCell = grid.Rows[grid.Rows.Count - 1].Cells[8];
                //    }

                //    Buscando = false;
                //    this.TxtCodigo.Focus();
                //    this.TxtCodigo.SelectAll();
                //}
            }
            catch
            {
            }

        }

        private bool isTextChangeRunning = false; // Variável de controle
        private void BuscarProduto()
        {

            try
            {
                //if (isTextChangeRunning)
                //    return; // Sai do método se já houver uma execução em andamento

                //isTextChangeRunning = true;

                ////if (Buscando) return;
                ////Buscando = true;

                //if (NumeroPedido == string.Empty) { GerarNumeroPedido(); }

                //using (var dados = new Dados())
                //{
                //    var filtro = this.TxtCodigo.Text;
                //    var result = dados.Select<Estoque>($"SELECT * FROM Estoques where CodigoDeBarras = '{filtro}';");
                //    var oEstoque = result.First();

                //    if (oEstoque != null && oEstoque.EstoqueId > 0)
                //    {
                //        if (oEstoque.Produto != "" && oEstoque.Produto != null)
                //        {
                //            oEstoque.Quantidade = clsGlobal.DeStringParaInt(TxtQuantidade.Text);

                //            string[] row = { oEstoque.ProdutoId.ToString(), string.Format("{0,4:#0000}", count), oEstoque.CodigoDeBarras, oEstoque.Produto, oEstoque.Quantidade.ToString(), oEstoque.PrecoDeVenda.ToString("N2"), ((clsGlobal.AplicarFormato(this.TxtQuantidade.Text)) * oEstoque.PrecoDeVenda).ToString("N2"), "" };//, oEstoque.SubTotal.ToString("N2"), "" };
                //            this.grid.Rows.Add(row);

                //            this.TxtUnitario.Text = oEstoque.PrecoDeVenda.ToString("N2");
                //            this.TxtSubTotal.Text = (oEstoque.Quantidade * oEstoque.PrecoDeVenda).ToString("N2");
                //            this.lblDescricaoProduto.Text = oEstoque.Produto.ToString();

                //            if (this.grid.Rows.Count > 0)
                //            {
                //                this.TxtTotal.Text = clsGlobal.Calcular(grid, 11).ToString("N2");
                //            }

                //            this.TxtQuantidade.Text = "1";
                //            this.Buscando = false;

                //            if (grid.Rows.Count > 0)
                //                grid.CurrentCell = grid.Rows[grid.Rows.Count - 1].Cells[10];

                //            count++;

                //            lblStatusCaixa.Text = "CAIXA OCUPADO";

                //            this.TxtCodigo.Focus();
                //            this.TxtCodigo.SelectAll();

                //            //if (filtro.Length < 14)
                //            //{
                //            //    if (TxtCodigo.Text.Length >= 8) this.TxtCodigo.Focus();
                //            //}
                //            //else
                //            //{
                //            this.TxtCodigo.Focus();
                //            this.TxtCodigo.Clear();
                //            //}
                //        }
                //        this.TxtCodigo.Focus();
                //        this.TxtCodigo.Clear();
                //    }
                //}


            }
            catch
            {
                this.TxtCodigo.Focus();
                this.TxtCodigo.Clear();
                grid.CurrentCell = grid.Rows[grid.Rows.Count - 1].Cells[1];
            }
            finally
            {
                grid.CurrentCell = grid.Rows[grid.Rows.Count - 1].Cells[1];
                this.TxtQuantidade.Text = "1";
                isTextChangeRunning = false; // Libera o bloqueio após a execução
            }
        }

        private void RegistrarCaixa(decimal valor, decimal desconto)
        {
            try
            {
                _= new OCaixa().RegistrarCaixa(valor, desconto);
            }
            catch
            {
                throw new Exception("Códiga: 1002");
            }

        }

        private void FinalizarVenda()
        {
            try
            {
                //var oItensCarrinho = new List<ItensCarrinho>();

                //int counte = this.grid.Rows.Count;
                //// resgata os itens do carrinho.
                //if (counte > 0)
                //{
                //    for (int i = 0; i < grid.Rows.Count; i++)
                //    {
                //        var fCaixa = new ItensCarrinho
                //        {
                //            ProdutoID = clsGlobal.DeStringParaInt(grid.Rows[i].Cells["ProdutoID"].Value.ToString()),
                //            Produto = grid.Rows[i].Cells["Produto"].Value.ToString(),
                //            CodigoDeBarras = grid.Rows[i].Cells["CodigoDeBarras"].Value.ToString(),
                //            Quantidade = clsGlobal.DeStringParaInt(grid.Rows[i].Cells["Quantidade"].Value.ToString().Trim()),
                //            PrecoUnitario = clsGlobal.AplicarFormato(grid.Rows[i].Cells["PrecoUnitario"].Value.ToString()),
                //            SubTotal = clsGlobal.AplicarFormato(grid.Rows[i].Cells["SubTotal"].Value.ToString()),
                //            NumeroPedido = this.NumeroPedido,
                //        };
                //        oItensCarrinho.Add(fCaixa);
                //    }
                //}
                //else
                //    return;

                //// difini e carrega os métodos de pagamentos.
                //var pagar = new FrmPagamento(oItensCarrinho.Sum(t => t.SubTotal));
                //pagar.ShowDialog();

                //var pagamentos = pagar.listaPagamentos;

                //var flag = 0;
                //// registra os itens do pedido e o pedido..
                //using (var dados = new Dados())
                //{
                //    foreach (var item in oItensCarrinho)
                //    {
                //        var oItensPedido = new ItensPedido
                //        {
                //            ProdutoID = item.ProdutoID,
                //            Quantidade = item.Quantidade,
                //            PrecoUnitario = item.PrecoUnitario,
                //            NumeroPedido = item.NumeroPedido,
                //        };
                //        flag = dados.Insert(oItensPedido);
                //    }
                //    var pedido = new Pedido
                //    {
                //        ClienteID = pagar.ClienteId,
                //        NumeroPedido = clsGlobal.DeStringParaInt(this.NumeroPedido),
                //        DataPedido = DateTime.Now,
                //        Total = oItensCarrinho.Sum(ip => (ip.Quantidade * ip.PrecoUnitario)),
                //        StatusPedido = pagar.listaPagamentos[0].FormaPagamento// "PAGO"
                //    };
                //    dados.Insert(pedido);
                //}

                //// registra o pagamento no caixa
                //RegistrarCaixa(oItensCarrinho.Sum(ip => (ip.Quantidade * ip.PrecoUnitario)), 0);


                //// atualiza o estoque
                //for (int i = 0; i <= counte - 1; i++)
                //{
                //    using (var dados = new Dados())
                //    {

                //        foreach (var item in oItensCarrinho)
                //        {
                //            var res = $"UPDATE [dbo].[Estoques] SET Quantidade = Quantidade - {item.Quantidade}, [updated_at] = GETDATE() WHERE codigodebarras in (select CodigoDeBarras from estoques where CodigoDeBarras = '{item.CodigoDeBarras}');";
                //            flag = dados.UpdateSql(res);
                //        }
                //    }
                //}

                //// limpar numero pedido
                //this.NumeroPedido = string.Empty;

                //// imprime o boleto
                //if (flag > 0)
                //{
                //    DialogResult dialogResult = MensagemBox.Mostrar("Deseja imprimir o cupom não fiscal?", "Sim", "Nao");
                //    if (dialogResult == DialogResult.Yes)
                //    {
                //        ImprimirBoleto(oItensCarrinho);
                //    }
                //    Buscando = false;
                //    Limpar();
                //}

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }

        }

        private void ImprimirBoleto(List<ItensCarrinho> itensCarrinho)
        {
            var oCupom = new ImprimeVendaVista(itensCarrinho);
            oCupom.Print();
        }

        private void GerarNumeroPedido()
        {
            var rnd = new Random();
            this.NumeroPedido = rnd.Next(0, 999999).ToString();
        }

        private void FecharCaixa()
        {

            try
            {
                // verificar se caixa esta aberto e resgatar valor do caixa aberto
                //using (var caixaAberto = new OCaixa().EstaAberto())
                //{
                //    var oCaixa = new OCaixa();
                //    //    
                //    var resultSuprimento = new Dados().SelectWithWhere<Suprimento>("Suprimentos", oCaixa.whereClause, oCaixa.Parametro(caixaAberto.AbrirCaixaId));
                //    var suprimento = resultSuprimento.Count > 0 ? resultSuprimento.First() : null; // resgatar valor de suprimento 

                //    var resultsangria = new Dados().SelectWithWhere<Sangria>("Sangrias", oCaixa.whereClause, oCaixa.Parametro(caixaAberto.AbrirCaixaId));
                //    var sangria = resultsangria.Count > 0 ? resultsangria.First() : null; // resgatar valor sangria

                //    var resultCaixa = new Dados().SelectWithWhere<Caixa>("Caixas", oCaixa.whereClause, oCaixa.Parametro(caixaAberto.AbrirCaixaId));
                //    var caixa = resultCaixa.Count > 0 ? resultCaixa.First() : null;// resgatar valor caixa

                //    var valorCaixaAberto = caixaAberto != null ? caixaAberto.Valor : 0.00M;
                //    var valorSuprimento = suprimento != null ? suprimento.Valor : 0.00M;
                //    var valorSangria = sangria != null ? sangria.Valor : 0.00M;
                //    var valorDesconto = (caixa != null ? caixa.Desconto : 0.00M);
                //    var valorCaixa = (caixa != null ? caixa.Valor : 0.00M) + (valorCaixaAberto + valorSuprimento + valorSangria) - valorDesconto;

                //    var valorBrutoCaixa = valorCaixa;// + valorCaixaAberto + valorSuprimento + valorSangria;
                //                                     //if (valorBrutoCaixa > 0)
                //                                     //    valorCaixa = valorBrutoCaixa;
                //                                     //    rowAfected = await caixa.Salvar();
                //    var retorno = new OCaixa().FecharCaixa(valorCaixa, caixaAberto.FuncionarioId);

                //    //var t = retorno;

                //    // O caixaResumo é usado somente para gerar a saída para o boleto.
                //    var caixaResumo = new CaixaResumo
                //    {
                //        TotalAbertoCom = valorCaixaAberto,
                //        TotalSuprimento = valorSuprimento,
                //        TotalSangria = valorSangria,
                //        TotalCaixa = valorBrutoCaixa,
                //        TotalLiquido = valorBrutoCaixa - valorCaixaAberto,// (valorCaixaAberto + valorSuprimento + valorSangria),
                //        TotalDesconto = valorDesconto// (valorCaixaAberto + valorSuprimento + valorSangria),
                //    };


                //    //    // escrever no logs.
                //    //    // gerar o arquivo de log.
                //    var sb = new StringBuilder();
                //    sb.AppendLine("---------- Fechar Caixa ----------");
                //    sb.AppendLine($"Data: {(caixa != null ? caixa.DataHora.ToString() : DateTime.Now.ToString())}");
                //    sb.AppendLine("Total Caixa" + (caixaResumo != null ? caixaResumo.TotalCaixa.ToString() : "0.00"));
                //    sb.AppendLine("Total AbertoCom" + (caixaResumo != null ? caixaResumo.TotalAbertoCom.ToString() : "0.00"));
                //    sb.AppendLine("Total Suprimento" + (caixaResumo != null ? caixaResumo.TotalSuprimento.ToString() : "0.00"));
                //    sb.AppendLine("Total Sangria" + (caixaResumo != null ? caixaResumo.TotalSangria.ToString() : "0.00"));
                //    sb.AppendLine("Total Desconto" + (caixaResumo != null ? caixaResumo.TotalDesconto.ToString() : "0.00"));
                //    sb.AppendLine("Total Liquido" + (caixaResumo != null ? caixaResumo.TotalLiquido.ToString() : "0.00"));
                //    sb.AppendLine("------------------------------------------------------------");

                //    clsGlobal.RegistrarLogs(sb);

                //    if ((valorCaixa < 1)) //&& (valorCaixa == valorCaixaAberto))
                //    {
                //        var result = MessageBox.Show("Não forão feitas nem uma venda para o dia de hoje, gostaria de imprimir o ressumo mesmo assim?".ToUpper(), "Fchando o caixa".ToUpper(), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //        if (result == DialogResult.No)
                //            return;
                //    }
                //    //    new ImprimirResumoDeVendas(caixaResumo).Print();
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Close();
            //this.Dispose();
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
                    if (MensagemBox.Mostrar("Você deseja cancelar a venda em andamento?", "Sim", "Nao") == DialogResult.Yes)
                    {
                        this.Close();
                    }
                    else
                    {
                        this.TxtCodigo.Focus();
                        this.TxtCodigo.SelectAll();
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
                if (MensagemBox.Mostrar("Você deseja cancelar a venda em andamento?", "Sim", "Nao") == DialogResult.Yes)
                {
                    this.Limpar();
                }
                else
                {
                    this.TxtCodigo.Focus();
                    this.TxtCodigo.SelectAll();
                    return;
                }

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
                FecharCaixa();
            }
            else if (e.KeyCode == Keys.F6)
            {
                // suprimento
                var suprimento = new FrmSuprimento();
                suprimento.id = this.oFuncionario.FuncionarioId;
                suprimento.ShowDialog();
                suprimento.Dispose();
            }
            else if (e.KeyCode == Keys.F7)
            {
                // sangria
                var sangria = new FrmSangia();
                sangria.id = this.oFuncionario.FuncionarioId;
                sangria.ShowDialog();
                sangria.Dispose();
            }
            else if (e.KeyCode == Keys.F8)
            {
                //Receber pendura.
                var f = new FrmInventario();
                f.oFuncionario = this.oFuncionario;
                f.ShowDialog();
                f.Dispose();
            }
            else if (e.KeyCode == Keys.F9)
            {
                //Abre o formulário para a pesquisa de produos.
                FrmEstoqueLista oEstoqueLista = new FrmEstoqueLista();
                oEstoqueLista.ShowDialog();
                if (oEstoqueLista.DialogResult.Equals(DialogResult.OK))
                {
                    TxtCodigo.Text = oEstoqueLista.CodigoProduto;
                }
                else
                {
                    TxtCodigo.Focus();
                    TxtCodigo.SelectAll();
                }
                oEstoqueLista.Dispose();
            }
            else if (e.Control && e.KeyCode == Keys.Q)
            {
                TxtQuantidade.Focus();
                TxtQuantidade.SelectAll();
            }
        }

        private void TxtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            MenuKeyDown(e);
        }

        private void TxtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = clsGlobal.SomenteNumeros(e);
        }

        private void TxtQuantidade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Q || e.KeyCode == Keys.Enter)
            {
                TxtCodigo.SelectAll();
                TxtCodigo.Focus();
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
                this.TxtTotal.Text = clsGlobal.Calcular(grid, 11).ToString("N2");
            }
            else { Limpar(); }

            TxtCodigo.Focus();
            TxtCodigo.SelectAll();
        }

        private void TxtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = clsGlobal.SomenteNumeros(e);
        }

        #endregion

        #region Eventos

        #region Eventos TypingTimer
        /// <summary>
        /// Este evento é disparado após completar 1 segundo que o usuário parar de digitar
        /// o código de barras. OBS: Faz a busca de produtos ficar mais eficiente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TypingTimer_Tick(object sender, EventArgs e)
        {
            // O usuário parou de digitar
            //_typingTimer.Stop();

            this.BuscarProduto();
            //MessageBox.Show("Você parou de digitar!");
        }

        #endregion TypingTimer

        private void TxtCodigoTextChanged()
        {
            try
            {
                if (isTextChangeRunning)
                    return; // Sai do método se já houver uma execução em andamento

                isTextChangeRunning = true;

                Int32 tamanho = TxtCodigo.Text.Length;
                string operador = "";
                if (this.Buscando == false)
                { operador = TxtCodigo.Text.Substring(tamanho - 1, 1).ToString(); }

                if (operador == "*" || operador == "x" || operador == "X")
                {
                    this.Buscando = true;
                    TxtQuantidade.Text = TxtCodigo.Text.Substring(0, tamanho - 1);
                    this.TxtCodigo.Text = "";
                    this.TxtCodigo.Focus();
                    this.TxtCodigo.SelectAll();
                    return;
                }
                else
                {
                    Buscando = false;
                    if (TxtCodigo.Text.Length >= 8 && TxtCodigo.Text.Length <= 14)
                    {
                        if (backgroundWorker1.IsBusy != true)
                        {
                            // Start the asynchronous operation.
                            backgroundWorker1.RunWorkerAsync();
                        }
                        //this.BuscarProduto();

                    }
                    //else
                    //{
                    //    this.TxtCodigo.Focus();
                    //    this.TxtCodigo.SelectAll();
                    //    //return;
                    //}
                }

            }
            catch
            {
                if (backgroundWorker1.WorkerSupportsCancellation == true)
                {
                    //Cancel the asynchronous operation.
                    backgroundWorker1.CancelAsync();
                }
                this.TxtCodigo.Focus();
                this.TxtCodigo.SelectAll();
            }
            finally
            {
                isTextChangeRunning = false; // Libera o bloqueio após a execução
            }
        }

        private void TxtCodigo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TxtCodigoTextChanged();
            }
            catch
            {
            }
        }

        private void FrmPDV_Load(object sender, EventArgs e)
        {
            //backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;

            Limpar();
            TxtCodigo.Focus();
            TxtCodigo.SelectAll();
        }

        private void FrmPDV_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                //backgroundWorker1.WorkerReportsProgress = false;
                backgroundWorker1.WorkerSupportsCancellation = false;
                GC.Collect();
            }
            catch { }
        }

        private void grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grid.Rows.Count > 0)
            {
                TxtCodigo.Text = grid.Rows[grid.CurrentRow.Index].Cells["CodigoDeBarras"].Value.ToString();
                BuscarProduto();
            }
        }

        private void iconcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #endregion

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            for (int i = 1; i <= 15; i++)
            {
                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    // Perform a time consuming operation and report progress.
                    System.Threading.Thread.Sleep(30);
                    //worker.ReportProgress(i * 10);
                }
            }
        }

        // This event handler updates the progress.
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //resultLabel.Text = (e.ProgressPercentage.ToString() + "%");
        }

        // This event handler deals with the results of the background operation.
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.BuscarProduto();
            this.TxtCodigo.Focus();
            this.TxtCodigo.SelectAll();
        }

        #region Algoritmo :1, de trava para o controle responsavel por fazer a busca de produtos

        ////Claro, vamos melhorar a confiabilidade e a estabilidade do algoritmo! Em vez de uma simples variável de controle, podemos utilizar uma fila de tarefas, onde cada evento TextChanged é enfileirado e processado sequencialmente, garantindo que apenas um evento seja executado por vez, de forma estável e escalável.
        ////Aqui está uma solução aprimorada:

        //private readonly BlockingCollection<Func<Task>> taskQueue = new();
        //private bool isProcessing = false;

        ////public Form1()
        ////{
        ////    InitializeComponent();
        ////    textBox1.TextChanged += TextBox1TextChanged;
        ////}

        //private void TextBox1TextChanged()
        //{
        //    // Adiciona a tarefa na fila, onde cada ação é independente
        //    taskQueue.Add(() => ProcessTextChangedAsync(TxtCodigo.Text));

        //    // Verifica se já está processando
        //    if (!isProcessing)
        //    {
        //        isProcessing = true;
        //        Task.Run(ProcessQueue); // Executa a fila em uma tarefa separada
        //    }
        //}

        //private async Task ProcessQueue()
        //{
        //    while (taskQueue.TryTake(out var task, Timeout.Infinite))
        //    {
        //        await task();
        //    }
        //    isProcessing = false;
        //}

        //private async Task ProcessTextChangedAsync(string newText)
        //{
        //    // Simulando uma tarefa assíncrona de longa duração
        //    await Task.Delay(2000);

        //    // Aqui você coloca o código que deseja executar ao final do evento
        //    MessageBox.Show("Texto alterado para: " + newText);
        //}
        ////}

        ////Explicação
        ////BlockingCollection: Usamos BlockingCollection<Func<Task>> como uma fila de tarefas, garantindo que novos eventos TextChanged sejam enfileirados em vez de executados imediatamente.
        ////Fila Sequencial: Cada mudança de texto gera uma nova tarefa enfileirada (ProcessTextChangedAsync), e o método ProcessQueue processa cada uma sequencialmente.
        ////Processamento Assíncrono: A fila é processada em uma Task separada para evitar o travamento da interface, e o processamento contínuo de eventos evita a perda de alterações de texto.
        ////Com essa abordagem, cada evento TextChanged é garantido a ser executado em sequência, eliminando qualquer risco de sobreposição ou execução instável.
        #endregion

        #region Algoritmo :2, de trava para o controle responsavel por fazer a busca de produtos

        //    //Implemente, por favor um formulario com um textbox1 para receber um código de barras buscar o produto na base de dados SqlServe e mostrar o valor do produto no textbox2.Implemente este algoritmo com trava para o evento de busca ser disparado só uma vez por produto.
        //    //Dito pelo ChatGPT: ChatGPT
        //    //Para criar um formulário que recebe um código de barras no TextBox1, consulta o produto no banco de dados SQL Server, e exibe o valor do produto no TextBox2, podemos usar uma abordagem semelhante à anterior, assegurando que a busca no banco de dados só ocorra uma vez por produto, mesmo se o evento TextChanged for disparado repetidamente.
        //    //Aqui está a implementação completa, assumindo que a tabela de produtos no SQL Server se chama Produtos e possui colunas CodigoBarras (VARCHAR) e Valor (DECIMAL).

        //    public partial class BuscarProdutoNoBanco
        //{
        //    private readonly BlockingCollection<Func<Task>> taskQueue = new BlockingCollection<Func<Task>>();
        //    private bool isProcessing = false;
        //    private string lastBarcode = string.Empty; // Para evitar buscas duplicadas

        //    //public Form1()
        //    //{
        //    //    InitializeComponent();

        //    //    // TextBox1 para receber o código de barras
        //    //    textBox1.TextChanged += TextBox1_TextChanged;
        //    //}

        //    private void TextBox1_TextChanged(object sender, EventArgs e)
        //    {
        //        // Verifica se o valor é o mesmo da última consulta realizada
        //        if (textBox1.Text == lastBarcode)
        //            return;

        //        // Atualiza o último código de barras consultado
        //        lastBarcode = textBox1.Text;

        //        // Adiciona a tarefa de busca na fila
        //        taskQueue.Add(() => BuscarProdutoAsync(textBox1.Text));

        //        // Inicia o processamento da fila se ainda não está processando
        //        if (!isProcessing)
        //        {
        //            isProcessing = true;
        //            Task.Run(ProcessQueue);
        //        }
        //    }

        //    private async Task ProcessQueue()
        //    {
        //        while (taskQueue.TryTake(out var task, Timeout.Infinite))
        //        {
        //            await task();
        //        }
        //        isProcessing = false;
        //    }

        //    private async Task BuscarProdutoAsync(string codigoBarras)
        //    {
        //        try
        //        {
        //            // String de conexão com o banco de dados
        //            string connectionString = "sua_string_de_conexao_aqui";

        //            using (SqlConnection connection = new SqlConnection(connectionString))
        //            {
        //                await connection.OpenAsync();

        //                // Comando SQL para buscar o produto pelo código de barras
        //                string query = "SELECT Valor FROM Produtos WHERE CodigoBarras = @CodigoBarras";
        //                using (SqlCommand command = new SqlCommand(query, connection))
        //                {
        //                    command.Parameters.AddWithValue("@CodigoBarras", codigoBarras);

        //                    // Executa o comando e obtém o valor do produto
        //                    var result = await command.ExecuteScalarAsync();
        //                    if (result != null && result != DBNull.Value)
        //                    {
        //                        decimal valor = (decimal)result;
        //                        textBox2.Text = valor.ToString("C"); // Exibe o valor formatado no TextBox2
        //                    }
        //                    else
        //                    {
        //                        textBox2.Text = "Produto não encontrado";
        //                    }
        //                }
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Erro ao buscar o produto: " + ex.Message);
        //        }
        //    }
        //}
        //    //Explicação
        //    //Controle de Busca Única por Produto: A variável lastBarcode armazena o último código de barras consultado.Se o mesmo código for digitado consecutivamente, a busca no banco de dados é ignorada.
        //    //Fila de Tarefas com BlockingCollection: O método TextBox1_TextChanged adiciona a busca à fila, garantindo que cada evento de alteração do texto seja processado na sequência correta.
        //    //Acesso ao Banco de Dados: No método BuscarProdutoAsync, usamos uma consulta SQL parametrizada para obter o valor do produto baseado no código de barras informado.
        //    //Exibição no TextBox2: Se o produto for encontrado, seu valor é exibido em textBox2. Caso contrário, exibe "Produto não encontrado".
        //    //Essa implementação assegura que as consultas ao banco sejam estáveis e que o evento seja disparado apenas uma vez por produto digitado, proporcionando maior confiabilidade e evitando acessos desnecessários ao banco.
        #endregion

    }
}

//private void TxtCodigo_TextChanged(object sender, EventArgs e)
//{
//    try
//    {
//        //    Int32 tamanho = TxtCodigo.Text.Length;
//        //    string operador = "";
//        //    if (this.Buscando == false)
//        //    { operador = TxtCodigo.Text.Substring(tamanho - 1, 1).ToString(); }

//        //    if (operador == "*" || operador == "x" || operador == "X")
//        //    {
//        //        this.Buscando = true;
//        //        TxtQuantidade.Text = TxtCodigo.Text.Substring(0, tamanho - 1);
//        //        this.TxtCodigo.Text = "";
//        //        this.TxtCodigo.Focus();
//        //        this.TxtCodigo.SelectAll();
//        //        return;
//        //    }
//        //    //else
//        //    //{
//        //    Buscando = false;
//        //    if (TxtCodigo.Text.Length >= 8 && TxtCodigo.Text.Length <= 14)
//        //    {
//        //        //if (backgroundWorker1.IsBusy != true)
//        //        //{
//        //        //    // Start the asynchronous operation.
//        //        //    backgroundWorker1.RunWorkerAsync();
//        //        //}
//        //        //this.BuscarProduto();

//        //    }
//        //    //else
//        //    //{
//        //    //this.TxtCodigo.Focus(); 
//        //    //this.TxtCodigo.SelectAll();
//        //    //    //return;
//        //    //}
//        //    //}

//    }
//    catch
//    {
//        //if (backgroundWorker1.WorkerSupportsCancellation == true)
//        //{
//        //    // Cancel the asynchronous operation.
//        //    backgroundWorker1.CancelAsync();
//        //}
//        this.TxtCodigo.Focus();
//        this.TxtCodigo.SelectAll();
//    }
//}
