using System;
using System.Drawing;
using System.Windows.Forms;


delegate void Salvar();

namespace CasaMendes
{

    public partial class FrmCadFuncionario : Form, IDisposable
    {

        #region Propriedaddes

        public string StatusLabel { get; set; }

        #endregion

        #region Variáveis

        public BindingSource BsFuncionario;
        private Funcionario oFuncionario;

        private int LinhaIndex;
        private string valor;
        private bool frmLoading;

        #endregion

        #region construtor

        public FrmCadFuncionario()
        {
            InitializeComponent();
        }

        #endregion

        #region Métodos auxiliares

        private void Limpar()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtEndereco.Clear();
            mkbCep.Clear();
            txtCidade.Clear();
            txtBairro.Clear();
            mkbRg.Clear();
            mkbCpf.Clear();
            dtpDataDeNascimento.Value = DateTime.Now;
            mkbCelular.Clear();
            mkbTelefone.Clear();
            txtObservacao.Clear();
        }

        private void VincularBindingSource()
        {
            if (frmLoading)
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
        }

        private void AtribuirValores()
        {
            oFuncionario = (Funcionario)DgvNomes.Rows[LinhaIndex].DataBoundItem;
            BsFuncionario.DataSource = (oFuncionario);

            cbPais.Text = oFuncionario.Pais;
            cbEstado.Text = oFuncionario.Estado;
            cbEstadoCivil.Text = oFuncionario.EstadoCivil;

        }

        private void Carregar()
        {
            //se a flag DataLoding for true, então carrega os dados no grid, se não retorna
            if (!frmLoading) 
                DgvNomes.DataSource = oFuncionario.Todos();
            else 
                return;

            // se está carregando os dados e o grid ainda não estiver sedo carregado antes
            // enão formata as colunas
            if (DgvNomes.Rows.Count > 0)
            {
                DgvNomes.RowHeadersVisible = false;
                DgvNomes.BackgroundColor = Color.White;
                for (int i = 0; i < DgvNomes.Columns.Count; i++)
                {
                    if (!DgvNomes.Columns[i].Equals(DgvNomes.Columns["Nome"])) DgvNomes.Columns[i].Visible = false;
                }
                DgvNomes.Columns["Nome"].Width = clsGlobal.DimencionarColuna(100, this.DgvNomes.Width);
            }
        }

        private void Botoes(bool status)
        {
            this.BtnNovo.Enabled = status;
            this.BtnCancelar.Enabled = !status;
            this.BtnExcluir.Enabled = status;
            this.BtnFechar.Enabled = status;
            this.PicFoto.Image = Properties.Resources.CasaMendes1Jpg;
        }

        private void CarregarCombo()
        {
            cbEstado.DisplayMember = "Estado";
            cbPais.DisplayMember = "Pais";
            clsGlobal.CarregarPaises(this.cbPais);
            clsGlobal.CarregarEstados(this.cbEstado);
        }

        #endregion

        #region Form Load

        private void FrmCadastroDeFuncionarios_Load(object sender, EventArgs e)
        {
            try
            {
                LinhaIndex = -1;
                this.Text = clsGlobal.MontarTitulo(Mensagens.M00041);
                frmLoading = true;
                BsFuncionario = new BindingSource();
                oFuncionario = new Funcionario();
                if (oFuncionario.FuncionarioId.Equals(0)) BsFuncionario.Add(oFuncionario);
                Limpar();
                Botoes(true);
                VincularBindingSource();
                CarregarCombo();
                frmLoading = false;
                Carregar();
                this.txtNome.Focus();
            }
            catch
            {
            }
        }

        #endregion

        #region Click

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            this.Botoes(false);
            Limpar();
            this.txtCodigo.Text = "0";
            this.txtNome.Focus();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Limpar();
            this.Botoes(true);
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            oFuncionario.Pais = cbPais.Text;
            oFuncionario.Estado = cbEstado.Text;
            oFuncionario.EstadoCivil = cbEstadoCivil.Text;
            oFuncionario.Salvar();
            Carregar();
            AtribuirValores();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (this.txtCodigo.Text != null && this.txtCodigo.Text != "0")
            {
                oFuncionario.Excluir();
                Carregar();
                AtribuirValores();
            }
        }

        private void LblPicFoto_Click(object sender, EventArgs e)
        {
            this.PicFoto.Image = Image.FromFile(clsGlobal.Abririmagens());
        }

        #endregion

        #region Grid view

        private void DgvNomes_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DgvNomes.Rows.Count > 0 && !frmLoading)
                {
                    LinhaIndex = e.RowIndex;
                    AtribuirValores();
                    BtnGravar.Enabled = true;
                }
                else
                {
                    BtnGravar.Enabled = false;
                }
            }
            catch { }
        }

        #endregion


        #region TextChanged

        private void MkbCep_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (frmLoading.Equals(true) || mkbCep.Text.Equals(0) || mkbCep.Text.Length.Equals(0)) return;
                valor = mkbCep.Text.Replace("-", "").ToString();
                mkbCep.Text = valor;
                int i = int.Parse(valor.Replace("(", "").Replace(")", "").Replace("-", "").ToString());
                oFuncionario.Cep = valor;
                mkbCep.Update();
            }
            catch { }
        }

        private void MkbCpf_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (frmLoading.Equals(true) || mkbCpf.Text.Equals(0) || mkbCpf.Text.Length.Equals(0)) return;
                valor = mkbCpf.Text.Replace(",", "").Replace(",", "").Replace("-", "").ToString();
                mkbCpf.Text = valor;
                int i = int.Parse(valor.Replace("(", "").Replace(")", "").Replace("-", "").ToString());
                oFuncionario.Cpf = valor;

                mkbCpf.Update();
            }
            catch { }
        }

        private void MkbRg_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (frmLoading.Equals(true) || mkbRg.Text.Equals(0) || mkbRg.Text.Length.Equals(0)) return;
                valor = mkbRg.Text.Replace(",", "").Replace(",", "").Replace("-", "").ToString();
                mkbRg.Text = valor;
                int i = int.Parse(valor.Replace("(", "").Replace(")", "").Replace("-", "").ToString());
                oFuncionario.Rg = valor;
                mkbRg.Update();
            }
            catch { }
        }

        private void MkbCelular_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (frmLoading.Equals(true) || mkbCelular.Text.Equals(0) || mkbCelular.Text.Length.Equals(0)) return;
                valor = mkbCelular.Text.Replace("(", "").Replace(")", "").Replace("-", "").ToString();
                mkbCelular.Text = valor;
                int i = int.Parse(valor.Replace("(", "").Replace(")", "").Replace("-", "").ToString());
                oFuncionario.Celular = valor;
                mkbCelular.Update();
            }
            catch { }
        }

        private void MkbTelefone_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (frmLoading.Equals(true) || mkbTelefone.Text.Equals(0) || mkbTelefone.Text.Length.Equals(0)) return;
                valor = mkbTelefone.Text.Replace("-", "").ToString();
                mkbCep.Text = valor;
                int i = int.Parse(valor.Replace("(", "").Replace(")", "").Replace("-", "").ToString());
                oFuncionario.Telefone = valor;
                mkbCep.Update();
            }
            catch { }
        }

        #endregion

    }
}