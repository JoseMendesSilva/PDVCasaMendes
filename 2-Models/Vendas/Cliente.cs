
using System;
using System.Collections.Generic;

namespace CasaMendes
{
    public class Cliente : Base,IDisposable
    {
        private bool disposedValue;

        public Cliente()
        {
        }

        [OpcoesBase(UsarNoBancoDeDados = true, ChavePrimaria = true, UsarParaBuscar = true)]
        public int ClienteId { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true)]
        public string Nome { get; set; }

        //[OpcoesBase(UsarNoBancoDeDados = true)]
        //public Destinatario Endereco { get; set; }

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
        public DateTime DataNascimento { get; set; } = DateTime.Now;

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string Rg { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string Cpf { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string InscricaoEstadual { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string Cnpj { get; set; }

        //[OpcoesBase(UsarNoBancoDeDados = true)]
        //public PessoaFisica PessoasFisica { get; set; }

        //[OpcoesBase(UsarNoBancoDeDados = true)]
        //public PessoaJuridica  PessoasJuridica{ get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string Telefone { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string Celular { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string Email { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string SITE { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public DateTime created_at { get; set; } = DateTime.Now;

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public DateTime updated_at { get; set; } = DateTime.Now;

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public DateTime? deleted_at { get; set; } = null;

        public new List<Cliente> Todos()
        {
            var Cliente = new List<Cliente>();
            foreach (var ibase in base.Todos())
            {
                Cliente.Add((Cliente)ibase);
            }
            return Cliente;
        }

        public new List<Cliente> Busca()
        {
            var Cliente = new List<Cliente>();
            foreach (var ibase in base.Busca())
            {
                Cliente.Add((Cliente)ibase);
            }
            return Cliente;
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
        ~Cliente()
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
