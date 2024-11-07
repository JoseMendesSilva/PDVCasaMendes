using System;
using System.Configuration;
using System.Drawing;
using System.Drawing.Printing;

namespace CasaMendes
{
    public sealed class ImprimirResumoDeVendas : PrintDocument
    {
        private CaixaResumo vendasResumo;
        private Font bold = new Font(FontFamily.GenericSansSerif, 7, FontStyle.Bold);
        private Font regularItens = new Font(FontFamily.GenericSansSerif, 6, FontStyle.Regular);

        //--------------------------------------------
        private int offset = 35;
        private float PosicaoY = 4;
        private float PosicaoX = 2;
        private int StartXLine=0;
        private int EndXLine=0;
        //private bool celula;
        private int contar = 1;
        //private float largura;
        //SizeF tamanho;

        string text;

        //--------------------------------------------

        public ImprimirResumoDeVendas(CaixaResumo vendasResumo)
        {
            this.vendasResumo = vendasResumo;
            this.PrinterSettings.PrinterName = ConfigurationManager.AppSettings["PrinterName"];
            this.OriginAtMargins = false;
            this.PrintPage += new PrintPageEventHandler(printPage);
        }

        public ImprimirResumoDeVendas()
        {
            this.PrinterSettings.PrinterName = ConfigurationManager.AppSettings["PrinterName"];
            this.OriginAtMargins = false;
            this.PrintPage += new PrintPageEventHandler(printPage);
        }

        private int AreaUtilPixel(int larguraEmMilimetro)
        {
            if (larguraEmMilimetro < 1) return 0;
            var dpi = 96;
            var pol = 25.4;
            var px = (larguraEmMilimetro * dpi) / pol;
            return (px > 0) ? Convert.ToInt32(px) : 0;
        }


        private void Cabecalho(Graphics graphics)
        {
            var areaUtil = AreaUtilPixel(58);
            EndXLine = areaUtil;
            PosicaoX += 4;

            text = vendasResumo.Titulo.ToUpper();
            var px = AreaUtilPixel(text.Length);
            var x = (EndXLine - px) / 3.00F;

            graphics.DrawString(text, bold, Brushes.Black, x, PosicaoY);

            PosicaoY += 14;
            graphics.DrawLine(Pens.Black, StartXLine, offset, EndXLine, offset);

            text = vendasResumo.Descricao.ToUpper();
            px = AreaUtilPixel(text.Length);
            x = (EndXLine - px) / 4.00F;

            graphics.DrawString(text, bold, Brushes.Black, x, PosicaoY);

            PosicaoY += 14;
            graphics.DrawLine(Pens.Black, StartXLine, offset, EndXLine, offset);
        }

        private void Rodape(Graphics graphics)
        {
            // Aqui é montado o rodapé da folha
            PosicaoY += 3;
            graphics.DrawLine(Pens.Black, StartXLine, offset, EndXLine, offset);

            text = string.Concat("Usuário: ", vendasResumo.FuncionarioId);
            PosicaoY += 11;
            graphics.DrawString(text, bold, Brushes.Black, PosicaoX, PosicaoY);

            text = string.Concat("DATA: ", vendasResumo.DataHora.ToString("dd/MM/yyyy"));
            PosicaoY += 11;
            graphics.DrawString(text, bold, Brushes.Black, PosicaoX, PosicaoY);

            text = string.Concat("HORA: " + vendasResumo.DataHora.ToString("HH:mm:ss"));
            PosicaoX += (EndXLine + text.Length)/1.7F;
            graphics.DrawString(text, bold, Brushes.Black, PosicaoX, PosicaoY);

        }

        private void printPage(object send, PrintPageEventArgs e)
        {
            if(vendasResumo is null) return;
            //-------------------------------------------------------------------
            // inserindo as informações de cabeçalho do documento a ser impresso.
            Graphics graphics = e.Graphics;
            //largura = AreaUtilPixel(58);

            Cabecalho(graphics);

            //-------------------------------------------------------------------
            // inserindo as informaçoes do corpo do documento a ser impresso.
            //-------------------------------------------------------------------
            var X_Valor = PosicaoX + (EndXLine + 50) / 2.00F;
            PosicaoY += 3;
            string text = string.Concat(string.Format("{0,3:#000}", contar++), " ", "Total Caixa:");
            graphics.DrawString(text, regularItens, Brushes.Black, PosicaoX, PosicaoY);
            
            text = string.Concat(vendasResumo.TotalCaixa.ToString("C2"));
            graphics.DrawString(text, regularItens, Brushes.Black, X_Valor, PosicaoY);
           //--------------------------------------------------------------------

            PosicaoY += 11;
             text = string.Concat(string.Format("{0,3:#000}", contar++), " ", "Aberto com:");
            graphics.DrawString(text, regularItens, Brushes.Black, PosicaoX, PosicaoY);

            text = string.Concat(vendasResumo.TotalAbertoCom.ToString("C2"));
            graphics.DrawString(text, regularItens, Brushes.Black, X_Valor, PosicaoY);
            //-------------------------------------------------------------------

            PosicaoY += 11;
            text = string.Concat(string.Format("{0,3:#000}", contar++), " ", "Suprimento:");
            graphics.DrawString(text, regularItens, Brushes.Black, PosicaoX, PosicaoY);

            text = string.Concat(vendasResumo.TotalSuprimento.ToString("C2"));
            graphics.DrawString(text, regularItens, Brushes.Black, X_Valor, PosicaoY);
            //-------------------------------------------------------------------

            PosicaoY += 11;
            text = string.Concat(string.Format("{0,3:#000}", contar++), " ", "Sangria:");
            graphics.DrawString(text, regularItens, Brushes.Black, PosicaoX, PosicaoY);

            text = string.Concat(vendasResumo.TotalSangria.ToString("C2"));
            graphics.DrawString(text, regularItens, Brushes.Black, X_Valor, PosicaoY);
            //-------------------------------------------------------------------

            text = string.Concat(string.Format("{0,3:#000}", contar++), " ", "Total Desconto:");
            PosicaoY += 11;
            graphics.DrawString(text, regularItens, Brushes.Black, PosicaoX, PosicaoY);

            text = string.Concat(vendasResumo.TotalDesconto.ToString("C2"));
            graphics.DrawString(text, regularItens, Brushes.Black, X_Valor, PosicaoY);
            //-------------------------------------------------------------------

            text = string.Concat(string.Format("{0,3:#000}", contar++), " ", "Total liquido:");
            PosicaoY += 11;
            graphics.DrawString(text, regularItens, Brushes.Black, PosicaoX, PosicaoY);

            text = string.Concat(vendasResumo.TotalLiquido.ToString("C2"));
            graphics.DrawString(text, regularItens, Brushes.Black, X_Valor, PosicaoY);
            //-------------------------------------------------------------------

            //PosicaoY += 11;

            //for (int i = 0; i < 10; i++)
            //{
            //        string Produto = string.Concat(string.Format("{0,3:#000}", contar), " ", (contar+1));
            //        graphics.DrawString(Produto.Length > 55 ? Produto.Substring(0, 55) + "..." : Produto, regularItens, Brushes.Black, 4, offset);
            //        offset += 11;
            //        contar++;
            //}
            //PosicaoY = offset;
            //-------------------------------------------------------------------
            // inserindo as informaçoes do rodapé do documento a ser impresso.
            Rodape(graphics);

            e.HasMorePages = false;
        }


    }
}
