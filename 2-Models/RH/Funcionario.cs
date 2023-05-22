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

        public Funcionario(bool disposedValue, int funcionarioId, string nome, string endereco, string cep, string cidade, string bairro, string estado, string pais, string rg, string cpf, string estadoCivil, DateTime dataCadastro, DateTime dataDeNascimento, string celular, string telefone, string observacao, string foto)
        {
            this.disposedValue = disposedValue;
            FuncionarioId = funcionarioId;
            Nome = nome ?? throw new ArgumentNullException(nameof(nome));
            Endereco = endereco ?? throw new ArgumentNullException(nameof(endereco));
            Cep = cep ?? throw new ArgumentNullException(nameof(cep));
            Cidade = cidade ?? throw new ArgumentNullException(nameof(cidade));
            Bairro = bairro ?? throw new ArgumentNullException(nameof(bairro));
            Estado = estado ?? throw new ArgumentNullException(nameof(estado));
            Pais = pais ?? throw new ArgumentNullException(nameof(pais));
            Rg = rg ?? throw new ArgumentNullException(nameof(rg));
            Cpf = cpf ?? throw new ArgumentNullException(nameof(cpf));
            EstadoCivil = estadoCivil ?? throw new ArgumentNullException(nameof(estadoCivil));
            DataCadastro = dataCadastro;
            DataDeNascimento = dataDeNascimento;
            Celular = celular ?? throw new ArgumentNullException(nameof(celular));
            Telefone = telefone ?? throw new ArgumentNullException(nameof(telefone));
            Observacao = observacao ?? throw new ArgumentNullException(nameof(observacao));
            Foto = foto ?? throw new ArgumentNullException(nameof(foto));
        }

        //[Codigo]
        [OpcoesBase(UsarNoBancoDeDados = true, ChavePrimaria = true, UsarParaBuscar = true)]
        public int FuncionarioId { get; set; }

        //,[Nome]
        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true)]
        public string Nome { get; set; }

        //,[Endereco]
        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string Endereco { get; set; }

        //,[Cep]
        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string Cep { get; set; }

        //,[Cidade]
        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string Cidade { get; set; }

        //,[Bairro]
        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string Bairro { get; set; }

        //,[Estado]
        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string Estado { get; set; }

        //,[Pais]
        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string Pais { get; set; }

        //,[RG]
        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string Rg { get; set; }

        //,[CPF]
        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string Cpf { get; set; }

        //,[EstadoCivil]
        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string EstadoCivil { get; set; }

        //,[DataCadastro]
        [OpcoesBase(UsarNoBancoDeDados = true)]
        public DateTime DataCadastro { get; set; } = DateTime.Now;

        //,[DataDeNascimento]
        [OpcoesBase(UsarNoBancoDeDados = true)]
        public DateTime DataDeNascimento { get; set; } = DateTime.Now;

        //,[Celular]
        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string Celular { get; set; }

        //,[Telefone]
        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string Telefone { get; set; }

        //,[Observacao]
        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string Observacao { get; set; }

        //,[Foto]
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
