
using System;
using System.Collections.Generic;

namespace CasaMendes
{
    public class Cliente : Base
    {
        [OpcoesBase(UsarNoBancoDeDados = true, ChavePrimaria = true, UsarParaBuscar = true)]
        public int ClienteId { get; set; }

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
        public DateTime DataNascimento { get; set; } = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy"));

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string Rg { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string Cpf { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string InscricaoEstadual { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string Cnpj { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string Telefone { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string Celular { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string Email { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string SITE { get; set; }

        //[OpcoesBase(UsarNoBancoDeDados = true)]
        //public DateTime created_at { get; set; } = DateTime.Now;

        //[OpcoesBase(UsarNoBancoDeDados = true)]
        //public DateTime updated_at { get; set; } = DateTime.Now;

        //[OpcoesBase(UsarNoBancoDeDados = true)]
        //public DateTime? deleted_at { get; set; } = null;

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

    }
}
