using System.Drawing.Printing;
using System.Drawing;
using System;
using System.Windows.Forms;
using System.Configuration;

namespace CasaMendes
{


    public class ImprimeVendaVista : PrintDocument
    {
        private DataGridView DgvVendas;
        private PreVenda venda;
        private Font bold = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);
        private Font regular = new Font(FontFamily.GenericSansSerif, 8, FontStyle.Regular);
        private Font regularItens = new Font(FontFamily.GenericSansSerif, 6, FontStyle.Regular);

        public ImprimeVendaVista(DataGridView dataGridView, PreVenda vendas)
        {
            this.DgvVendas = dataGridView;
            this.venda = vendas;
            this.PrinterSettings.PrinterName = ConfigurationManager.AppSettings["PrinterName"];
            this.OriginAtMargins = false;
            this.PrintPage += new PrintPageEventHandler(printPage);
        }

        private void printPage(object send, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            int offset = 105;

            int PosicaoStartX = 0;
            int PosicaoStartY = 0;
            int PosicaoX = 0;
            int PosicaoY = 0;

            decimal SubTotal = 0;
            decimal total = 0;

            string empresa = "Casa Mendes".ToUpper();
            string endereco = ("Viela 5" + " Nº ").ToUpper() + 39 + (", JD. Rosas - Francisco Morato").ToUpper();

            //print header
            PosicaoX += 100; //100
            PosicaoStartX += 10; //10
            graphics.DrawString(empresa, bold, Brushes.Black, PosicaoX, PosicaoStartY);

            PosicaoY = 15; //15
            PosicaoX += 195;
            graphics.DrawString(endereco, bold, Brushes.Black, PosicaoStartX, PosicaoY);

            PosicaoY += 13; //28
            graphics.DrawString("Contato: (11) 95384-7483".ToUpper(), bold, Brushes.Black, PosicaoStartX, PosicaoY);

            PosicaoY += 14; //42
            if (DgvVendas.Rows.Count > 0)
            {
                this.venda.NumeroDaVenda = DgvVendas.Rows[0].Cells[1].Value.ToString();
                graphics.DrawString("PEDIDO: " + this.venda.NumeroDaVenda, bold, Brushes.Black, PosicaoStartX, PosicaoY);
            }
            else
            {
                graphics.DrawString("PEDIDO: " + 1, bold, Brushes.Black, PosicaoStartX, PosicaoY);
            }

            PosicaoY += 14; //56
            PosicaoX -= 5;
            graphics.DrawLine(Pens.Black, PosicaoStartX, PosicaoY, PosicaoX, PosicaoY);

            PosicaoY += 3; //59
            PosicaoX -= 210; //80
            graphics.DrawString("CUPOM NÃO FISCAL".ToUpper(), bold, Brushes.Black, PosicaoX, PosicaoY);

            PosicaoY += 18; //67
            PosicaoX += 210;//290
            graphics.DrawLine(Pens.Black, PosicaoStartX, PosicaoY, PosicaoX, PosicaoY);

            //itens header                                          x              y
            PosicaoY += 2; //75
            //offset = offset;
            graphics.DrawString("ITEM", regular, Brushes.Black, PosicaoStartX, PosicaoY);
            graphics.DrawString("PRODUTO", regular, Brushes.Black, 40, PosicaoY);
            graphics.DrawString("UNIT.", regular, Brushes.Black, 170, PosicaoY);
            graphics.DrawString("QTD.", regular, Brushes.Black, 210, PosicaoY);
            graphics.DrawString("TOTAL", regular, Brushes.Black, 250, PosicaoY);
            graphics.DrawLine(Pens.Black, PosicaoStartX, offset, PosicaoX, offset);


            //itens de venda
            for (int i = 0; i < DgvVendas.Rows.Count; i++)
            {
                    this.venda.Desconto = clsGlobal.DeStringParaDecimal(DgvVendas.Rows[i].Cells[3].Value.ToString());
                    this.venda.Tributos = clsGlobal.DeStringParaDecimal(DgvVendas.Rows[i].Cells[4].Value.ToString());
                       this.venda.Juros = clsGlobal.DeStringParaDecimal(DgvVendas.Rows[i].Cells[5].Value.ToString());
                this.venda.TotalPendura = clsGlobal.DeStringParaDecimal(DgvVendas.Rows[i].Cells[6].Value.ToString());
                            string Item = DgvVendas.Rows[i].Cells[7].Value.ToString();
                     this.venda.Produto = DgvVendas.Rows[i].Cells[9].Value.ToString();
                  this.venda.Quantidade = clsGlobal.DeStringParaInt(DgvVendas.Rows[i].Cells[10].Value.ToString());
                this.venda.PrecoDeVenda = clsGlobal.DeStringParaDecimal(DgvVendas.Rows[i].Cells[11].Value.ToString());
                       this.venda.Valor = clsGlobal.DeStringParaDecimal(DgvVendas.Rows[i].Cells[12].Value.ToString());

                graphics.DrawString(Item.ToString(), regularItens, Brushes.Black, PosicaoStartX, offset);
                graphics.DrawString(venda.Produto.Length > 20 ? venda.Produto.Substring(0, 20) + "..." : venda.Produto, regularItens, Brushes.Black, 40, offset);
                graphics.DrawString(venda.PrecoDeVenda.ToString(), regularItens, Brushes.Black, 175, offset);
                graphics.DrawString(venda.Quantidade.ToString(), regularItens, Brushes.Black, 215, offset);
                graphics.DrawString(venda.Valor.ToString(), regularItens, Brushes.Black, 250, offset);
                offset += PosicaoStartX;
                SubTotal += this.venda.Valor;

            }

            offset += 1;
            //total
            graphics.DrawLine(Pens.Black, PosicaoStartX, offset, PosicaoX, offset);
            offset += 5;
            PosicaoX -= 65; //225

            graphics.DrawString("SUBTOTAL R$: ", regular, Brushes.Black, PosicaoStartX, offset);
            graphics.DrawString(SubTotal.ToString("N2"), regular, Brushes.Black, PosicaoX, offset);
            offset += 16;

            graphics.DrawString("DESCONTO R$: ", regular, Brushes.Black, PosicaoStartX, offset);
            graphics.DrawString(this.venda.Desconto.ToString("N2"), regular, Brushes.Black, PosicaoX, offset);
            offset += 16;

            total = SubTotal - this.venda.Desconto;
            if (this.venda.TipoDeVenda == "PENDURA") //se for pendura, então calcula e apresenta o acréscimo.
            {
                graphics.DrawString("TRIBUTOS R$: ", regular, Brushes.Black, PosicaoStartX, offset);
                graphics.DrawString(this.venda.Tributos.ToString("N2"), regular, Brushes.Black, PosicaoX, offset);
                offset += 16;

                graphics.DrawString("JUROS R$: ", regular, Brushes.Black, PosicaoStartX, offset);
                graphics.DrawString(this.venda.Juros.ToString("N2"), regular, Brushes.Black, PosicaoX, offset);
                total = this.venda.TotalPendura;
                offset += 16;

            }
                graphics.DrawString("TOTAL R$: ", regular, Brushes.Black, PosicaoStartX, offset);
                graphics.DrawString(total.ToString("N2"), regular, Brushes.Black, PosicaoX, offset);
                offset += 15;
            PosicaoX += 65; //290

            graphics.DrawLine(Pens.Black, PosicaoStartX, offset, PosicaoX, offset);
            offset += 1;
            PosicaoX -= 240;//50

            graphics.DrawString("Cliente: ", regular, Brushes.Black, PosicaoStartX, offset);
            graphics.DrawString(this.venda.ClienteId.ToString(), regular, Brushes.Black, PosicaoStartX + PosicaoX, offset);
            offset += 15;

            graphics.DrawString("Venda: ", regular, Brushes.Black, PosicaoStartX, offset);
            graphics.DrawString(this.venda.TipoDeVenda, regular, Brushes.Black, PosicaoStartX + PosicaoX, offset);
            offset += 13;
            PosicaoX += 240; //290

            graphics.DrawLine(Pens.Black, PosicaoStartX, offset, PosicaoX, offset);
            offset += 5;
            PosicaoX -= 70;//220

            ////bottom
            graphics.DrawString("Data: " + DateTime.Now.ToString("dd/MM/yyyy"), regularItens, Brushes.Black, PosicaoStartX, offset);
            graphics.DrawString("HORA: " + DateTime.Now.ToString("HH:mm:ss"), regularItens, Brushes.Black, PosicaoX, offset);

            e.HasMorePages = false;

        }


    }
}