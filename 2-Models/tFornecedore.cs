using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;

namespace CasaMendes
{
   public class tFornecedore : Base, IDisposable
    {
        // Flag: Has Dispose already been called?
        bool disposed;

        public tFornecedore()
        {
            // Do not re-create Dispose clean-up code here.
            // Calling Dispose(disposing: false) is optimal in terms of
            // readability and maintainability.
            disposed = false;
            Dispose(disposing: false);
        }

        ~tFornecedore()
        {
            // Do not re-create Dispose clean-up code here.
            // Calling Dispose(disposing: false) is optimal in terms of
            // readability and maintainability.
            Dispose(disposing: false);
        }

        [OpcoesBase(UsarNoBancoDeDados = true, ChavePrimaria = true, UsarParaBuscar = true)]
         public string CodigoDoFornecedor { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true)]
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

        public new List<tFornecedore> Todos()
        {
            var Fornecedores = new List<tFornecedore>();
            foreach (var ibase in base.Todos())
            {
                Fornecedores.Add((tFornecedore)ibase);
            }
            return Fornecedores;
        }

        public new List<tFornecedore> Busca()
        {
            var Fornecedores = new List<tFornecedore>();
            foreach (var ibase in base.Busca())
            {
                Fornecedores.Add((tFornecedore)ibase);
            }
            return Fornecedores;
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        // Protected implementation of Dispose pattern.
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                this.Dispose();
                // Free any other managed objects here.
                //
            }

            disposed = true;
        }


    }
}
