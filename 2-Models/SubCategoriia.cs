using System;
using System.Collections.Generic;

namespace CasaMendes
{
    public class SubCategoriia : Base
    {
        [OpcoesBase(UsarNoBancoDeDados = true, ChavePrimaria = true, UsarParaBuscar = true)]
        public int SubCategoriiaId { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true)]
        public int CategoriaId { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true)]
        public string Nome { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string Descricao { get; set; }

        public new List<SubCategoriia> Todos()
        {
            var subCategoriia = new List<SubCategoriia>();
            foreach (var ibase in base.Todos())
            {
                subCategoriia.Add((SubCategoriia)ibase);
            }
            return subCategoriia;
        }

        public new List<SubCategoriia> Busca()
        {
            var subCategoriia = new List<SubCategoriia>();
            foreach (var ibase in base.Busca())
            {
                subCategoriia.Add((SubCategoriia)ibase);
            }
            return subCategoriia;
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
