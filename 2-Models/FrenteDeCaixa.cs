using System;

namespace CasaMendes
{
    public class FrenteDeCaixa //: Cl_pPreVenda
    {
        public int ClienteId { get; set; }
        public string Cliente { get; set; }
        public string TipoDeVenda { get; set; }
        public int NumeroDaVenda { get; set; }

        public string CodigoDeBarras { get; set; }
        public string Produto { get; set; }
        public int Quantidade { get; set; }

        public decimal Dinheiro { get; set; }
        public decimal Troco { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Desconto { get; set; }
        public decimal DescontoAplicado { get; set; }

        //--------------------------------------------
        public decimal Margem { get; set; }
        public decimal Encargo { get; set; }
        public decimal Anotar { get; set; }

        //--------------------------------------------
        public DateTime DataLancamento { get; set; }
        public decimal Entrada { get; set; }
        public decimal SaidaAnterior { get; set; }

    }
}
