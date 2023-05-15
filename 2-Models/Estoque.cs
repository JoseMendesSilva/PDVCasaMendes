
using System;
using System.Collections.Generic;

namespace CasaMendes
{
    public class Estoque : Base
    {
        [OpcoesBase(UsarNoBancoDeDados = true, ChavePrimaria = true, UsarParaBuscar = true)]
        public int EstoqueId { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true)]
        public int ProdutoId { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true)]
        public string CodigoDeBarras { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public int Quantidade { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public double PrecoDeVenda { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public double QuantidadeParaDesconto { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public double ValorDesconto { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public DateTime created_at { get; set; } = DateTime.Now;

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public DateTime updated_at { get; set; } = DateTime.Now;

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public DateTime deleted_at { get; set; }// = null;

        public new List<Estoque> Todos()
        {
            var estoque = new List<Estoque>();
            foreach (var ibase in base.Todos())
            {
                estoque.Add((Estoque)ibase);
            }
            return estoque;
        }

        public new List<Estoque> Busca()
        {
            var estoque = new List<Estoque>();
            foreach (var ibase in base.Busca())
            {
                estoque.Add((Estoque)ibase);
            }
            return estoque;
        }

    }

}
