using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CasaMendes.Classes.Estatica
{
    public class ClsItensPromocao
    {
        /*
         * Write the produto
         * Código de barras
         * Quantidade minima a ser aplicado o desconto
         * Valor de dsconto
         */

        public ClsItensPromocao()
        {

        }

        private decimal sQuantidade;
        public decimal QuantidadeMinimaParaDesconto
        {
            get { return sQuantidade; }
            set { sQuantidade = value; }
        }

        private decimal sValor;
        public decimal ValorDesconto
        {
            get { return sValor; }
            set { sValor = value; }
        }

    }
}
