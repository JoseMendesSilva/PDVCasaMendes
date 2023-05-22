using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaMendes
{
    public class Contato
    {
        [OpcoesBase(UsarNoBancoDeDados = true)]
        public int ContatoId { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public int ClienteId { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public int FornecedorId { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public int FuncionarioId { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string Celular { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string Telefone { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string Email { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string SITE { get; set; }
    }
}
