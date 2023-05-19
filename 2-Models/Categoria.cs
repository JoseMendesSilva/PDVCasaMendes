using System;
using System.Collections.Generic;

namespace CasaMendes
{
    public class Categoria : Base
    {
        [OpcoesBase(UsarNoBancoDeDados = true, ChavePrimaria = true, UsarParaBuscar = true)]
        public int CategoriaId { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true)]
        public string Nome { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string Descricao { get; set; }

        public new List<Categoria> Todos()
        {
            var Categoriia = new List<Categoria>();
            foreach (var ibase in base.Todos())
            {
                Categoriia.Add((Categoria)ibase);
            }
            return Categoriia;
        }

        public new List<Categoria> Busca()
        {
            var Categoriia = new List<Categoria>();
            foreach (var ibase in base.Busca())
            {
                Categoriia.Add((Categoria)ibase);
            }
            return Categoriia;
        }

    }
}
