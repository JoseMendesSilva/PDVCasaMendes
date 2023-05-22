using System;
using System.Collections.Generic;

namespace CasaMendes
{
    public class TabelaDeMargen : Base, IDisposable
    {

        private double _PorcentagemPessoPorItem;
        private bool disposedValue;

        public TabelaDeMargen()
        {
            this.Porcentagem();
        }

        public TabelaDeMargen(int tabelaDeMargenId, int subCategoriaId, int numeroDeItensNaLoja, double valorDeBase, double porcentagemPesoPorItem, double despesa, double custo, double encargo, double margemDeLucro)
        {
            TabelaDeMargenId = tabelaDeMargenId;
            SubCategoriaId = subCategoriaId;
            NumeroDeItensNaLoja = numeroDeItensNaLoja;
            ValorDeBase = valorDeBase;
            PorcentagemPesoPorItem = porcentagemPesoPorItem;
            Despesa = despesa;
            Custo = custo;
            Encargo = encargo;
            MargemDeLucro = margemDeLucro;
        }

        private double Porcentagem()
        {
            return _PorcentagemPessoPorItem = ValorDeBase / NumeroDeItensNaLoja;
        }

        [OpcoesBase(UsarNoBancoDeDados = true, ChavePrimaria = true, UsarParaBuscar = true)]
        public int TabelaDeMargenId { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true)]
        public int SubCategoriaId { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public int NumeroDeItensNaLoja { get; set; } = 28;

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public double ValorDeBase { get; set; } = 395.73;

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public double PorcentagemPesoPorItem { 
            get { 
                return _PorcentagemPessoPorItem;
            } 
            set { _PorcentagemPessoPorItem = value;} 
        }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public double Despesa { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public double Custo { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public double Encargo { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public double MargemDeLucro { get; set; }

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

        //bool disposed = false;
        //public void Dispose()
        //{
        //    Dispose(disposing: true);
        //    GC.SuppressFinalize(this);
        //}

        //// Protected implementation of Dispose pattern.
        //protected virtual void Dispose(bool disposing)
        //{
        //    if (disposed)
        //        return;

        //    if (disposing)
        //    {
        //        this.Dispose();
        //        // Free any other managed objects here.
        //        //
        //    }

        //    disposed = true;
        //}

    }
}
