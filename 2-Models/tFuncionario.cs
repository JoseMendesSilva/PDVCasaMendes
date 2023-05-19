using System;
using System.Collections.Generic;

namespace CasaMendes
{
    public class tFuncionario : Base
    {
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

        public new List<tFuncionario> Todos()
        {
            var Funcionario = new List<tFuncionario>();
            foreach (var ibase in base.Todos())
            {
                Funcionario.Add((tFuncionario)ibase);
            }
            return Funcionario;
        }

        public new List<tFuncionario> Busca()
        {
            var Funcionario = new List<tFuncionario>();
            foreach (var ibase in base.Busca())
            {
                Funcionario.Add((tFuncionario)ibase);
            }
            return Funcionario;
        }

        //bool disposed = false;
        //public void Dispose()
        //{
        //    Dispose(disposing: true);
        //    GC.SuppressFinalize(this);
        //}

        //// Protected implementation of Dispose pattern.
        //protected virtual void Dispose(bool disposing)
        //{
        //    if (disposed)
        //        return;

        //    if (disposing)
        //    {
        //        this.Dispose();
        //        // Free any other managed objects here.
        //        //
        //    }

        //    disposed = true;
        //}

    }
}
