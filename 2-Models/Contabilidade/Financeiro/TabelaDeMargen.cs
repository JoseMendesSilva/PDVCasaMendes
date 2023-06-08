using DocumentFormat.OpenXml.Drawing;
using System;
using System.Collections.Generic;

namespace CasaMendes
{
    public class TabelaDeMargen : Base, IDisposable
    {

        private bool disposedValue;

        private decimal Porcentagem()
        {
            if (ValorDeBase <= 0 || NumeroDeItensNaLoja <= 0) return 0;
            return ValorDeBase / NumeroDeItensNaLoja;
        }

        [OpcoesBase(UsarNoBancoDeDados = true, ChavePrimaria = true, UsarParaBuscar = true)]
        public int TabelaDeMargenId { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true)]
        public int SubCategoriaId { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public int NumeroDeItensNaLoja { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public decimal ValorDeBase { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public decimal PorcentagemPesoPorItem
        {
            get
            {
                return Porcentagem();
            }
            set{ }
        }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public decimal Despesa { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public decimal Custo { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public decimal Encargo { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public decimal MargemDeLucro { get; set; }

        public new List<TabelaDeMargen> Todos()
        {
            var oTabelaDeMargen = new List<TabelaDeMargen>();
            foreach (var ibase in base.Todos())
            {
                oTabelaDeMargen.Add((TabelaDeMargen)ibase);
            }
            return oTabelaDeMargen;
        }

        public new List<TabelaDeMargen> Busca()
        {
            var oTabelaDeMargen = new List<TabelaDeMargen>();
            foreach (var ibase in base.Busca())
            {
                oTabelaDeMargen.Add((TabelaDeMargen)ibase);
            }
            return oTabelaDeMargen;
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
        ~TabelaDeMargen()
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
