using CasaMendes.Classes.Estatica;
using System;
using System.Collections;
using System.Windows.Forms;

namespace CasaMendes.Formularios
{
    public partial class frmCadastrarFornecedores : Form
    {

        #region Variáveis.

        Classes.cl_Fornecedores oFornecedores;

        #endregion

        #region Construtor.

        public frmCadastrarFornecedores(ArrayList arr = null)
        {
            InitializeComponent();

            this.Text = clsGlobal.MontarTitulo("Cadastrar fornecedores");

            try
            {
                if (arr[0].ToString() == "-1")
                {
                    clsGlobal.LimparControles((ControlCollection)this.Controls);
                    clsGlobal.AbilitarControles((ControlCollection)this.Controls, false);
                }
                //=================================================================================================
                oFornecedores = new Classes.cl_Fornecedores();
                oFornecedores.CodigoDoFornecedor = Convert.ToDecimal(arr[0].ToString());
                oFornecedores.RazaoSocial = arr[1].ToString();
                oFornecedores.Endereco = arr[2].ToString();

                if (arr[3].ToString() == "") { oFornecedores.Cep = 0; } else { oFornecedores.Cep = Convert.ToDecimal(arr[3].ToString()); }

                oFornecedores.Cidade = arr[4].ToString();
                oFornecedores.Bairro = arr[5].ToString();
                oFornecedores.Estado = arr[6].ToString();

                if (arr[7].ToString() == "") { oFornecedores.Cnpj = 0; } else { oFornecedores.Cnpj = Convert.ToDecimal(arr[7].ToString()); }
                if (arr[8].ToString() == "") { oFornecedores.InscricaoEstadual = 0; } else { oFornecedores.InscricaoEstadual = Convert.ToDecimal(arr[8].ToString()); }
                if (arr[9].ToString() == "") { oFornecedores.DataCadastro = DateTime.Now; } else { oFornecedores.DataCadastro = Convert.ToDateTime(arr[9].ToString()); }
                if (arr[10].ToString() == "") { oFornecedores.Telefone = 0; } else { oFornecedores.Telefone = Convert.ToDecimal(arr[10].ToString()); }
                if (arr[11].ToString() == "") { oFornecedores.Celular = 0; } else { oFornecedores.Celular = Convert.ToDecimal(arr[11].ToString()); }

                oFornecedores.SITE = arr[12].ToString().ToLower();
                oFornecedores.Email = arr[13].ToString().ToLower();

                //=================================================================================================
                if (oFornecedores.CodigoDoFornecedor != 0) { txtCodigoDoFornecedor.Text = oFornecedores.CodigoDoFornecedor.ToString(); } else { txtCodigoDoFornecedor.Clear(); }
                if (oFornecedores.RazaoSocial != "") { txtRazaoSocial.Text = oFornecedores.RazaoSocial.ToString(); } else { txtRazaoSocial.Clear(); }
                if (oFornecedores.Endereco != "") { txtEndereco.Text = oFornecedores.Endereco.ToString(); } else { txtEndereco.Clear(); }
                if (oFornecedores.Cep != 0) { mkbCep.Text = oFornecedores.Cep.ToString(); } else { mkbCep.Clear(); }
                if (oFornecedores.Cidade != "") { txtCidade.Text = oFornecedores.Cidade.ToString(); } else { txtCidade.Clear(); }
                if (oFornecedores.Bairro != "") { txtBairro.Text = oFornecedores.Bairro.ToString(); } else { txtBairro.Clear(); }
                if (oFornecedores.Estado != "") { cbEstado.Text = oFornecedores.Estado.ToString(); } else { cbEstado.Items.Clear(); }
                if (oFornecedores.Cnpj != 0) { mkbCNPJ.Text = oFornecedores.Cnpj.ToString(); } else { mkbCNPJ.Clear(); }
                if (oFornecedores.InscricaoEstadual != 0) { mkbInscricaoEstadual.Text = oFornecedores.InscricaoEstadual.ToString(); } else { mkbInscricaoEstadual.Clear(); }
                if (oFornecedores.Telefone != 0) { mkbTelefone.Text = oFornecedores.Telefone.ToString(); } else { mkbTelefone.Clear(); }
                if (oFornecedores.Celular != 0) { mkbCelular.Text = oFornecedores.Celular.ToString(); } else { mkbCelular.Clear(); }
                if (oFornecedores.SITE != "") { this.txtSite.Text = oFornecedores.SITE.ToString(); } else { this.txtSite.Clear(); }
                if (oFornecedores.Email != "") { this.txtEmail.Text = oFornecedores.Email.ToString(); } else { this.txtEmail.Clear(); }
                this.dtpDataDoCadastro.Text = oFornecedores.DataCadastro.ToString();

            }
            catch {; }
        }

        #endregion

        #region Manutenção.

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                string sTemp = "";
                if (oFornecedores == null) oFornecedores = new Classes.cl_Fornecedores();
                //============================================================================================
                if (this.txtRazaoSocial.Text == "") { return; }
                //============================================================================================
                if (this.txtCodigoDoFornecedor.Text != "") { oFornecedores.CodigoDoFornecedor = Convert.ToDecimal(this.txtCodigoDoFornecedor.Text); }
                oFornecedores.RazaoSocial = this.txtRazaoSocial.Text;
                oFornecedores.Endereco = this.txtEndereco.Text;

                //============================================================================================
                sTemp = this.mkbCep.Text.Replace("_", "").Replace("-", "").ToString();
                if (sTemp != "") { oFornecedores.Cep = Convert.ToDecimal(sTemp); } else { oFornecedores.Cep = 0; }
                //============================================================================================

                oFornecedores.Cidade = this.txtCidade.Text;
                oFornecedores.Bairro = this.txtBairro.Text;
                oFornecedores.Estado = this.cbEstado.Text;
                oFornecedores.DataCadastro = Convert.ToDateTime(this.dtpDataDoCadastro.Text);

                //============================================================================================
                sTemp = this.mkbCNPJ.Text.Replace("_", "").Replace("-", "").Replace(",", "").Replace("/", "");
                if (sTemp != "") { oFornecedores.Cnpj = Convert.ToDecimal(sTemp); } else { oFornecedores.Cnpj = 0; }
                //============================================================================================

                //============================================================================================
                sTemp = this.mkbInscricaoEstadual.Text.Replace("_", "").Replace(",", "").Replace(".", "").Trim();
                if (sTemp != "") { oFornecedores.InscricaoEstadual = Convert.ToDecimal(sTemp); } else { oFornecedores.InscricaoEstadual = 0; }
                //============================================================================================

                //============================================================================================
                sTemp = this.mkbTelefone.Text.Replace("(", "").Replace(")", "").Replace("_", "").Replace(" ", "").Replace("-", "").Replace("_", "").Trim();
                if (sTemp != "") { oFornecedores.Telefone = Convert.ToDecimal(sTemp); } else { oFornecedores.Telefone = 0; }
                //============================================================================================

                //============================================================================================
                sTemp = this.mkbCelular.Text.Replace("(", "").Replace(")", "").Replace("_", "").Replace(" ", "").Replace("-", "").Replace("_", "").Trim();
                if (sTemp != "") { oFornecedores.Celular = Convert.ToDecimal(sTemp); } else { oFornecedores.Celular = 0; }
                //============================================================================================

                oFornecedores.SITE = this.txtSite.Text;
                oFornecedores.Email = this.txtEmail.Text;

                //============================================================================================
                oFornecedores.Gravar();
                if (this.Tag.ToString() != "editar")
                {
                    DialogResult = MessageBox.Show(Classes.Estatica.clsMensagens.M00043 + " " + Classes.Estatica.clsMensagens.M00042, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (DialogResult == DialogResult.Yes)
                    {
                        clsGlobal.LimparControles((ControlCollection)this.Controls);
                        this.txtRazaoSocial.Focus();
                        this.txtRazaoSocial.SelectAll();
                    }

                    else
                    {
                        this.Close();
                    }
                }
            }
            catch {; }
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
                Classes.cl_Fornecedores.CarregarComboBox(this.cbEstado);
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

        #endregion

    }
}

//https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/language-specification/expressions#conditional-operator