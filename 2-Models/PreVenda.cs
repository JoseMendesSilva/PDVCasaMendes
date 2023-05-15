using System;
using System.Collections.Generic;

namespace CasaMendes.Propriedades
{
    public class PreVenda : Base
    {

        [OpcoesBase(UsarNoBancoDeDados = true, ChavePrimaria = true, UsarParaBuscar = true, AutoGenerantor = true)]
        public int PreVendaId { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true)]
        public int ClienteId { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true)]
        public string CodigoDeBarras { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true)]
        public int NumeroDaVenda { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public int Quantidade { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true)]
        public string TipoDeVenda { get; set; } // pendura, pg, debito, crédito e pix.

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public double Valor { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public double Dinheiro { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public double Troco { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public double Parcela { get; set; }

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
