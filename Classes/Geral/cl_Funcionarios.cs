
using CasaMendes.Classes.ADL;
using CasaMendes.Classes.Estatica;
using CasaMendes.Propriedades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace CasaMendes.Classes
{
    public class cl_Funcionarios : cl_pBase
    {

        #region Variáveis

        ///*Cl_Dados*/ Cl_Dados;
        DataSet oDs;
        #endregion

        public cl_Funcionarios()
        {
            //Cl_Dados = new Cl_Dados();
        }

        ~cl_Funcionarios()
        {

            //if (Cl_Dados != null) { Cl_Dados = null; }
            if (oDs != null) { oDs.Dispose(); }
        }

        #region Manutenção de dados

        private void AdicionarParrametos()
        {
            if (Classes.ADL.Cl_Dados.Params.Count != 0) Classes.ADL.Cl_Dados.Params.Clear();
            Cl_Dados.AdicionarParametro("@Codigo", Codigo);
            Cl_Dados.AdicionarParametro("@Nome", Nome);
            Cl_Dados.AdicionarParametro("@Endereco", Endereco);
            Cl_Dados.AdicionarParametro("@Cep", Cep);
            Cl_Dados.AdicionarParametro("@Cidade", Cidade);
            Cl_Dados.AdicionarParametro("@Bairro", Bairro);
            Cl_Dados.AdicionarParametro("@Estado", Estado);
            Cl_Dados.AdicionarParametro("@Pais", Pais);
            Cl_Dados.AdicionarParametro("@RG", Rg);
            Cl_Dados.AdicionarParametro("@CPF", Cpf);
            Cl_Dados.AdicionarParametro("@EstadoCivil", EstadoCivil);
            Cl_Dados.AdicionarParametro("@DataDeNascimento", DataDeNascimento.ToShortDateString());
            Cl_Dados.AdicionarParametro("@Celular", Celular);
            Cl_Dados.AdicionarParametro("@Telefone", Telefone);
            Cl_Dados.AdicionarParametro("@CelularContato", CelularContato);
            Cl_Dados.AdicionarParametro("@Observacao", Observacao);

            if (!this.Foto.Equals(null))
            {
                Cl_Dados.AdicionarParametro("@Foto", Cl_Dados.MontarByte(Foto));
            }
        }

        private List<string> ListarCampos()
        {
            List<string> Campos = new List<string>();
            Campos.Add("tFuncionarios");
            Campos.Add("Codigo");
            Campos.Add("Nome");
            Campos.Add("Endereco");
            Campos.Add("Cep");
            Campos.Add("Cidade");
            Campos.Add("Bairro");
            Campos.Add("Estado");
            Campos.Add("Pais");
            Campos.Add("Rg");
            Campos.Add("Cpf");
            Campos.Add("EstadoCivil");
            Campos.Add("DataCadastro");
            Campos.Add("DataDeNascimento");
            Campos.Add("Celular");
            Campos.Add("Telefone");
            Campos.Add("CelularContato");
            Campos.Add("Observacao");
            Campos.Add("Foto");
            return Campos;
        }

        public void Novo()
        {
            try
            {
                string JaExiste = Cl_Dados.LerUmRegistro("SELECT Nome FROM tFuncionarios WHERE Nome = " + Nome);//  Verif(ica se o usuário não está cadastrado no controle de acesso.
                if (JaExiste == Nome) // Se o usuário já estiver cadastrado imforma e sai,caso coontrário procegue com o cadastro.
                {
                    MessageBox.Show("O nome: " + this.Nome + " já existe no cadastro.", "Cadastro.");
                    return;
                }

                Codigo = Convert.ToInt16(Cl_Dados.LerMaxima("tFuncionarios", "Codigo"));
                if (Codigo == 0) { Codigo = 1; }

                AdicionarParrametos();

                Cl_Dados.AdicionarParametro("@DataCadastro", DataCadastro);

                Cl_Dados.Cadastrar(ListarCampos(), true);//Chama o método cadastrar da classe Dados.
            }
            catch (Exception ex)
            {
                Classes.Estatica.clsGlobal.RegistrarLogDeErros(0, "Linha: " + ex.Message);
            }
        }

        public void Atualizar()
        {
            try
            {
                List<string> Campos = new List<string>();
                Campos.Add("tFuncionarios");
                Campos.Add("Codigo");
                Campos.Add("Nome");
                Campos.Add("Endereco");
                Campos.Add("Cep");
                Campos.Add("Cidade");
                Campos.Add("Bairro");
                Campos.Add("Estado");
                Campos.Add("Pais");
                Campos.Add("Rg");
                Campos.Add("Cpf");
                Campos.Add("EstadoCivil");
                Campos.Add("DataDeNascimento");
                Campos.Add("Celular");
                Campos.Add("Telefone");
                Campos.Add("CelularContato");
                Campos.Add("Observacao");
                Campos.Add("Foto");

                AdicionarParrametos();
                Cl_Dados.Atualizar(Campos,true);//Chama o método atualizar da classe Dados.
            }
            catch (Exception ex)
            {
                clsGlobal.RegistrarLogDeErros(0, clsMensagens.M00003 + ": " + ex.Message);
            }
        }

        public void Excluir(string Filtro)
        {
            Cl_Dados.Excluir("tFuncionarios", "Codigo", Filtro);
        }

        #endregion

        #region Baixar dados

        public void CarregarDataGridFuncionarios(DataGridView dgvNomes)
        {
            try
            {
                string sSql = "SELECT Nome FROM tFuncionarios ORDER BY Nome";
                dgvNomes.DataSource = Cl_Dados.PegarDados(sSql);
            }
            catch { }
        }

        public void CarregarCaixaCombo(ComboBox cb)
        {
            try
            {
                cb.DataSource = Cl_Dados.LerUmRegistro("SELECT Nome FROM tFuncionarios");
            }
            catch
            {
            }
        }

        public string BuscarCodigoFuncionario(string Filtro)
        {
            try
            {
                string sSql = "SELECT tFuncionarios.Codigo FROM tFuncionarios WHERE Nome = '" + Filtro + "'";
                return Cl_Dados.LerUmRegistro(sSql);
            }
            catch
            {
                return "0";
            }
        }

        public void Buscar(string Filtro)
        {
            try
            {
                string sSql = String.Concat("SELECT * FROM tFuncionarios WHERE (Nome = '", Filtro, "')");
                oDs = Cl_Dados.CarregarDataset(sSql, "tFuncionarios");

                if (Cl_Dados.MaximaPosicao > 0)
                {
                    BaixarDados();
                }
            }
            catch
            {
            }
        }

        private void BaixarDados()
        {
            foreach (DataRow Linha in oDs.Tables["tFuncionarios"].Rows)
            {
                //===============================================================================
                Codigo = 0;
                Nome = null;
                Endereco = null;
                Cep = 0;
                Cidade = null;
                Bairro = null;
                Estado = null;
                Pais = null;
                Rg = 0;
                Cpf = 0;
                EstadoCivil = null;
                DataDeNascimento = DateTime.Now;
                Celular = 0;
                Telefone = 0;
                CelularContato = 0;
                Observacao = null;
                Foto = null;

                //===============================================================================
                Codigo = Convert.ToInt16(Linha["Codigo"].ToString());
                Nome = Convert.ToString(Linha["Nome"].ToString());
                Endereco = Convert.ToString(Linha["Endereco"].ToString());
                Cep = Convert.ToDecimal(Linha["Cep"]);
                Cidade = Convert.ToString(Linha["Cidade"].ToString());
                Bairro = Convert.ToString(Linha["Bairro"].ToString());
                Estado = Convert.ToString(Linha["Estado"].ToString());
                Pais = Convert.ToString(Linha["Pais"].ToString());
                Rg = Convert.ToDecimal(Linha["RG"]);
                Cpf = Convert.ToDecimal(Linha["CPF"]);
                EstadoCivil = Convert.ToString(Linha["EstadoCivil"].ToString());
                DataDeNascimento = Convert.ToDateTime(Linha["DataDeNascimento"]);
                //Email = Convert.ToString(Linha["Email"].ToString());
                Celular = Convert.ToDecimal(Linha["Celular"]);
                Telefone = Convert.ToDecimal(Linha["Telefone"]);
                CelularContato = Convert.ToDecimal(Linha["CelularContato"]);
                Observacao = Linha["Observacao"].ToString();

                if (Linha["Foto"] != System.DBNull.Value)
                {
                    Foto = Cl_Dados.MontarImage((byte[])Linha["Foto"]);
                }
            }
        }

        #endregion

    }
}
