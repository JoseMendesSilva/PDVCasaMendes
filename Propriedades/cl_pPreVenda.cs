using System;

namespace CasaMendes.Propriedades
{
    public class Cl_pPreVenda : cl_pBase
    {
        public decimal CodigoDaVenda { get; set; }
        public decimal CodigoDoCliente { get; set; }
        public decimal CodigoDeBarras { get; set; }
        public decimal NumeroDaVenda { get; set; }
        public decimal Quantidade { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataDaVenda { get; set; }
        public string TipoDeVenda { get; set; }
        public bool StatusDaVenda { get; set; }
        public decimal Dinheiro { get; set; }
        public decimal Troco { get; set; }
        public decimal Parcela { get; set; }
        public decimal Lucro { get; set; }
    }
}
