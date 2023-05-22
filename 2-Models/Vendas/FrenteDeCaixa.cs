using System;

namespace CasaMendes
{
    public class FrenteDeCaixa : Base, IDisposable
    {
        private bool disposedValue;

        public FrenteDeCaixa()
        {
        }

        public FrenteDeCaixa(bool disposedValue, int clienteId, string cliente, string tipoDeVenda, int numeroDaVenda, string codigoDeBarras, string produto, int quantidade, decimal dinheiro, decimal troco, decimal subTotal, decimal desconto, decimal descontoAplicado, decimal margem, decimal encargo, decimal anotar, DateTime dataLancamento, decimal entrada, decimal saidaAnterior)
        {
            this.disposedValue = disposedValue;
            ClienteId = clienteId;
            Cliente = cliente ?? throw new ArgumentNullException(nameof(cliente));
            TipoDeVenda = tipoDeVenda ?? throw new ArgumentNullException(nameof(tipoDeVenda));
            NumeroDaVenda = numeroDaVenda;
            CodigoDeBarras = codigoDeBarras ?? throw new ArgumentNullException(nameof(codigoDeBarras));
            Produto = produto ?? throw new ArgumentNullException(nameof(produto));
            Quantidade = quantidade;
            Dinheiro = dinheiro;
            Troco = troco;
            SubTotal = subTotal;
            Desconto = desconto;
            DescontoAplicado = descontoAplicado;
            Margem = margem;
            Encargo = encargo;
            Anotar = anotar;
            DataLancamento = dataLancamento;
            Entrada = entrada;
            SaidaAnterior = saidaAnterior;
        }

        public int ClienteId { get; set; }
        public string Cliente { get; set; }
        public string TipoDeVenda { get; set; }
        public int NumeroDaVenda { get; set; }

        public string CodigoDeBarras { get; set; }
        public string Produto { get; set; }
        public int Quantidade { get; set; }

        public decimal Dinheiro { get; set; }
        public decimal Troco { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Desconto { get; set; }
        public decimal DescontoAplicado { get; set; }

        //--------------------------------------------
        public decimal Margem { get; set; }
        public decimal Encargo { get; set; }
        public decimal Anotar { get; set; }

        //--------------------------------------------
        public DateTime DataLancamento { get; set; }
        public decimal Entrada { get; set; }
        public decimal SaidaAnterior { get; set; }

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
        ~FrenteDeCaixa()
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
