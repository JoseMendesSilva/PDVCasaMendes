using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Drawing;
using System.Configuration;
using DocumentFormat.OpenXml.Bibliography;

namespace CasaMendes
{
    public partial class FrmFrenteDeCaixa : Form
    {

        #region Veriáveis

        private bool Buscando = false;
        private readonly string Funcionario = "José Mendes";//25
        private int count = 1;
        private PreVenda oPreVenda;

        #endregion

        public FrmFrenteDeCaixa()
        {
            InitializeComponent();

            this.grid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellDoubleClick);
            this.grid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grid_KeyDown);
            this.grid.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.grid_RowsRemoved);
            this.TxtQuantidade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtQuantidade_KeyDown);
            this.TxtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCodigo_KeyPress);
            this.TxtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCodigo_KeyDown);
        }

        #region Vendas

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

            oPreVenda.ClienteId = 0;
            oPreVenda.Produto = string.Empty;
            oPreVenda.Quantidade = 0;
            oPreVenda.PrecoDeVenda = 0;
            oPreVenda.NumeroDaVenda = "0";
            oPreVenda.TipoDeVenda = "A VISTA";// pendura, pg, debito, crédito e pix.
            oPreVenda.Valor = 0;
            oPreVenda.Dinheiro = 0;
            oPreVenda.Troco = 0;
            oPreVenda.Parcela = 0;
            oPreVenda.Tributos = 0;
            oPreVenda.Juros = 0;
            //oPreVenda.SubTotal = 0;

            grid.Rows.Clear();

            lblOperador.Text = "Operador: " + this.Funcionario;
            lblTerminal.Text = "Terminal: " + 1;
            this.PicLogoTipo.Image = Properties.Resources.CasaMendes1Jpg;
        }

        public void CarregarPendura(int ClienteId, string TipoDeVenda)
        {
            try
            {
                Buscando = true;
                this.oPreVenda.ClienteId = ClienteId;
                this.oPreVenda.TipoDeVenda = TipoDeVenda;
                this.oPreVenda.NumeroDaVenda = null;
                this.oPreVenda.created_at = null;
                var ListaPreVenda = new List<PreVenda>();
                ListaPreVenda = this.oPreVenda.Busca();

                if (ListaPreVenda.Count > 0)
                {
                    GerarNumero();
                    lblStatusCaixa.Text = "CAIXA OCUPADO";

                    for (int i = 0; i < ListaPreVenda.Count; i++)
                    {
                        this.oPreVenda = (PreVenda)ListaPreVenda[i];
                        if (this.oPreVenda.Produto != "" && oPreVenda.Produto != null)
                        {
                            string[] row = { this.oPreVenda.ClienteId.ToString(), this.oPreVenda.NumeroDaVenda.ToString(), this.oPreVenda.TipoDeVenda.ToString(), this.oPreVenda.Desconto.ToString(), this.oPreVenda.Tributos.ToString(), this.oPreVenda.Juros.ToString(), string.Format("{0,4:#0000}", count), this.oPreVenda.PreVendaId.ToString(), this.oPreVenda.Produto, this.oPreVenda.Quantidade.ToString(), this.oPreVenda.PrecoDeVenda.ToString("N2"), this.oPreVenda.Valor.ToString("N2"), this.oPreVenda.PreVendaId.ToString() };
                            this.grid.Rows.Add(row);
                            count++;
                        }
                    }
                    //decimal total = decimal.Parse(grid.Rows[0].Cells[11].Value.ToString());
                    decimal total = clsGlobal.Calcular(grid, 11) - oPreVenda.Parcela;
                    this.TxtTotal.Text = total.ToString("N2");
                    if (grid.Rows.Count > 0)
                    {
                        grid.CurrentCell = grid.Rows[grid.Rows.Count - 1].Cells[8];
                    }
                    Buscando = false;
                    this.TxtCodigo.Focus();
                    this.TxtCodigo.SelectAll();
                }
            }
            catch
            {
            }
        }

        private void BuscarProduto()
        {
            try
            {
                string Filtro = TxtCodigo.Text;
                if (oPreVenda.NumeroDaVenda == "0" || oPreVenda.NumeroDaVenda == null) { GerarNumero(); }

                var oEstoque = new Estoque();
                List<Estoque> ResEstoque = new List<Estoque>();
                oEstoque.CodigoDeBarras = Filtro;
                ResEstoque = oEstoque.Busca();

                if (ResEstoque.Count > 0)
                {
                    oEstoque = (Estoque)ResEstoque[0];
                    ResEstoque = null;
                    if (oEstoque.Produto != "" && oEstoque.Produto != null)
                    {
                        int quant = clsGlobal.DeStringParaInt(TxtQuantidade.Text);
                        decimal SubTotal = quant * oEstoque.PrecoDeVenda;

                        string[] row = { oPreVenda.ClienteId.ToString(), oPreVenda.NumeroDaVenda.ToString(), oPreVenda.TipoDeVenda.ToString(), oPreVenda.Desconto.ToString(), oPreVenda.Tributos.ToString(), oPreVenda.Juros.ToString(), string.Format("{0,4:#0000}", count), oEstoque.CodigoDeBarras, oEstoque.Produto, this.TxtQuantidade.Text, oEstoque.PrecoDeVenda.ToString("N2"), SubTotal.ToString("N2"), "" };
                        this.grid.Rows.Add(row);

                        this.TxtUnitario.Text = oEstoque.PrecoDeVenda.ToString("N2");
                        this.TxtSubTotal.Text = SubTotal.ToString("N2");
                        this.lblDescricaoProduto.Text = oEstoque.Produto.ToString();
                        if (oEstoque.Foto != null) this.PicLogoTipo.Image = Image.FromFile(oEstoque.Foto.ToString());
                        else this.PicLogoTipo.Image = Properties.Resources.CasaMendes1Jpg;

                        if (this.grid.Rows.Count > 0) { this.TxtTotal.Text = clsGlobal.Calcular(grid, 11).ToString("N2"); }
                        if (clsGlobal.DeStringParaInt(this.TxtQuantidade.Text) > 1) { this.TxtQuantidade.Text = "1"; }
                        this.Buscando = false;

                        if (grid.Rows.Count > 0)
                        {
                            grid.CurrentCell = grid.Rows[grid.Rows.Count - 1].Cells[10];
                        }
                        count++;

                        lblStatusCaixa.Text = "CAIXA OCUPADO";


                        this.TxtCodigo.Focus();
                        this.TxtCodigo.SelectAll();
                    }
                    if (Filtro.Length < 14)
                    {
                        this.TxtCodigo.Focus();
                    }
                    else
                    {
                        this.TxtCodigo.Focus();
                        this.TxtCodigo.SelectAll();
                    }
                }
            }
            catch
            {
            }
        }

        private void FinalizarVenda()
        {
            try
            {
                var oEstq = new Estoque();
                int counte = this.grid.Rows.Count;
                if (counte > 0)
                {
                    decimal SubTotal = 0;

                    if (this.oPreVenda == null) this.oPreVenda = new PreVenda();
                    oPreVenda.Valor = clsGlobal.DeStringParaDecimal(this.TxtTotal.Text.Replace("R$ ", "").ToString());
                    frmFinlizarVendas oFinlizarVenda = new frmFinlizarVendas();
                    oFinlizarVenda.txtTotal.Text = this.oPreVenda.Valor.ToString("N2");
                    oFinlizarVenda.ShowDialog();

                    this.oPreVenda.Dinheiro = oFinlizarVenda.Dinheiro;
                    this.oPreVenda.Desconto = oFinlizarVenda.Desconto;
                    this.oPreVenda.Troco = oFinlizarVenda.Troco;
                    this.oPreVenda.ClienteId = oFinlizarVenda.ClienteId;
                    this.oPreVenda.TipoDeVenda = oFinlizarVenda.TipoDeVenda;

                    if (this.oPreVenda.TipoDeVenda == "PENDURA")
                    {
                        this.oPreVenda.Tributos = clsGlobal.DeStringParaDecimal(ConfigurationManager.AppSettings["Tributos"]);
                        this.oPreVenda.Juros = clsGlobal.DeStringParaDecimal(ConfigurationManager.AppSettings["Juros"]);
                    }
                    else
                    {
                        this.oPreVenda.Tributos = 0;
                        this.oPreVenda.Juros = 0;
                    }

                    if (oFinlizarVenda.DialogResult == DialogResult.Cancel)
                    {
                        oFinlizarVenda.Dispose();
                        this.TxtCodigo.Focus();
                        this.TxtCodigo.SelectAll();
                        return;
                    }
                    else
                    {
                        oFinlizarVenda.Dispose();
                    }

                    for (int i = 0; i < grid.Rows.Count; i++)
                    {
                        grid.Rows[i].Cells["NumeroDaVenda"].Value = this.oPreVenda.NumeroDaVenda;
                        grid.Rows[i].Cells["TipoDeVenda"].Value = this.oPreVenda.TipoDeVenda;
                        grid.Rows[i].Cells["Desconto"].Value = this.oPreVenda.Desconto;
                        grid.Rows[i].Cells["Tributos"].Value = this.oPreVenda.Tributos;
                        grid.Rows[i].Cells["Juros"].Value = this.oPreVenda.Juros;
                        if (oPreVenda.Tributos > 0 || oPreVenda.Juros > 0)
                        {
                            SubTotal = clsGlobal.AplicarEncargos((this.oPreVenda.Valor = clsGlobal.DeStringParaDecimal(grid.Rows[i].Cells["ValorTotal"].Value.ToString())), this.oPreVenda.Tributos, this.oPreVenda.Juros);
                            grid.Rows[i].Cells["ValorTotal"].Value = SubTotal.ToString("N2");
                        }
                    }

                    for (int i = 0; i <= counte - 1; i++)
                    {
                        if (oPreVenda.PreVendaId > 0) this.oPreVenda.PreVendaId = clsGlobal.DeStringParaInt(grid.Rows[i].Cells["PreVendaId"].Value.ToString());
                        this.oPreVenda.Produto = grid.Rows[i].Cells["Descricao"].Value.ToString();
                        this.oPreVenda.Quantidade = clsGlobal.DeStringParaInt(grid.Rows[i].Cells["Quantidade"].Value.ToString().Trim());
                        this.oPreVenda.PrecoDeVenda = clsGlobal.DeStringParaDecimal(grid.Rows[i].Cells["ValorUnitario"].Value.ToString());
                        this.oPreVenda.NumeroDaVenda = grid.Rows[i].Cells["NumeroDaVenda"].Value.ToString();
                        this.oPreVenda.TipoDeVenda = grid.Rows[i].Cells["TipoDeVenda"].Value.ToString() == null ? "A VISTA" : grid.Rows[i].Cells["TipoDeVenda"].Value.ToString();
                        this.oPreVenda.Valor = clsGlobal.DeStringParaDecimal(grid.Rows[i].Cells["ValorTotal"].Value.ToString());
                        this.oPreVenda.Salvar();
                        string CodigoDeBarras = grid.Rows[i].Cells["CodigoDeBarras"].Value.ToString();
                        string sql = $"UPDATE Estoques SET Quantidade = (Quantidade - '{this.oPreVenda.Quantidade}') WHERE CodigoDeBarras = '{CodigoDeBarras}'";
                        oEstq.SalvarSql(sql);
                    }

                    DialogResult dialogResult = MensagemBox.Mostrar("Deseja imprimir o cupom não fiscal?", "Sim", "Nao");
                    if (dialogResult == DialogResult.Yes)
                    {
                        ImprimirBoleto();
                    }
                    Buscando = false;
                    Limpar();
                }
            }
            catch
            {
            }

        }

        private void ImprimirBoleto()
        {
            ImprimeVendaVista oCupom = new ImprimeVendaVista(grid, oPreVenda);
            oCupom.Print();
        }

        private void GerarNumero()
        {
            var rnd = new Random();
            oPreVenda.NumeroDaVenda = rnd.Next(0, 999999).ToString();
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
            }
            else if (e.KeyCode == Keys.F6)
            {

            }
            else if (e.KeyCode == Keys.F7)
            {
                //Não implementado.
            }
            else if (e.KeyCode == Keys.F8)
            {
                //Receber anotado.
                FrmReceberPendura f = new FrmReceberPendura();
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
                this.TxtTotal.Text = clsGlobal.Calcular(grid, 5).ToString("N2");
            }
            else { Limpar(); }

            TxtCodigo.Focus();
            TxtCodigo.SelectAll();
        }

        #endregion

        #region Eventos

        private void TxtCodigo_TextChanged(object sender, EventArgs e)
        {
            try
            {
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
                    if (TxtCodigo.Text.Length < 8)
                    { this.TxtCodigo.Focus(); return; }
                }

                this.BuscarProduto();
            }
            catch
            {

            }
        }

        private void FrmPDV_Load(object sender, EventArgs e)
        {
            if (oPreVenda == null) oPreVenda = new PreVenda();
            Limpar();
            TxtCodigo.Focus();
            TxtCodigo.SelectAll();
        }

        private void FrmPDV_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                GC.Collect();
            }
            catch { }
        }

        private void grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grid.Rows.Count > 0)
            {
                TxtCodigo.Text = grid.Rows[grid.CurrentRow.Index].Cells["ProdutosId_"].Value.ToString();
            }
        }

        private void iconcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        private void TxtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = clsGlobal.SomenteNumeros(e);
        }

    }
}
