using System.Drawing.Printing;
using System.Drawing;
using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;

namespace CasaMendes
{


    public class ImprimeVendaVista : PrintDocument
    {
        private List<ItensCarrinho> ItensCarrinho;
        private Font bold = new Font(FontFamily.GenericSansSerif, 9, FontStyle.Bold);
        private Font regular = new Font(FontFamily.GenericSansSerif, 7, FontStyle.Regular);
        private Font regularItens = new Font(FontFamily.GenericSansSerif, 6, FontStyle.Regular);

        public ImprimeVendaVista(List<ItensCarrinho> itensCarrinho)
        {
            this.ItensCarrinho = itensCarrinho;
            this.PrinterSettings.PrinterName = ConfigurationManager.AppSettings["PrinterName"];
            this.OriginAtMargins = false;
            this.PrintPage += new PrintPageEventHandler(printPage);
        }

        private void printPage(object send, PrintPageEventArgs e)
        {
            //Graphics graphics = e.Graphics;
            //int offset = 105;

            //int PosicaoStartX = 0;
            //int PosicaoStartY = 0;
            //int PosicaoX = 0;
            //int PosicaoY = 0;

            //int PosicaoStartXLine = 4;
            //int PosicaoXLine = 180;

            //int PosicaoXMenu = 40;

            ////decimal SubTotal = 0;
            ////decimal total = 0;

            //string empresa = "Casa Mendes".ToUpper();
            //string endereco = ("Viela 5" + " Nº ").ToUpper() + 39 + (", JD. Rosas").ToUpper();

            ////print header
            //PosicaoX += 100; //100
            //PosicaoStartX = PosicaoStartXLine; //5
            //graphics.DrawString(empresa, bold, Brushes.Black, 40, PosicaoStartY);

            //PosicaoY = 15; //15
            //PosicaoX += 195;
            //graphics.DrawString(endereco, bold, Brushes.Black, PosicaoStartX, PosicaoY);

            //PosicaoY += 13; //28
            //graphics.DrawString("Contato:(11)95384-7483".ToUpper(), bold, Brushes.Black, PosicaoStartX, PosicaoY);

            //PosicaoY += 14; //42
            //    graphics.DrawString("PEDIDO: " + this.ItensCarrinho[0].NumeroPedido, bold, Brushes.Black, PosicaoStartX, PosicaoY);
            
            //PosicaoY += 14; //56
            //PosicaoX -= 5;
            //graphics.DrawLine(Pens.Black, PosicaoStartXLine, PosicaoY, PosicaoXLine, PosicaoY);

            //PosicaoY += 3; //59
            //PosicaoX -= 210; //80
            //graphics.DrawString("CUPOM NÃO FISCAL".ToUpper(), bold, Brushes.Black, 15, PosicaoY);
            ////graphics.DrawString("CUPOM NÃO FISCAL".ToUpper(), bold, Brushes.Black, PosicaoStartX, PosicaoY);

            //PosicaoY += 18; //77
            //PosicaoX += 210;//290
            //graphics.DrawLine(Pens.Black, PosicaoStartXLine, PosicaoY, PosicaoXLine, PosicaoY);

            ////itens header                                          x              y
            //PosicaoY += 2; //79
            ////offset = offset;
            //graphics.DrawString("ITEM", regular, Brushes.Black, PosicaoStartX, PosicaoY);
            //graphics.DrawString("PRODUTO", regular, Brushes.Black, PosicaoXMenu, PosicaoY);
            //PosicaoY += 13; //92
            //graphics.DrawString("UNIT.", regular, Brushes.Black, PosicaoXMenu, PosicaoY);
            //PosicaoXMenu += 45; //85 
            //graphics.DrawString("QTD.", regular, Brushes.Black, PosicaoXMenu, PosicaoY);
            //PosicaoXMenu += 50; //135 
            //graphics.DrawString("TOTAL", regular, Brushes.Black, PosicaoXMenu, PosicaoY);
            //graphics.DrawLine(Pens.Black, PosicaoStartXLine, offset, PosicaoXLine, offset);

            //var count = 1;
            //PosicaoY += 23; //105 ++
            //PosicaoXMenu -= 95; //135 
            ////itens de venda
            //foreach (var item in ItensCarrinho)
            //{
            //    PosicaoXMenu = 40; //40 
            //    graphics.DrawString(string.Format("{0,4:#0000}", count++), regularItens, Brushes.Black, PosicaoStartX, offset);
            //    graphics.DrawString(item.Produto.Length > 20 ? item.Produto.Substring(0, 20) + "..." : item.Produto, regularItens, Brushes.Black, PosicaoXMenu, offset);
            //    graphics.DrawString(item.PrecoUnitario.ToString(), regularItens, Brushes.Black, PosicaoXMenu, PosicaoY);
            //    PosicaoXMenu = 90; //85 
            //    graphics.DrawString(item.Quantidade.ToString(), regularItens, Brushes.Black, PosicaoXMenu, PosicaoY);
            //    PosicaoXMenu = 140; //120 
            //    graphics.DrawString((item.Quantidade * item.PrecoUnitario).ToString("N2"), regularItens, Brushes.Black, PosicaoXMenu, PosicaoY);
            //    offset += 20;
            //    PosicaoY = offset + 10; //105 ++ 78400924
            //    //SubTotal += item.SubTotal;

            //}

            //offset += 1;
            ////total
            //graphics.DrawLine(Pens.Black, PosicaoStartXLine, offset, PosicaoXLine, offset);
            //offset += 5;
            //PosicaoX -= 155; //135

            //graphics.DrawString("SUBTOTAL R$: ", regular, Brushes.Black, PosicaoStartX, offset);
            //graphics.DrawString(ItensCarrinho.Sum(st => st.SubTotal).ToString("N2"), regular, Brushes.Black, PosicaoX, offset + 5);
            //offset += 16;

            //graphics.DrawString("DESCONTO R$: ", regular, Brushes.Black, PosicaoStartX, offset);
            //graphics.DrawString("0.00".ToString(), regular, Brushes.Black, PosicaoX, offset);
            //offset += 16;

            ////total = SubTotal - this.venda.Desconto;
            ////if (this.venda.TipoDeVenda == "PENDURA") //se for pendura, então calcula e apresenta o acréscimo.
            ////{
            ////    graphics.DrawString("TRIBUTOS R$: ", regular, Brushes.Black, PosicaoStartX, offset);
            ////    graphics.DrawString(this.venda.Tributos.ToString("N2"), regular, Brushes.Black, PosicaoX, offset);
            ////    offset += 16;

            ////    graphics.DrawString("JUROS R$: ", regular, Brushes.Black, PosicaoStartX, offset);
            ////    graphics.DrawString(this.venda.Juros.ToString("N2"), regular, Brushes.Black, PosicaoX, offset);
            ////    offset += 16;

            ////    graphics.DrawString("PARCELA R$: ", regular, Brushes.Black, PosicaoStartX, offset);
            ////    graphics.DrawString(this.venda.Parcela.ToString("N2"), regular, Brushes.Black, PosicaoX, offset);
            ////    offset += 16;

            ////}


            ////graphics.DrawString("TOTAL R$: ", regular, Brushes.Black, PosicaoStartX, offset);
            ////graphics.DrawString(total.ToString("N2"), regular, Brushes.Black, PosicaoX, offset);
            ////offset += 15;
            ////graphics.DrawLine(Pens.Black, PosicaoStartXLine, offset, PosicaoXLine, offset);
            ////offset += 1;

            ////graphics.DrawString("Cliente: ", regular, Brushes.Black, PosicaoStartX, offset);
            ////graphics.DrawString(this.venda.ClienteId.ToString(), regular, Brushes.Black, PosicaoX, offset);
            ////offset += 15;

            ////PosicaoX -= 15; //290
            ////graphics.DrawString("Venda: ", regular, Brushes.Black, PosicaoStartX, offset);
            ////graphics.DrawString(this.venda.TipoDeVenda, regular, Brushes.Black, PosicaoX, offset);
            ////offset += 15;

            ////PosicaoX += 15;
            ////graphics.DrawString("Troco: R$ ", regular, Brushes.Black, PosicaoStartX, offset);
            ////graphics.DrawString(this.venda.Troco.ToString(), regular, Brushes.Black, PosicaoX, offset);
            ////offset += 13;

            ////graphics.DrawLine(Pens.Black, PosicaoStartXLine, offset, PosicaoXLine, offset);
            ////PosicaoX -= 30;//220

            //////bottom
            //graphics.DrawString("Data: " + DateTime.Now.ToString("dd/MM/yyyy"), regular, Brushes.Black, PosicaoStartX, offset);
            //graphics.DrawString("HORA: " + DateTime.Now.ToString("HH:mm:ss"), regular, Brushes.Black, PosicaoX - 30, offset);
            //offset += 10;

            //graphics.DrawLine(Pens.Black, PosicaoStartXLine, offset, PosicaoXLine, offset);
            //graphics.DrawString("", regular, Brushes.Black, PosicaoStartX, offset);
            //offset += 5;
            //graphics.DrawString("TROCA: ", regular, Brushes.Black, PosicaoStartX, offset);
            //offset += 10;
            //graphics.DrawString("COM DATA DE VALIDADE VENCIDA.", regular, Brushes.Black, PosicaoStartX, offset);
            //offset += 15;
            //graphics.DrawString("DEVOLUÇÕES: ", regular, Brushes.Black, PosicaoStartX, offset);
            //offset += 10;
            //graphics.DrawString("NÃO ECEITAMOS DEVOLUÇÕES.", regular, Brushes.Black, PosicaoStartX, offset);
            //offset += 10;

            //graphics.DrawLine(Pens.Black, PosicaoStartXLine, offset + 6, PosicaoXLine, offset + 6);
            //graphics.DrawString("Volte sempre!".ToUpper(), regular, Brushes.Black, 40, offset);

            //e.HasMorePages = false;

        }


    }
}