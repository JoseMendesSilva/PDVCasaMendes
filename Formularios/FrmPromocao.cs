using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CasaMendes.Classes.Geral;
using CasaMendes.Classes.Estatica;
using System.Globalization;

namespace CasaMendes.Formularios
{
    public partial class FrmPromocao : Form
    {
        #region Variáveis

        string oldValueDesconto = null;
        string newValueDesconto = null;

        int eRowIndex;

        #endregion

        public FrmPromocao()
        {
            InitializeComponent();
        }

        [STAThreadAttribute()]
        private void FrmPromocao_Load(object sender, EventArgs e)
        {
            try
            {
                ClsPromocao oP = new ClsPromocao();

                clsGlobal.SetUpDataGridView(this.dgv);
                oP.lerPromocao(this.dgv);
                clsGlobal.RedimencionarGrade(this, this.dgv);

                this.dgv.Columns[0].Width = clsGlobal.DimencionarColuna(17, this.dgv.Width);
                this.dgv.Columns[1].Width = clsGlobal.DimencionarColuna(51, this.dgv.Width);
                this.dgv.Columns[2].Width = clsGlobal.DimencionarColuna(16, this.dgv.Width);
                this.dgv.Columns[3].Width = clsGlobal.DimencionarColuna(16, this.dgv.Width);

                clsGlobal.AlinharElementosNoGridView(dgv, 0, "center");
                clsGlobal.AlinharElementosNoGridView(dgv, 1, "left");
                clsGlobal.AlinharElementosNoGridView(dgv, 2, "center");
                clsGlobal.AlinharElementosNoGridView(dgv, 3, "center");


                oP = null;
                GC.Collect();
            }
            catch
            {
            }
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void GerarDescontos()
        {
            if (this.dgv.RowCount > 0)
            {
                ClsPromocao op = new ClsPromocao();
                decimal JurosSobreVendasFiado = op.De_String_Para_decimal(this.TxtJuros.Text);

                if (!op.escreverXml(this.dgv, JurosSobreVendasFiado)) { MessageBox.Show("Ocorreu um erro ao gerar a lista de desconto.", Application.ProductName); }
                else { MessageBox.Show("Arquivo gerado com sucesso.", Application.ProductName); }
            }

        }

        private void BtnGerarDescontos_Click(object sender, EventArgs e)
        {
            GerarDescontos();
        }

        private void dgv_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (this.TxtValorDesconto.Focused) return;

            // [Desconto]
            this.TxtDesconto.Text = dgv[2, e.RowIndex].Value.ToString();

            // [V. desconto]
            this.TxtValorDesconto.Text = dgv[3, e.RowIndex].Value.ToString();

            oldValueDesconto = dgv[3, e.RowIndex].Value.ToString();

            eRowIndex = e.RowIndex;

        }
     
        private void TxtValorDesconto_TextChanged(object sender, EventArgs e)
        {
            //if (this.TxtValorDesconto.TextLength > 0) newValueDesconto = TxtValorDesconto.Text;
        }

        private void TxtValorDesconto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if ((this.TxtValorDesconto.TextLength > 0) | (!TxtValorDesconto.Text.Equals("0,00")))
                {
                    newValueDesconto = TxtValorDesconto.Text;
                
                if ((newValueDesconto != string.Empty) && (newValueDesconto != oldValueDesconto))
                {
                    dgv[3, eRowIndex].Value = this.newValueDesconto;
                }
                }
                else
                {
                    newValueDesconto = "0";
                    dgv.Focus();
                }
            }

            if (e.KeyCode == Keys.Escape)
            {
                    dgv[3, eRowIndex].Value = this.oldValueDesconto;
                    this.oldValueDesconto = "0";
                    this.newValueDesconto = "0";
                    dgv.Focus();
            }

        }

        private void dgv_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void dgv_KeyPress(object sender, KeyPressEventArgs e)
        {
            string s = e.KeyChar.ToString();
            //if (e.KeyChar == "Enter")
            //{
            //    if (TxtValorDesconto.Text.Length.Equals(0) | TxtValorDesconto.Text.Equals("0"))
            //    {
            //        this.TxtValorDesconto.Text = "0,00";
            //    }

            //    this.TxtValorDesconto.SelectAll();
            //    this.TxtValorDesconto.Focus();

            //}

        }

        private void dgv_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            //dgv.CurrentCell.ColumnIndex = dgv.CurrentCellAddres;
        }
        
    }
}
