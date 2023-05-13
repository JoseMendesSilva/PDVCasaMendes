
using CasaMendes.Classes.Estatica;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CasaMendes.Classes
{
    class Cliente : Propriedades.cl_pBase
    {        //string _CodigoInadimplente = "0";

        private void AdicionarParametros(string Tabela = "tClentes")
        {
            if (Classes.ADL.Cl_Dados.Params.Count > 0) Classes.ADL.Cl_Dados.Params.Clear();
            //if (Tabela == "tClentes")
            //{
            Classes.ADL.Cl_Dados.AdicionarParametro("@Codigo", this.Codigo.ToString());
            Classes.ADL.Cl_Dados.AdicionarParametro("@Nome", this.Nome.ToString());
            Classes.ADL.Cl_Dados.AdicionarParametro("@Endereco", this.Endereco.ToString());
            Classes.ADL.Cl_Dados.AdicionarParametro("@Cep", this.Cep.ToString());
            Classes.ADL.Cl_Dados.AdicionarParametro("@Cidade", this.Cidade.ToString());
            Classes.ADL.Cl_Dados.AdicionarParametro("@Bairro", this.Bairro.ToString());
            Classes.ADL.Cl_Dados.AdicionarParametro("@Estado", this.Estado.ToString());
            Classes.ADL.Cl_Dados.AdicionarParametro("@Pais", this.Pais.ToString());
            Classes.ADL.Cl_Dados.AdicionarParametro("@DataCadastro", DateTime.Now.ToString("yyyy-MM-dd"));
            Classes.ADL.Cl_Dados.AdicionarParametro("@Rg", this.Rg.ToString());
            Classes.ADL.Cl_Dados.AdicionarParametro("@Cpf", this.Cpf.ToString());
            Classes.ADL.Cl_Dados.AdicionarParametro("@InscricaoEstadual", this.InscricaoEstadual.ToString());
            Classes.ADL.Cl_Dados.AdicionarParametro("@Cnpj", this.Cnpj.ToString());
            Classes.ADL.Cl_Dados.AdicionarParametro("@Telefone", this.Telefone.ToString());
            Classes.ADL.Cl_Dados.AdicionarParametro("@Celular", this.Celular.ToString());
            Classes.ADL.Cl_Dados.AdicionarParametro("@Email", this.Email.ToString());
            Classes.ADL.Cl_Dados.AdicionarParametro("@SITE", this.SITE.ToString());
            //}
        }

        public void Gravar(ArrayList arrCliente = null, Enumeradores.eAcao Acao = Enumeradores.eAcao.Atualizar)
        {
            try
            {

                if (arrCliente[0].ToString() != "") { this.Codigo = Convert.ToInt16(arrCliente[0].ToString()); } else { this.Codigo = 1; }
                if (arrCliente[1].ToString() != "") { this.Nome = arrCliente[1].ToString().ToUpper(); }

                string tmp = "SELECT Nome FROM tClientes WHERE Nome = '" + Nome.ToString() + "'";
                tmp = Convert.ToString(Classes.ADL.Cl_Dados.LerUmRegistro(tmp));
                if ((tmp == this.Nome) & Acao == Enumeradores.eAcao.Cadastrar) { MessageBox.Show("Cliente já cadastrado!", Application.ProductName); return; }

                if (arrCliente[2].ToString() != "") { this.Endereco = arrCliente[2].ToString().ToUpper(); } else { this.Endereco = "null"; }

                tmp = arrCliente[3].ToString().Replace("_", "").Replace("-", "");
                if (tmp != "") { this.Cep = Convert.ToDecimal(tmp); } else { this.Cep = 0; }

                if (arrCliente[4].ToString() != "") { this.Cidade = arrCliente[4].ToString().ToUpper(); } else { this.Cidade = "null"; }
                if (arrCliente[5].ToString() != "") { this.Bairro = arrCliente[5].ToString().ToUpper(); } else { this.Bairro = "null"; }
                if (arrCliente[6].ToString() != "") { this.Estado = arrCliente[6].ToString().ToUpper(); } else { this.Estado = "null"; }
                if (arrCliente[7].ToString() != "") { this.Pais = arrCliente[7].ToString().ToUpper(); } else { this.Pais = "null"; }

                DateTime d = Convert.ToDateTime(arrCliente[8].ToString());
                this.DataCadastro = Convert.ToDateTime(d.ToString("yyyy-MM-dd"));

                tmp = arrCliente[9].ToString().Replace("_", "").Replace("-", "").Replace(",", "").Trim();
                if (tmp != "") { this.Rg = Convert.ToDecimal(arrCliente[9].ToString()); } else { this.Rg = 0; }

                tmp = arrCliente[10].ToString().Replace("_", "").Replace("-", "").Replace(",", "").Trim();
                if (tmp != "") { this.Cpf = Convert.ToDecimal(tmp); } else { this.Cpf = 0; }

                tmp = arrCliente[11].ToString().Replace("_", "").Replace("-", "").Replace(",", "").Trim();
                if (tmp != "") { this.InscricaoEstadual = Convert.ToDecimal(tmp); } else { this.InscricaoEstadual = 0; }

                tmp = arrCliente[12].ToString().Replace("_", "").Replace("-", "").Replace(",", "").Trim();
                if (tmp != "") { this.Cnpj = Convert.ToDecimal(tmp); } else { this.Cnpj = 0; }

                tmp = arrCliente[13].ToString().Replace("(", "").Replace(")", "").Replace("-", "").Trim();
                if (tmp != "") { this.Telefone = Convert.ToDecimal(tmp); } else { this.Telefone = 0; }

                tmp = arrCliente[14].ToString().Replace("(", "").Replace(")", "").Replace("-", "").Trim();
                if (tmp != "") { this.Celular = Convert.ToDecimal(tmp); } else { this.Celular = 0; }

                if (arrCliente[15].ToString() != "") { this.Email = arrCliente[15].ToString().ToLower(); } else { this.Email = "null"; }
                if (arrCliente[16].ToString() != "") { this.SITE = arrCliente[16].ToString().ToLower(); } else { this.SITE = "null"; }

                if ((Acao == Enumeradores.eAcao.Cadastrar) && (this.Codigo == -1))
                {
                    this.Codigo = Convert.ToInt16(Classes.ADL.Cl_Dados.LerMaxima("tClientes", "Codigo"));
                }

                this.AdicionarParametros();

                List<string> Campos = new List<string>();
                Campos.Add("tClientes");
                Campos.Add("Codigo");
                Campos.Add("Nome");
                Campos.Add("Endereco");
                Campos.Add("Cep");
                Campos.Add("Cidade");
                Campos.Add("Bairro");
                Campos.Add("Estado");
                Campos.Add("Pais");
                Campos.Add("DataCadastro");
                Campos.Add("Rg");
                Campos.Add("Cpf");
                Campos.Add("InscricaoEstadual");
                Campos.Add("Cnpj");
                Campos.Add("Telefone");
                Campos.Add("Celular");
                Campos.Add("Email");
                Campos.Add("SITE");

                if (Acao == Enumeradores.eAcao.Cadastrar)
                {
                    Classes.ADL.Cl_Dados.Cadastrar(Campos, true);
                }
                else
                {
                    Classes.ADL.Cl_Dados.Atualizar(Campos, true);
                }
            }
            catch /*(Exception ex)*/
            {
                //MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        public static void Excluir(string pFiltro)
        {
            try
            {
                Classes.ADL.Cl_Dados.Excluir("tClientes", "Codigo", pFiltro);
            }
            catch {; }
        }

        public static void CarregarDataGridCliente(DataGridView dgv)
        {
            try
            {
                string sSql;
                sSql = "   SELECT";
                sSql += "  [Codigo]";
                sSql += ", [Nome]";
                sSql += ", [Endereco]";
                sSql += ", [Cep]";
                sSql += ", [Cidade]";
                sSql += ", [Bairro]";
                sSql += ", [Estado]";
                sSql += ", [Pais]";
                sSql += ", [DataCadastro]";
                sSql += ", [Rg]";
                sSql += ", [Cpf]";
                sSql += ", [InscricaoEstadual]";
                sSql += ", [Cnpj]";
                sSql += ", [Telefone]";
                sSql += ", [Celular]";
                sSql += ", [Email]";
                sSql += ", [Site]";
                sSql += "  FROM [tClientes]";

                dgv.DataSource = Classes.ADL.Cl_Dados.PegarDados(sSql);
                //clsGlobal.SetUpDataGridView(dgv);
            }
            catch { }
        }

        public static void CarregarClienteParaAnotar(DataGridView dgv)
        {
            try
            {
                string sSql;
                sSql = "   SELECT";
                sSql += "  [Codigo]";
                sSql += ", [Nome]";
                sSql += "  FROM [tClientes]";

                dgv.DataSource = ADL.Cl_Dados.PegarDados(sSql);
            }
            catch { }
        }

    }
}
