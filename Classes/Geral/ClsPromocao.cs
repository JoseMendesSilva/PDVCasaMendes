using System;
using System.IO;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Xml;

using CasaMendes.Classes.ADL;
using CasaMendes.Classes.Estatica;

namespace CasaMendes
{
    //class ClsPromocao<Tkeys, Tvalor1, Tvalor1>
    public class ClsPromocao
    {

        //====================================================================================================
        private const string m_Document = "CM_promocao.xml";
        private string path = clsGlobal.ValidarDiretorio(Application.StartupPath, @"\" + m_Document);

        //====================================================================================================
        public Dictionary<string, ClsItensPromocao> Dicionario_de_Promocao;
        private ClsItensPromocao obj;
        
        private string Scodigodebarras;
        private decimal Dvalor;
        private decimal valor_decimal;

        //===================Promoção construtor================
        public ClsPromocao()
        {
            Dicionario_de_Promocao = new Dictionary<string, ClsItensPromocao>();
        }

        //====================================================================================================
        private string CodigoDeBarras
        {
            get { return Scodigodebarras; }
            set { Scodigodebarras = value; }
        }
       
        //====================================================================================================
        public decimal Valor
        {
            get { return Dvalor; }
            set { Dvalor = value; }
        }

        //====================================================================================================
        public decimal De_String_Para_decimal(string sValor)
        {
            valor_decimal = Convert.ToDecimal(sValor);
            return valor_decimal; 
        }

        //====================================================================================================
        public string LeituraXML()
        {
            try
            {
                
            //Create the XmlDocument.
            XmlDocument doc = new XmlDocument(); 
            
            // Create the file if it not exists.
            if (!File.Exists(path))
            {
                return "o arquivo nao existe";
            }

            doc.Load(m_Document);

            //Display all the desconto.
            XmlNodeList elemCodigoDeBarras = doc.GetElementsByTagName("codigo");
            XmlNodeList elemQuantidade_desconto = doc.GetElementsByTagName("quantidade_desconto");
            XmlNodeList elemListValor_desconto = doc.GetElementsByTagName("valor_desconto");
                
                if (!Dicionario_de_Promocao.Count.Equals(0))
                {
                    Dicionario_de_Promocao.Clear(); 
                }                 
                                
                for (int i = 0; i < elemQuantidade_desconto.Count; i++)
                {
                    obj = new ClsItensPromocao();
                    Scodigodebarras = elemCodigoDeBarras[i].InnerXml;
                    obj.QuantidadeMinimaParaDesconto = De_String_Para_decimal(elemQuantidade_desconto[i].InnerXml);
                    obj.ValorDesconto = De_String_Para_decimal(elemListValor_desconto[i].InnerXml);

                    Dicionario_de_Promocao.Add(Scodigodebarras, obj);
                }

                //Teste para verificar se o dicionário foi preenchido corretamente.
                 /*string s="";
                 foreach (KeyValuePair<string, ClsItensPromocao> kvp in Dicionario_de_Promocao)
                 {
                     s += string.Format("codigoebarras = {0}, QuantidadeMinimaParaDesconto = {1}, ValorDesconto = {2}", kvp.Key.ToString(), kvp.Value.QuantidadeMinimaParaDesconto, kvp.Value.ValorDesconto) + Environment.NewLine;
                 }
                 MessageBox.Show(s, Application.ProductName);*/

                return string.Empty;
            }
            catch//(Exception ex)
            {
                //MessageBox.Show(ex.Message);
                return null;
            }

        }

        public void lerPromocao(DataGridView dgv)
        {
            //string sql = "SELECT CodigoDeBarras, Produto, Desconto, ValorDesconto FROM tProdutos inner join tFornecedores on tProdutos.CodigoDoFornecedor = tFornecedores.CodigoDoFornecedor where ((Desconto > 0 ) and (ValorDesconto > 0 )) ORDER BY tProdutos.Produto";
            string sql = "SELECT [CodigoDeBarras], [Produto], [Desconto], [ValorDesconto] as [V. desconto] FROM [tProdutos] where Desconto > 0";
            dgv.DataSource = Cl_Dados.ListarDescontos(sql);
        }

        public bool escreverXml(DataGridView dgv, decimal JurosSobreVendasFiado)
        {
            XmlWriter writer = null;

        string produto;
        string CodigoDeBarras;
        string QuantidadeMinima;
        string ValorDesconto;

        try
        {

            if (File.Exists(path)) File.Delete(path);

            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            writer = XmlWriter.Create(m_Document, settings);

            writer.WriteComment("Lista de produtos em promoção");

            // Write an element (this one is the root).
            writer.WriteStartElement("lista-de-promocao");

            // Write the namespace declaration.
            writer.WriteAttributeString("xmlns", "status", null, "urn:lista");

            // Write the genre attribute.
            writer.WriteAttributeString("genero", "interno");

            for (int i = 0; i < dgv.RowCount+1; i++)
            {
                writer.WriteComment("Produto " + (i + 1));
                writer.WriteStartElement("lista");

                // Write the namespace declaration.
                writer.WriteAttributeString("xmlns", "tp", null, "urn:lista");

                // Write the genre attribute.
                writer.WriteAttributeString("Status", "interno");

                if (i < dgv.RowCount)
                {
                    CodigoDeBarras = dgv.Rows[i].Cells[0].Value.ToString();
                    produto = dgv.Rows[i].Cells[1].Value.ToString();
                    QuantidadeMinima = dgv.Rows[i].Cells[2].Value.ToString();
                    ValorDesconto = dgv.Rows[i].Cells[3].Value.ToString();
                    
                    // Write the produto.
                    writer.WriteStartElement("produto");
                    writer.WriteString(produto);
                    writer.WriteEndElement();

                    //Código de barras
                    writer.WriteStartElement("codigo");
                    writer.WriteString(CodigoDeBarras);
                    writer.WriteEndElement();

                    //Quantidade minima a ser aplicado o desconto
                    writer.WriteStartElement("quantidade_desconto");
                    writer.WriteString(QuantidadeMinima);
                    writer.WriteEndElement();

                    //Valor de dsconto
                    writer.WriteElementString("valor_desconto", ValorDesconto);
                    writer.WriteEndElement();
                }
                else
                {
                    // Write the produto.
                    writer.WriteStartElement("produto");
                    writer.WriteString("Tacha sobre venda fiado");
                    writer.WriteEndElement();

                    //Código de barras
                    writer.WriteStartElement("codigo");
                    writer.WriteString("tachaX");
                    writer.WriteEndElement();

                    //Quantidade minima a ser aplicado o desconto
                    writer.WriteStartElement("quantidade_desconto");
                    writer.WriteString("1");
                    writer.WriteEndElement();

                    //Valor de dsconto
                    writer.WriteElementString("valor_desconto", (JurosSobreVendasFiado/100).ToString());
                    writer.WriteEndElement();
                }

            }

            // Write the close tag for the root element.
            writer.WriteEndElement();

            // Write an element (this one is the root).
            //writer.WriteStartElement("lista-de-promocao");
            // Write the XML to file and close the writer.
            writer.Flush();
            writer.Close();
        }
        catch 
        {
            return false;
        }
        finally
        {
         if (writer != null) writer.Close();
         GC.Collect();
        }

       return true;

       }

        /*////////////====================================//////////////*/

   }

}

/*
        public void escreverXml()
        {
            ArrayList al = new ArrayList();
            al = Cl_Dados.PegarArrayListDados("SELECT CodigoDeBarras, Produto, Desconto, ValorDesconto FROM [tProdutos] inner join tFornecedores on tProdutos.CodigoDoFornecedor = tFornecedores.CodigoDoFornecedor where Desconto > 0 ORDER BY tProdutos.Produto");

            XmlWriter writer = null;

       try {

           if (File.Exists(path))
           {
               File.Delete(path);
           }

        XmlWriterSettings settings = new XmlWriterSettings();
        settings.Indent = true;
        writer = XmlWriter.Create (m_Document, settings);
        
        writer.WriteComment("Lista de produtos em promoção");

        // Write an element (this one is the root).
        writer.WriteStartElement("lista-de-promocao");

        // Write the namespace declaration.
        writer.WriteAttributeString("xmlns", "status", null, "urn:lista");

        // Write the genre attribute.
        writer.WriteAttributeString("genero", "interno");
        for (int i = 0; i < 4; i++)
        {
            writer.WriteComment("Produto " + (i + 1));
            writer.WriteStartElement("lista");

            // Write the namespace declaration.
            writer.WriteAttributeString("xmlns", "tp", null, "urn:lista");

            // Write the genre attribute.
            writer.WriteAttributeString("Status", "interno");

            if (i == 0)
            {
                // Write the produto.
                writer.WriteStartElement("produto");
                writer.WriteString("Cigarro");
                writer.WriteEndElement();

                //Código de barras
                writer.WriteStartElement("codigo");
                writer.WriteString("178400924");
                writer.WriteEndElement();

                //Quantidade minima a ser aplicado o desconto
                writer.WriteStartElement("quantidade_desconto");
                writer.WriteString("3");
                writer.WriteEndElement();

                //Valor de dsconto
                writer.WriteElementString("valor_desconto", "0,05");
                writer.WriteEndElement();
            }
            else if (i == 1)
            {
                // Write the produto.
                writer.WriteStartElement("produto");
                writer.WriteString("Paçoca");
                writer.WriteEndElement();

                //Código de barras
                writer.WriteStartElement("codigo");
                writer.WriteString("7898364280199");
                writer.WriteEndElement();

                //Quantidade minima a ser aplicado o desconto
                writer.WriteStartElement("quantidade_desconto");
                writer.WriteString("3");
                writer.WriteEndElement();

                //Valor de dsconto
                writer.WriteElementString("valor_desconto", "0,05");
                writer.WriteEndElement();
            }
            else if (i == 2)
            {
                // Write the produto.
                writer.WriteStartElement("produto");
                writer.WriteString("Cartela de ovos");
                writer.WriteEndElement();

                //Código de barras
                writer.WriteStartElement("codigo");
                writer.WriteString("7115");
                writer.WriteEndElement();

                //Quantidade minima a ser aplicado o desconto
                writer.WriteStartElement("quantidade_desconto");
                writer.WriteString("1");
                writer.WriteEndElement();

                //Valor de dsconto
                writer.WriteElementString("valor_desconto", "0,11");
                writer.WriteEndElement();
            }
            else
            {
                // Write the produto.
                writer.WriteStartElement("produto");
                writer.WriteString("Cerveja Itaipava");
                writer.WriteEndElement();
                
                //Código de barras
                writer.WriteStartElement("codigo");
                writer.WriteString("7897395020101");
                writer.WriteEndElement();

                //Quantidade minima a ser aplicado o desconto
                writer.WriteStartElement("quantidade_desconto");
                writer.WriteString("3");
                writer.WriteEndElement();

                //Valor de dsconto
                writer.WriteElementString("valor_desconto", "0,5");
                writer.WriteEndElement();
            }

        }

        // Write the close tag for the root element.
        writer.WriteEndElement();

        // Write an element (this one is the root).
        //writer.WriteStartElement("lista-de-promocao");
        // Write the XML to file and close the writer.
        writer.Flush();
        writer.Close();
      }

      finally {
        if (writer != null)
           writer.Close();

        //oP = null;
        //GC.Collect(2, GCCollectionMode.Optimized);
     }
        

        }
*/