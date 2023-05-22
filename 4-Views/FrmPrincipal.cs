using System;
using System.Windows.Forms;

namespace CasaMendes
{
    public partial class FrmPrincipal : Form
    {
        private int childFormNumber = 0;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        #region ToolsStrip

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
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
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
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
            //funcionario.Width = this.Width - 20;
            //funcionario.Height = this.Height - 120;
            funcionario.Top = this.Top + 8;
            funcionario.Left = this.Left + 8;
            //funcionario.WindowState = FormWindowState.Maximized;
            this.StatusLabeTtoolStrip.Text = "Funcionários cadastrados atualmente: ( " + funcionario.StatusLabel + " ) funcionários.";
        }

        private void ClienteMenuItem_Click(object sender, EventArgs e)
        {
            var cliente = new frmClientes();
            // Set the Parent Form of the Child window.
            cliente.MdiParent = this;
            cliente.Text = "Clientes " + childFormNumber++;
            // Display the new form.
            cliente.Show();
            //cliente.Width = this.Width - 20;
            //cliente.Height = this.Height - 120;
            cliente.Top = this.Top + 8;
            cliente.Left = this.Left + 8;
            //cliente.WindowState = FormWindowState.Maximized;
            this.StatusLabeTtoolStrip.Text = "Cliente cadastrados atualmente: ( " + cliente.StatusLabel + " ) clientes.";
        }

        private void FornecedorMenuItem_Click(object sender, EventArgs e)
        {
            var fornecedores = new frmFornecedores();
            // Set the Parent Form of the Child window.
            fornecedores.MdiParent = this;
            fornecedores.Text = "Fornecedores " + childFormNumber++;
            // Display the new form.
            fornecedores.Show();
            //fornecedores.Width = this.Width - 20;
            //fornecedores.Height = this.Height - 120;
            fornecedores.Top = this.Top + 8;
            fornecedores.Left = this.Left + 8;
            //fornecedores.WindowState = FormWindowState.Maximized;
            this.StatusLabeTtoolStrip.Text = "Cliente cadastrados atualmente: ( " + fornecedores.StatusLabel + " ) clientes.";
        }

        private void ProdutoMenuItem_Click(object sender, EventArgs e)
        {
            var produtos = new FrmProdutos();
            // Set the Parent Form of the Child window.
            produtos.MdiParent = this;
            produtos.Text = "Produtos " + childFormNumber++;
            // Display the new form.
            produtos.Show();

            produtos.Width = this.Width - 20;
            produtos.Height = this.Height - 120;
            produtos.Top = this.Top + 8;
            produtos.Left = this.Left + 8;

            //produtos.WindowState = FormWindowState.Maximized;
            this.StatusLabeTtoolStrip.Text = "Produtos cadastrados: ( " + produtos.StatusLabel + " ) Itens.";
        }

        private void FrenteDeCaixaMenuItem_Click(object sender, EventArgs e)
        {
            var frenteDeCaixa = new FrmFrenteDeCaixa();
            // Set the Parent Form of the Child window.
            //frenteDeCaixa.MdiParent = this;
            frenteDeCaixa.Text = "FrenteDeCaixa " + childFormNumber++;
            // Display the new form.
            frenteDeCaixa.ShowDialog();
            //frenteDeCaixa.Top = this.Top + 8;
            //frenteDeCaixa.Left = this.Left + 8;
            //frenteDeCaixa.WindowState = FormWindowState.Maximized;
            //this.StatusLabeTtoolStrip.Text = "Produtos em estoque: ( " + frenteDeCaixa.StatusLabel + " ) Itens.";
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var estoque = new FrmEstoque();
            // Set the Parent Form of the Child window.
            estoque.MdiParent = this;
            estoque.Text = "Estoque " + childFormNumber++;
            // Display the new form.
            estoque.Show();
            //estoque.Width = this.Width - 20;
            //estoque.Height = this.Height - 120;
            estoque.Top = this.Top + 8;
            estoque.Left = this.Left + 8;
            //estoque.WindowState = FormWindowState.Maximized;
            this.StatusLabeTtoolStrip.Text = "Produtos em estoque: ( " + estoque.StatusLabel + " ) Itens.";
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ResumoDeVenda = new FrmCarregarVendas();
            // Set the Parent Form of the Child window.
            ResumoDeVenda.MdiParent = this;
            ResumoDeVenda.Text = "ResumoDeVendasAtual " + childFormNumber++;
            // Display the new form.
            ResumoDeVenda.Show();
            //ResumoDeVenda.Width = this.Width - 20;
            //ResumoDeVenda.Height = this.Height - 120;
            ResumoDeVenda.Top = this.Top + 8;
            ResumoDeVenda.Left = this.Left + 8;
            //ResumoDeVenda.WindowState = FormWindowState.Maximized;
            //this.StatusLabeTtoolStrip.Text = "Produtos em estoque: ( " + ResumoDeVenda.StatusLabel + " ) Itens.";
        }

        private void ReceberPenduraMenuItem_Click(object sender, EventArgs e)
        {
            var CarregarVenda = new frmCarregarVendasCliente();
            // Set the Parent Form of the Child window.
            CarregarVenda.MdiParent = this;
            CarregarVenda.Text = "ResumoDeVendasAtual " + childFormNumber++;
            // Display the new form.
            CarregarVenda.Show();
            //CarregarVenda.Width = this.Width - 20;
            //CarregarVenda.Height = this.Height - 120;
            CarregarVenda.Top = this.Top + 8;
            CarregarVenda.Left = this.Left + 8;
            //CarregarVenda.WindowState = FormWindowState.Maximized;
            //this.StatusLabeTtoolStrip.Text = "Produtos em estoque: ( " + ResumoDeVenda.StatusLabel + " ) Itens.";
        }

        private void CategoriaMenuItem_Click(object sender, EventArgs e)
        {
            var CadCategoria = new FrmCadCategoria();
            // Set the Parent Form of the Child window.
            CadCategoria.MdiParent = this;
            CadCategoria.Text = "Categorias " + childFormNumber++;
            // Display the new form.
            CadCategoria.Show();
            //CadCategoria.WindowState = FormWindowState.Maximized;
            //CadCategoria.Width = this.Width - 20;
            //CadCategoria.Height = this.Height - 120;
            CadCategoria.Top = this.Top + 8;
            CadCategoria.Left = this.Left + 8;
            //this.StatusLabeTtoolStrip.Text = "Produtos em estoque: ( " + ResumoDeVenda.StatusLabel + " ) Itens.";
        }

        private void SubCategoriaMenuItem_Click(object sender, EventArgs e)
        {
            var CadSubcategoria = new FrmCadSubcategoria();
            // Set the Parent Form of the Child window.
            CadSubcategoria.MdiParent = this;
            CadSubcategoria.Text = "SubCategorias " + childFormNumber++;
            // Display the new form.
            CadSubcategoria.Show();
            //CadSubcategoria.Width = this.Width - 20;
            //CadSubcategoria.Height = this.Height - 120;
            CadSubcategoria.Top = this.Top + 8;
            CadSubcategoria.Left = this.Left + 8;

            //CadSubcategoria.WindowState = FormWindowState.Maximized;
            //this.StatusLabeTtoolStrip.Text = "Produtos em estoque: ( " + ResumoDeVenda.StatusLabel + " ) Itens.";
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
            //oTabelaDeMargen.Width = this.Width - 20;
            //oTabelaDeMargen.Height = this.Height - 120;
            //oTabelaDeMargen.WindowState = FormWindowState.Maximized;
            //this.StatusLabeTtoolStrip.Text = "Produtos em estoque: ( " + oTabelaDeMargen.StatusLabel + " ) Itens.";
        }

        #endregion
  
    }
}
