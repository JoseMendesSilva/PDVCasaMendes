
using System;
using System.Collections;
using System.Windows.Forms;

namespace CasaMendes
{
    public partial class FrmCadFornecedores : Form
    {

        #region Variáveis

        public Fornecedore oFornecedor;
        private readonly BindingSource BsFornecedor;

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
            TxtCodigoDoFornecedor.DataBindings.Add(new Binding("Text", BsFornecedor, "CodigoDoFornecedor"));
            TxtRazaoSocial.DataBindings.Add(new Binding("Text", BsFornecedor, "RazaoSocial"));
            TxtEndereco.DataBindings.Add(new Binding("Text", BsFornecedor, "Endereco"));
            MkbCep.DataBindings.Add(new Binding("Text", BsFornecedor, "Cep"));
            TxtCidade.DataBindings.Add(new Binding("Text", BsFornecedor, "Cidade"));
            TxtBairro.DataBindings.Add(new Binding("Text", BsFornecedor, "Bairro"));
            DtpDataDoCadastro.DataBindings.Add(new Binding("Value", BsFornecedor, "DataCadastro"));
            MkbInscricaoEstadual.DataBindings.Add(new Binding("Text", BsFornecedor, "InscricaoEstadual"));
            MkbCNPJ.DataBindings.Add(new Binding("Text", BsFornecedor, "Cnpj"));
            MkbTelefone.DataBindings.Add(new Binding("Text", BsFornecedor, "Telefone"));
            MkbCelular.DataBindings.Add(new Binding("Text", BsFornecedor, "Celular"));
            TxtEmail.DataBindings.Add(new Binding("Text", BsFornecedor, "Email"));
            TxtSite.DataBindings.Add(new Binding("Text", BsFornecedor, "SITE"));
        }

        private void AtribuirValores()
        {
            CbEstado.Text = oFornecedor.Estado;
        }

        #endregion

        #region Click

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            oFornecedor.Cnpj = oFornecedor.Cnpj.Replace(",", "").Replace("-", "").Replace("-", "").Replace("/", "");
            oFornecedor.InscricaoEstadual = oFornecedor.InscricaoEstadual.Replace(",", "");
            this.oFornecedor.Estado = CbEstado.Text;
            this.Close();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region KeyDown

        private void TxtRazaoSocial_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (this.TxtRazaoSocial.Text.Length >= 49))
            {
                if (this.TxtRazaoSocial.Text != "")
                {
                    this.TxtEndereco.Enabled = true;
                    this.TxtEndereco.Focus();
                    this.TxtEndereco.SelectAll();
                }
                else { this.TxtRazaoSocial.Focus(); }
            }
        }

        private void TxtEndereco_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (this.TxtEndereco.Text.Length >= 49))
            {
                this.MkbCep.Enabled = true;
                this.MkbCep.Focus();
                this.MkbCep.SelectAll();
            }
        }

        private void MkbCep_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (this.MkbCep.Text.Length >= 7))
            {
                this.TxtCidade.Enabled = true;
                this.TxtCidade.Focus();
                this.TxtCidade.SelectAll();
            }
        }

        private void TxtCidade_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (this.TxtCidade.Text.Length >= 29))
            {
                this.TxtBairro.Enabled = true;
                this.TxtBairro.Focus();
                this.TxtBairro.SelectAll();
            }
        }

        private void TxtBairro_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (this.TxtBairro.Text.Length >= 29))
            {
                //Classes.cl_Fornecedores.CarregarComboBox(this.cbEstado);
                CbEstado.SelectedIndex = 0;
                this.CbEstado.Enabled = true;
                this.CbEstado.Focus();
                this.CbEstado.SelectAll();
            }

        }

        private void CbEstado_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (this.CbEstado.Text.Length >= 19))
            {
                this.MkbCNPJ.Enabled = true;
                this.MkbCNPJ.Focus();
                this.MkbCNPJ.SelectAll();
            }
        }

        private void MkbCNPJ_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (this.MkbCNPJ.Text.Length >= 15))
            {
                this.MkbInscricaoEstadual.Enabled = true;
                this.MkbInscricaoEstadual.Focus();
                this.MkbInscricaoEstadual.SelectAll();
            }
        }

        private void MkbInscricaoEstadual_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (this.TxtEndereco.Text.Length >= 13))
            {
                this.DtpDataDoCadastro.Enabled = true;
                this.DtpDataDoCadastro.Focus();
            }
        }

        private void DtpDataDoCadastro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.MkbTelefone.Enabled = true;
                this.MkbTelefone.Focus();
                this.MkbTelefone.SelectAll();
            }
        }

        private void MkbTelefone_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (this.MkbTelefone.Text.Length >= 14))
            {
                this.MkbCelular.Enabled = true;
                this.MkbCelular.Focus();
                this.MkbCelular.SelectAll();
            }
        }

        private void MkbCelular_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (this.MkbCelular.Text.Length >= 13))
            {
                this.TxtEmail.Enabled = true;
                this.TxtEmail.Focus();
                this.TxtEmail.SelectAll();
            }
        }

        private void TxtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (this.TxtEmail.Text.Length >= 81))
            {
                this.TxtSite.Enabled = true;
                this.TxtSite.Focus();
                this.TxtSite.SelectAll();
            }
        }

        private void TxtSite_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (this.TxtSite.Text.Length >= 81))
            {
                this.BtnGravar.Enabled = true;
                this.BtnGravar.Focus();
            }
        }

        public static implicit operator FrmCadFornecedores(FrmCadClientes v)
        {
            throw new NotImplementedException();
        }

        #endregion

        private void FrmCadastrarFornecedores_Load(object sender, EventArgs e)
        {
            clsGlobal.CarregarEstados(this.CbEstado);
            BsFornecedor.DataSource = oFornecedor;
            VincularBindingSource();
            AtribuirValores();
        }

        /*frmBuscarProduto*/
    }
}
