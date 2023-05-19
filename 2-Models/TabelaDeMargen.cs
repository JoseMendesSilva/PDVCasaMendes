using System;
using System.Collections.Generic;

namespace CasaMendes
{
    public class TabelaDeMargen : Base
    {
        [OpcoesBase(UsarNoBancoDeDados = true, ChavePrimaria = true, UsarParaBuscar = true)]
        public int TabelaDeMargenId { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true)]
        public int SubCategoriaId { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public int NumeroDeItensNaLoja { get; set; } = 800;

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public double PorcentagemPessoPorItem { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public double Despesa { get; set; } = 15.00;

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public double Custo { get; set; } = 5.00;

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public double Encargo { get; set; } = 15.00;

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public double MargemDeLucro { get; set; } = 20.00;

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
