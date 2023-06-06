using System.Drawing.Printing;
using System.Drawing;
using System;
using System.Windows.Forms;
using System.Configuration;

namespace CasaMendes
{


    public class ImprimerListaDeCompra : PrintDocument
    {
        private DataGridView DgvProdutos;
        private Font bold = new Font(FontFamily.GenericSansSerif, 9, FontStyle.Bold);
        private Font regularItens = new Font(FontFamily.GenericSansSerif, 6, FontStyle.Regular);

        public ImprimerListaDeCompra(DataGridView DgvProduto)
        {
            this.DgvProdutos = DgvProduto;
            this.PrinterSettings.PrinterName = ConfigurationManager.AppSettings["PrinterName"];
            this.OriginAtMargins = false;
            this.PrintPage += new PrintPageEventHandler(printPage);
        }

        private void printPage(object send, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            int offset = 30;
            int PosicaoY = 0;
            int PosicaoX = 5;
            int PosicaoStartXLine = 4;
            int PosicaoXLine = 180;

            PosicaoY += 10;
            PosicaoX += 10;
            graphics.DrawString("Lista De Compra ".ToUpper(), bold, System.Drawing.Brushes.Black, PosicaoX, PosicaoY);

            PosicaoY += 18;
            graphics.DrawLine(Pens.Black, PosicaoStartXLine, PosicaoY, PosicaoXLine, PosicaoY);

            for (int i = 0; i < DgvProdutos.Rows.Count; i++)
                {
                    if (DgvProdutos.Rows[i].Cells["Listar"].Value.Equals(true))
                    {
                        string Produto = DgvProdutos.Rows[i].Cells[3].Value.ToString();
                        graphics.DrawString(Produto.Length > 55 ? Produto.Substring(0, 55) + "..." : Produto, regularItens, Brushes.Black, 4, offset);
                        offset += 11;
                    }
                }

            offset += 1;
            graphics.DrawLine(Pens.Black, PosicaoStartXLine, offset, PosicaoXLine, offset);
            offset += 1;

            //bottom
            graphics.DrawString("Data: " + DateTime.Now.ToString("dd/MM/yyyy"), regularItens, System.Drawing.Brushes.Black, 5, offset);
            offset += 10;
            graphics.DrawString("HORA: " + DateTime.Now.ToString("HH:mm:ss"), regularItens, System.Drawing.Brushes.Black, 5, offset);
            //offset += 10;

            e.HasMorePages = false;

        }


    }
}