using System;
using System.Collections.Generic;

namespace CasaMendes.Propriedades
{
    public class PreVenda : Base
    {

        [OpcoesBase(UsarNoBancoDeDados = true, ChavePrimaria = true, AutoGenerantor = true, UsarParaBuscar = true)]
        public decimal CodigoDaVenda { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public decimal CodigoDoCliente { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public decimal CodigoDeBarras { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public decimal NumeroDaVenda { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public decimal Quantidade { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public decimal Valor { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string TipoDeVenda { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public bool StatusDaVenda { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public decimal Dinheiro { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public decimal Troco { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public decimal Parcela { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public decimal Lucro { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public DateTime created_at { get; set; } = DateTime.Now;

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public DateTime updated_at { get; set; } = DateTime.Now;

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public DateTime? deleted_at { get; set; } = null;

        public new List<PreVenda> Todos()
        {
            var PreVenda = new List<PreVenda>();
            foreach (var ibase in base.Todos())
            {
                PreVenda.Add((PreVenda)ibase);
            }
            return PreVenda;
        }

        public new List<PreVenda> Busca()
        {
            var PreVenda = new List<PreVenda>();
            foreach (var ibase in base.Busca())
            {
                PreVenda.Add((PreVenda)ibase);
            }
            return PreVenda;
        }

    }
}
