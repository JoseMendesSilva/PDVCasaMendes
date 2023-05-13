using System;
using System.Drawing;

namespace CasaMendes.Propriedades
{
    //Esta classe recebeu o modificador abstrata, portanto, ela so pode se herdada.
    abstract public class cl_pBase
    {
        //================================================================================================
        private Int16 _codigo;
        public Int16 Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        //================================================================================================
        string _endereco;
        public string Endereco
        {
            get { return _endereco; }
            set { _endereco = value; }
        }

        //================================================================================================
        Decimal _cep;
        public Decimal Cep
        {
            get { return _cep; }
            set { _cep = value; }
        }

        //================================================================================================
        string _cidade;
        public string Cidade
        {
            get { return _cidade; }
            set { _cidade = value; }
        }

        //================================================================================================
        string _bairro;
        public string Bairro
        {
            get { return _bairro; }
            set { _bairro = value; }
        }

        //================================================================================================
        string _estado;
        public string Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }

        //================================================================================================
        string _pais;
        public string Pais
        {
            get { return _pais; }
            set { _pais = value; }
        }

        //================================================================================================
        DateTime _dataCadastro;
        public DateTime DataCadastro
        {
            get { return _dataCadastro; }
            set { _dataCadastro = value; }
        }

        //================================================================================================
        DateTime _dataDeNascimento;
        public DateTime DataDeNascimento
        {
            get { return _dataDeNascimento; }
            set { _dataDeNascimento = value; }
        }

        //================================================================================================
        Decimal _celular;
        public Decimal Celular
        {
            get { return _celular; }
            set { _celular = value; }
        }

        //================================================================================================
        Decimal _telefoneContato;
        public Decimal TelefoneContato
        {
            get { return _telefoneContato; }
            set { _telefoneContato = value; }
        }

        //================================================================================================
        Decimal _telefone;
        public Decimal Telefone
        {
            get { return _telefone; }
            set { _telefone = value; }
        }

        //================================================================================================
        Decimal _celularContato;
        public Decimal CelularContato
        {
            get { return _celularContato; }
            set { _celularContato = value; }
        }

        //================================================================================================
        Image _foto;
        public Image Foto
        {
            get { return _foto; }
            set { _foto = value; }
        }

        //================================================================================================
        string _email;
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        //================================================================================================
        string _SITE;
        public string SITE
        {
            get { return _SITE; }
            set { _SITE = value; }
        }

        //================================================================================================
        Decimal _rg;
        public Decimal Rg
        {
            get { return _rg; }
            set { _rg = value; }
        }

        //================================================================================================
        Decimal _cpf;
        public Decimal Cpf
        {
            get { return _cpf; }
            set { _cpf = value; }
        }

        //================================================================================================
        Decimal _cnpj;
        public Decimal Cnpj
        {
            get { return _cnpj; }
            set { _cnpj = value; }
        }

        //================================================================================================
        Decimal _inscricaoEstadual;
        public Decimal InscricaoEstadual
        {
            get { return _inscricaoEstadual; }
            set { _inscricaoEstadual = value; }
        }

        //================================================================================================
        public string Nome { get; set; }

        //================================================================================================
        public string EstadoCivil { get; set; }

        //================================================================================================
        public string Observacao { get; set; }

        //================================================================================================
        public string Status { get; set; }
    }
}
