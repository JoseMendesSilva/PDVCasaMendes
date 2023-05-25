
using System;
using System.Collections.Generic;

namespace CasaMendes
{
    public class Produto : Base, IDisposable
    {
        private bool disposedValue;

        public Produto()
        {
        }

        [OpcoesBase(UsarNoBancoDeDados = true, ChavePrimaria = true, UsarParaBuscar = true)]
        public int ProdutoId { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public int FornecedorId { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true)]
        public string CodigoDeBarras { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true)]
        public string Nome { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public DateTime DataDeValidade { get; set; } = DateTime.Now;

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public int Quantidade { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public decimal ValorCompra { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public decimal PrecoUnitario { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public decimal PrecoDeVenda { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = false)]
        public string Foto { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public DateTime created_at { get; set; } = DateTime.Now;

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public DateTime updated_at { get; set; } = DateTime.Now;

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public DateTime? deleted_at { get; set; } = null;

        public new List<Produto> Todos()
        {
            var produtos = new List<Produto>();
            foreach (var ibase in base.Todos())
            {
                produtos.Add((Produto)ibase);
            }
            return produtos;
        }

        public new List<Produto> Busca()
        {
            var produtos = new List<Produto>();
            foreach (var ibase in base.Busca())
            {
                produtos.Add((Produto)ibase);
            }
            return produtos;
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
        ~Produto()
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
