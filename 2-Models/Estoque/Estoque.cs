﻿
using System;
using System.Collections;
using System.Collections.Generic;

namespace CasaMendes
{
    public class Estoque : Base, IDisposable, IEnumerable
    {
        private bool disposedValue;

        //public Estoque()
        //{
        //}

        [OpcoesBase(UsarNoBancoDeDados = true, ChavePrimaria = true, UsarParaBuscar = true)]
        public int EstoqueId { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true)]
        public int ProdutoId { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true)]
        public string CodigoDeBarras { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string Produto { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public int Quantidade { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public decimal PrecoDeVenda { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public decimal QuantidadeItemDesconto { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public decimal ValorDesconto { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = false)]
        public string Foto { get; set; }

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

        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable)CodigoDeBarras).GetEnumerator();
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
        ~Estoque()
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
