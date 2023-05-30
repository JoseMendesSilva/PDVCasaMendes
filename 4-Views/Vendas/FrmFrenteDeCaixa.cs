using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Drawing;
using System.Configuration;

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
            this.TxtCodigo.TextChanged += new System.EventHandler(this.TxtCodigo_TextChanged);
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
            oPreVenda.TotalPendura = 0;

            grid.Rows.Clear();
            lblOperador.Text = "Operador: " + this.Funcionario;
            lblTerminal.Text = "Terminal: " + 1;
            this.PicLogoTipo.Image = Properties.Resources.CasaMendes1Jpg;
        }

        private void BuscarProduto(string Filtro)
        {
            try
            {
                if (Filtro.Length < 8) return;
                if (oPreVenda.NumeroDaVenda == "0") { GerarNumero(); }

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

                        string[] row = { oPreVenda.ClienteId.ToString(), oPreVenda.NumeroDaVenda.ToString(), oPreVenda.TipoDeVenda.ToString(), oPreVenda.Desconto.ToString(), oPreVenda.Tributos.ToString(), oPreVenda.Juros.ToString(), oPreVenda.TotalPendura.ToString(), string.Format("{0,4:#0000}", count), oEstoque.CodigoDeBarras, oEstoque.Produto, this.TxtQuantidade.Text, oEstoque.PrecoDeVenda.ToString("N2"), SubTotal.ToString("N2") };
                        this.grid.Rows.Add(row);

                        this.TxtUnitario.Text = oEstoque.PrecoDeVenda.ToString("N2");
                        this.TxtSubTotal.Text = (clsGlobal.DeStringParaInt(TxtQuantidade.Text) * oEstoque.PrecoDeVenda).ToString("N2");
                        this.lblDescricaoProduto.Text = oEstoque.Produto.ToString();
                        if (oEstoque.Foto != null) this.PicLogoTipo.Image = Image.FromFile(oEstoque.Foto.ToString());
                        else this.PicLogoTipo.Image = Properties.Resources.CasaMendes1Jpg;

                        if (this.grid.Rows.Count > 0) { this.TxtTotal.Text = clsGlobal.Calcular(grid, 12).ToString("N2"); }
                        if (clsGlobal.DeStringParaInt(this.TxtQuantidade.Text) > 1) { this.TxtQuantidade.Text = "1"; }
                        this.Buscando = false;

                        if (grid.Rows.Count > 0)
                        {
                            grid.CurrentCell = grid.Rows[grid.Rows.Count - 1].Cells[8];
                        }
                      count++;

                        lblStatusCaixa.Text = "CAIXA OCUPADO";

                        oEstoque = null;

                        this.TxtCodigo.Focus();
                        this.TxtCodigo.SelectAll();
                    }
                }
                else
                {
                    if (Filtro.Length < 13)
                    {
                        this.TxtCodigo.Focus();
                    }
                    else
                    {
                        this.TxtCodigo.Focus();
                        this.TxtCodigo.SelectAll();
                        //return;
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

                int counte = this.grid.Rows.Count;
                if (this.grid.Rows.Count > 0)
                {

                    oPreVenda.Valor = clsGlobal.DeStringParaDecimal(this.TxtTotal.Text.Replace("R$ ", "").ToString());
                    frmFinlizarVendas oFinlizarVenda = new frmFinlizarVendas();
                    oFinlizarVenda.txtTotal.Text = oPreVenda.Valor.ToString("N2");
                    oFinlizarVenda.ShowDialog();

                    oPreVenda.Dinheiro = oFinlizarVenda.Dinheiro;
                    oPreVenda.Desconto = oFinlizarVenda.Desconto;
                    oPreVenda.Troco = oFinlizarVenda.Troco;
                    oPreVenda.ClienteId = oFinlizarVenda.ClienteId;
                    oPreVenda.TipoDeVenda = oFinlizarVenda.TipoDeVenda;

                    oPreVenda.Tributos = oFinlizarVenda.Tributos;
                    oPreVenda.Juros = oFinlizarVenda.Juros;
                    oPreVenda.TotalPendura = oFinlizarVenda.TotalPendura;

                    for (int i = 0; i < grid.Rows.Count; i++)
                    {
                        grid.Rows[i].Cells[0].Value = oPreVenda.ClienteId;
                        grid.Rows[i].Cells[1].Value = oPreVenda.NumeroDaVenda;
                        grid.Rows[i].Cells[2].Value = oPreVenda.TipoDeVenda;
                        grid.Rows[i].Cells[3].Value = oPreVenda.Desconto;
                        grid.Rows[i].Cells[4].Value = oPreVenda.Tributos;
                        grid.Rows[i].Cells[5].Value = oPreVenda.Juros;
                        grid.Rows[i].Cells[6].Value = oPreVenda.TotalPendura;
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

                    for (int i = 0; i <= counte - 1; i++)
                    {
                        oPreVenda.ClienteId = clsGlobal.DeStringParaInt(grid.Rows[i].Cells[0].Value.ToString());
                        oPreVenda.NumeroDaVenda = grid.Rows[i].Cells[1].Value.ToString();
                        oPreVenda.TipoDeVenda = grid.Rows[i].Cells[2].Value.ToString() == null ? "A VISTA" : grid.Rows[i].Cells[2].Value.ToString();
                        oPreVenda.Desconto = clsGlobal.DeStringParaDecimal(grid.Rows[i].Cells[3].Value.ToString());
                        oPreVenda.Tributos = clsGlobal.DeStringParaDecimal(grid.Rows[i].Cells[4].Value.ToString());
                        oPreVenda.Juros = clsGlobal.DeStringParaDecimal(grid.Rows[i].Cells[5].Value.ToString());
                        oPreVenda.TotalPendura = clsGlobal.DeStringParaDecimal(grid.Rows[i].Cells[6].Value.ToString());
                        oPreVenda.Produto = grid.Rows[i].Cells[9].Value.ToString();
                        oPreVenda.Quantidade = clsGlobal.DeStringParaInt(grid.Rows[i].Cells[10].Value.ToString().Trim());
                        oPreVenda.PrecoDeVenda = clsGlobal.DeStringParaDecimal(grid.Rows[i].Cells[11].Value.ToString().Replace("R$ ", ""));
                        oPreVenda.Valor = clsGlobal.DeStringParaDecimal(grid.Rows[i].Cells[12].Value.ToString().Replace("R$ ", ""));
                        oPreVenda.Salvar();
                    }

                    DialogResult dialogResult = MensagemBox.Mostrar("Deseja imprimir o cupom não fiscal?", "Sim", "Nao");
                    if (dialogResult == DialogResult.Yes)
                    {
                        ImprimirBoleto();
                    }

                    Limpar();
                }
            }
            catch
            {
            }
            finally
            {
                //TxtCodigo.Focus();
                //TxtCodigo.SelectAll();
            }

        }

        private void ImprimirBoleto()
        {
            ImprimeVendaVista oCupom = new ImprimeVendaVista(grid, oPreVenda);
            oCupom.Print();
        }

        private void GerarNumero()
        {
            //var rnd = new Random();
            int day = int.Parse(DateTime.Now.Day.ToString());
            int month = int.Parse(DateTime.Now.Month.ToString());
            int yar = int.Parse(DateTime.Now.Year.ToString());
            int minuto = int.Parse(DateTime.Now.Minute.ToString("G2"));
            DateTime dadetime = new DateTime(yar, month, day);
            DateTime dadetime2 = DateTime.Parse(DateTime.Now.ToString());
            string dteTime = dadetime.ToString("ddMMyyyy");
            string dteTime2 = dadetime2.ToString("HHmm");
            string numero = string.Concat(dteTime, dteTime2);
            oPreVenda.NumeroDaVenda = numero;
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
                FrmEstoque ffc = new FrmEstoque();
                ffc.ShowDialog();
                if (ffc.DialogResult.Equals(DialogResult.OK))
                {
                    TxtCodigo.Text = ffc.CodigoProduto;
                }
                else
                {
                    TxtCodigo.Focus();
                    TxtCodigo.SelectAll();
                }
                ffc.Dispose();
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
                    if (TxtCodigo.Text.Length < 4)
                    { this.TxtCodigo.Focus(); return; }
                }

                this.BuscarProduto(this.TxtCodigo.Text);
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

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            ImprimirBoleto();
        }

    }
}
