
using System;
using System.Collections.Generic;

namespace CasaMendes
{
    public class Estoque : Base, IDisposable
    {
        [OpcoesBase(UsarNoBancoDeDados = true, ChavePrimaria = true, UsarParaBuscar = true)]
        public int EstoqueId { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true)]
        public int ProdutoId { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true)]
        public string CodigoDeBarras { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = false)]
        public string Produto { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public int Quantidade { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public decimal PrecoDeVenda { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public decimal QuantidadeParaDesconto { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public decimal ValorDesconto { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public DateTime created_at { get; set; } = DateTime.Now;

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public DateTime updated_at { get; set; } = DateTime.Now;

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public DateTime? deleted_at { get; set; } = null;

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

        public void Dispose()
        {
            throw new NotImplementedException();
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
