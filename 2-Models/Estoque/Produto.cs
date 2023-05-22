
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

        public Produto(bool disposedValue, int idProduto, string codigoDeBarras, int codigoDoFornecedor, string nome, DateTime dataDeValidade, decimal valorCompra, int quantidade, int estoque, decimal precoUnitario, decimal precoDeVenda, int desconto, string foto, decimal valorDesconto, int codigoDaNotaFiscal, DateTime created_at, DateTime updated_at, DateTime? deleted_at)
        {
            this.disposedValue = disposedValue;
            this.idProduto = idProduto;
            CodigoDeBarras = codigoDeBarras ?? throw new ArgumentNullException(nameof(codigoDeBarras));
            CodigoDoFornecedor = codigoDoFornecedor;
            Nome = nome ?? throw new ArgumentNullException(nameof(nome));
            DataDeValidade = dataDeValidade;
            ValorCompra = valorCompra;
            Quantidade = quantidade;
            Estoque = estoque;
            PrecoUnitario = precoUnitario;
            PrecoDeVenda = precoDeVenda;
            Desconto = desconto;
            Foto = foto ?? throw new ArgumentNullException(nameof(foto));
            ValorDesconto = valorDesconto;
            CodigoDaNotaFiscal = codigoDaNotaFiscal;
            this.created_at = created_at;
            this.updated_at = updated_at;
            this.deleted_at = deleted_at;
        }

        [OpcoesBase(UsarNoBancoDeDados = true, ChavePrimaria = true, UsarParaBuscar = true)]
        public int idProduto { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true)]
        public string CodigoDeBarras { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public int CodigoDoFornecedor { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true)]
        public string Nome { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public DateTime DataDeValidade { get; set; } = DateTime.Now;

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public decimal ValorCompra { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public int Quantidade { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public int Estoque { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public decimal PrecoUnitario { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public decimal PrecoDeVenda { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public int Desconto { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = false)]
        public string Foto { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public decimal ValorDesconto { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public int CodigoDaNotaFiscal { get; set; }

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
