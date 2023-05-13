using CasaMendes.Classes.Estatica;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CasaMendes
{
    public partial class frmCadastrarFuncionario : Form, IDisposable
    {

        #region Propriedaddes

        public string StatusLabel { get; set; }

        #endregion

        #region Variáveis

        public BindingSource BsFuncionario;
        private tFuncionario oFuncionario;

        string TestoDoBtnNovo = clsMensagens.M00039;  // "Valor: Novo";
        private int LinhaIndex;
        string valor = "";
        bool frmLoad;

        #endregion

        #region construtor

        public frmCadastrarFuncionario()
        {
            InitializeComponent();
            frmLoad = true;
            LinhaIndex = -1;
            this.Text = clsGlobal.MontarTitulo(clsMensagens.M00041);

            BsFuncionario = new BindingSource();
            oFuncionario = new tFuncionario();
            if (oFuncionario.FuncionarioId.Equals(0)) BsFuncionario.Add(oFuncionario);

            this.btnCancelar.Visible = false;
            this.btnNovo.Text = TestoDoBtnNovo;
            this.PicFoto.Image = Properties.Resources.CasaMendes1Jpg;
        }

        #endregion

        #region Métodos auxiliares

        private void VincularBindingSource()
        {
                      txtCodigo.DataBindings.Add(new Binding("Text", BsFuncionario, "FuncionarioId"));
                        txtNome.DataBindings.Add(new Binding("Text", BsFuncionario, "Nome"));
                    txtEndereco.DataBindings.Add(new Binding("Text", BsFuncionario, "Endereco"));
                         mkbCep.DataBindings.Add(new Binding("Text", BsFuncionario, "Cep"));
                      txtCidade.DataBindings.Add(new Binding("Text", BsFuncionario, "Cidade"));
                      txtBairro.DataBindings.Add(new Binding("Text", BsFuncionario, "Bairro"));
                          mkbRg.DataBindings.Add(new Binding("Text", BsFuncionario, "Rg"));
                         mkbCpf.DataBindings.Add(new Binding("Text", BsFuncionario, "Cpf"));
           dtpDataDeNascimento.DataBindings.Add(new Binding("Value", BsFuncionario, "DataDeNascimento"));
                     mkbCelular.DataBindings.Add(new Binding("Text", BsFuncionario, "Celular"));
                    mkbTelefone.DataBindings.Add(new Binding("Text", BsFuncionario, "Telefone"));
                  txtObservacao.DataBindings.Add(new Binding("Text", BsFuncionario, "Observacao"));
        }

        private void AtribuirValores()
        {
            oFuncionario = (tFuncionario)dgvNomes.Rows[LinhaIndex].DataBoundItem;
            BsFuncionario.DataSource = (oFuncionario);

            cbPais.Text = oFuncionario.Pais;
            cbEstado.Text = oFuncionario.Estado;
            cbEstadoCivil.Text = oFuncionario.EstadoCivil;

        }

        private void Carregar() => dgvNomes.DataSource = oFuncionario.Todos();

        private void Botoes(bool status)
        {
            this.btnCancelar.Visible = !status;
            this.btnExcluir.Enabled = status;
            btnFechar.Enabled = status;
        }

        #endregion

        #region Form Load

        private void frmCadastroDeFuncionarios_Load(object sender, EventArgs e)
        {
            try
            {
                VincularBindingSource();

                dgvNomes.RowHeadersVisible = false;
                Carregar();

                for (int i = 0; i < dgvNomes.Columns.Count; i++)
                {
                    dgvNomes.Columns[i].Visible = false;
                }
                dgvNomes.Columns["Nome"].Visible = true;

                int tamanho = dgvNomes.Width - 24;
                dgvNomes.Columns["Nome"].Width = tamanho;
                dgvNomes.BackgroundColor = Color.White;

                //cbEstado.DisplayMember = "Estado";
                //cbPais.DisplayMember = "Pais";
                //cbEstadoCivil.DisplayMember = "EstadoCivil";

                clsGlobal.CarregarPaises(this.cbPais);
                clsGlobal.CarregarEstados(this.cbEstado);

                this.txtNome.Focus();
            }
            catch
            {

            }
            finally { frmLoad = false; }
        }

        #endregion

        #region Click

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Image img = Properties.Resources.CasaMendes1Jpg;
            this.PicFoto.Image = img;
            this.Botoes(false);

            clsGlobal.LimparControles((ControlCollection)this.Controls);
            clsGlobal.CarregarPaises(this.cbPais);
            clsGlobal.CarregarEstados(this.cbEstado);
            this.PicFoto.Visible = false;
            this.txtCodigo.Text = "0";
            this.txtNome.Focus();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            TestoDoBtnNovo = clsMensagens.M00026;// "Novo";
            this.btnNovo.Text = TestoDoBtnNovo;
            clsGlobal.LimparControles((ControlCollection)this.Controls);
            this.Botoes(true);

            this.PicFoto.Visible = true;

            //oFuncionario.CarregarDataGridFuncionarios(dgvNomes);

            //if (oFuncionario.Codigo > 0) { ExibirDados(); }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            oFuncionario.Pais = cbPais.Text;
            oFuncionario.Estado= cbEstado.Text;
            oFuncionario.EstadoCivil = cbEstadoCivil.Text;

            oFuncionario.Salvar();
            clsGlobal.CarregarPaises(this.cbPais);
            clsGlobal.CarregarEstados(this.cbEstado);
            Carregar();
            AtribuirValores();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (this.txtCodigo.Text != null && this.txtCodigo.Text != "0")
            {
                oFuncionario.Excluir();
                Carregar();
                AtribuirValores();
            }
        }
       
        private void lblPicFoto_Click(object sender, EventArgs e)
        {
            clsGlobal.Abririmagens(this.PicFoto);
        }

        #endregion

        #region Grid view

        private void dgvNomes_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvNomes.Rows.Count > 0)
                {
                    PicFoto.Visible = true;
                    LinhaIndex = e.RowIndex;
                    AtribuirValores();
                }
            }
            catch { }
        }

        #endregion


        #region TextChanged

        private void mkbCep_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (frmLoad.Equals(true) || mkbCep.Text.Equals(0) || mkbCep.Text.Length.Equals(0)) return;
                valor = mkbCep.Text;//.Replace("-", "").ToString();
                //mkbCep.Text = valor;
                //int i = int.Parse(v.Replace("(", "").Replace(")", "").Replace("-", "").ToString());
                oFuncionario.Cep = valor;
                mkbCep.Update();
            }
            catch { }
        }

        private void mkbCpf_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (frmLoad.Equals(true) || mkbCpf.Text.Equals(0) || mkbCpf.Text.Length.Equals(0)) return;
                valor = mkbCpf.Text;//.Replace(",", "").Replace(",", "").Replace("-", "").ToString();
                //mkbCpf.Text = valor;
                //int i = int.Parse(v.Replace("(", "").Replace(")", "").Replace("-", "").ToString());
                oFuncionario.Cpf = valor;

                mkbCpf.Update();
            }
            catch { }
        }

        private void mkbRg_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (frmLoad.Equals(true) || mkbRg.Text.Equals(0) || mkbRg.Text.Length.Equals(0)) return;
                valor = mkbRg.Text;//.Replace(",", "").Replace(",", "").Replace("-", "").ToString();
                //mkbRg.Text = valor;
                //int i = int.Parse(v.Replace("(", "").Replace(")", "").Replace("-", "").ToString());
                oFuncionario.Rg = valor;
                mkbRg.Update();
            }
            catch { }
        }

        private void mkbCelular_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (frmLoad.Equals(true) || mkbCelular.Text.Equals(0) || mkbCelular.Text.Length.Equals(0)) return;
                valor = mkbCelular.Text;//.Replace("(", "").Replace(")", "").Replace("-", "").ToString();
                //mkbCelular.Text = valor;
                //int i = int.Parse(v.Replace("(", "").Replace(")", "").Replace("-", "").ToString());
                oFuncionario.Celular = valor;
                mkbCelular.Update();
            }
            catch { }
        }

        private void mkbTelefone_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (frmLoad.Equals(true) || mkbTelefone.Text.Equals(0) || mkbTelefone.Text.Length.Equals(0)) return;
                valor = mkbTelefone.Text;//.Replace("-", "").ToString();
                //mkbCep.Text = valor;
                //int i = int.Parse(v.Replace("(", "").Replace(")", "").Replace("-", "").ToString());
                oFuncionario.Telefone = valor;
                mkbCep.Update();
            }
            catch { }
        }

        #endregion

    }
}

//private void maskedTextBox1_TextChanged(object sender, EventArgs e)
//{
//    try {
//        v = maskedTextBox1.Text;
//        maskedTextBox1.Text = v;
//        //int i = int.Parse(v.Replace("(", "").Replace(")", "").Replace("-", "").ToString());
//        oFuncionario.Telefone = int.Parse(v.Replace("(", "").Replace(")", "").Replace("-", "").ToString());
//    }catch { }
//}

//this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmCadastrarFuncionarios_Paint);
//this.Move += new System.EventHandler(this.frmCadastrarFuncionarios_Move);
//this.Resize += new System.EventHandler(this.frmCadastrarFuncionarios_Resize);
//this.txtNome.Validating += new System.ComponentModel.CancelEventHandler(this.txtNome_Validating);

//private void ExibirDados()
//{
//    try
//    {
//        this.txtCodigo.Text = oFuncionario.Codigo.ToString() != "0" ? oFuncionario.Codigo.ToString() : "";
//        this.txtNome.Text = oFuncionario.Nome.ToString().ToUpper() != "NULL" ? oFuncionario.Nome.ToString() : "";
//        this.txtEndereco.Text = oFuncionario.Endereco.ToString().ToUpper() != "NULL" ? oFuncionario.Endereco.ToString() : "";
//        this.mkbCep.Text = oFuncionario.Cep.ToString() != "0" ? oFuncionario.Cep.ToString() : "";
//        this.txtCidade.Text = oFuncionario.Cidade.ToString().ToUpper() != "NULL" ? oFuncionario.Cidade.ToString() : "";
//        this.txtBairro.Text = oFuncionario.Bairro.ToString().ToUpper() != "NULL" ? oFuncionario.Bairro.ToString() : "";
//        this.cbEstado.Text = oFuncionario.Estado.ToString().ToUpper() != "NULL" ? oFuncionario.Estado.ToString() : "";
//        this.cbPais.Text = oFuncionario.Pais.ToString().ToUpper() != "NULL" ? oFuncionario.Pais.ToString() : "";
//        this.mkbCpf.Text = oFuncionario.Cpf.ToString() != "0" ? oFuncionario.Cpf.ToString() : "";
//        this.mkbRg.Text = oFuncionario.Rg.ToString() != "0" ? oFuncionario.Rg.ToString() : "";
//        this.cbEstadoCivil.Text = oFuncionario.EstadoCivil.ToString().ToUpper() != "NULL" ? oFuncionario.EstadoCivil.ToString() : "";
//        this.dtpDataDeNascimento.Text = oFuncionario.DataDeNascimento.ToString().ToUpper() != "NULL" ? oFuncionario.DataDeNascimento.ToString() : "";
//        this.mkbCelular.Text = oFuncionario.Celular.ToString() != "0" ? oFuncionario.Celular.ToString() : "";
//        this.mkbCelularContato.Text = oFuncionario.CelularContato.ToString() != "0" ? oFuncionario.CelularContato.ToString() : "";
//        this.mkbTelefone.Text = oFuncionario.Telefone.ToString() != "0" ? oFuncionario.Telefone.ToString() : "";
//        this.txtObservacao.Text = oFuncionario.Observacao.ToString().ToUpper() != "NULL" ? oFuncionario.Observacao.ToString() : "";
//        this.PicFoto.Image = oFuncionario.Foto;
//    }
//    catch { }
//}