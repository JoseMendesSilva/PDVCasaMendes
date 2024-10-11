using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
namespace CasaMendes
{
    //[DefaultEvent("Load")]
    //[InitializationEvent("Load")]
    [Serializable]
    [ClassInterface(ClassInterfaceType.AutoDual)]
    [ComVisible(true)]
    public class FrenteDeCaixa : PreVenda, IDisposable
    {
       
        //private bool disposedValue;

        //[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
        //public FrenteDeCaixa()
        //{
        //}

        //public int ClienteId { get; set; }
        public string Cliente { get; set; }
        //public string TipoDeVenda { get; set; }
        //public int NumeroDaVenda { get; set; }

        public string CodigoDeBarras { get; set; }
        //public string Produto { get; set; }
        //public int Quantidade { get; set; }

        //public decimal Dinheiro { get; set; }
        //public decimal Troco { get; set; }
        //public decimal SubTotal { get; set; }
        //public decimal Desconto { get; set; }
        public decimal DescontoAplicado { get; set; }

        //--------------------------------------------
        public decimal Margem { get; set; }
        public decimal Encargo { get; set; }
        public decimal Anotar { get; set; }

        //--------------------------------------------
        public DateTime DataLancamento { get; set; } = DateTime.Now;
        public decimal Entrada { get; set; }
        public decimal SaidaAnterior { get; set; }

        //protected virtual void Dispose(bool disposing)
        //{
        //    if (!disposedValue)
        //    {
        //        if (disposing)
        //        {
        //            // TODO: dispose managed state (managed objects)
        //        }

        //        // TODO: free unmanaged resources (unmanaged objects) and override finalizer
        //        // TODO: set large fields to null
        //        disposedValue = true;
        //    }
        //}

        // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        ~FrenteDeCaixa()
        {
            // Não altere este código. Coloque o código de limpeza no método 'Dispose(bool disposing)'
            Dispose(disposing: false);
        }

        //public void Dispose()
        //{
        //    // Não altere este código. Coloque o código de limpeza no método 'Dispose(bool disposing)'
        //    Dispose(disposing: true);
        //    GC.SuppressFinalize(this);
        //}

    }
}
