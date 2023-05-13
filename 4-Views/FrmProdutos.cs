using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CasaMendes
{
    public partial class FrmProdutos : Form
    {
        int LinhaIndex;
        bool editar;
        tProduto oProduto;

        #region Propriedades

        public string StatusLabel{ get; set; }

        #endregion

        public FrmProdutos()
        {
            InitializeComponent();
            LinhaIndex = -1;
            editar = false;
            oProduto = new tProduto();
        }

        private void Botoes(bool b)
        {
            btnEditar.Enabled = !b;
            btnFechar.Enabled = b;
            btnExcluir.Enabled = !b;
            btnNovo.Enabled = b;
            btnAbrirListaDeesconto.Enabled = b;
        }

        private void Carregar()
        {
            dgv.DataSource = oProduto.Todos();
            StatusLabel = (dgv.RowCount - 1).ToString();
        }

        private void Atualizar()
        {
            if (editar.Equals(true) && LinhaIndex != -1) {
                oProduto = (tProduto)dgv.Rows[LinhaIndex].DataBoundItem;

                FrmCadProduto fProduto = new FrmCadProduto();
                fProduto.BsProduto.Add(oProduto);
                fProduto.ShowDialog();
                if (fProduto.DialogResult.Equals(DialogResult.OK)) oProduto.Salvar();
                Carregar();
            }
        }

        private void txtCodigoDeBarras_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.txtBusca.Text.Length > 0)
                {
                    this.txtBusca.Clear();
                }
                if (this.txtCodigoDeBarras.Text != "0") oProduto.CodigoDeBarras = txtCodigoDeBarras.Text;
                dgv.DataSource = oProduto.Busca();
            }
            catch { }
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.txtCodigoDeBarras.Text.Length > 0)
                {
                    this.txtCodigoDeBarras.Clear();
                }
                if (this.txtBusca.Text != "0") oProduto.Nome= txtBusca.Text;
                dgv.DataSource = oProduto.Busca();
            }
            catch { }
        }

        private void dgv_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.Rows.Count > 0)
            {
                LinhaIndex = e.RowIndex;
                editar = true;
                btnEditar.Enabled = editar;
                btnExcluir.Enabled = editar;
                return;
            }
            editar = false;
            btnEditar.Enabled = editar;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Atualizar();
        }

        private void FrmProdutos_Load(object sender, EventArgs e)
        {
            Botoes(true);
            Carregar();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FrmCadProduto fProduto = new FrmCadProduto();
            fProduto.ShowDialog();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (editar.Equals(true) && LinhaIndex != -1)
            {
                oProduto = (tProduto)dgv.Rows[LinhaIndex].DataBoundItem;
                oProduto.Excluir();
                Carregar();
            }
        }
    }
}
