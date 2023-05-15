
using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using CasaMendes.Classes;
using CasaMendes.Classes.Geral;
using CasaMendes.Classes.Estatica;

namespace CasaMendes
{
    public partial class FrmEstoque : Form
    {

        public string StatusLabel { get; set; }

        #region Construtor

        public FrmEstoque()
        {
            InitializeComponent();

        }

        #endregion

        private void dgv_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
  
        }

        private void dgv_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    BtnAceitar.PerformClick();
            //}
            //else if (e.KeyCode == Keys.Escape)
            //{
            //    CancelarProduto();
            //}
        }

        private void txtBusca_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    this.Close();
            //}
            //else if (e.KeyCode == Keys.Escape)
            //{
            //    Filtro = "-1";
            //    cod = "-1";
            //    this.Close();
            //}
        }

        private void txtCodigoDeBarras_TextChanged(object sender, EventArgs e)
        {
 
        }

        private void txtCodigoDeBarras_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    this.Close();
            //}
            //else if (e.KeyCode == Keys.Escape)
            //{
            //    Filtro = "-1";
            //    cod = "-1";
            //    this.Close();
            //}
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
        }

        private void BtnAceitar_Click(object sender, EventArgs e)
        {
        }

    }
}
