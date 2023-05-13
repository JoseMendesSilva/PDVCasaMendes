
using System;
using System.Collections.Generic;

namespace CasaMendes
{
    public class tProduto : Base
    {
        [OpcoesBase(UsarNoBancoDeDados = true, ChavePrimaria = true, UsarParaBuscar = true)]
        public int idProduto { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true)]
        public string CodigoDeBarras { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public int CodigoDoFornecedor { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true)]
        public string Nome { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public DateTime DataDeValidade { get; set; } = DateTime.Now;

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public decimal ValorCompra { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public int Quantidade { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public int Estoque { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public decimal PrecoUnitario { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public decimal PrecoDeVenda { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public int Desconto { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = false)]
        public string Foto { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public decimal ValorDesconto { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public int CodigoDaNotaFiscal { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public DateTime created_at { get; set; } = DateTime.Now;

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public DateTime updated_at { get; set; } = DateTime.Now;

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public DateTime? deleted_at { get; set; } = null;

        public new List<tProduto> Todos()
        {
            var produtos = new List<tProduto>();
            foreach (var ibase in base.Todos())
            {
                produtos.Add((tProduto)ibase);
            }
            return produtos;
        }

        public new List<tProduto> Busca()
        {
            var produtos = new List<tProduto>();
            foreach (var ibase in base.Busca())
            {
                produtos.Add((tProduto)ibase);
            }
            return produtos;
        }

    }
}
