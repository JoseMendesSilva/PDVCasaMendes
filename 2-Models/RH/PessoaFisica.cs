namespace CasaMendes
{
    public class PessoaFisica
    {
        [OpcoesBase(UsarNoBancoDeDados = true)]
        public int PessoaFisicaId { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public int ClienteId { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public int FornecedorId { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public int FuncionarioId { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string Rg { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string Cpf { get; set; }
    }
}
