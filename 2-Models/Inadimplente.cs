using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace CasaMendes
{
    public class Inadimplente : Base
    {

        public string InadimplenteId { get; set; }
        public string ClienteId { get; set; }
        public string Status { get; set; }
        public string Data { get; set; }
        public string DividaAtiva { get; set; }
        public string Encargos { get; set; }
        public string Observacao { get; set; }

        public new List<Inadimplente> Todos()
        {
            var inadimplente = new List<Inadimplente>();
            foreach (var ibase in base.Todos())
            {
                inadimplente.Add((Inadimplente)ibase);
            }
            return inadimplente;
        }

        public new List<Inadimplente> Busca()
        {
            var inadimplente = new List<Inadimplente>();
            foreach (var ibase in base.Busca())
            {
                inadimplente.Add((Inadimplente)ibase);
            }
            return inadimplente;
        }


    }
}
