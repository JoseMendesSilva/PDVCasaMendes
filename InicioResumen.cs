using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasaMendes
{
    public partial class InicioResumen : Form
    {
        public InicioResumen()
        {
            InitializeComponent();
        }

        //private void RedimencionarGrade()
        //{
        //    try
        //    {
        //        DgvEstoque.RowHeadersVisible = false;

        //        for (int i = 0; i < DgvEstoque.Columns.Count; i++)
        //        {
        //                DgvEstoque.Columns[i].Visible = false;
        //        }

        //        DgvEstoque.Columns["Produto"].Visible = true;
        //        DgvEstoque.Columns["CodigoDeBarras"].Visible = true;
        //        DgvEstoque.Columns["PrecoDeVenda"].Visible = true;

        //        DgvEstoque.Columns["CodigoDeBarras"].HeaderText = "Cód Barras".ToUpper();
        //        DgvEstoque.Columns["Produto"].HeaderText = "Produto".ToUpper();
        //        DgvEstoque.Columns["PrecoDeVenda"].HeaderText = "Valor venda".ToUpper();

        //        DgvEstoque.Columns["CodigoDeBarras"].Width = clsGlobal.DimencionarColuna(25, this.Width);
        //        DgvEstoque.Columns["Produto"].Width = clsGlobal.DimencionarColuna(40, this.Width);
        //        DgvEstoque.Columns["PrecoDeVenda"].Width = clsGlobal.DimencionarColuna(15, this.Width);

        //    }
        //    catch
        //    {

        //    }
        //}


        private void timer1_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString("hh:mm:ss ");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void InicioResumen_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    this.Refresh();
            //    using (var oEstoque = new Estoque())
            //    {
            //        DgvEstoque.DataSource = oEstoque.Todos();
            //        LblEstoqueItens.Text = DgvEstoque.RowCount.ToString();
            //        RedimencionarGrade();
            //    }
            //}catch  { }
        }//07896327511984

    }
}
