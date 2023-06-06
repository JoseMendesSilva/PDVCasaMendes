using System.Drawing.Printing;
using System.Drawing;
using System;
using System.Windows.Forms;
using System.Configuration;
using DocumentFormat.OpenXml.Drawing;

namespace CasaMendes
{


    public class ImprimeVendaVista : PrintDocument
    {
        private DataGridView DgvVendas;
        private PreVenda venda;
        private Font bold = new Font(FontFamily.GenericSansSerif, 9, FontStyle.Bold);
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

            int PosicaoStartXLine = 4;
            int PosicaoXLine = 180;

            int PosicaoXMenu = 40;

            decimal SubTotal = 0;
            decimal total = 0;

            string empresa = "Casa Mendes".ToUpper();
            string endereco = ("Viela 5" + " Nº ").ToUpper() + 39 + (", JD. Rosas").ToUpper();

            //print header
            PosicaoX += 100; //100
            PosicaoStartX = PosicaoStartXLine; //5
            graphics.DrawString(empresa, bold, Brushes.Black, 40, PosicaoStartY);

            PosicaoY = 15; //15
            PosicaoX += 195;
            graphics.DrawString(endereco, bold, Brushes.Black, PosicaoStartX, PosicaoY);

            PosicaoY += 13; //28
            graphics.DrawString("Contato:(11)95384-7483".ToUpper(), bold, Brushes.Black, PosicaoStartX, PosicaoY);

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
            graphics.DrawLine(Pens.Black, PosicaoStartXLine, PosicaoY, PosicaoXLine, PosicaoY);

            PosicaoY += 3; //59
            PosicaoX -= 210; //80
            graphics.DrawString("CUPOM NÃO FISCAL".ToUpper(), bold, Brushes.Black, 15, PosicaoY);
            //graphics.DrawString("CUPOM NÃO FISCAL".ToUpper(), bold, Brushes.Black, PosicaoStartX, PosicaoY);

            PosicaoY += 18; //77
            PosicaoX += 210;//290
            graphics.DrawLine(Pens.Black, PosicaoStartXLine, PosicaoY, PosicaoXLine, PosicaoY);

            //itens header                                          x              y
            PosicaoY += 2; //79
            //offset = offset;
            graphics.DrawString("ITEM", regular, Brushes.Black, PosicaoStartX, PosicaoY);
            graphics.DrawString("PRODUTO", regular, Brushes.Black, PosicaoXMenu, PosicaoY);
            PosicaoY += 13; //92
            graphics.DrawString("UNIT.", regular, Brushes.Black, PosicaoXMenu, PosicaoY);
            PosicaoXMenu += 45; //85 
            graphics.DrawString("QTD.", regular, Brushes.Black, PosicaoXMenu, PosicaoY);
            PosicaoXMenu += 50; //135 
            graphics.DrawString("TOTAL", regular, Brushes.Black, PosicaoXMenu, PosicaoY);
            graphics.DrawLine(Pens.Black, PosicaoStartXLine, offset, PosicaoXLine, offset);

            PosicaoY += 23; //105 ++
            PosicaoXMenu -= 95; //135 
            //itens de venda
            for (int i = 0; i < DgvVendas.Rows.Count; i++)
            {
                string Item = DgvVendas.Rows[i].Cells[0].Value.ToString();
                //string Item = string.Format("{0,4:#0000}", DgvVendas.Rows[i].Cells[0].Value);
                this.venda.Desconto = clsGlobal.DeStringParaDecimal(DgvVendas.Rows[i].Cells[3].Value.ToString());
                this.venda.Tributos = clsGlobal.DeStringParaDecimal(DgvVendas.Rows[i].Cells[4].Value.ToString());
                this.venda.Juros = clsGlobal.DeStringParaDecimal(DgvVendas.Rows[i].Cells[5].Value.ToString());
                this.venda.SubTotal = clsGlobal.DeStringParaDecimal(DgvVendas.Rows[i].Cells["ValorTotal"].Value.ToString());
                this.venda.Produto = DgvVendas.Rows[i].Cells[9].Value.ToString();
                this.venda.Quantidade = clsGlobal.DeStringParaInt(DgvVendas.Rows[i].Cells[10].Value.ToString());
                this.venda.PrecoDeVenda = clsGlobal.DeStringParaDecimal(DgvVendas.Rows[i].Cells[11].Value.ToString());
                this.venda.Valor = clsGlobal.DeStringParaDecimal(DgvVendas.Rows[i].Cells[12].Value.ToString());

                PosicaoXMenu = 40; //40 
                graphics.DrawString(Item.ToString(), regularItens, Brushes.Black, PosicaoStartX, offset);
                graphics.DrawString(venda.Produto.Length > 20 ? venda.Produto.Substring(0, 20) + "..." : venda.Produto, regularItens, Brushes.Black, PosicaoXMenu, offset);
                graphics.DrawString(venda.PrecoDeVenda.ToString(), regularItens, Brushes.Black, PosicaoXMenu, PosicaoY);
                PosicaoXMenu = 90; //85 
                graphics.DrawString(venda.Quantidade.ToString(), regularItens, Brushes.Black, PosicaoXMenu, PosicaoY);
                PosicaoXMenu = 140; //120 
                graphics.DrawString(venda.Valor.ToString("N2"), regularItens, Brushes.Black, PosicaoXMenu, PosicaoY);
                offset += 20;
                PosicaoY = offset + 10; //105 ++ 78400924
                SubTotal += this.venda.Valor;

            }

            offset += 1;
            //total
            graphics.DrawLine(Pens.Black, PosicaoStartXLine, offset, PosicaoXLine, offset);
            offset += 5;
            PosicaoX -= 155; //135

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
                offset += 16;

                graphics.DrawString("PARCELA R$: ", regular, Brushes.Black, PosicaoStartX, offset);
                graphics.DrawString(this.venda.Parcela.ToString("N2"), regular, Brushes.Black, PosicaoX, offset);
                offset += 16;

            }

            graphics.DrawString("TOTAL R$: ", regular, Brushes.Black, PosicaoStartX, offset);
            graphics.DrawString(total.ToString("N2"), regular, Brushes.Black, PosicaoX, offset);
            offset += 15;

            graphics.DrawLine(Pens.Black, PosicaoStartXLine, offset, PosicaoXLine, offset);
            offset += 1;

            graphics.DrawString("Cliente: ", regular, Brushes.Black, PosicaoStartX, offset);
            graphics.DrawString(this.venda.ClienteId.ToString(), regular, Brushes.Black, PosicaoX, offset);
            offset += 15;

            PosicaoX -= 15; //290
            graphics.DrawString("Venda: ", regular, Brushes.Black, PosicaoStartX, offset);
            graphics.DrawString(this.venda.TipoDeVenda, regular, Brushes.Black, PosicaoX, offset);
            offset += 13;

            graphics.DrawLine(Pens.Black, PosicaoStartXLine, offset, PosicaoXLine, offset);
            PosicaoX -= 7;//220

            ////bottom
            graphics.DrawString("Data: " + DateTime.Now.ToString("dd/MM/yyyy"), regularItens, Brushes.Black, PosicaoStartX, offset);
            graphics.DrawString("HORA: " + DateTime.Now.ToString("HH:mm:ss"), regularItens, Brushes.Black, PosicaoX, offset);
            offset += 10;

            graphics.DrawLine(Pens.Black, PosicaoStartXLine, offset, PosicaoXLine, offset);
            graphics.DrawString("", regularItens, Brushes.Black, PosicaoStartX, offset);
            offset += 5;
            graphics.DrawString("TROCA: ", regularItens, Brushes.Black, PosicaoStartX, offset);
            offset += 10;
            graphics.DrawString("COM DATA DE VALIDADE VENCIDA.", regularItens, Brushes.Black, PosicaoStartX, offset);
            offset += 15;
            graphics.DrawString("DEVOLUÇÕES: ", regularItens, Brushes.Black, PosicaoStartX, offset);
            offset += 10;
            graphics.DrawString("NÃO ECEITAMOS DEVOLUÇÕES.", regularItens, Brushes.Black, PosicaoStartX, offset);

            e.HasMorePages = false;

        }


    }
}