using DocumentFormat.OpenXml.Packaging;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace CasaMendes
{
    using oGlobal = clsGlobal;
    public partial class Form1 : Form
    {

        private AppDiretorios?[] _items = null;

        public AppDiretorios? this[int index]
        {
            get => _items[index];
            set => _items[index] = value;
        }

        public struct AppDiretorios
        {
            private string pa;
            private string pathApp
            {
                get{ return pa; }
                set{ pa = Application.StartupPath; }
            }
            public string produto { get; set; }
            public string CodigoDeBarras { get; set; }
            public string QuantidadeMinima { get; set; }
            public string ValorDesconto { get; set; }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLer_Click(object sender, EventArgs e)
        {
            LeituraXML();
        }
        //====================================================================================================
        public string LeituraXML()
        {
            try
            {

                //Create the XmlDocument.
                XmlDocument doc = new XmlDocument();

                // Create the file if it not exists.

                var path = Application.StartupPath;

                doc.Load("CM_promocao.xml");

                //Display all the desconto.
                XmlNodeList elemCodigoDeBarras = doc.GetElementsByTagName("codigo");
                XmlNodeList elemQuantidade_desconto = doc.GetElementsByTagName("quantidade_desconto");
                XmlNodeList elemListValor_desconto = doc.GetElementsByTagName("valor_desconto");

                //StringBuilder sb = new StringBuilder();
                var ApDir = new AppDiretorios();
                //ApDir.produto = e[0].InnerXml;
                ApDir.QuantidadeMinima = elemQuantidade_desconto[0].InnerXml;
                ApDir.ValorDesconto = elemListValor_desconto[0].InnerXml;
                ApDir.CodigoDeBarras = elemCodigoDeBarras[0].InnerXml;
                //sb.Append(elemCodigoDeBarras[0].InnerXml);
                //sb.Append(elemQuantidade_desconto[0].InnerXml);
                //sb.Append(elemListValor_desconto[0].InnerXml);

                MessageBox.Show($"Cod De Barras: {ApDir.CodigoDeBarras}, Quant Minima: {ApDir.QuantidadeMinima} Valor Desconto: {ApDir.ValorDesconto}");

                return string.Empty;
            }
            catch//(Exception ex)
            {
                //MessageBox.Show(ex.Message);
                return null;
            }

        }

        public void escreverXml()
        {
  
            XmlWriter writer = null;

            try
            {

                
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Indent = true;
                writer = XmlWriter.Create("CM_promocao.xml", settings);

                writer.WriteComment("Lista de produtos em promoção");

                // Write an element (this one is the root).
                writer.WriteStartElement("lista-de-promocao");

                // Write the namespace declaration.
                writer.WriteAttributeString("xmlns", "status", null, "urn:lista");

                // Write the genre attribute.
                writer.WriteAttributeString("genero", "interno");
                    writer.WriteComment("Produto " + (1));
                    writer.WriteStartElement("lista");

                    // Write the namespace declaration.
                    writer.WriteAttributeString("xmlns", "tp", null, "urn:lista");

                    // Write the genre attribute.
                    writer.WriteAttributeString("Status", "interno");

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
                    
                // Write the close tag for the root element.
                writer.WriteEndElement();

                // Write an element (this one is the root).
                //writer.WriteStartElement("lista-de-promocao");
                // Write the XML to file and close the writer.
                writer.Flush();
                writer.Close();
            }

            finally
            {
                if (writer != null)
                    writer.Close();

                //oP = null;
                //GC.Collect(2, GCCollectionMode.Optimized);
            }


        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            escreverXml();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }

}


//async Task TestWriter(Stream stream)
//{
//    XmlWriterSettings settings = new XmlWriterSettings();
//    settings.Async = true;

//    using (XmlWriter writer = XmlWriter.Create(stream, settings))
//    {
//        await writer.WriteStartElementAsync("pf", "root", "http://ns");
//        await writer.WriteStartElementAsync(null, "sub", null);
//        await writer.WriteAttributeStringAsync(null, "att", null, "val");
//        await writer.WriteStringAsync("text");
//        await writer.WriteEndElementAsync();
//        await writer.WriteProcessingInstructionAsync("pName", "pValue");
//        await writer.WriteCommentAsync("cValue");
//        await writer.WriteCDataAsync("cdata value");
//        await writer.WriteEndElementAsync();
//        await writer.FlushAsync();
//    }
//}

////////////////////////////////////////////////////

//async Task TestReader(Stream stream)
//{
//    XmlReaderSettings settings = new XmlReaderSettings();
//    settings.Async = true;

//    using (XmlReader reader = XmlReader.Create(stream, settings))
//    {
//        while (await reader.ReadAsync())
//        {
//            switch (reader.NodeType)
//            {
//                case XmlNodeType.Element:
//                    Console.WriteLine("Start Element {0}", reader.Name);
//                    break;
//                case XmlNodeType.Text:
//                    Console.WriteLine("Text Node: {0}", await reader.GetValueAsync());
//                    break;
//                case XmlNodeType.EndElement:
//                    Console.WriteLine("End Element {0}", reader.Name);
//                    break;
//                default:
//                    Console.WriteLine("Other node {0} with value {1}", reader.NodeType, reader.Value);
//                    break;
//            }
//        }
//    }
//}
