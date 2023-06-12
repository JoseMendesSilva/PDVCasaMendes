using System.Drawing.Printing;
using System.Drawing;
using System;
using System.Windows.Forms;
using System.Configuration;
using System.Collections.Generic;

namespace CasaMendes
{


    public class ImprimerListaDeCompra : PrintDocument
    {
        //List<string> lsita;
        private DataGridView DgvProdutos;
        private Font bold = new Font(FontFamily.GenericSansSerif, 9, FontStyle.Bold);
        private Font regularItens = new Font(FontFamily.GenericSansSerif, 6, FontStyle.Regular);

        //public ImprimerListaDeCompra(DataGridView DgvProduto, List<string> lsita)
        public ImprimerListaDeCompra(DataGridView DgvProduto)
        {
            this.DgvProdutos = DgvProduto;
            //this.lsita = lsita;
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
            //bool celula;
            int contar = 1;
            for (int i = 0; i < DgvProdutos.Rows.Count; i++)
            {
                if (DgvProdutos.Rows[i].Cells["Listar"].Value.Equals(true))
                {
                    string Produto = string.Concat(string.Format("{0,3:#000}", contar), " ", DgvProdutos.Rows[i].Cells[3].Value.ToString());
                    graphics.DrawString(Produto.Length > 55 ? Produto.Substring(0, 55) + "..." : Produto, regularItens, Brushes.Black, 4, offset);
                    offset += 11;
                    contar++;
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