using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;

namespace CasaMendes
{
    public partial class temp : Form
    {
        //Produto produto;
        //pProduto produtoTemp;

        public temp() //
        {
            InitializeComponent();
            ArrayList arr = new ArrayList();
            using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\App Casa Mendes\MDF\loja.mdf"))
            {
                string queryString = "select * from tProdutos";
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                DataTable oDt = new DataTable();
                SqlDataAdapter oDa = new SqlDataAdapter();
                oDt.Locale = System.Globalization.CultureInfo.InvariantCulture;
                oDa.SelectCommand = command;

                oDa.Fill(oDt);

                DgvProdutos.DataSource = oDt;
                label1.Text = DgvProdutos.RowCount.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Gravar()
        {
            try
            {
                Produto oProduto = new Produto();

                for (int i = 0; i < DgvProdutos.Rows.Count - 1; i++)
                {
                    if (DgvProdutos.Rows[i].Cells[1].Value.ToString() != null)
                    {
                        oProduto.CodigoDeBarras = DgvProdutos.Rows[i].Cells[1].Value.ToString();
                        oProduto.FornecedorId = 1;
                        oProduto.SubCategoriaId = 1;
                        oProduto.Nome = DgvProdutos.Rows[i].Cells[3].Value.ToString();
                        oProduto.DataDeValidade = DateTime.Parse(DgvProdutos.Rows[i].Cells[4].Value.ToString());
                        oProduto.Quantidade = clsGlobal.DeStringParaInt(DgvProdutos.Rows[i].Cells[6].Value.ToString());
                        oProduto.ValorCompra = clsGlobal.DeStringParaDecimal(DgvProdutos.Rows[i].Cells[5].Value.ToString());
                        oProduto.PrecoUnitario = clsGlobal.DeStringParaDecimal(DgvProdutos.Rows[i].Cells[8].Value.ToString());
                        oProduto.PrecoDeVenda = clsGlobal.DeStringParaDecimal(DgvProdutos.Rows[i].Cells[9].Value.ToString());
                        oProduto.Foto = "";
                        oProduto.Salvar();
                    }
                }

                MessageBox.Show("Processo realisado com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Gravar();
        }

        private void BtnCriarTabelaEstoque_Click(object sender, EventArgs e)
        {
            DialogResult dresult = MensagemBox.Mostrar("Você quer mesmo RECRIAR a tabela produtos? Esta ação não poderá ser desfeita. Todos os dados serão substiyuidos.".ToUpper(), "Sim", "Não");
            if (dresult == DialogResult.Yes)
            {
                var p = new Produto();
                p.CriarTabela();
                Gravar();
            }
             dresult = MensagemBox.Mostrar("Você quer mesmo RECRIAR a tabela estoques? Esta ação não poderá ser desfeita. Todos os dados serão substiyuidos.".ToUpper(), "Sim", "Não");
            if (dresult == DialogResult.Yes)
            {
                var et = new Estoque();
                et.CriarTabela();
            }
        }
    }
}

//var oEstoque = new Estoque
//{
//    EstoqueId = 0,
//    ProdutoId = oProduto.ProdutoId,
//    Produto = oProduto.Nome,
//    CodigoDeBarras = oProduto.CodigoDeBarras,
//    Quantidade = oProduto.Quantidade,
//    PrecoDeVenda = oProduto.PrecoDeVenda,
//    QuantidadeItemDesconto = 0,
//    Foto = oProduto.Foto,
//    ValorDesconto = 0
//};

////Verificando se o nome já existe no estoque e resgata o EstoqueId.
//var eEstoque = new Estoque
//{
//    CodigoDeBarras = oEstoque.CodigoDeBarras
//};

//List<Estoque> l = eEstoque.Busca();
//if (l.Count > 0)
//{
//    oEstoque.EstoqueId = l[0].EstoqueId;
//}

//oEstoque.Salvar();