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

        //private void ShowNewForm(object sender, EventArgs e)
        //{
        //}

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

        private void FuncionarioMenuItem_Click(object sender, EventArgs e)
        {
            var funcionario = new frmCadastrarFuncionario();
            // Set the Parent Form of the Child window.
            funcionario.MdiParent = this;
            funcionario.Text = "Janela " + childFormNumber++;
            // Display the new form.
            funcionario.Show();
            funcionario.WindowState = FormWindowState.Maximized;
            this.StatusLabeTtoolStrip.Text = "Funcionários cadastrados atualmente: ( " + funcionario.StatusLabel + " ) funcionários.";
        }

        private void ClienteMenuItem_Click(object sender, EventArgs e)
        {
            //var cliente = new frmCadastrarClientes();
            //// Set the Parent Form of the Child window.
            //cliente.MdiParent = this;
            //cliente.Text = "Janela " + childFormNumber++;
            //// Display the new form.
            //cliente.Show();
            //cliente.WindowState = FormWindowState.Maximized;
            //this.StatusLabeTtoolStrip.Text = "Cliente cadastrados atualmente: ( " + cliente.StatusLabel + " ) clientes.";
            
            var cliente = new frmClientes();
            // Set the Parent Form of the Child window.
            cliente.MdiParent = this;
            cliente.Text = "Janela " + childFormNumber++;
            // Display the new form.
            cliente.Show();
            cliente.WindowState = FormWindowState.Maximized;
            this.StatusLabeTtoolStrip.Text = "Cliente cadastrados atualmente: ( " + cliente.StatusLabel + " ) clientes.";
        }

        private void FornecedorMenuItem_Click(object sender, EventArgs e)
        {
            var fornecedores = new frmFornecedores();
            // Set the Parent Form of the Child window.
            fornecedores.MdiParent = this;
            fornecedores.Text = "Janela " + childFormNumber++;
            // Display the new form.
            fornecedores.Show();
            fornecedores.WindowState = FormWindowState.Maximized;
            this.StatusLabeTtoolStrip.Text = "Cliente cadastrados atualmente: ( " + fornecedores.StatusLabel + " ) clientes.";
        }

        private void ProdutoMenuItem_Click(object sender, EventArgs e)
        {
            var produtos = new FrmProdutos();
            // Set the Parent Form of the Child window.
            produtos.MdiParent = this;
            produtos.Text = "Janela " + childFormNumber++;
            // Display the new form.
            produtos.Show();
            produtos.WindowState = FormWindowState.Maximized;
            this.StatusLabeTtoolStrip.Text = "Produtos cadastrados atualmente em estoque: ( " + produtos.StatusLabel + " ) Itens.";
        }

        private void EstoqueMenuItem_Click(object sender, EventArgs e)
        {
            var estoque = new FrmEstoque();
            // Set the Parent Form of the Child window.
            estoque.MdiParent = this;
            estoque.Text = "Janela " + childFormNumber++;
            // Display the new form.
            estoque.Show();
            estoque.WindowState = FormWindowState.Maximized;
            this.StatusLabeTtoolStrip.Text = "Produtos em estoque: ( " + estoque.StatusLabel + " ) Itens.";
        }
    }
}
