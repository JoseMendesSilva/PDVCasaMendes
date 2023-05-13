using System;

namespace CasaMendes.Propriedades
{
    public class Cl_pFrenteDeCaixa : Cl_pPreVenda
    {
        public string Produto { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Desconto { get; set; }
        public decimal DescontoAplicado { get; set; }

        //--------------------------------------------
        public decimal Margem { get; set; }
        public decimal Encargos { get; set; }
        public decimal Anotar { get; set; }
        public decimal Combustivel { get; set; }

        //--------------------------------------------
        public DateTime DataLancamento { get; set; }
        public decimal Entrada { get; set; }
        public decimal SaidaAnterior { get; set; }

    }
}
