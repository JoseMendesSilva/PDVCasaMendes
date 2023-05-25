using System;
using System.Collections.Generic;

namespace CasaMendes
{
    public class Categoria : Base, IDisposable
    {
        private bool disposedValue;

        public Categoria()
        {
        }

        [OpcoesBase(UsarNoBancoDeDados = true, ChavePrimaria = true, UsarParaBuscar = true)]
        public int CategoriaId { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true)]
        public string Nome { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string Descricao { get; set; }

        public new List<Categoria> Todos()
        {
            var Categoriia = new List<Categoria>();
            foreach (var ibase in base.Todos())
            {
                Categoriia.Add((Categoria)ibase);
            }
            return Categoriia;
        }

        public new List<Categoria> Busca()
        {
            var Categoriia = new List<Categoria>();
            foreach (var ibase in base.Busca())
            {
                Categoriia.Add((Categoria)ibase);
            }
            return Categoriia;
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
        ~Categoria()
        {
            // Não altere este código. Coloque o código de limpeza no método 'Dispose(bool disposing)'
            Dispose(disposing: false);
        }

        void IDisposable.Dispose()
        {
            // Não altere este código. Coloque o código de limpeza no método 'Dispose(bool disposing)'
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
