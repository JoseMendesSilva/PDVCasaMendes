﻿
using CasaMendes.Classes.Estatica;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CasaMendes
{
    public partial class frmCadastrarClientes : Form
    {

        #region Variáveis
        public Cliente oCliente;
        BindingSource BsCliente;
        #endregion

        #region propriedades
        public string StatusLabel { get; set; }
        #endregion

        #region Construtor

        public frmCadastrarClientes()
        {
            InitializeComponent();
            this.Text = clsGlobal.MontarTitulo("Cadastrar Cliente");
            oCliente = new Cliente();
            BsCliente = new BindingSource { oCliente };
            //if (oCliente.ClienteId.Equals(0)) BsCliente.DataSource = oCliente;
            //editar = false;
        }

        #endregion

        #region Métodos auxiliares

        private void VincularBindingSource()
        {
            txtCodigo.DataBindings.Add(new Binding("Text", BsCliente, "ClienteId"));
            txtNome.DataBindings.Add(new Binding("Text", BsCliente, "Nome"));
            txtEndereco.DataBindings.Add(new Binding("Text", BsCliente, "Endereco"));
            mkbCep.DataBindings.Add(new Binding("Text", BsCliente, "Cep"));
            txtCidade.DataBindings.Add(new Binding("Text", BsCliente, "Cidade"));
            txtBairro.DataBindings.Add(new Binding("Text", BsCliente, "Bairro"));
            dtpDataNascimento.DataBindings.Add(new Binding("Value", BsCliente, "DataNascimento"));
            mkbRg.DataBindings.Add(new Binding("Text", BsCliente, "Rg"));
            mkbCpf.DataBindings.Add(new Binding("Text", BsCliente, "Cpf"));
            mkbInscricaoEstadual.DataBindings.Add(new Binding("Text", BsCliente, "InscricaoEstadual"));
            mkbCnpj.DataBindings.Add(new Binding("Text", BsCliente, "Cnpj"));
            mkbTelefone.DataBindings.Add(new Binding("Text", BsCliente, "Telefone"));
            mkbCelular.DataBindings.Add(new Binding("Text", BsCliente, "Celular"));
            txtEmail.DataBindings.Add(new Binding("Text", BsCliente, "Email"));
            txtSite.DataBindings.Add(new Binding("Text", BsCliente, "SITE"));
        }

        //private void Limpar()
        //{
        //    txtCodigo.Clear();
        //    txtNome.Clear();
        //    txtEndereco.Clear();
        //    mkbCep.Clear();
        //    txtCidade.Clear();
        //    txtBairro.Clear();
        //    dtpDataNascimento.Value = DateTime.Now;
        //    mkbRg.Clear();
        //    mkbCpf.Clear();
        //    mkbInscricaoEstadual.Clear();
        //    mkbCnpj.Clear();
        //    mkbTelefone.Clear();
        //    mkbCelular.Clear();
        //    txtEmail.Clear();
        //    txtSite.Clear();

        //}

        private void AtribuirValores()
        {
            BsCliente.DataSource = oCliente;
            cbEstado.Text = oCliente.Estado;
            cbPais.Text = oCliente.Pais;
        }

        //private void Botoes(bool status)
        //{
        //    this.BtnNovo.Visible = status;
        //    this.BtnCancelar.Visible = !status;
        //    this.btnExcluir.Enabled = status;
        //    this.btnFechar.Enabled = status;
        //}

        #endregion

        #region KeyDown

        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.txtNome.Text.Length != 0)
                {
                    this.txtEndereco.Focus();
                }
                else
                {
                    this.txtNome.Focus();
                    this.txtNome.SelectAll();
                }
            }
        }

        private void txtEndereco_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.mkbCep.Focus();
                this.mkbCep.SelectAll();
            }
        }

        private void mkbCep_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.txtCidade.Focus();
                this.txtCidade.SelectAll();
            }
        }

        private void txtCidade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.txtBairro.Focus();
                this.txtBairro.SelectAll();
            }
        }

        private void txtBairro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.cbEstado.Focus();
                this.cbEstado.SelectAll();
            }
        }

        private void cbEstado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.cbPais.Focus();
                this.cbPais.SelectAll();
            }
        }

        private void cbPais_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (pnlPessoaJuridica.Visible == true)
                {
                    this.mkbInscricaoEstadual.Focus();
                    this.mkbInscricaoEstadual.SelectAll();
                }
                else
                {
                    this.mkbRg.Focus();
                    this.mkbRg.SelectAll();
                }
            }
        }

        private void mkbInscricaoEstadual_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.mkbCnpj.Focus();
                this.mkbCnpj.SelectAll();
            }
        }

        private void mkbCnpj_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.mkbTelefone.Focus();
                this.mkbTelefone.SelectAll();
            }
        }

        private void mkbRg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.mkbCpf.Focus();
                this.mkbCpf.SelectAll();
            }
        }

        private void mkbCpf_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.mkbTelefone.Focus();
                this.mkbTelefone.SelectAll();
            }
        }

        private void mkbTelefone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.mkbCelular.Focus();
                this.mkbCelular.SelectAll();
            }
        }

        private void mkbCelular_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.txtEmail.Focus();
                this.txtEmail.SelectAll();
            }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.txtSite.Focus();
                this.txtSite.SelectAll();
            }

        }

        private void txtSite_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.btnGravar.Focus();
            }
        }

        #endregion

        #region Formulário
        //private void frmCadastrarClientes_Activated(object sender, EventArgs e)
        //{
        //    this.txtNome.Focus();
        //    this.txtNome.SelectAll();
        //}

        private void frmCadastrarClientes_Load(object sender, EventArgs e)
        {
            //Limpar();
            clsGlobal.CarregarPaises(this.cbPais);
            clsGlobal.CarregarEstados(this.cbEstado);
            if (oCliente.ClienteId > 0) BsCliente.DataSource = oCliente;
            VincularBindingSource();
            //AtribuirValores();
        }
        #endregion

        #region Changed
        private void rbPF_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                pnlPessoaJuridica.Visible = false;
                lblPessoaFisica.Visible = true;
                lblPessoaJuridica.Visible = false;
                pnlPessoaFisica.Visible = true;
            }
            catch
            { }
        }

        private void rbPJ_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                pnlPessoaJuridica.Visible = false;
                lblPessoaJuridica.Visible = true;
                lblPessoaFisica.Visible = false;
                pnlPessoaFisica.Visible = false;
                pnlPessoaJuridica.Visible = true;
            }
            catch
            { }
        }

        private void cbStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (cbStatus.Checked == true) { cbStatus.Text = "ATIVO"; }
            else { cbStatus.Text = "INATIVO"; }
        }

        //private void txtNome_TextChanged(object sender, EventArgs e)
        //{
        //    if (txtNome.Text.Length > 0)
        //    {
        //        BtnBuscar.Enabled = btnGravar.Enabled = true;
        //    }
        //    else
        //    {
        //        BtnBuscar.Enabled = btnGravar.Enabled = false;
        //    }
        //}
        #endregion

        #region Click
        private void btnGravar_Click(object sender, EventArgs e)
        {
            this.Close();
            //try
            //{
            //    if (txtNome.Text.Length > 0)
            //    {
            //        if (editar.Equals(false))
            //        {
            //            BtnBuscar.PerformClick();

            //            if (oCliente.ClienteId > 0 && novo == false)
            //            {
            //                MessageBox.Show("Cliente já cadastrado!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //                Botoes(true);
            //                return;
            //            }
            //        }
            //        oCliente.Estado = cbEstado.Text;
            //        oCliente.Pais = cbPais.Text;
            //        oCliente.Salvar();
            //        Botoes(true);
            //        BsCliente.Clear();
            //        novo = false;
            //        editar = false;
            //    }
            //}
            //catch { }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void BtnNovo_Click(object sender, EventArgs e)
        //{
        //    Botoes(false);
        //    Limpar();
        //    this.btnGravar.Enabled = true;
        //    this.txtNome.Focus();
        //    this.txtNome.SelectAll();
        //    editar = false;
        //    novo = true;
        //}

        //private void BtnCancelar_Click(object sender, EventArgs e)
        //{
        //    Botoes(true);
        //    Limpar();
        //}

        //private void btnExcluir_Click(object sender, EventArgs e)
        //{

        //    if (this.txtCodigo.Text != null && this.txtCodigo.Text != "0")
        //    {
        //        oCliente.Excluir();
        //        if (txtNome.Text.Length > 0)
        //        {
        //            oCliente.Nome = txtNome.Text;
        //            oCliente.ClienteId = int.Parse(txtCodigo.Text = "0");
        //            BsCliente.DataSource = oCliente.Busca();
        //        }
        //    }
        //}

        //private void BtnBuscar_Click(object sender, EventArgs e)
        //{
        //    if (txtCodigo.Text != "0" && txtCodigo.Text != "" && editar.Equals(true))
        //    {
        //        oCliente.ClienteId = int.Parse(txtCodigo.Text);
        //        BsCliente.DataSource = oCliente.Busca();
        //    }
        //    else if (txtNome.Text.Length > 0)
        //    {
        //        oCliente.Nome = txtNome.Text;
        //        oCliente.ClienteId = int.Parse(txtCodigo.Text = "0");
        //        var lista = new List<Cliente>();
        //        lista = oCliente.Busca();
        //        if (lista.Count > 0)
        //        {
        //            BsCliente.DataSource = (Cliente)lista[0];
        //        }
        //        else
        //        {
        //            if (novo) return;
        //            MessageBox.Show("Registro não encontrado!", Application.ProductName);
        //            string nome = this.txtNome.Text;
        //            Limpar();
        //            if (oCliente.ClienteId > 0)
        //                BsCliente.DataSource = oCliente;
        //        }
        //    }
        //    if (oCliente.ClienteId != 0)
        //    {
        //        editar = true;
        //    }
        //    else
        //    {
        //        editar = false;
        //    }
        //    txtNome.Focus();
        //    txtNome.SelectAll();
        //}

        #endregion

    }
}
