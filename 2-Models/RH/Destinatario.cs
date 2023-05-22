using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaMendes
{
    public class Destinatario
    {
        [OpcoesBase(UsarNoBancoDeDados = true)]
        public int DestinatarioId { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public int ClienteId { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public int FornecedorId { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public int FuncionarioId { get; set; }


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
    }
}
