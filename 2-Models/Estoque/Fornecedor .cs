using System;
using System.Collections.Generic;
using System.Drawing;

namespace CasaMendes
{
    class Fornecedor : Base , IDisposable
    {
        private bool disposedValue;

        public Fornecedor()
        {
        }

        public Fornecedor(bool disposedValue, int fornecedorID, string razaoSocial, string endereco, string cep, string cidade, string bairro, string estado, string pais, DateTime dataCadastro, string celular, string telefone, string email, string sITE, string cnpj, string inscricaoEstadual, DateTime created_at, DateTime updated_at, DateTime? deleted_at)
        {
            this.disposedValue = disposedValue;
            FornecedorID = fornecedorID;
            RazaoSocial = razaoSocial ?? throw new ArgumentNullException(nameof(razaoSocial));
            Endereco = endereco ?? throw new ArgumentNullException(nameof(endereco));
            Cep = cep ?? throw new ArgumentNullException(nameof(cep));
            Cidade = cidade ?? throw new ArgumentNullException(nameof(cidade));
            Bairro = bairro ?? throw new ArgumentNullException(nameof(bairro));
            Estado = estado ?? throw new ArgumentNullException(nameof(estado));
            Pais = pais ?? throw new ArgumentNullException(nameof(pais));
            DataCadastro = dataCadastro;
            Celular = celular ?? throw new ArgumentNullException(nameof(celular));
            Telefone = telefone ?? throw new ArgumentNullException(nameof(telefone));
            Email = email ?? throw new ArgumentNullException(nameof(email));
            SITE = sITE ?? throw new ArgumentNullException(nameof(sITE));
            Cnpj = cnpj ?? throw new ArgumentNullException(nameof(cnpj));
            InscricaoEstadual = inscricaoEstadual ?? throw new ArgumentNullException(nameof(inscricaoEstadual));
            this.created_at = created_at;
            this.updated_at = updated_at;
            this.deleted_at = deleted_at;
        }

        [OpcoesBase(UsarNoBancoDeDados = true, ChavePrimaria = true, UsarParaBuscar = true)]
         public int FornecedorID { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string RazaoSocial { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string Endereco { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string Cep { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string Cidade { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string Bairro { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string Estado { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string Pais { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public DateTime DataCadastro { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string Celular { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string Telefone { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string Email { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string SITE { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string Cnpj { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string InscricaoEstadual { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public DateTime created_at { get; set; } = DateTime.Now;

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public DateTime updated_at { get; set; } = DateTime.Now;

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public DateTime? deleted_at { get; set; } = null;

        public new List<Fornecedor> Todos()
        {
            var Fornecedor = new List<Fornecedor>();
            foreach (var ibase in base.Todos())
            {
                Fornecedor.Add((Fornecedor)ibase);
            }
            return Fornecedor;
        }

        public new List<Fornecedor> Busca()
        {
            var Fornecedor = new List<Fornecedor>();
            foreach (var ibase in base.Busca())
            {
                Fornecedor.Add((Fornecedor)ibase);
            }
            return Fornecedor;
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
        ~Fornecedor()
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
