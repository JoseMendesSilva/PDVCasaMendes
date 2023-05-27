using System.Drawing.Printing;
using System.Drawing;
using System;
using System.Windows.Forms;

namespace CasaMendes
{


    public class ImprimeVendaVista : PrintDocument
    {
        private const double V = 123.00D;
        private string empresa = "Casa Mendes";
        private DataGridView DgvVendas;
        private PreVenda venda= new PreVenda();
        private Font bold = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);
        private Font regular = new Font(FontFamily.GenericSansSerif, 8, FontStyle.Regular);
        private Font regularItens = new Font(FontFamily.GenericSansSerif, 6, FontStyle.Regular);

        public ImprimeVendaVista(DataGridView dataGridView)
        {
            this.DgvVendas = dataGridView;
            this.PrinterSettings.PrinterName = "Microsoft Print to PDF";
            this.PrinterSettings.PrintFileName = "Venda N: " + DateTime.Now.ToString();
            this.OriginAtMargins = false;
            this.PrintPage += new PrintPageEventHandler(printPage);
        }

        private void printPage(object send, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            int offset = 105;

            //print header
            graphics.DrawString(empresa, bold, Brushes.Black, 20, 0);
            graphics.DrawString(("Viela 5" + " Nº ").ToUpper() + 39, regular, Brushes.Black, 20, 15);
            graphics.DrawLine(Pens.Black, 20, 30, 300, 30);
            graphics.DrawString("CUPOM NÃO FISCAL", bold, Brushes.Black, 80, 35);
            graphics.DrawLine(Pens.Black, 20, 50, 300, 50);
            graphics.DrawString("PEDIDO: " + 1, regular, Brushes.Black, 20, 60);
            graphics.DrawLine(Pens.Black, 20, 75, 300, 75);

            ////print header
            //graphics.DrawString(empresa, bold, Brushes.Black, 20, 0);
            //graphics.DrawString(("endereco" + " Nº ").ToUpper() + 1, regular, Brushes.Black, 20, 15);
            //graphics.DrawLine(Pens.Black, 20, 30, 310, 30);
            //graphics.DrawString("CUPOM NÃO FISCAL", bold, Brushes.Black, 80, 35);
            //graphics.DrawLine(Pens.Black, 20, 50, 310, 50);
            //graphics.DrawString("PEDIDO: " + 1, regular, Brushes.Black, 20, 60);
            //graphics.DrawLine(Pens.Black, 20, 75, 310, 75);

            //itens header
            graphics.DrawString("PRODUTO", regular, Brushes.Black, 20, 80);
            graphics.DrawString("UNIT.", regular, Brushes.Black, 150, 80);
            graphics.DrawString("QTD.", regular, Brushes.Black, 200, 80);
            graphics.DrawString("TOTAL", regular, Brushes.Black, 245, 80);
            graphics.DrawLine(Pens.Black, 20, 95, 310, 95);

            this.venda = new PreVenda();
            decimal total = 0;

            //itens de venda
            for (int i = 0; i < DgvVendas.Rows.Count; i++)
            {
                this.venda.Produto = DgvVendas.Rows[i].Cells[5].Value.ToString();
                this.venda.PrecoDeVenda = decimal.Parse(DgvVendas.Rows[i].Cells[7].Value.ToString());
                this.venda.Quantidade = int.Parse(DgvVendas.Rows[i].Cells[6].Value.ToString());
                this.venda.Valor = decimal.Parse(DgvVendas.Rows[i].Cells[8].Value.ToString());
                //string produto = "iv.produto.descricao";
                graphics.DrawString(venda.Produto.Length > 20 ? venda.Produto.Substring(0, 20) + "..." : venda.Produto, regularItens, Brushes.Black, 20, offset);
                graphics.DrawString(venda.PrecoDeVenda.ToString(), regularItens, Brushes.Black, 155, offset);
                graphics.DrawString(venda.Quantidade.ToString(), regularItens, Brushes.Black, 215, offset);
                graphics.DrawString(venda.Valor.ToString(), regularItens, Brushes.Black, 250, offset);
                offset += 20;
                 total += this.venda.Valor;

            }

            //total
            graphics.DrawLine(Pens.Black, 20, offset, 310, offset);
            offset += 5;

            graphics.DrawString("TOTAL R$: ", bold, Brushes.Black, 20, offset);
            graphics.DrawString(total.ToString(), bold, Brushes.Black, 245, offset);
            offset += 15;

            graphics.DrawLine(Pens.Black, 20, offset, 310, offset);
            offset += 5;

            //bottom
            graphics.DrawString("Data: " + DateTime.Now.ToString("dd/MM/yyyy"), regularItens, Brushes.Black, 20, offset);
            graphics.DrawString("HORA: " + DateTime.Now.ToString("HH:mm:ss"), regularItens, Brushes.Black, 220, offset);

            e.HasMorePages = false;

        }


    }
}