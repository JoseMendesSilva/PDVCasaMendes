using System;
using System.Collections.Generic;

namespace CasaMendes
{
    public class SubCategoria : Base
    {
        [OpcoesBase(UsarNoBancoDeDados = true, ChavePrimaria = true, UsarParaBuscar = true)]
        public int SubCategoriaId { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public int CategoriaId { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true)]
        public string Nome { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string Descricao { get; set; }

        public new List<SubCategoria> Todos()
        {
            var subCategoriia = new List<SubCategoria>();
            foreach (var ibase in base.Todos())
            {
                subCategoriia.Add((SubCategoria)ibase);
            }
            return subCategoriia;
        }

        public new List<SubCategoria> Busca()
        {
            var subCategoriia = new List<SubCategoria>();
            foreach (var ibase in base.Busca())
            {
                subCategoriia.Add((SubCategoria)ibase);
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
