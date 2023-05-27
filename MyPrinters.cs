using DocumentFormat.OpenXml.Drawing.Charts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasaMendes
{
    public partial class MyPrinters : Form
    {
        public MyPrinters()
        {
            InitializeComponent();
        }
        private PrintDocument printDocument = new PrintDocument();
        private static String COMPROVANTE = @ConfigurationManager.AppSettings["DiretorioComprovante"] + @"\comprovante.txt";
        private String stringToPrint = "";

        private void button1_Click(object sender, EventArgs e)
        {
            //geraComprovante();
            ////imprimeComprovante();
            //ImprimeVendaVista o = new ImprimeVendaVista();
            //o.Print();
        }
        private void MyPrinters_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();

            foreach (var impressoare in PrinterSettings.InstalledPrinters)
            {
                comboBox1.Items.Add(impressoare);
            }
            comboBox1.SelectedIndex = 3;
        }
 
        private void geraComprovante()
        {
            if(!Directory.Exists(@ConfigurationManager.AppSettings["DiretorioComprovante"])) { Directory.CreateDirectory(@ConfigurationManager.AppSettings["DiretorioComprovante"]); }
            FileStream fs = new FileStream(COMPROVANTE, FileMode.Create);
            StreamWriter writer = new StreamWriter(fs);
            writer.WriteLine("==========================================");
            writer.WriteLine("          NOME DA EMPRESA AQUI            ");
            writer.WriteLine("==========================================");
            writer.WriteLine(String.Format("{0,-6}| {1,-28}| {2,-9}| {3,-6}", "Item", "Descricao", "Quant", "Total").ToUpper());
            writer.WriteLine(String.Format("{0,-6} {1,-32} {2,-10} {3,-7}", "0001", "Arroz", "0001", " 10,55").ToUpper());
            writer.WriteLine(String.Format("{0,-6} {1,-32} {2,-10} {3,-7}", "0001", "feijão", "0001", " 10,55").ToUpper());
            writer.WriteLine(String.Format("{0,-6} {1,-32} {2,-10} {3,-7}", "0001", "açucar", "0001", " 10,55").ToUpper());
            writer.WriteLine(String.Format("{0,-6} {1,-32} {2,-10} {3,-7}", "0001", "Café canecão", "0001", " 10,55").ToUpper());
            writer.WriteLine(String.Format("{0,-6} {1,-32} {2,-10} {3,-7}", "0001", "Doce de leite", "0001", " 10,55").ToUpper());
            writer.WriteLine(String.Format("{0,-6} {1,-32} {2,-10} {3,-7}", "0001", "Fini bananinha", "0001", " 10,55").ToUpper());
            writer.WriteLine(String.Format("{0,-6} {1,-32} {2,-10} {3,-7}", "0001", "Refri convenção guaraná 2L", "0001", " 10,55").ToUpper());
            writer.WriteLine(String.Format("{0,-6} {1,-32} {2,-10} {3,-7}", "0001", "Coca cola 2,5L", "0001", " 10,55").ToUpper());
            writer.WriteLine(String.Format("{0,-6} {1,-32} {2,-10} {3,-7}", "0001", "Lula cebola", "0001", " 10,55").ToUpper());
            writer.WriteLine(String.Format("{0,-6} {1,-32} {2,-10} {3,-7}", "0001", "Fofura churasco", "0001", " 10,55").ToUpper());
            writer.WriteLine(String.Format("{0,-6} {1,-32} {2,-10} {3,-7}", "0001", "Poeme choc ao leite", "0001", " 10,55").ToUpper());
            writer.WriteLine(String.Format("{0,-6} {1,-32} {2,-10} {3,-7}", "0001", "Toddy", "0001", " 10,55").ToUpper());

            writer.Close();
            fs.Close();
        }

        private void imprimeComprovante()
        {
            FileStream fs = new FileStream(COMPROVANTE, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            stringToPrint = sr.ReadToEnd();
            printDocument.PrinterSettings.PrinterName = comboBox1.SelectedItem.ToString();
            printDocument.PrintPage += new PrintPageEventHandler(printPage);
            printDocument.Print();
            sr.Close();
            fs.Close();
        }

        private void printPage(object sender, PrintPageEventArgs e)
        {
            int charactersOnPage = 0;
            int linesPerPage = 0;
            Graphics graphics = e.Graphics;

            // Sets the value of charactersOnPage to the number of characters 
            // of stringToPrint that will fit within the bounds of the page.
            graphics.MeasureString(stringToPrint, this.Font, e.MarginBounds.Size, StringFormat.GenericTypographic, out charactersOnPage, out linesPerPage);

            // Draws the string within the bounds of the page
            graphics.DrawString(stringToPrint, this.Font, Brushes.Black, e.MarginBounds, StringFormat.GenericTypographic);

            // Remove the portion of the string that has been printed.
            stringToPrint = stringToPrint.Substring(charactersOnPage);

            // Check to see if more pages are to be printed.
            e.HasMorePages = (stringToPrint.Length > 0);
        }

       // private void button1_Click(object sender, EventArgs e)
       // {
       //     using(var pd = new PrintDocument())
       //     {
       //         StringBuilder sb = new StringBuilder();
       //         sb.AppendLine("Casa Mendes Caixa N: 1".ToUpper());
       //         sb.AppendLine("Funcionário: José Mendes".ToUpper());
       //         sb.AppendLine("Número venda: 999999999".ToUpper());
       //         sb.AppendLine(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
       //         sb.AppendLine(String.Format("{0,0}","--------------------------------------------------------------"));
       //         sb.AppendLine(String.Format("{0,-6}| {1,-28}| {2,-9}| {3,-6}", "Item", "Descricao", "Quant", "Total").ToUpper());
       //         sb.AppendLine(String.Format("{0,-6} {1,-32} {2,-10} {3,-7}", "0001", "Arroz", "0001", " 10,55").ToUpper());
       //         sb.AppendLine(String.Format("{0,-6} {1,-32} {2,-10} {3,-7}", "0001", "feijão", "0001", " 10,55").ToUpper());
       //         sb.AppendLine(String.Format("{0,-6} {1,-32} {2,-10} {3,-7}", "0001", "açucar", "0001", " 10,55").ToUpper());
       //         sb.AppendLine(String.Format("{0,-6} {1,-32} {2,-10} {3,-7}", "0001", "Café canecão", "0001", " 10,55").ToUpper());
       //         sb.AppendLine(String.Format("{0,-6} {1,-32} {2,-10} {3,-7}", "0001", "Doce de leite", "0001", " 10,55").ToUpper());
       //         sb.AppendLine(String.Format("{0,-6} {1,-32} {2,-10} {3,-7}", "0001", "Fini bananinha", "0001", " 10,55").ToUpper());
       //         sb.AppendLine(String.Format("{0,-6} {1,-32} {2,-10} {3,-7}", "0001", "Refri convenção guaraná 2L", "0001", " 10,55").ToUpper());
       //         sb.AppendLine(String.Format("{0,-6} {1,-32} {2,-10} {3,-7}", "0001", "Coca cola 2,5L", "0001", " 10,55").ToUpper());
       //         sb.AppendLine(String.Format("{0,-6} {1,-32} {2,-10} {3,-7}", "0001", "Lula cebola", "0001", " 10,55").ToUpper());
       //         sb.AppendLine(String.Format("{0,-6} {1,-32} {2,-10} {3,-7}", "0001", "Fofura churasco", "0001", " 10,55").ToUpper());
       //         sb.AppendLine(String.Format("{0,-6} {1,-32} {2,-10} {3,-7}", "0001", "Poeme choc ao leite", "0001", " 10,55").ToUpper());
       //         sb.AppendLine(String.Format("{0,-6} {1,-32} {2,-10} {3,-7}", "0001", "Toddy", "0001", " 10,55").ToUpper());
       //         sb.AppendLine(String.Format("{0,0}", "--------------------------------------------------------------"));
       //         sb.AppendLine(String.Format("{0,6} {1,15}\n\n", "Year", "Population").ToUpper());
       //         sb.AppendLine(String.Format("{0,0}\n\n", "-"));
       //         sb.AppendLine(String.Format("{0,0} {1,15:N20}\n", "Total", "253,99").ToUpper());
       //         sb.AppendLine(String.Format("{0,0} {0,10} {1,15:N0}\n", "Tipo de venda  PENDURA", "Acrescimo", "10% AC").ToUpper());
       //         sb.AppendLine(String.Format("{0,0} {1,15:N0}\n", "Taxa", "10% AM").ToUpper());
       //         sb.AppendLine(String.Format("{0,0} {1,15:N0}\n", "Total venda pendura", "304,79").ToUpper());
       //         sb.AppendLine(String.Format("{0,0}", "--------------------------------------------------------------"));


       //         pd.PrinterSettings.PrinterName=comboBox1.SelectedItem.ToString();
       //         pd.PrintPage += pd_PrintPage;
       //         _texts = sb.ToString();
       //         pd.Print();
       //     }
       // }

       //private string _texts;
       // private void pd_PrintPage(object sender, PrintPageEventArgs e)
    //    {
    //        using (var font = new Font("Time New Roman", 14))
    //        using (var brush = new SolidBrush(Color.Black))
    //        {
    //            int caracteres = 0;
    //    int linhas = 0;
    //    e.Graphics.MeasureString(_texts, font, new System.Drawing.Size(e.MarginBounds.Width, e.MarginBounds.Height - font.Height + 1), new StringFormat(), out caracteres, out linhas);
    //            e.Graphics.DrawString(_texts.Substring(0, caracteres), font, brush, e.MarginBounds);
    //            _texts = _texts.Substring(caracteres);
    //            e.HasMorePages = !string.IsNullOrWhiteSpace(_texts);
    //}


//}
    }
}
