using System;
using System.Collections.Generic;

namespace CasaMendes
{
    public class Funcionario : Base, IDisposable
    {
        private bool disposedValue;

        public Funcionario()
        {
        }

        [OpcoesBase(UsarNoBancoDeDados = true, ChavePrimaria = true, UsarParaBuscar = true)]
        public int FuncionarioId { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true)]
        public string Nome { get; set; }

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
        public string Rg { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string Cpf { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string EstadoCivil { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public DateTime DataCadastro { get; set; } = DateTime.Now;

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public DateTime DataDeNascimento { get; set; } = DateTime.Now;

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string Celular { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string Telefone { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string Observacao { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string Foto { get; set; }

        public new List<Funcionario> Todos()
        {
            var Funcionario = new List<Funcionario>();
            foreach (var ibase in base.Todos())
            {
                Funcionario.Add((Funcionario)ibase);
            }
            return Funcionario;
        }

        public new List<Funcionario> Busca()
        {
            var Funcionario = new List<Funcionario>();
            foreach (var ibase in base.Busca())
            {
                Funcionario.Add((Funcionario)ibase);
            }
            return Funcionario;
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
        ~Funcionario()
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
