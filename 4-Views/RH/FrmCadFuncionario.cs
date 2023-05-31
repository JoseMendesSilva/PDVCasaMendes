using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;


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
        private bool frmLoaded;

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
            TxtCodigo.Clear();
            TxtNome.Clear();
            TxtEndereco.Clear();
            MkbCep.Clear();
            TxtCidade.Clear();
            TxtBairro.Clear();
            MkbRg.Clear();
            MkbCpf.Clear();
            DtpDataDeNascimento.Value = DateTime.Now;
            MkbCelular.Clear();
            MkbTelefone.Clear();
            TxtObservacao.Clear();
            oFuncionario.Foto = null;
        }

        private void VincularBindingSource()
        {
            if (frmLoading)
            {
                TxtCodigo.DataBindings.Add(new Binding("Text", BsFuncionario, "FuncionarioId"));
                TxtNome.DataBindings.Add(new Binding("Text", BsFuncionario, "Nome"));
                TxtEndereco.DataBindings.Add(new Binding("Text", BsFuncionario, "Endereco"));
                MkbCep.DataBindings.Add(new Binding("Text", BsFuncionario, "Cep"));
                TxtCidade.DataBindings.Add(new Binding("Text", BsFuncionario, "Cidade"));
                TxtBairro.DataBindings.Add(new Binding("Text", BsFuncionario, "Bairro"));
                MkbRg.DataBindings.Add(new Binding("Text", BsFuncionario, "Rg"));
                MkbCpf.DataBindings.Add(new Binding("Text", BsFuncionario, "Cpf"));
                DtpDataDeNascimento.DataBindings.Add(new Binding("Value", BsFuncionario, "DataDeNascimento"));
                MkbCelular.DataBindings.Add(new Binding("Text", BsFuncionario, "Celular"));
                MkbTelefone.DataBindings.Add(new Binding("Text", BsFuncionario, "Telefone"));
                TxtObservacao.DataBindings.Add(new Binding("Text", BsFuncionario, "Observacao"));
            }
        }

        private void AtribuirValores()
        {
            oFuncionario = (Funcionario)DgvFuncionarios.Rows[LinhaIndex].DataBoundItem;
            BsFuncionario.DataSource = (oFuncionario);

            CbPais.Text = oFuncionario.Pais;
            CbEstado.Text = oFuncionario.Estado;
            CbEstadoCivil.Text = oFuncionario.EstadoCivil;

            if (oFuncionario.Foto != null)
            {
                PicFoto.Image = Image.FromFile(clsGlobal.AbrirImagem(oFuncionario.Foto));
            }
            else
            {
               PicFoto.Image = Properties.Resources.CasaMendes1Jpg;
            }

        }

        private void Carregar()
        {
            //se a flag DataLoding for true, então carrega os dados no grid, se não retorna
            if (frmLoading) return;

                DgvFuncionarios.DataSource = null;
            DgvFuncionarios.DataSource = oFuncionario.Todos();

            // se está carregando os dados e o grid ainda não estiver sedo carregado antes
            // enão formata as colunas
            if (DgvFuncionarios.Rows.Count > 0)
            {
                DgvFuncionarios.RowHeadersVisible = false;

                for (int i = 0; i < DgvFuncionarios.Columns.Count; i++)
                {
                    if (!DgvFuncionarios.Columns[i].Equals(DgvFuncionarios.Columns["Nome"])) DgvFuncionarios.Columns[i].Visible = false;
                }
                DgvFuncionarios.Columns["Nome"].Width = clsGlobal.DimencionarColuna(100, this.DgvFuncionarios.Width);
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
            CbEstado.DisplayMember = "Estado";
            CbPais.DisplayMember = "Pais";
            clsGlobal.CarregarPaises(this.CbPais);
            clsGlobal.CarregarEstados(this.CbEstado);
        }

        #endregion

        #region Form Load

        private void FrmCadastroDeFuncionarios_Load(object sender, EventArgs e)
        {
            try
            {
                var oProcessando = new FrmProcessando();
                oProcessando.Show();
                oProcessando.TopMost = true;
                oProcessando.Processo(3, "Cadastro de funcionário", "Carregando.");
                LinhaIndex = -1;
                oProcessando.Processo(10, "Cadastro de funcionário", "Carregando.");
                this.Text = clsGlobal.MontarTitulo(Mensagens.M00041);
                oProcessando.Processo(16, "Cadastro de funcionário", "Carregando.");
                frmLoading = true;
                oProcessando.Processo(22, "Cadastro de funcionário", "Carregando.");
                frmLoaded = false;
                oProcessando.Processo(28, "Cadastro de funcionário", "Carregando.");
                BsFuncionario = new BindingSource();
                oProcessando.Processo(34, "Cadastro de funcionário", "Carregando.");
                oFuncionario = new Funcionario();
                oProcessando.Processo(40, "Cadastro de funcionário", "Carregando.");
                if (oFuncionario.FuncionarioId.Equals(0)) BsFuncionario.Add(oFuncionario);
                oProcessando.Processo(46, "Cadastro de funcionário", "Carregando.");
                Limpar();
                oProcessando.Processo(52, "Cadastro de funcionário", "Carregando.");
                Botoes(true);
                oProcessando.Processo(58, "Cadastro de funcionário", "Carregando.");
                CarregarCombo();
                oProcessando.Processo(64, "Cadastro de funcionário", "Carregando.");
                VincularBindingSource();
                oProcessando.Processo(70, "Cadastro de funcionário", "Carregando.");
                frmLoading = false;
                oProcessando.Processo(76, "Cadastro de funcionário", "Carregando.");
                Carregar();
                oProcessando.Processo(84, "Cadastro de funcionário", "Carregando.");
                frmLoaded = true;
                oProcessando.Processo(90, "Cadastro de funcionário", "Carregando.");
                this.TxtNome.Focus();
                oProcessando.Processo(96, "Cadastro de funcionário", "Carregando.");
                oProcessando.Close();
                oProcessando.Dispose();
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
            this.TxtCodigo.Text = "0";
            this.TxtNome.Focus();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Limpar();
            this.Botoes(true);
            Carregar();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                oFuncionario.Pais = CbPais.Text;
                oFuncionario.Estado = CbEstado.Text;
                oFuncionario.EstadoCivil = CbEstadoCivil.Text;
                oFuncionario.Salvar();
                Carregar();
                AtribuirValores();
                Botoes(true);
                MessageBox.Show($"O funcionário: ' {oFuncionario.Nome} ', foi cadastrado com sucesso.");
            }
            catch
            {
                MessageBox.Show($"O funcionário: ' {oFuncionario.Nome} ', não foi cadastrado.");
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (this.TxtCodigo.Text != null && this.TxtCodigo.Text != "0")
            {
                oFuncionario.Excluir(); 
                Carregar();
                if (DgvFuncionarios.Rows.Count>0)
                    AtribuirValores();
                MessageBox.Show($"O funcionário ' {oFuncionario.Nome} ' foi excluido com sucesso.");
            }
            else
                MessageBox.Show($"O funcionário ' {oFuncionario.Nome} ' naõ foi excluido.");
        }

        private void LblPicFoto_Click(object sender, EventArgs e)
        {
            try
            {
                oFuncionario.Foto = clsGlobal.BuscarFotoProduto();
                PicFoto.Image = Image.FromFile(clsGlobal.AbrirImagem(oFuncionario.Foto));
            }
            catch { }
        }

        #endregion

        #region Grid view

        private void DgvFuncionarios_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DgvFuncionarios.Rows.Count > 0 && !frmLoading && frmLoaded)
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

        #region TextoChanged

        private void MkbCep_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (frmLoading.Equals(true) || MkbCep.Text.Equals(0) || MkbCep.Text.Length.Equals(0)) return;
                valor = MkbCep.Text.Replace("-", "").ToString();
                MkbCep.Text = valor;
                int i = int.Parse(valor.Replace("(", "").Replace(")", "").Replace("-", "").ToString());
                oFuncionario.Cep = valor;
                MkbCep.Update();
            }
            catch { }
        }

        private void MkbCpf_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (frmLoading.Equals(true) || MkbCpf.Text.Equals(0) || MkbCpf.Text.Length.Equals(0)) return;
                valor = MkbCpf.Text.Replace(",", "").Replace(",", "").Replace("-", "").ToString();
                MkbCpf.Text = valor;
                int i = int.Parse(valor.Replace("(", "").Replace(")", "").Replace("-", "").ToString());
                oFuncionario.Cpf = valor;

                MkbCpf.Update();
            }
            catch { }
        }

        private void MkbRg_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (frmLoading.Equals(true) || MkbRg.Text.Equals(0) || MkbRg.Text.Length.Equals(0)) return;
                valor = MkbRg.Text.Replace(",", "").Replace(",", "").Replace("-", "").ToString();
                MkbRg.Text = valor;
                int i = int.Parse(valor.Replace("(", "").Replace(")", "").Replace("-", "").ToString());
                oFuncionario.Rg = valor;
                MkbRg.Update();
            }
            catch { }
        }

        private void MkbCelular_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (frmLoading.Equals(true) || MkbCelular.Text.Equals(0) || MkbCelular.Text.Length.Equals(0)) return;
                valor = MkbCelular.Text.Replace("(", "").Replace(")", "").Replace("-", "").ToString();
                MkbCelular.Text = valor;
                int i = int.Parse(valor.Replace("(", "").Replace(")", "").Replace("-", "").ToString());
                oFuncionario.Celular = valor;
                MkbCelular.Update();
            }
            catch { }
        }

        private void MkbTelefone_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (frmLoading.Equals(true) || MkbTelefone.Text.Equals(0) || MkbTelefone.Text.Length.Equals(0)) return;
                valor = MkbTelefone.Text.Replace("-", "").ToString();
                MkbCep.Text = valor;
                int i = int.Parse(valor.Replace("(", "").Replace(")", "").Replace("-", "").ToString());
                oFuncionario.Telefone = valor;
                MkbCep.Update();
            }
            catch { }
        }

        #endregion

    }
}