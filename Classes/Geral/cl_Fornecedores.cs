
using System;
using System.Collections.Generic;
using System.Windows.Forms;

using oDados = CasaMendes.Classes.ADL.Cl_Dados;

namespace CasaMendes.Classes
{
    class cl_Fornecedores : Propriedades.cl_pFornecedores
    {
        public Enumeradores.eAcao Acao = Enumeradores.eAcao.None;

        public static void CarregarComboBox(ComboBox cBox)
        {
            Estatica.clsGlobal.CarregarEstados(cBox);
        }

        public static void CarregarDataGridProdutos(DataGridView dgv)
        {
            try
            {
                string sSql = "";
                sSql += "SELECT CodigoDoFornecedor";
                sSql += ", RazaoSocial";
                sSql += ", Endereco";
                sSql += ", Cep";
                sSql += ", Cidade";
                sSql += ", Bairro";
                sSql += ", Estado";
                sSql += ", Cnpj";
                sSql += ", InscricaoEstadual";
                sSql += ", DataCadastro";
                sSql += ", Telefone";
                sSql += ", Celular";
                sSql += ", Site";
                sSql += ", Email FROM tFornecedores";

                dgv.DataSource = Classes.ADL.Cl_Dados.PegarDados(sSql);

                Classes.Estatica.clsGlobal.SetUpDataGridView(dgv);

            }
            catch { }
        }

        public void Gravar()
        {
            try
            {
                List<string> Campos = new List<string>();
                Campos.Add("tFornecedores");
                Campos.Add("CodigoDoFornecedor");
                Campos.Add("RazaoSocial");
                Campos.Add("Endereco");
                Campos.Add("Cep");
                Campos.Add("Cidade");
                Campos.Add("Bairro");
                Campos.Add("Estado");
                Campos.Add("DataCadastro");
                Campos.Add("Cnpj");
                Campos.Add("InscricaoEstadual");
                Campos.Add("Telefone");
                Campos.Add("Celular");
                Campos.Add("Site");
                Campos.Add("Email");

                if (this.CodigoDoFornecedor == -1 || this.CodigoDoFornecedor == 0 || Acao == Enumeradores.eAcao.Cadastrar)
                {
                    Acao = Enumeradores.eAcao.Cadastrar;
                    if (this.CodigoDoFornecedor == -1 || this.CodigoDoFornecedor == 0) { this.CodigoDoFornecedor = Convert.ToDecimal(oDados.LerMaxima("tFornecedores", "CodigoDoFornecedor")); }
                }
                else
                {
                    Acao = Enumeradores.eAcao.Atualizar;
                }

                if (oDados.Params.Count != 0) oDados.Params.Clear();
                oDados.AdicionarParametro("CodigoDoFornecedor", this.CodigoDoFornecedor);
                oDados.AdicionarParametro("RazaoSocial", this.RazaoSocial);
                oDados.AdicionarParametro("Endereco", this.Endereco);
                oDados.AdicionarParametro("Cep", this.Cep);
                oDados.AdicionarParametro("Cidade", this.Cidade);
                oDados.AdicionarParametro("Bairro", this.Bairro);
                oDados.AdicionarParametro("Estado", this.Estado);
                oDados.AdicionarParametro("DataCadastro", this.DataCadastro.ToShortDateString());
                oDados.AdicionarParametro("Cnpj", this.Cnpj);
                oDados.AdicionarParametro("InscricaoEstadual", this.InscricaoEstadual);
                oDados.AdicionarParametro("Telefone", this.Telefone);
                oDados.AdicionarParametro("Celular", this.Celular);
                oDados.AdicionarParametro("Site", this.SITE);
                oDados.AdicionarParametro("Email", this.Email);

                if (Acao == Enumeradores.eAcao.Cadastrar)
                {
                    oDados.Cadastrar(Campos, true);
                }
                else
                {
                    oDados.Atualizar(Campos,true);
                }

            }

            catch {; }
        }

        public void Excluir(string sTabele, string sId, string sFiltro)
        {
            Excluir(sTabele, sId, sFiltro);
        }

    }
}

//string sSql = "SELECT";
//sSql += " CodigoDoFornecedor";
//sSql += " ,(RazaoSocial) AS [Razão social]";
//sSql += " ,Cnpj             ";
//sSql += " ,(InscricaoEstadual) AS [Inscr estadual]";
//sSql += " ,(DataCadastro) AS [Data Cadastro]";
//sSql += " ,Telefone         ";
//sSql += " ,Celular          ";
//sSql += "FROM tFornecedores";