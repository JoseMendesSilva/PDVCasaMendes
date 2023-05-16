using System;
using System.Collections.Generic;

namespace CasaMendes
{
    public class PreVenda : Base
    {

        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true, ChavePrimaria = true)]
        public int PreVendaId { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true)]
        public int ClienteId { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string Produto { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public int Quantidade { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public decimal PrecoDeVenda { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true)]
        public int NumeroDaVenda { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true)]
        public string TipoDeVenda { get; set; } // pendura, pg, debito, crédito e pix.

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public decimal Valor { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public decimal Dinheiro { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public decimal Troco { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public decimal Parcela { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true)]
        public DateTime created_at { get; set; } = DateTime.Parse(DateTime.Now.ToShortDateString());

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public DateTime updated_at { get; set; } = DateTime.Parse(DateTime.Now.ToShortDateString());

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

        bool disposed = false;
        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        // Protected implementation of Dispose pattern.
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                this.Dispose();
                // Free any other managed objects here.
                //
            }

            disposed = true;
        }


    }
}
