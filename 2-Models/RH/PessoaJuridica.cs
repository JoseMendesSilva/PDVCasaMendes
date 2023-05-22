namespace CasaMendes
{
    public class PessoaJuridica
    {
        [OpcoesBase(UsarNoBancoDeDados = true)]
        public int PessoaJuridicaId { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public int ClienteId { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public int FornecedorId { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public int FuncionarioId { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string InscricaoEstadual { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string Cnpj { get; set; }
    }
}
