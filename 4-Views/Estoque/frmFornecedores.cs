using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CasaMendes
{
    public partial class FrmFornecedores : Form
    {

        #region Variáveis

        //BindingSource BsFornecedor;
        //tFornecedore oFornecedor;
        int LinhaIndex;
        bool editar;
        public string StatusLabel;
        FrmCadFornecedores cadFornecedor;

        #endregion

        public FrmFornecedores()
        {
            InitializeComponent();
            LinhaIndex = -1;
            editar = false;
        }

        #region Métodos auxiliares

        private void RedimencionarGrade()
        {
            try
            {
                if (dgv.Rows.Count > 0)
                {
                    for (int i = 0; i < dgv.Columns.Count; i++)
                    {
                        dgv.Columns[i].Visible = false;
                    }

                    dgv.RowHeadersVisible = false;
                    dgv.Columns["RazaoSocial"].Visible = true;
                    int t = dgv.Width - 22;
                    dgv.Columns["RazaoSocial"].Width = t;
                    dgv.Columns["RazaoSocial"].HeaderText = "Fornecedores";
                }
            }
            catch
            {

            }
        }

        private void Carregar()
        {
            using (Fornecedore oFornecedor = new Fornecedore())
            {
                dgv.DataSource = oFornecedor.Todos();
                StatusLabel = (dgv.RowCount - 1).ToString();
            }
        }

        private void Gravar()
        {

            cadFornecedor = new FrmCadFornecedores();

            if (editar.Equals(true) && LinhaIndex != -1)
            {
                cadFornecedor.oFornecedor = (Fornecedore)dgv.Rows[LinhaIndex].DataBoundItem;
            }

            cadFornecedor.ShowDialog();
            //Verificando se o nome já existe.
            if (cadFornecedor.oFornecedor.FornecedorId == 0)
            {
                var forn = new Fornecedore
                {
                    RazaoSocial = cadFornecedor.oFornecedor.RazaoSocial
                };
                List<Fornecedore> fornecedor = forn.Busca();
                if (fornecedor.Count > 0)
                {
                    MessageBox.Show("O cadastro já existe!");
                    return;
                }
            }

            if (cadFornecedor.DialogResult.Equals(DialogResult.Cancel)) return;
            cadFornecedor.oFornecedor.Salvar();
            cadFornecedor.Dispose();
            Carregar();

            if (editar)
            {
                MessageBox.Show("O registro foi atualizado com sucesso!");
            }
            else
            {
                MessageBox.Show("Cadastro realizado com sucesso!");
            }
            Botoes(true);
        }

        private void Novo()
        {
            Botoes(false);
            editar = false;
            Gravar();
        }

        private void Excluir()
        {
            try
            {
                if (editar.Equals(true) && LinhaIndex != -1)
                {
                    var oFornecedor = new Fornecedore();
                    oFornecedor = (Fornecedore)dgv.Rows[LinhaIndex].DataBoundItem;
                    oFornecedor.Excluir();
                    oFornecedor.Dispose();
                    MessageBox.Show($"O Fornecedor ' {oFornecedor.RazaoSocial} ' foi excluido com sucesso.");
                    Carregar();
                }
                else
                {
                    MessageBox.Show($"Seleciona um Fornecedor para excluir.");
                }
            }
            catch { }
        }

        private void Botoes(bool b)
        {
            btnEditar.Enabled = !b;
            btnFechar.Enabled = b;
            btnExcluir.Enabled = !b;
            btnNovo.Enabled = b;
        }

        #endregion

        private void FrmFornecedores_Load(object sender, EventArgs e)
        {
            var oProcessando = new FrmProcessando();
            oProcessando.Show();
            oProcessando.TopMost = true;
            oProcessando.Processo(15,"Lista de fornecedores","Carregando.");
            using (Fornecedore oFornecedor = new Fornecedore())
            {
                oProcessando.Processo(35, "Lista de fornecedores", "Carregando..");
                dgv.DataSource = oFornecedor.Todos();
                oProcessando.Processo(60, "Lista de fornecedores", "Carregando...");
                StatusLabel = (dgv.RowCount - 1).ToString();
                oProcessando.Processo(75, "Lista de fornecedores", "Carregando.");

                RedimencionarGrade();
                oProcessando.Processo(100, "Lista de fornecedores", "Carregando..");
                oProcessando.Close();
                oProcessando.Dispose();
            }
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Botoes(false);
            Gravar();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            Excluir();
        }

        private void Dgv_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.Rows.Count > 0)
            {
                editar = true;
                LinhaIndex = e.RowIndex;
            }
            else
            {
                editar = false;
            }
        }

    }
}
