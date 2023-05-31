
using System;
using System.Windows.Forms;

namespace CasaMendes
{
    public partial class FrmCadClientes : Form
    {

        #region Variáveis

        public Cliente oCliente;
        readonly BindingSource BsCliente;

        #endregion

        #region propriedades

        public string StatusLabel { get; set; }

        #endregion

        #region Construtor

        public FrmCadClientes()
        {
            InitializeComponent();
            this.Text = clsGlobal.MontarTitulo("Cadastrar Cliente");
            oCliente = new Cliente();
            BsCliente = new BindingSource { oCliente };
        }

        #endregion

        #region Métodos auxiliares

        private void VincularBindingSource()
        {
            TxtCodigo.DataBindings.Add(new Binding("Text", BsCliente, "ClienteId"));
            TxtNome.DataBindings.Add(new Binding("Text", BsCliente, "Nome"));
            TxtEndereco.DataBindings.Add(new Binding("Text", BsCliente, "Endereco"));
            MkbCep.DataBindings.Add(new Binding("Text", BsCliente, "Cep"));
            TxtCidade.DataBindings.Add(new Binding("Text", BsCliente, "Cidade"));
            TxtBairro.DataBindings.Add(new Binding("Text", BsCliente, "Bairro"));
            DtpDataNascimento.DataBindings.Add(new Binding("Value", BsCliente, "DataNascimento"));
            MkbRg.DataBindings.Add(new Binding("Text", BsCliente, "Rg"));
            MkbCpf.DataBindings.Add(new Binding("Text", BsCliente, "Cpf"));
            MkbInscricaoEstadual.DataBindings.Add(new Binding("Text", BsCliente, "InscricaoEstadual"));
            MkbCnpj.DataBindings.Add(new Binding("Text", BsCliente, "Cnpj"));
            MkbTelefone.DataBindings.Add(new Binding("Text", BsCliente, "Telefone"));
            MkbCelular.DataBindings.Add(new Binding("Text", BsCliente, "Celular"));
            TxtEmail.DataBindings.Add(new Binding("Text", BsCliente, "Email"));
            TxtSite.DataBindings.Add(new Binding("Text", BsCliente, "SITE"));
        }

        private void AtribuirValores()
        {
            //BsCliente.DataSource = oCliente;
            CbEstado.Text = oCliente.Estado;
            CbPais.Text = oCliente.Pais;
        }

        #endregion

        #region KeyDown

        private void TxtNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.TxtNome.Text.Length != 0)
                {
                    this.TxtEndereco.Focus();
                }
                else
                {
                    this.TxtNome.Focus();
                    this.TxtNome.SelectAll();
                }
            }
        }

        private void TxtEndereco_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.MkbCep.Focus();
                this.MkbCep.SelectAll();
            }
        }

        private void MkbCep_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.TxtCidade.Focus();
                this.TxtCidade.SelectAll();
            }
        }

        private void TxtCidade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.TxtBairro.Focus();
                this.TxtBairro.SelectAll();
            }
        }

        private void TxtBairro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.CbEstado.Focus();
                this.CbEstado.SelectAll();
            }
        }

        private void CbEstado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.CbPais.Focus();
                this.CbPais.SelectAll();
            }
        }

        private void CbPais_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (PnlPessoaJuridica.Visible == true)
                {
                    this.MkbInscricaoEstadual.Focus();
                    this.MkbInscricaoEstadual.SelectAll();
                }
                else
                {
                    this.MkbRg.Focus();
                    this.MkbRg.SelectAll();
                }
            }
        }

        private void MkbInscricaoEstadual_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.MkbCnpj.Focus();
                this.MkbCnpj.SelectAll();
            }
        }

        private void MkbCnpj_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.MkbTelefone.Focus();
                this.MkbTelefone.SelectAll();
            }
        }

        private void MkbRg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.MkbCpf.Focus();
                this.MkbCpf.SelectAll();
            }
        }

        private void MkbCpf_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.MkbTelefone.Focus();
                this.MkbTelefone.SelectAll();
            }
        }

        private void MkbTelefone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.MkbCelular.Focus();
                this.MkbCelular.SelectAll();
            }
        }

        private void MkbCelular_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.TxtEmail.Focus();
                this.TxtEmail.SelectAll();
            }
        }

        private void TxtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.TxtSite.Focus();
                this.TxtSite.SelectAll();
            }

        }

        private void TxtSite_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.BtnGravar.Focus();
            }
        }

        #endregion

        #region Formulário
 
        private void FrmCadastrarClientes_Load(object sender, EventArgs e)
        {
            var oProcessando = new FrmProcessando();
            oProcessando.Show();
            oProcessando.TopMost = true;
            oProcessando.Processo(5, "Cadastrar cliente", "Carregando.");
            clsGlobal.CarregarPaises(this.CbPais);
            oProcessando.Processo(17, "Cadastrar cliente", "Carregando..");
            clsGlobal.CarregarEstados(this.CbEstado);
            oProcessando.Processo(34, "Cadastrar cliente", "Carregando...");
            if (oCliente.ClienteId > 0) BsCliente.DataSource = oCliente;
            oProcessando.Processo(51, "Cadastrar cliente", "Carregando.");
            VincularBindingSource();
            oProcessando.Processo(68, "Cadastrar cliente", "Carregando..");
            AtribuirValores();
            oProcessando.Processo(90, "Cadastrar cliente", "Carregando...");
            oProcessando.Close();
            oProcessando.Dispose();
        }

        #endregion

        #region Changed

        private void RbPF_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                PnlPessoaJuridica.Visible = false;
                LblPessoaFisica.Visible = true;
                LblPessoaJuridica.Visible = false;
                PnlPessoaFisica.Visible = true;
            }
            catch
            { }
        }

        private void RbPJ_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                PnlPessoaJuridica.Visible = false;
                LblPessoaJuridica.Visible = true;
                LblPessoaFisica.Visible = false;
                PnlPessoaFisica.Visible = false;
                PnlPessoaJuridica.Visible = true;
            }
            catch
            { }
        }

        private void CbStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (CbStatus.Checked == true) { CbStatus.Text = "ATIVO"; }
            else { CbStatus.Text = "INATIVO"; }
        }

        #endregion

        #region Click

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            this.oCliente.Estado = CbEstado.Text;
            this.oCliente.Pais = CbPais.Text;
            this.Close();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

    }
}
