using System;
using System.Windows.Forms;

namespace CasaMendes
{
    public partial class FrmPrincipal : Form
    {

        #region Variaveis

        private int childFormNumber = 0;

        #endregion

        #region Construtor

        public FrmPrincipal()
        {
            InitializeComponent();
            CriarTabelasDoSistema.CriarTabelas();
        }

        #endregion

        #region ToolsStrip

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStrip.Visible = ToolBarMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatusStrip.Visible = StatusBarMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form ChildForm in MdiChildren)
            {
                ChildForm.Close();
            }
        }

        #endregion

        #region Formulários do sistema

        private void FuncionarioMenuItem_Click(object sender, EventArgs e)
        {
            var funcionario = new FrmCadFuncionario();
            // Set the Parent Form of the Child window.
            funcionario.MdiParent = this;
            funcionario.Text = "Funcionarios " + childFormNumber++;
            // Display the new form.
            funcionario.Show();

            if (!this.WindowState.Equals(FormWindowState.Maximized))
            {
                funcionario.Top = this.Top;
                funcionario.Left = this.Left;
            }
            else
            {
                funcionario.Top = this.Top + 8;
                funcionario.Left = this.Left + 8;
            }
            this.AtualStatus.Text = $"Funcionários ativos: ( {funcionario.StatusLabel} ) funcionários.";
        }

        private void ClienteMenuItem_Click(object sender, EventArgs e)
        {
            var cliente = new FrmClientes();
            // Set the Parent Form of the Child window.
            cliente.MdiParent = this;
            cliente.Text = "Clientes " + childFormNumber++;
            // Display the new form.
            cliente.Show();

            if (!this.WindowState.Equals(FormWindowState.Maximized))
            {
                cliente.Top = this.Top;
                cliente.Left = this.Left;
            }
            else
            {
                cliente.Top = this.Top + 8;
                cliente.Left = this.Left + 8;
            }
            this.AtualStatus.Text = $"Cliente no cadastrado: ( {cliente.StatusLabel} ) clientes.";
        }

        private void FornecedorMenuItem_Click(object sender, EventArgs e)
        {
            var fornecedores = new FrmFornecedores();
            // Set the Parent Form of the Child window.
            fornecedores.MdiParent = this;
            fornecedores.Text = "Fornecedores " + childFormNumber++;
            // Display the new form.
            fornecedores.Show();

            if (!this.WindowState.Equals(FormWindowState.Maximized))
            {
                fornecedores.Top = this.Top;
                fornecedores.Left = this.Left;
            }
            else
            {
                fornecedores.Top = this.Top + 8;
                fornecedores.Left = this.Left + 8;
            }
            this.AtualStatus.Text = $"Fornecedores ativos.: ( {fornecedores.StatusLabel} ) clientes.";
        }

        private void ProdutoMenuItem_Click(object sender, EventArgs e)
        {
            var produtos = new FrmProdutos();
            // Set the Parent Form of the Child window.
            produtos.MdiParent = this;
            produtos.Text = "Produtos " + childFormNumber++;
            // Display the new form.
            produtos.Show();

            if (!this.WindowState.Equals(FormWindowState.Maximized))
            {
                produtos.Top = this.Top;
                produtos.Left = this.Left;
            }
            else
            {
                produtos.Top = this.Top + 8;
                produtos.Left = this.Left + 8;
            }

            this.AtualStatus.Text = $"Produtos cadastrados: ( {produtos.StatusLabel} ) Itens.";
        }

        private void FrenteDeCaixaMenuItem_Click(object sender, EventArgs e)
        {
            FrmFrenteDeCaixa frenteDeCaixa = new FrmFrenteDeCaixa();
            // Set the Parent Form of the Child window.
            //frenteDeCaixa.MdiParent = this;
            frenteDeCaixa.Text = "FrenteDeCaixa " + childFormNumber++;
            // Display the new form.
            frenteDeCaixa.ShowDialog();
        }

        private void EstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var estoque = new FrmEstoque();
            // Set the Parent Form of the Child window.
            estoque.MdiParent = this;
            estoque.Text = "Estoque " + childFormNumber++;
            // Display the new form.
            estoque.Show();

            if (!this.WindowState.Equals(FormWindowState.Maximized))
            {
                estoque.Top = this.Top;
                estoque.Left = this.Left;
            }
            else
            {
                estoque.Top = this.Top + 8;
                estoque.Left = this.Left + 8;
            }
            this.AtualStatus.Text = $"Produtos em estoque: (  {estoque.StatusLabel} ) Itens.";
        }

        private void VendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Vendas = new FrmCarregarVendas();
            // Set the Parent Form of the Child window.
            Vendas.MdiParent = this;
            childFormNumber++;
            Vendas.Width = this.Width - 20;
            Vendas.Height = this.Height - 120;
            // Display the new form.
            Vendas.Show();
            Vendas.gbBusca.Width = Vendas.DgvVendas.Width;

            if (!this.WindowState.Equals(FormWindowState.Maximized))
            {
                Vendas.Top = this.Top;
                Vendas.Left = this.Left;
            }
            else
            {
                Vendas.Top = this.Top + 8;
                Vendas.Left = this.Left + 8;
            }
            this.AtualStatus.Text = $"Número de venda(s): ( {Vendas.StatusLabel} )";
        }

        private void ReceberPenduraMenuItem_Click(object sender, EventArgs e)
        {
            var CarregarVenda = new FrmCarregarVendas();
            // Set the Parent Form of the Child window.
            CarregarVenda.MdiParent = this;
            CarregarVenda.Text = "ResumoDeVendasAtual " + childFormNumber++;
            // Display the new form.
            CarregarVenda.Show();

            if (!this.WindowState.Equals(FormWindowState.Maximized))
            {
                CarregarVenda.Top = this.Top;
                CarregarVenda.Left = this.Left;
            }
            else
            {
                CarregarVenda.Top = this.Top + 8;
                CarregarVenda.Left = this.Left + 8;
            }
            this.AtualStatus.Text = $"Venda(s): ( {CarregarVenda.StatusLabel} ) efetuadas até: {DateTime.Now.ToShortDateString()}.";
        }

        private void CategoriaMenuItem_Click(object sender, EventArgs e)
        {
            var CadCategoria = new FrmCadCategoria();
            // Set the Parent Form of the Child window.
            CadCategoria.MdiParent = this;
            CadCategoria.Text = "Categorias " + childFormNumber++;
            // Display the new form.
            CadCategoria.Show();

            if (!this.WindowState.Equals(FormWindowState.Maximized))
            {
                CadCategoria.Top = this.Top;
                CadCategoria.Left = this.Left;
            }
            else
            {
                CadCategoria.Top = this.Top + 8;
                CadCategoria.Left = this.Left + 8;
            }
            this.AtualStatus.Text = $"Categoria(s): ( {CadCategoria.StatusLabel} ) definida(s).";
        }

        private void SubCategoriaMenuItem_Click(object sender, EventArgs e)
        {
            var CadSubcategoria = new FrmCadSubcategoria();
            // Set the Parent Form of the Child window.
            CadSubcategoria.MdiParent = this;
            CadSubcategoria.Text = "SubCategorias " + childFormNumber++;
            // Display the new form.
            CadSubcategoria.Show();

            if (!this.WindowState.Equals(FormWindowState.Maximized))
            {
                CadSubcategoria.Top = this.Top;
                CadSubcategoria.Left = this.Left;
            }
            else
            {
                CadSubcategoria.Top = this.Top + 8;
                CadSubcategoria.Left = this.Left + 8;
            }
            this.AtualStatus.Text = $"Subcategoria(s): ( {CadSubcategoria.StatusLabel} ) definida(s).";
        }

        private void PrecosMenuItem_Click(object sender, EventArgs e)
        {
            var oTabelaDeMargen = new FrmTabelaDeMargen();
            // Set the Parent Form of the Child window.
            oTabelaDeMargen.MdiParent = this;
            oTabelaDeMargen.Text = "SubCategorias " + childFormNumber++;
            // Display the new form.
            oTabelaDeMargen.Show();
            if (!this.WindowState.Equals(FormWindowState.Maximized))
            {
                oTabelaDeMargen.Top = this.Top;
                oTabelaDeMargen.Left = this.Left;
            }
            else
            {
                oTabelaDeMargen.Top = this.Top + 8;
                oTabelaDeMargen.Left = this.Left + 8;
            }
            this.AtualStatus.Text = $"Existem: ( {oTabelaDeMargen.StatusLabel} ) regras de preços definida(s).";
        }

        #endregion

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                FrenteDeCaixaMenuItem_Click(null, null);
            }
            catch { }
        }

    }
}
