using System;
using System.Runtime.InteropServices;

namespace CasaMendes
{
    [Serializable]
    [ClassInterface(ClassInterfaceType.AutoDual)]
    [ComVisible(true)]
    public class CaixaResumo
    {
        public int FuncionarioId { get; set; } = 0;
        public decimal TotalCaixa { get; set; } = 0.00M;
        public decimal TotalAbertoCom { get; set; } = 0.00M;
        public decimal TotalSuprimento { get; set; } = 0.00M;
        public decimal TotalSangria { get; set; } = 0.00M;
        public decimal TotalLiquido { get; set; } = 0.00M;
        public decimal TotalDesconto { get; set; } = 0.00M;

        public DateTime DataHora { get; set; } = DateTime.Now;
        public string Titulo { get; set; } = ".......... Casa Mendes ..........";
        public string Descricao { get; set; } = "..Resumo de vendas dia..";
    }
}
