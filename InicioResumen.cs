﻿using System;
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
