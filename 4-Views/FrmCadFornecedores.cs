
using System;
using System.Collections;
using System.Windows.Forms;

namespace CasaMendes
{
    public partial class FrmCadFornecedores : Form
    {

        #region Variáveis

        public Fornecedore oFornecedor;
        BindingSource BsFornecedor;

        //int LinhaIndex;
        //bool editar;

        #endregion

        #region propriedades

        public string StatusLabel { get; set; }

        #endregion

        #region Construtor.

        public FrmCadFornecedores()
        {
            InitializeComponent();
            oFornecedor = new Fornecedore();
            BsFornecedor = new BindingSource { oFornecedor };
            this.Text = clsGlobal.MontarTitulo("Cadastrar fornecedores");
        }

        #endregion

        #region Métodos auxiliares

        private void VincularBindingSource()
        {
            txtCodigoDoFornecedor.DataBindings.Add(new Binding("Text", BsFornecedor, "CodigoDoFornecedor"));
            txtRazaoSocial.DataBindings.Add(new Binding("Text", BsFornecedor, "RazaoSocial"));
            txtEndereco.DataBindings.Add(new Binding("Text", BsFornecedor, "Endereco"));
            mkbCep.DataBindings.Add(new Binding("Text", BsFornecedor, "Cep"));
            txtCidade.DataBindings.Add(new Binding("Text", BsFornecedor, "Cidade"));
            txtBairro.DataBindings.Add(new Binding("Text", BsFornecedor, "Bairro"));
            dtpDataDoCadastro.DataBindings.Add(new Binding("Value", BsFornecedor, "DataCadastro"));
            mkbInscricaoEstadual.DataBindings.Add(new Binding("Text", BsFornecedor, "InscricaoEstadual"));
            mkbCNPJ.DataBindings.Add(new Binding("Text", BsFornecedor, "Cnpj"));
            mkbTelefone.DataBindings.Add(new Binding("Text", BsFornecedor, "Telefone"));
            mkbCelular.DataBindings.Add(new Binding("Text", BsFornecedor, "Celular"));
            txtEmail.DataBindings.Add(new Binding("Text", BsFornecedor, "Email"));
            txtSite.DataBindings.Add(new Binding("Text", BsFornecedor, "SITE"));
        }

        private void AtribuirValores()
        {
            //BsCliente.DataSource = oCliente;
            cbEstado.Text = oFornecedor.Enderecos.Estado;
            //cbPais.Text = oFornecedor.Pais;
        }

        #endregion

        #region Click

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string c = oFornecedor.Cnpj.Replace(",", "").Replace("-", "").Replace("-", "").Replace("/", "");
            oFornecedor.Cnpj = c;
            string i = oFornecedor.InscricaoEstadual.Replace(",", "");
            oFornecedor.Cnpj = c;
            this.oFornecedor.Enderecos.Estado = cbEstado.Text;
            this.Close();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region KeyDown

        private void txtRazaoSocial_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (this.txtRazaoSocial.Text.Length >= 49))
            {
                if (this.txtRazaoSocial.Text != "")
                {
                    this.txtEndereco.Enabled = true;
                    this.txtEndereco.Focus();
                    this.txtEndereco.SelectAll();
                }
                else { this.txtRazaoSocial.Focus(); }
            }
        }

        private void txtEndereco_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (this.txtEndereco.Text.Length >= 49))
            {
                this.mkbCep.Enabled = true;
                this.mkbCep.Focus();
                this.mkbCep.SelectAll();
            }
        }

        private void mkbCep_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (this.mkbCep.Text.Length >= 7))
            {
                this.txtCidade.Enabled = true;
                this.txtCidade.Focus();
                this.txtCidade.SelectAll();
            }
        }

        private void txtCidade_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (this.txtCidade.Text.Length >= 29))
            {
                this.txtBairro.Enabled = true;
                this.txtBairro.Focus();
                this.txtBairro.SelectAll();
            }
        }

        private void txtBairro_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (this.txtBairro.Text.Length >= 29))
            {
                //Classes.cl_Fornecedores.CarregarComboBox(this.cbEstado);
                cbEstado.SelectedIndex = 0;
                this.cbEstado.Enabled = true;
                this.cbEstado.Focus();
                this.cbEstado.SelectAll();
            }

        }

        private void cbEstado_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (this.cbEstado.Text.Length >= 19))
            {
                this.mkbCNPJ.Enabled = true;
                this.mkbCNPJ.Focus();
                this.mkbCNPJ.SelectAll();
            }
        }

        private void mkbCNPJ_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (this.mkbCNPJ.Text.Length >= 15))
            {
                this.mkbInscricaoEstadual.Enabled = true;
                this.mkbInscricaoEstadual.Focus();
                this.mkbInscricaoEstadual.SelectAll();
            }
        }

        private void mkbInscricaoEstadual_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (this.txtEndereco.Text.Length >= 13))
            {
                this.dtpDataDoCadastro.Enabled = true;
                this.dtpDataDoCadastro.Focus();
            }
        }

        private void dtpDataDoCadastro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.mkbTelefone.Enabled = true;
                this.mkbTelefone.Focus();
                this.mkbTelefone.SelectAll();
            }
        }

        private void mkbTelefone_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (this.mkbTelefone.Text.Length >= 14))
            {
                this.mkbCelular.Enabled = true;
                this.mkbCelular.Focus();
                this.mkbCelular.SelectAll();
            }
        }

        private void mkbCelular_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (this.mkbCelular.Text.Length >= 13))
            {
                this.txtEmail.Enabled = true;
                this.txtEmail.Focus();
                this.txtEmail.SelectAll();
            }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (this.txtEmail.Text.Length >= 81))
            {
                this.txtSite.Enabled = true;
                this.txtSite.Focus();
                this.txtSite.SelectAll();
            }
        }

        private void txtSite_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (this.txtSite.Text.Length >= 81))
            {
                this.btnGravar.Enabled = true;
                this.btnGravar.Focus();
            }
        }

        public static implicit operator FrmCadFornecedores(FrmCadClientes v)
        {
            throw new NotImplementedException();
        }

        #endregion

        private void frmCadastrarFornecedores_Load(object sender, EventArgs e)
        {
            clsGlobal.CarregarEstados(this.cbEstado);
            //if (oFornecedor.CodigoDoFornecedor.Equals(0))
            BsFornecedor.DataSource = oFornecedor;
            VincularBindingSource();
            AtribuirValores();
        }
    }
}
