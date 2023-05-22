
using System;
using System.Collections.Generic;

namespace CasaMendes
{
    public class Estoque : Base, IDisposable
    {
        private bool disposedValue;

        public Estoque()
        {
        }

        public Estoque(int estoqueId, int produtoId, string codigoDeBarras, string produto, int quantidade, decimal precoDeVenda, decimal quantidadeParaDesconto, decimal valorDesconto, DateTime created_at, DateTime updated_at, DateTime? deleted_at)
        {
            EstoqueId = estoqueId;
            ProdutoId = produtoId;
            CodigoDeBarras = codigoDeBarras ?? throw new ArgumentNullException(nameof(codigoDeBarras));
            Produto = produto ?? throw new ArgumentNullException(nameof(produto));
            Quantidade = quantidade;
            PrecoDeVenda = precoDeVenda;
            QuantidadeParaDesconto = quantidadeParaDesconto;
            ValorDesconto = valorDesconto;
            this.created_at = created_at;
            this.updated_at = updated_at;
            this.deleted_at = deleted_at;
        }

        [OpcoesBase(UsarNoBancoDeDados = true, ChavePrimaria = true, UsarParaBuscar = true)]
        public int EstoqueId { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true)]
        public int ProdutoId { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true)]
        public string CodigoDeBarras { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = false)]
        public string Produto { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public int Quantidade { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public decimal PrecoDeVenda { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public decimal QuantidadeParaDesconto { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public decimal ValorDesconto { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public DateTime created_at { get; set; } = DateTime.Now;

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public DateTime updated_at { get; set; } = DateTime.Now;

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public DateTime? deleted_at { get; set; } = null;

        public new List<Estoque> Todos()
        {
            var estoque = new List<Estoque>();
            foreach (var ibase in base.Todos())
            {
                estoque.Add((Estoque)ibase);
            }
            return estoque;
        }

        public new List<Estoque> Busca()
        {
            var estoque = new List<Estoque>();
            foreach (var ibase in base.Busca())
            {
                estoque.Add((Estoque)ibase);
            }
            return estoque;
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
        ~Estoque()
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
