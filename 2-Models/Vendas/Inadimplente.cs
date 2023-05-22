using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace CasaMendes
{
    public class Inadimplente : Base, IDisposable
    {
        private bool disposedValue;

        public Inadimplente()
        {
        }

        public Inadimplente(bool disposedValue, string inadimplenteId, string clienteId, string status, string data, string dividaAtiva, string encargos, string observacao)
        {
            this.disposedValue = disposedValue;
            InadimplenteId = inadimplenteId ?? throw new ArgumentNullException(nameof(inadimplenteId));
            ClienteId = clienteId ?? throw new ArgumentNullException(nameof(clienteId));
            Status = status ?? throw new ArgumentNullException(nameof(status));
            Data = data ?? throw new ArgumentNullException(nameof(data));
            DividaAtiva = dividaAtiva ?? throw new ArgumentNullException(nameof(dividaAtiva));
            Encargos = encargos ?? throw new ArgumentNullException(nameof(encargos));
            Observacao = observacao ?? throw new ArgumentNullException(nameof(observacao));
        }

        public string InadimplenteId { get; set; }
        public string ClienteId { get; set; }
        public string Status { get; set; }
        public string Data { get; set; }
        public string DividaAtiva { get; set; }
        public string Encargos { get; set; }
        public string Observacao { get; set; }

        public new List<Inadimplente> Todos()
        {
            var inadimplente = new List<Inadimplente>();
            foreach (var ibase in base.Todos())
            {
                inadimplente.Add((Inadimplente)ibase);
            }
            return inadimplente;
        }

        public new List<Inadimplente> Busca()
        {
            var inadimplente = new List<Inadimplente>();
            foreach (var ibase in base.Busca())
            {
                inadimplente.Add((Inadimplente)ibase);
            }
            return inadimplente;
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
        ~Inadimplente()
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
