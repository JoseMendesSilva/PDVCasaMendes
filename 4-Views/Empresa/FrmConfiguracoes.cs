using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace CasaMendes
{
    public partial class FrmConfiguracoes : Form
    {
        private string[] tabelas = new string[14];
        private int count = 0;

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
                get { return pa; }
                set { pa = Application.StartupPath; }
            }

            public string produto { get; set; }
            public string CodigoDeBarras { get; set; }
            public string QuantidadeMinima { get; set; }
            public string ValorDesconto { get; set; }
        }

        public FrmConfiguracoes()
        {
            InitializeComponent();
            //this.BtnOk.Click += new System.EventHandler(BtnOk_Click);
            //this.BtnRetornar.Click += new System.EventHandler(this.BtnRetornar_Click);
            //this.docToPrint1.PrintPage += new PrintPageEventHandler(docToPrint_PrintPage);
        }

        private void MyPrintersLoad()
        {
            CbPrinters.Items.Clear();
            foreach (var impressoare in PrinterSettings.InstalledPrinters)
            {
                CbPrinters.Items.Add(impressoare);
            }
            ReadSetting("PrinterName");
        }

        private void ReadSetting(string key)
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                string result = appSettings[key] ?? "Not Found";
                CbPrinters.SelectedText = result;
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error reading app settings");
            }
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;

                var key = "PrinterName";
                var value = CbPrinters.Text;

                if (settings[key] == null)
                {
                    settings.Add(key, value);
                }
                else
                {
                    settings[key].Value = value;
                }

                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
                MessageBox.Show("O nome da impressoara selecionada, foi salvo com sucesso.");
            }
            catch
            {
                MensagemBox.Mostrar("O nome da impressoara selecionada, não foi salvo com sucesso.", "OK", "Cancelar");
            }
        }

        private void BtnRetornar_Click(object sender, EventArgs e)
        {

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

                doc.Load("CM_Promocao.xml");

                //Display all the desconto.
                XmlNodeList elemCodigoDeBarras = doc.GetElementsByTagName("codigo");
                XmlNodeList elemQuantidade_desconto = doc.GetElementsByTagName("quantidade_desconto");
                XmlNodeList elemListValor_desconto = doc.GetElementsByTagName("valor_desconto");

                var sb = new StringBuilder();
                var ApDir = new AppDiretorios();
                //ApDir.produto = e[0].InnerXml;
                ApDir.QuantidadeMinima = elemQuantidade_desconto[0].InnerXml;
                ApDir.ValorDesconto = elemListValor_desconto[0].InnerXml;
                ApDir.CodigoDeBarras = elemCodigoDeBarras[0].InnerXml;
                sb.Append(elemCodigoDeBarras[0].InnerXml);
                sb.Append(elemQuantidade_desconto[0].InnerXml);
                sb.Append(elemListValor_desconto[0].InnerXml);

                this.RTBoxPromocao.Text = sb.ToString();

                //MessageBox.Show($"Cod De Barras: {ApDir.CodigoDeBarras}, Quant Minima: {ApDir.QuantidadeMinima} Valor Desconto: {ApDir.ValorDesconto}");

                return string.Empty;
            }
            catch//(Exception ex)
            {
                //MessageBox.Show(ex.Message);
                return null;
            }

        }
        //====================================================================================================

        //====================================================================================================
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
        //====================================================================================================

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            escreverXml();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private async void FrmConfiguracoes_Load(object sender, EventArgs e)
        {
            MyPrintersLoad();

            //var categorias = await new Categoria().TabelaExiste();
            //var subCategorias = await new SubCategoria().TabelaExiste();
            //var fornecedores = await new Fornecedore().TabelaExiste();
            //var produtos = await new Produto().TabelaExiste();
            //var estoques = await new Estoque().TabelaExiste();
            //var funcionarios = await new Funcionario().TabelaExiste();
            //var preVendas = await new PreVenda().TabelaExiste();
            //var clientes = await new Cliente ().TabelaExiste();
            //var tabelaDeMargens = await new TabelaDeMargen().TabelaExiste();

            //var caixas = await new Caixa().TabelaExiste();
            //var abrircaixas = await new AbrirCaixa().TabelaExiste();
            //var fecharcaixas = await new FecharCaixa().TabelaExiste();
            //var sangrias = await new Sangria().TabelaExiste();
            //var suprimentoCaixas = await new Suprimento().TabelaExiste();

            //if (categorias) CbCategorias.Checked = true;
            //if(subCategorias) CbSubCategorias.Checked = true;
            //if(fornecedores) CbFornecedores.Checked = true;
            //if(produtos) CbProdutos.Checked = true;
            //if(estoques) CbEstoque.Checked = true;
            //if(funcionarios) CbFuncionarios.Checked = true;
            //if(preVendas) CbPreVendas.Checked = true;
            //if(clientes) CbClientes.Checked = true;
            //if(tabelaDeMargens) CbTabelaDeMargen.Checked = true;

            //if(caixas) CbCaixa.Checked = true;
            //if(abrircaixas) CbAbrirCaixa.Checked = true;
            //if(fecharcaixas) CbFecharCaixa.Checked = true;
            //if(sangrias) CbSangria.Checked = true;
            //if(suprimentoCaixas) CbSuprimento.Checked = true;
        }

        private async void BtnCriaTabelas_Click(object sender, EventArgs e)
        {
            if (tabelas == null) return;
            var res = MessageBox.Show("As tabelas que forão setadas para serem criadas, serão, permanentemente excluidas do sistema com perdas definitivas dos dados, se existirem, e serão cridas , totalmente limpas. Deseja proceguir?", "Informação do sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(res == DialogResult.No) return;

            // zera o contador
            this.count = 0;
            var listaOk = new List<string>();
            string messagem = string.Empty;
            var messagemCount = 0;

            foreach (var item in tabelas)
            {
                if (item == null) break;
                if ( await CriarTabelasDoSistema.CriarTabelas(item.ToString()))
                {
                    listaOk.Add(item.ToString());
                    messagemCount++;
                }
            }


            foreach (var item in listaOk)
            {
                if (item == null) break;
                if (string.IsNullOrEmpty(item.ToString())) messagem += item.ToString();
                if (messagemCount < listaOk.Count) messagem += string.Concat(" ", item.ToString(), ",");
                messagem += string.Concat(item.ToString(), ", "); 
            }

            if (!string.IsNullOrEmpty(messagem))
                MessageBox.Show($"A(s) tabelas - {messagem} forão criadas com sucesso.");

            this.BtnLimpar.PerformClick();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            CbTabelaDeMargen.Checked = false;
            CbCategorias.Checked = false;
            CbSubCategorias.Checked = false;
            CbFornecedores.Checked = false;
            CbProdutos.Checked = false;
            CbEstoque.Checked = false;
            CbClientes.Checked = false;
            CbPreVendas.Checked = false;
            CbFuncionarios.Checked = false;

            CbCaixa.Checked = false;
            CbAbrirCaixa.Checked = false;
            CbFecharCaixa.Checked = false;
            CbSangria.Checked = false;
            CbSuprimento.Checked = false;

            for(int i = 0; i < 14; i++)
            {
                if (tabelas[i] != null) tabelas[i] = null;
            }
            count = 0;
        }

        private void CbFuncionarios_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CbFuncionarios.Checked)
            {
                tabelas[this.count++] = CbFuncionarios.Tag.ToString();
                //if (this.count > 0) this.count--;
            }
        }

        private void CbClientes_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CbClientes.Checked)
            {
                tabelas[this.count++] = CbClientes.Tag.ToString();
                //if (this.count > 0) this.count--;
            }
        }

        private void CbFornecedores_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CbFornecedores.Checked)
            {
                tabelas[this.count++] = CbFornecedores.Tag.ToString();
                //if (this.count > 0) this.count--;
            }
        }

        private void CbProdutos_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CbProdutos.Checked)
            {
                tabelas[this.count++] = CbProdutos.Tag.ToString();
                //if (this.count > 0) this.count--;
            }
        }

        private void CbEstoque_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CbEstoque.Checked)
            {
                tabelas[this.count++] = CbEstoque.Tag.ToString();
                //if (this.count > 0) this.count--;
            }
        }

        private void CbCategorias_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CbCategorias.Checked)
            {
                tabelas[this.count++] = CbCategorias.Tag.ToString();
                //if (this.count > 0) this.count--;
            }
        }

        private void CbSubCategorias_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CbSubCategorias.Checked)
            {
                tabelas[this.count++] = CbSubCategorias.Tag.ToString();
                //if (this.count > 0) this.count--;
            }
        }

        private void CbPreVendas_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CbPreVendas.Checked)
            {
                tabelas[this.count++] = CbPreVendas.Tag.ToString();
                //if (this.count > 0) this.count--;
            }
        }

        private void CbCaixa_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CbCaixa.Checked)
            {
                tabelas[this.count++] = CbCaixa.Tag.ToString();
            }
        }

        private void CbAbrirCaixa_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CbAbrirCaixa.Checked)
            {
                tabelas[this.count++] = CbAbrirCaixa.Tag.ToString();
            }
        }

        private void CbFecharCaixa_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CbFecharCaixa.Checked)
            {
                tabelas[this.count++] = CbFecharCaixa.Tag.ToString();
            }
        }

        private void CbSuprimento_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CbSuprimento.Checked)
            {
                tabelas[this.count++] = CbSuprimento.Tag.ToString();
            }
        }

        private void CbSangria_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CbSangria.Checked)
            {
                tabelas[this.count++] = CbSangria.Tag.ToString();
            }
        }

        private void CbTabelaDeMargen_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CbTabelaDeMargen.Checked)
            {
                tabelas[this.count++] = CbTabelaDeMargen.Tag.ToString();
                return;
            }
        }

        private void BtnResumoVendas_Click(object sender, EventArgs e)
        {
            try
            {
                // linha de código usada para testar o componente de
                // impressão de coupom de ressumo de vendas.
                new ImprimirResumoDeVendas().Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}

//streamToPrint = new StreamReader("C:\\Users\\DELL\\Desktop\\ERP.txt");
//try
//{
//    printFont = new Font("Arial", 10);
//    PrintDocument pd = new PrintDocument();
//    pd.PrintPage += new PrintPageEventHandler(this.docToPrint_PrintPage);
//    pd.Print();
//}
//finally
//{
//    streamToPrint.Close();
//}

//private Font printFont;
//private StreamReader streamToPrint;

//private PrintDocument printDoc = new PrintDocument();
//private static String COMPROVANTE = @ConfigurationManager.AppSettings["DiretorioComprovante"] + @"\comprovante.txt";
//private String stringToPrint = "";

//// The PrintPage event is raised for each page to be printed.
//private void pd_PrintPage(object sender, PrintPageEventArgs ev)
//{
//    float linesPerPage = 0;
//    float yPos = 0;
//    int count = 0;
//    float leftMargin = ev.MarginBounds.Left;
//    float topMargin = ev.MarginBounds.Top;
//    string line = null;

//    Calculate the number of lines per page.
//   linesPerPage = ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics);

//    Print each line of the file.
//    while (count < linesPerPage && ((line = streamToPrint.ReadLine()) != null))
//    {
//        yPos = topMargin + (count * printFont.GetHeight(ev.Graphics));
//        ev.Graphics.DrawString(line, printFont, Brushes.Black, leftMargin, yPos, new StringFormat());
//        count++;
//    }

//    If more lines exist, print another page.
//    if (line != null)
//        ev.HasMorePages = true;
//    else
//        ev.HasMorePages = false;
//}

//public void Printing()
//{
//    try
//    {
//        streamToPrint = new StreamReader("C:\\Users\\DELL\\Desktop\\ERP.txt");
//        try
//        {
//            printFont = new Font("Arial", 10);
//            PrintDocument pd = new PrintDocument();
//            pd.PrintPage += new PrintPageEventHandler(docToPrint_PrintPage);
//            pd.PrinterSettings.PrinterName = "printer";
//            // Set the page orientation to landscape.
//            pd.DefaultPageSettings.Landscape = true;
//            pd.Print();
//        }
//        finally
//        {
//            streamToPrint.Close();
//        }
//    }
//    catch (Exception ex)
//    {
//        MessageBox.Show(ex.Message);
//    }
//}

//private void docToPrint_PrintPage(object sender, PrintPageEventArgs e)
//{

//    // Insert code to render the page here.
//    // This code will be called when the control is drawn.

//    // The following code will render a simple
//    // message on the document in the control.
//    string text = "In docToPrint_PrintPage method.In docToPrint_PrintPage method.In docToPrint_PrintPage method.In docToPrint_PrintPage method.";
//    System.Drawing.Font printFont = new Font("Arial", 35, FontStyle.Regular);
//    e.Graphics.DrawString(text, printFont, Brushes.Black, 10, 10);
//}

//private void MyPrinterSettings()
//{
//    // Add list of supported paper sizes found on the printer. 
//    // The DisplayMember property is used to identify the property that will provide the display string.
//    comboPaperSize.DisplayMember = "PaperName";

//    PaperSize pkSize;
//    for (int i = 0; i < docToPrint1.PrinterSettings.PaperSizes.Count; i++)
//    {
//        pkSize = docToPrint1.PrinterSettings.PaperSizes[i];
//        comboPaperSize.Items.Add(pkSize);
//    }

//    // Create a PaperSize and specify the custom paper size through the constructor and add to combobox.
//    PaperSize pkCustomSize1 = new PaperSize("First custom size", 100, 200);

//    comboPaperSize.Items.Add(pkCustomSize1);

//    // Add list of paper sources found on the printer to the combo box.
//    // The DisplayMember property is used to identify the property that will provide the display string.
//    comboPaperSource.DisplayMember = "SourceName";

//    PaperSource pkSource;
//    for (int i = 0; i < docToPrint1.PrinterSettings.PaperSources.Count; i++)
//    {
//        pkSource = docToPrint1.PrinterSettings.PaperSources[i];
//        comboPaperSource.Items.Add(pkSource);
//    }

//    // Add list of printer resolutions found on the printer to the combobox.
//    // The PrinterResolution's ToString() method will be used to provide the display string.

//    PrinterResolution pkResolution;
//    for (int i = 0; i < docToPrint1.PrinterSettings.PrinterResolutions.Count; i++)
//    {
//        pkResolution = docToPrint1.PrinterSettings.PrinterResolutions[i];
//        comboPrintResolution.Items.Add(pkResolution);
//    }
//    // Set the paper size based upon the selection in the combo box.
//    if (comboPaperSize.SelectedIndex != -1)
//    {
//        docToPrint1.DefaultPageSettings.PaperSize =
//            docToPrint1.PrinterSettings.PaperSizes[comboPaperSize.SelectedIndex];
//    }

//    // Set the paper source based upon the selection in the combo box.
//    if (comboPaperSource.SelectedIndex != -1)
//    {
//        docToPrint1.DefaultPageSettings.PaperSource =
//            docToPrint1.PrinterSettings.PaperSources[comboPaperSource.SelectedIndex];
//    }

//    // Set the printer resolution based upon the selection in the combo box.
//    if (comboPrintResolution.SelectedIndex != -1)
//    {
//        docToPrint1.DefaultPageSettings.PrinterResolution =
//            docToPrint1.PrinterSettings.PrinterResolutions[comboPrintResolution.SelectedIndex];
//    }

//    // Print the document with the specified paper size, source, and print resolution.
//    //printDoc.Print();
//}



//private void printPage(object sender, PrintPageEventArgs e)
//{
//    int charactersOnPage = 0;
//    int linesPerPage = 0;
//    Graphics graphics = e.Graphics;

//    // Sets the value of charactersOnPage to the number of characters 
//    // of stringToPrint that will fit within the bounds of the page.
//    graphics.MeasureString(stringToPrint, this.Font, e.MarginBounds.Size, StringFormat.GenericTypographic, out charactersOnPage, out linesPerPage);

//    // Draws the string within the bounds of the page
//    graphics.DrawString(stringToPrint, this.Font, Brushes.Black, e.MarginBounds, StringFormat.GenericTypographic);

//    // Remove the portion of the string that has been printed.
//    stringToPrint = stringToPrint.Substring(charactersOnPage);

//    // Check to see if more pages are to be printed.
//    e.HasMorePages = (stringToPrint.Length > 0);
//}

//private void ReadAllSettings()
//{
//    try
//    {
//        var appSettings = ConfigurationManager.AppSettings;

//        if (appSettings.Count == 0)
//        {
//            StringBuilder.Append("AppSettings is empty.");
//        }
//        else
//        {
//            foreach (var key in appSettings.AllKeys)
//            {
//                StringBuilder.Append($"Key: {key} Value: {appSettings[key]}\n");
//            }
//        }
//    }
//    catch (ConfigurationErrorsException)
//    {
//        Console.WriteLine("Error reading app settings");
//    }
//}

//private void AddUpdateAppSettings(string key, string value)
//{
//    try
//    {
//        var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
//        var settings = configFile.AppSettings.Settings;
//        if (settings[key] == null)
//        {
//            settings.Add(key, value);
//        }
//        else
//        {
//            settings[key].Value = value;
//        }
//        configFile.Save(ConfigurationSaveMode.Modified);
//        ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
//    }
//    catch (ConfigurationErrorsException)
//    {
//        Console.WriteLine("Error writing app settings");
//    }
//}

//private void Retornar()
//{
//    this.Close();
//    this.Dispose();
//}

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
