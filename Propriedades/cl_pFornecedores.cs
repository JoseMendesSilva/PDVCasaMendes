using System;
using System.Drawing;

namespace CasaMendes.Propriedades
{
    class cl_pFornecedores : Base
    {
        public decimal CodigoDoFornecedor { get; set; }
 
        public string RazaoSocial { get; set; }    

        public string Endereco {  get;  set;}

         public Decimal Cep{ get;  set; }

        public string Cidade { get; set; }
 
        public string Bairro {  get;  set; }
 
        public string Estado  {  get; set; }
 
        public string Pais { get; set; }

        public DateTime DataCadastro { get; set;}

        public DateTime DataDeNascimento{ get; set;}

        public decimal Celular{ get; set; }

        public decimal TelefoneContato{ get; set; }

        public decimal Telefone{get;set;}

        public Decimal CelularContato{get;set;}

        public Image Foto { get; set;  }

        public string Email {get;set;}

        public string SITE{ get; set; }

        public Decimal Rg { get; set; }

        public Decimal Cpf { get; set;}

        public Decimal Cnpj { get;set;}

        public Decimal InscricaoEstadual{get;set;}

       public string Nome { get; set; }

        public string EstadoCivil { get; set; }

        public string Observacao { get; set; }

        public string Status { get; set; }

    }
}
