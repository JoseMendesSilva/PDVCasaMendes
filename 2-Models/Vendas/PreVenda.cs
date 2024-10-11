using System;
using System.Collections.Generic;

namespace CasaMendes
{
    public class PreVenda : Base, IDisposable
    {
        private bool disposedValue;

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
        public string NumeroDaVenda { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true)]
        public string TipoDeVenda { get; set; } // pendura, pg, debito, crédito e pix.

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public decimal Valor { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public decimal Dinheiro { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public decimal Desconto { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public decimal Troco { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public decimal Parcela { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public decimal Tributos { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public decimal Juros { get; set; }

        //[OpcoesBase(UsarNoBancoDeDados = true)]
        //public decimal SubTotal { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = false)]
        public DateTime created_at { get; set; } = DateTime.Now;

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public DateTime updated_at { get; set; } = DateTime.Now;

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

        public new List<PreVenda> BuscaMaiorIgual()
        {
            var PreVenda = new List<PreVenda>();
            foreach (var ibase in base.BuscaMaiorIgual())
            {
                PreVenda.Add((PreVenda)ibase);
            }
            return PreVenda;
        }

        public new List<PreVenda> BuscaSqlQuery(string Sql)
        {
            var PreVenda = new List<PreVenda>();
            foreach (var ibase in base.BuscaSqlQuery(Sql))
            {
                PreVenda.Add((PreVenda)ibase);
            }
            return PreVenda;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        ~PreVenda()
        {
            // Não altere este código. Coloque o código de limpeza no método 'Dispose(bool disposing)'
            Dispose(disposing: false);
        }

        public void Dispose()
        {
            // Não altere este código. Coloque o código de limpeza no método 'Dispose(bool disposing)'
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

    }
}
