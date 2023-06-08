using System;
using System.Collections.Generic;

namespace CasaMendes
{
    public class SubCategoria : Base, IDisposable
    {
        private bool disposedValue;

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
        ~SubCategoria()
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
