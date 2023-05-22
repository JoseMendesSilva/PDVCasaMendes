using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Xml;

namespace CasaMendes
{

    public class Promocao : Base
    {

        // //private decimal sQuantidade { get; set; }
        // public decimal QuantidadeMinimaParaDesconto { get;set;}
        // public decimal ValorDesconto { get; set; }
        // private string Scodigodebarras { get; set; }
        // private decimal Dvalor { get; set; }
        // private decimal valor_decimal { get; set; }
        // public decimal Valor { get; set; }

        // private const string m_Document = "CM_promocao.xml";
        // private string path = clsGlobal.ValidarDiretorio(Application.StartupPath, @"\" + m_Document);

        // //public Dictionary<string, ClsItensPromocao> Dicionario_de_Promocao;
        // //private ClsItensPromocao obj;


        // public Promocao()
        // {
        //     Dicionario_de_Promocao = new Dictionary<string, ClsItensPromocao>();
        // }

        //  public string LeituraXML()
        // {
        //     try
        //     {

        //     //Create the XmlDocument.
        //     XmlDocument doc = new XmlDocument(); 

        //     // Create the file if it not exists.
        //     if (!File.Exists(path))
        //     {
        //         return "o arquivo nao existe";
        //     }

        //     doc.Load(m_Document);

        //     //Display all the desconto.
        //     XmlNodeList elemCodigoDeBarras = doc.GetElementsByTagName("codigo");
        //     XmlNodeList elemQuantidade_desconto = doc.GetElementsByTagName("quantidade_desconto");
        //     XmlNodeList elemListValor_desconto = doc.GetElementsByTagName("valor_desconto");

        //         if (!Dicionario_de_Promocao.Count.Equals(0))
        //         {
        //             Dicionario_de_Promocao.Clear(); 
        //         }                 

        //         for (int i = 0; i < elemQuantidade_desconto.Count; i++)
        //         {
        //             obj = new ClsItensPromocao();
        //             Scodigodebarras = elemCodigoDeBarras[i].InnerXml;
        //             obj.QuantidadeMinimaParaDesconto = int.Parse(elemQuantidade_desconto[i].InnerXml);
        //             obj.ValorDesconto = decimal.Parse(elemListValor_desconto[i].InnerXml);

        //             Dicionario_de_Promocao.Add(Scodigodebarras, obj);
        //         }

        //         //Teste para verificar se o dicionário foi preenchido corretamente.
        //          /*string s="";
        //          foreach (KeyValuePair<string, ClsItensPromocao> kvp in Dicionario_de_Promocao)
        //          {
        //              s += string.Format("codigoebarras = {0}, QuantidadeMinimaParaDesconto = {1}, ValorDesconto = {2}", kvp.Key.ToString(), kvp.Value.QuantidadeMinimaParaDesconto, kvp.Value.ValorDesconto) + Environment.NewLine;
        //          }
        //          MessageBox.Show(s, Application.ProductName);*/

        //         return string.Empty;
        //     }
        //     catch//(Exception ex)
        //     {
        //         //MessageBox.Show(ex.Message);
        //         return null;
        //     }

        // }

        // public void lerPromocao(DataGridView dgv)
        // {
        //     //string sql = "SELECT CodigoDeBarras, Produto, Desconto, ValorDesconto FROM tProdutos inner join tFornecedores on tProdutos.CodigoDoFornecedor = tFornecedores.CodigoDoFornecedor where ((Desconto > 0 ) and (ValorDesconto > 0 )) ORDER BY tProdutos.Produto";
        //     string sql = "SELECT [CodigoDeBarras], [Produto], [Desconto], [ValorDesconto] as [V. desconto] FROM [tProdutos] where Desconto > 0";
        //     //dgv.DataSource = Cl_Dados.ListarDescontos(sql);
        // }

        // public bool escreverXml(DataGridView dgv, decimal JurosSobreVendasFiado)
        // {
        //     XmlWriter writer = null;

        // string produto;
        // string CodigoDeBarras;
        // string QuantidadeMinima;
        // string ValorDesconto;

        // try
        // {

        //     if (File.Exists(path)) File.Delete(path);

        //     XmlWriterSettings settings = new XmlWriterSettings();
        //     settings.Indent = true;
        //     writer = XmlWriter.Create(m_Document, settings);

        //     writer.WriteComment("Lista de produtos em promoção");

        //     // Write an element (this one is the root).
        //     writer.WriteStartElement("lista-de-promocao");

        //     // Write the namespace declaration.
        //     writer.WriteAttributeString("xmlns", "status", null, "urn:lista");

        //     // Write the genre attribute.
        //     writer.WriteAttributeString("genero", "interno");

        //     for (int i = 0; i < dgv.RowCount+1; i++)
        //     {
        //         writer.WriteComment("Produto " + (i + 1));
        //         writer.WriteStartElement("lista");

        //         // Write the namespace declaration.
        //         writer.WriteAttributeString("xmlns", "tp", null, "urn:lista");

        //         // Write the genre attribute.
        //         writer.WriteAttributeString("Status", "interno");

        //         if (i < dgv.RowCount)
        //         {
        //             CodigoDeBarras = dgv.Rows[i].Cells[0].Value.ToString();
        //             produto = dgv.Rows[i].Cells[1].Value.ToString();
        //             QuantidadeMinima = dgv.Rows[i].Cells[2].Value.ToString();
        //             ValorDesconto = dgv.Rows[i].Cells[3].Value.ToString();

        //             // Write the produto.
        //             writer.WriteStartElement("produto");
        //             writer.WriteString(produto);
        //             writer.WriteEndElement();

        //             //Código de barras
        //             writer.WriteStartElement("codigo");
        //             writer.WriteString(CodigoDeBarras);
        //             writer.WriteEndElement();

        //             //Quantidade minima a ser aplicado o desconto
        //             writer.WriteStartElement("quantidade_desconto");
        //             writer.WriteString(QuantidadeMinima);
        //             writer.WriteEndElement();

        //             //Valor de dsconto
        //             writer.WriteElementString("valor_desconto", ValorDesconto);
        //             writer.WriteEndElement();
        //         }
        //         else
        //         {
        //             // Write the produto.
        //             writer.WriteStartElement("produto");
        //             writer.WriteString("Tacha sobre venda fiado");
        //             writer.WriteEndElement();

        //             //Código de barras
        //             writer.WriteStartElement("codigo");
        //             writer.WriteString("tachaX");
        //             writer.WriteEndElement();

        //             //Quantidade minima a ser aplicado o desconto
        //             writer.WriteStartElement("quantidade_desconto");
        //             writer.WriteString("1");
        //             writer.WriteEndElement();

        //             //Valor de dsconto
        //             writer.WriteElementString("valor_desconto", (JurosSobreVendasFiado/100).ToString());
        //             writer.WriteEndElement();
        //         }

        //     }

        //     // Write the close tag for the root element.
        //     writer.WriteEndElement();

        //     // Write an element (this one is the root).
        //     //writer.WriteStartElement("lista-de-promocao");
        //     // Write the XML to file and close the writer.
        //     writer.Flush();
        //     writer.Close();
        // }
        // catch 
        // {
        //     return false;
        // }
        // finally
        // {
        //  if (writer != null) writer.Close();
        //  GC.Collect();
        // }

        //return true;

        //}

        // public new List<Promocao> Todos()
        // {
        //     var Promocao = new List<Promocao>();
        //     foreach (var ibase in base.Todos())
        //     {
        //         Promocao.Add((Promocao)ibase);
        //     }
        //     return Promocao;
        // }

        // public new List<Promocao> Busca()
        // {
        //     var Promocao = new List<Promocao>();
        //     foreach (var ibase in base.Busca())
        //     {
        //         Promocao.Add((Promocao)ibase);
        //     }
        //     return Promocao;
        // }


    }

}
