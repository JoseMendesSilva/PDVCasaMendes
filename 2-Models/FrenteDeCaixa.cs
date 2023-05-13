using System;
using System.Collections.Generic;

namespace CasaMendes
{
    public class FrenteDeCaixa : Base
    {

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string Produto { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public decimal SubTotal { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public decimal Desconto { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public decimal DescontoAplicado { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public decimal Margem { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public decimal Encargos { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public decimal Anotar { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public decimal Combustivel { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public DateTime DataLancamento { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public decimal Entrada { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public decimal SaidaAnterior { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public DateTime created_at { get; set; } = DateTime.Now;

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public DateTime updated_at { get; set; } = DateTime.Now;

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public DateTime? deleted_at { get; set; } = null;

        public new List<FrenteDeCaixa> Todos()
        {
            var frenteDeCaixa = new List<FrenteDeCaixa>();
            foreach (var ibase in base.Todos())
            {
                frenteDeCaixa.Add((FrenteDeCaixa)ibase);
            }
            return frenteDeCaixa;
        }

        public new List<FrenteDeCaixa> Busca()
        {
            var frenteDeCaixa = new List<FrenteDeCaixa>();
            foreach (var ibase in base.Busca())
            {
                frenteDeCaixa.Add((FrenteDeCaixa)ibase);
            }
            return frenteDeCaixa;
        }

    }
}
