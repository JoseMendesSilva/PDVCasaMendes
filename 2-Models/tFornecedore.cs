using System;
using System.Collections.Generic;
using System.Drawing;

namespace CasaMendes
{
    class tFornecedore : Base
    {
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

        //[OpcoesBase(UsarNoBancoDeDados = true)]
        //public string Pais { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public DateTime DataCadastro { get; set; }

        //[OpcoesBase(UsarNoBancoDeDados = true)]
        //public string DataDeNascimento { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string Celular { get; set; }

        //[OpcoesBase(UsarNoBancoDeDados = true)]
        //public string TelefoneContato { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string Telefone { get; set; }

        //[OpcoesBase(UsarNoBancoDeDados = true)]
        //public string CelularContato { get; set; }

        //[OpcoesBase(UsarNoBancoDeDados = true)]
        //public string Foto { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string Email { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string SITE { get; set; }

        //[OpcoesBase(UsarNoBancoDeDados = true)]
        //public string Rg { get; set; }

        //[OpcoesBase(UsarNoBancoDeDados = true)]
        //public string Cpf { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string Cnpj { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string InscricaoEstadual { get; set; }

        //[OpcoesBase(UsarNoBancoDeDados = true)]
        //public string Nome { get; set; }

        //[OpcoesBase(UsarNoBancoDeDados = true)]
        //public string EstadoCivil { get; set; }

        //[OpcoesBase(UsarNoBancoDeDados = true)]
        //public string Observacao { get; set; }

        //[OpcoesBase(UsarNoBancoDeDados = true)]
        //public string Status { get; set; }

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

    }
}
