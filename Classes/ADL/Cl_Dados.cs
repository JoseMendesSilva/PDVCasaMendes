
using CasaMendes.Classes.Estatica;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CasaMendes.Classes.ADL
{
    //Esta classe recebeu o modificador static, portanto, não pode se instãnciada.
    public static class Cl_Dados
    {
        //======================================================================================================
        #region Variáveis
        //====================================================================================================
        private static SqlConnection oConexao;
        private static SqlCommand oComando;
        private static SqlDataAdapter oDa;
        private static SqlDataReader oDr;
        private static SqlTransaction oTransacao;
        private static DataTable oDt;

        //======================================================================================================
        public static List<SqlParameter> Params = null;
        private static string sConexao; //= "Data Source = " + clsGlobal.ValidarDiretorio(sPath, "loja.mdf");;
        public static string sSql;
        private static bool Retorno = false;
        private static string sPath;// = clsGlobal.ValidarDiretorio(clsGlobal.sCaminho, "MDF");

        // recupera o caminho da base de dados no arquivo AppSettings
        // private string caminho = ConfigurationSettings.AppSettings["CaminhoDaBaseDeDados"];

        #endregion Fim da região das vriáveis

        //======================================================================================================
        #region Construtorres.

        //======================================================================================================
        public static void Cl_DadosInicio()
        {
            sPath = clsGlobal.ValidarDiretorio(clsGlobal.sCaminho, "MDF");
            var ConexaoDir = clsGlobal.ValidarDiretorio(sPath, "loja.mdf");
               sConexao = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" +  ConexaoDir  + ";Integrated Security=True";

            if (Params == null) Params = new List<SqlParameter>();

        }

        #endregion Fim da região, construtorres.

        //======================================================================================================
        #region Criar base de dados.

        ////======================================================================================================
        //private static void CriarDb()
        //{
        //    try
        //    {
        //        //SqlCeEngine.
        //        //using (SqlCeEngine motor = new SqlCeEngine(sConexao))
        //        //{
        //        //    //motor.Upgrade();
        //        //    motor.CreateDatabase();

        //        //    oConexao = new SqlConnection(sConexao);
        //        //    oConexao.Open();

        //        //    #region CREATE TABLE.

        //        //    //==========================================================================================
        //        //    #region CREATE TABLE Clientes.
        //        //    //=============================================Tabela Clientes==================================================================================   
        //        //    sSql = "CREATE TABLE [tClientes]" +
        //        //           "(" +
        //        //           "[Codigo]            NUMERIC(38,0) NOT NULL, " +
        //        //           "[Nome]              NVARCHAR(50)  NOT NULL, " +
        //        //           "[Endereco]          NVARCHAR(50)      NULL, " +
        //        //           "[Cep]               NVARCHAR(10)      NULL, " +
        //        //           "[Cidade]            NVARCHAR(30)      NULL, " +
        //        //           "[Bairro]            NVARCHAR(30)      NULL, " +
        //        //           "[Estado]            NVARCHAR(30)      NULL, " +
        //        //           "[Pais]              NVARCHAR(30)      NULL, " +
        //        //           "[DataCadastro]      DATETIME          NULL, " +
        //        //           "[Rg]                NVARCHAR(20)      NULL, " +
        //        //           "[Cpf]               NVARCHAR(20)      NULL, " +
        //        //           "[InscricaoEstadual] NVARCHAR(20)      NULL, " +
        //        //           "[Cnpj]              NVARCHAR(20)      NULL, " +
        //        //           "[Telefone]          NVARCHAR(20)      NULL, " +
        //        //           "[Celular]           NVARCHAR(20)      NULL, " +
        //        //           "[Email]             NVARCHAR(150)     NULL, " +
        //        //           "[Site]              NVARCHAR(150)     NULL, " +
        //        //           "CONSTRAINT[PK_tClientes] PRIMARY KEY([Codigo]));";
        //        //    oComando = new SqlCommand(sSql, oConexao);
        //        //    oComando.ExecuteNonQuery();
        //        //    oComando.Dispose();

        //        //    //=============================================Tabela Controle de acesso==================================================================================   
        //        //    sSql = "CREATE TABLE [tControleAcesso](" +
        //        //    "[CodigoControleAcesso] NUMERIC(38,0)           NOT NULL, " +
        //        //    "[CodigoFuncionario]    NUMERIC(38,0)           NOT NULL, " +
        //        //    "[Senha] NVARCHAR(15)                NOT NULL, " +
        //        //    "[NivelAcesso]          INT          NOT NULL, " +
        //        //    "[Cadastrar]            BIT          NOT NULL, " +
        //        //    "[Atualizar] BIT                     NOT NULL, " +
        //        //    "[Excluir] BIT                       NOT NULL, " +
        //        //    "[AbrirCaixa] BIT                    NOT NULL, " +
        //        //    "[FecharCaixa] BIT                   NOT NULL, " +
        //        //    "[Sangria] BIT                       NOT NULL, " +
        //        //    "CONSTRAINT[PK_tControleAcesso] PRIMARY KEY([CodigoControleAcesso]));";
        //        //    oComando = new SqlCommand(sSql, oConexao);
        //        //    oComando.ExecuteNonQuery();
        //        //    oComando.Dispose();

        //        //    #endregion

        //        //    //==========================================================================================
        //        //    #region CREATE TABLE Fornecedores.
        //        //    //=============================================Tabela fornecedores==================================================================================   
        //        //    //=============================================Dados pessoais==============================================   
        //        //    sSql = "CREATE TABLE [tFornecedores](" +
        //        //           "    [CodigoDoFornecedor] NUMERIC(38,0) NOT NULL, " +
        //        //           "    [RazaoSocial]        NVARCHAR(50)  NOT NULL, " +
        //        //           "    [Endereco]           NVARCHAR(50)  NULL,     " +
        //        //           "    [Cep]                NUMERIC(8)    NULL,     " +
        //        //           "    [Cidade]             NVARCHAR(30)  NULL,     " +
        //        //           "    [Bairro]             NVARCHAR(30)  NULL,     " +
        //        //           "    [Estado]             NVARCHAR(20)  NULL,     " +
        //        //           "    [DataCadastro]       DATETIME      NULL,     " +
        //        //    //=============================================Documentos==================================================================================   
        //        //           "    [Cnpj]               NUMERIC(15)   NULL,     " +
        //        //           "    [InscricaoEstadual]  NUMERIC(14)   NULL,     " +
        //        //    //=============================================Contatos==================================================================================   
        //        //           "    [Telefone]           NUMERIC(14)   NULL,     " +
        //        //           "    [Celular]            NUMERIC(13)   NULL,     " +
        //        //           "    [Site]               NVARCHAR(82)  NULL,     " +
        //        //           "    [Email]              NVARCHAR(82)  NULL,     " +
        //        //           "CONSTRAINT[PK_tFornecedores] PRIMARY KEY([CodigoDoFornecedor]));";
        //        //    oComando = new SqlCommand(sSql, oConexao);
        //        //    oComando.ExecuteNonQuery();
        //        //    oComando.Dispose();

        //        //    #endregion

        //        //    //==========================================================================================
        //        //    #region CREATE TABLE Funcionarios.
        //        //    //=============================================Tabela funcionarios==================================================================================   
        //        //    sSql = "CREATE TABLE [tFuncionarios](" +
        //        //      "[Codigo]           NUMERIC(38,0)  NOT   NULL, " +
        //        //      "[Nome]             NVARCHAR(50)   NOT   NULL, " +
        //        //      "[Endereco]         NVARCHAR(50)         NULL, " +
        //        //      "[Cep]              NUMERIC(8,0)         NULL, " +
        //        //      "[Cidade]           NVARCHAR(25)         NULL, " +
        //        //      "[Bairro]           NVARCHAR(25)         NULL, " +
        //        //      "[Estado]           NVARCHAR(25)         NULL, " +
        //        //      "[Pais]             NVARCHAR(25)         NULL, " +
        //        //      "[RG]               NUMERIC(14,0)        NULL, " +
        //        //      "[CPF]              NUMERIC(11,0)        NULL, " +
        //        //      "[EstadoCivil]      NVARCHAR(25)         NULL, " +
        //        //      "[DataCadastro]     DATETIME             NULL, " +
        //        //      "[DataDeNascimento] DATETIME             NULL, " +
        //        //      "[Celular]          NUMERIC(11,0)        NULL, " +
        //        //      "[Telefone]         NUMERIC(11,0)        NULL, " +
        //        //      "[CelularContato]   NUMERIC(11,0)        NULL, " +
        //        //      "[Observacao]       NTEXT                NULL, " +
        //        //      "[Foto]             IMAGE                NULL, " +
        //        //       "CONSTRAINT[PK_tFuncionarios] PRIMARY KEY([Codigo]));";
        //        //    oComando = new SqlCommand(sSql, oConexao);
        //        //    oComando.ExecuteNonQuery();
        //        //    oComando.Dispose();

        //        //    #endregion

        //        //    //==========================================================================================
        //        //    #region CREATE TABLE Gestao.
        //        //    //=============================================Tabela gestão==================================================================================   
        //        //    sSql = "CREATE TABLE [tGestao](" +
        //        //           "[CodigoGestao] NUMERIC(38,0)    NOT NULL, " +
        //        //           "[Gestao]       NVARCHAR(50)     NOT NULL, " +
        //        //           "[Impostos]     NUMERIC(10, 2)   NOT NULL, " +
        //        //           "[CustoFixo]    NUMERIC(10, 2)   NOT NULL, " +
        //        //           "[Frete]        NUMERIC(10, 2)   NOT NULL, " +
        //        //           "[Encargos]     NUMERIC(10, 2)   NOT NULL, " +
        //        //           "[Lucro]        NUMERIC(10, 2)   NOT NULL, " +
        //        //           "[Anotar]       NUMERIC(10, 2)       NULL, " +
        //        //           "[Promocao]     NUMERIC(10, 2)       NULL, " +
        //        //           "CONSTRAINT[PK_tGestao] PRIMARY KEY([CodigoGestao]));";
        //        //    oComando = new SqlCommand(sSql, oConexao);
        //        //    oComando.ExecuteNonQuery();
        //        //    oComando.Dispose();

        //        //    #endregion

        //        //    //==========================================================================================
        //        //    #region CREATE TABLE Inadimplentes.
        //        //    //=============================================Tabela gestão==================================================================================   
        //        //    sSql = "CREATE TABLE [tInadimplentes](" +
        //        //           "[CodigotInadimplente] int              NOT NULL , " +
        //        //           "[CodigoCliente]       NUMERIC(38,0)    NOT NULL DEFAULT 0.00, " +
        //        //           "[Status]              NVARCHAR(20)     NOT NULL DEFAULT 'Liberado', " +
        //        //           "[Data]                datetime             NULL DEFAULT GETDATE(), " +
        //        //           "[DividaAtiva]         BIT                  NULL DEFAULT 0.00, " +
        //        //           "[Encargos]            NUMERIC(10, 4)       NULL DEFAULT 0.0000, " +
        //        //           "[Observacao]          NTEXT                NULL DEFAULT 'null', " +
        //        //           "CONSTRAINT[PK_tInadimplentes] PRIMARY KEY([CodigotInadimplente]));";
        //        //    oComando = new SqlCommand(sSql, oConexao);
        //        //    oComando.ExecuteNonQuery();
        //        //    oComando.Dispose();

        //        //    #endregion

        //        //    //==========================================================================================
        //        //    #region CREATE TABLE PreVendas.

        //        //    sSql = "CREATE TABLE[tPreVendas] (" +
        //        //           "[CodigoDaVenda]   NUMERIC(38,0)  NOT NULL, " +
        //        //           "[CodigoDoCliente] NUMERIC(38,0)  NOT NULL DEFAULT 0, " +
        //        //           "[CodigoDeBarras]  NUMERIC(38,0)  NOT NULL DEFAULT 0, " +
        //        //           "[NumeroDaVenda]   nvarchar(30)   NOT NULL, " +
        //        //           "[Quantidade]      NUMERIC(38,0)  NOT NULL DEFAULT 0, " +
        //        //           "[DataDaVenda]     datetime       NOT NULL, " +
        //        //           "[TipoDeVenda]     nvarchar(7)    NOT NULL DEFAULT N'A VISTA', " +
        //        //           "[StatusDaVenda]   bit            NOT NULL DEFAULT 0, " +
        //        //           "[Dinheiro]        money                   DEFAULT 0.00, " +
        //        //           "[Troco]           money                   DEFAULT 0.00, " +
        //        //           "[Parcela]         money                   DEFAULT 0.00, " +
        //        //           "CONSTRAINT[PK_tPreVendas] PRIMARY KEY([CodigoDaVenda]));";

        //        //    oComando = new SqlCommand(sSql, oConexao);
        //        //    oComando.ExecuteNonQuery();
        //        //    oComando.Dispose();

        //        //    #endregion

        //        //    #region CREATE TABLE Produtos.

        //        //    //=============================================Tabela produtos==================================================================================   
        //        //    sSql = "CREATE TABLE [tProdutos]( " +
        //        //    "[CodigoDeBarras]     numeric(38, 0) NOT NULL DEFAULT - 1 PRIMARY KEY, " +
        //        //    "[CodigoDoFornecedor] bigint         NOT NULL DEFAULT 0, " +
        //        //    "[Produto]            nvarchar(50)   NOT NULL DEFAULT N'NULL', " +
        //        //    "[DataDeValidade]     datetime                DEFAULT GETDATE(), " +
        //        //    "[ValorCompra]        money                   DEFAULT 0, " +
        //        //    "[Quantidade]         numeric(38, 4)          DEFAULT 0, " +
        //        //    "[Estoque]            numeric(38, 4)          DEFAULT 0, " +
        //        //    "[PrecoUnitario]      money                   DEFAULT 0, " +
        //        //    "[PrecoDeVenda]       money                   DEFAULT 0, " +
        //        //    "[Desconto]           money                   DEFAULT 0, " +
        //        //    "[Foto]               image                   DEFAULT null, " +
        //        //    "[ID_Produto]         int            NOT NULL DEFAULT 0)";

        //        //    oComando = new SqlCommand(sSql, oConexao);
        //        //    oComando.ExecuteNonQuery();
        //        //    oComando.Dispose();

        //        //    #endregion

        //        //    #region CREATE TABLE vendas.

        //        //    //=============================================Tabela vendas==================================================================================   
        //        //    sSql = "CREATE TABLE [tVendas](" +
        //        //           "[CodigoVenda] NUMERIC(38,0)                NOT NULL, " +
        //        //           "[NumeroCaixa] INT                          NOT NULL, " +
        //        //           "[DataVenda]   DATETIME                     NOT NULL, " +
        //        //           "[SubTotal]    MONEY                        NOT NULL, " +
        //        //           "[Status]      NVARCHAR(10)                 NOT NULL, " +
        //        //           "[Parcela]     MONEY                            NULL, " +
        //        //           "CONSTRAINT[PK_tVendas] PRIMARY KEY([CodigoVenda]));";
        //        //    oComando = new SqlCommand(sSql, oConexao);
        //        //    oComando.ExecuteNonQuery();
        //        //    oComando.Dispose();
        //        //    oConexao.Dispose();

        //        //    #endregion CREATE TABLE.

        //        //    #endregion

        //        //    #region INSERT INTO.

        //        //    #region CREATE TABLE Funcionarios.
        //        //    //=======================================Funcionarios========================================================================================   
        //        //    sSql = "INSERT INTO [tFuncionarios] " +
        //        //           "(Codigo " +
        //        //           ",Nome " +
        //        //           ",Endereco " +
        //        //           ",Cep " +
        //        //           ",Cidade " +
        //        //           ",Bairro " +
        //        //           ",Estado " +
        //        //           ",Pais" +
        //        //           ",RG " +
        //        //           ",CPF " +
        //        //           ",EstadoCivil " +
        //        //           ",DataCadastro " +
        //        //           ",DataDeNascimento " +
        //        //           ",Celular" +
        //        //           ",Telefone " +
        //        //           ",CelularContato" +
        //        //           ",Observacao" +
        //        //           ") " +
        //        //           "VALUES (" +
        //        //           "@Codigo, " +
        //        //           "@Nome, " +
        //        //           "@Endereco, " +
        //        //           "@Cep, " +
        //        //           "@Cidade, " +
        //        //           "@Bairro,  " +
        //        //           "@Estado,  " +
        //        //           "@Pais, " +
        //        //           "@RG,  " +
        //        //           "@CPF, " +
        //        //           "@EstadoCivil, " +
        //        //           "@DataCadastro, " +
        //        //           "@DataDeNascimento, " +
        //        //           "@Celular, " +
        //        //           "@Telefone, " +
        //        //           "@CelularContato, " +
        //        //           "@Observacao " +
        //        //           ")";
        //        //    //oComando = new SqlCommand(sSql, oConexao);

        //        //    Cl_Dados.AdicionarParametro("@Codigo", 1);
        //        //    Cl_Dados.AdicionarParametro("@Nome", "Usuário padrão, accesso total.");
        //        //    Cl_Dados.AdicionarParametro("@Endereco", "null");
        //        //    Cl_Dados.AdicionarParametro("@Cep", 1);
        //        //    Cl_Dados.AdicionarParametro("@Cidade", "null");
        //        //    Cl_Dados.AdicionarParametro("@Bairro", "null");
        //        //    Cl_Dados.AdicionarParametro("@Estado", "null");
        //        //    Cl_Dados.AdicionarParametro("@Pais", "null");
        //        //    Cl_Dados.AdicionarParametro("@RG", 0);
        //        //    Cl_Dados.AdicionarParametro("@CPF", 0);
        //        //    Cl_Dados.AdicionarParametro("@EstadoCivil", "null");
        //        //    Cl_Dados.AdicionarParametro("@DataCadastro", DateTime.Now);
        //        //    Cl_Dados.AdicionarParametro("@DataDeNascimento", DateTime.Now);
        //        //    Cl_Dados.AdicionarParametro("@Celular", 0);
        //        //    Cl_Dados.AdicionarParametro("@Telefone", 0);
        //        //    Cl_Dados.AdicionarParametro("@CelularContato", 0);
        //        //    Cl_Dados.AdicionarParametro("@Observacao", "null");

        //        //    Cl_Dados.ExecutarQuery(true);

        //        //    #endregion

        //        //    //#region CREATE TABLE Controle de Acesso.

        //        //    ////=======================================tControleAcesso========================================================================================   
        //        //    //sSql = "INSERT INTO[tControleAcesso] " +
        //        //    //"([CodigoControleAcesso]" +
        //        //    //"  ,[CodigoFuncionario]" +
        //        //    //"	,[Senha]" +
        //        //    //"	,[NivelAcesso]" +
        //        //    //"	,[Cadastrar] " +
        //        //    //"	,[Atualizar]" +
        //        //    //"	,[Excluir]" +
        //        //    //"	,[AbrirCaixa]" +
        //        //    //"	,[FecharCaixa]" +
        //        //    //"	,[Sangria]) " +
        //        //    //"VALUES" +
        //        //    //"	(@CodigoControleAcesso" +
        //        //    //"	,@CodigoFuncionario" +
        //        //    //"	,@Senha               " +
        //        //    //"	,@NivelAcesso       " +
        //        //    //"	,@Cadastrar          " +
        //        //    //"	,@Atualizar         " +
        //        //    //"	,@Excluir             " +
        //        //    //"	,@AbrirCaixa          " +
        //        //    //"	,@FecharCaixa         " +
        //        //    //"	,@Sangria);            ";

        //        //    //Cl_Dados.AdicionarParametro("@CodigoControleAcesso", 1);
        //        //    //Cl_Dados.AdicionarParametro("@CodigoFuncionario", 1);
        //        //    //Cl_Dados.AdicionarParametro("@Senha", "000001");
        //        //    //Cl_Dados.AdicionarParametro("@NivelAcesso", 1);
        //        //    //Cl_Dados.AdicionarParametro("@Cadastrar", true);
        //        //    //Cl_Dados.AdicionarParametro("@Atualizar", true);
        //        //    //Cl_Dados.AdicionarParametro("@Excluir", true);
        //        //    //Cl_Dados.AdicionarParametro("@AbrirCaixa", true);
        //        //    //Cl_Dados.AdicionarParametro("@FecharCaixa", true);
        //        //    //Cl_Dados.AdicionarParametro("@Sangria", true);

        //        //    //Cl_Dados.ExecutarQuery(true);

        //        //    //#endregion

        //        //    #region CREATE TABLE vendas.

        //        //    #endregion

        //        //    #region CREATE TABLE vendas.

        //        //    #endregion

        //        //    #region CREATE TABLE vendas.

        //        //    #endregion

        //        //    #region CREATE TABLE vendas.

        //        //    #endregion

        //        //    #endregion INSERT INTO.
        //        //}
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, Application.ProductName);
        //    }
        //}

        #endregion Fim da região,  Criar base de dados..

        //======================================================================================================
        #region Download de dados.
 
        //======================================================================================================
        public static DataSet CarregarDataset(string sSql, string sTabela)
        {
            try
            {
                using (oConexao = new SqlConnection(sConexao))
                {
                    oConexao.Open();
                    DataSet oDs = new DataSet(sTabela);
                    oDa = new SqlDataAdapter
                    {
                        SelectCommand = new SqlCommand(sSql, oConexao)
                    };
                    oDs.Clear();

                    oDs.Tables.Add(sTabela);
                    oDs.Tables[sTabela].BeginLoadData();
                    oDa.Fill(oDs, sTabela);
                    MaximaPosicao = Convert.ToInt16(oDs.Tables[sTabela].Rows.Count);
                    oDa.Dispose();
                    oConexao.Dispose();
                    oDs.Tables[sTabela].EndLoadData();

                    return oDs;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + " - " + Application.ProductName);
                //return null;
            }
        }

        //======================================================================================================
        public static string RetornoEscalarDeUmRegistro(string sSql)
        {
            string strTemp = "";
            try
            {
                using (oConexao = new SqlConnection(sConexao))
                {
                    oConexao.Open();
                    oComando = new SqlCommand(sSql, oConexao);

                    if (Params.Count != 0)
                    {
                        foreach (SqlParameter p in Params)
                        {
                            oComando.Parameters.Add(p);
                        }
                        Params.Clear();
                    }

                    strTemp = oComando.ExecuteScalar().ToString();

                    oComando.Dispose();
                    oConexao.Dispose();
                }
            }
            catch (Exception ex)
            {
                Params.Clear();
                throw new Exception(ex.Message);
            }
            return strTemp;
        }

        //======================================================================================================
        public static string LerUmRegistro(string sSql)
        {
            try
            {
                using (oConexao = new SqlConnection(sConexao))
                {
                    oConexao.Open();
                    oComando = new SqlCommand(sSql, oConexao);

                    if (Params.Count != 0)
                    {
                        foreach (SqlParameter p in Params)
                        {
                            oComando.Parameters.Add(p);
                        }
                        Params.Clear();
                    }

                    oDa = new SqlDataAdapter();
                    oDr = oComando.ExecuteReader();

                    string strTemp = "";

                    while (oDr.Read())
                    {
                        strTemp = oDr[0].ToString();
                    }

                    oDa.Dispose();
                    oDr.Dispose();
                    oComando.Dispose();
                    oConexao.Dispose();
                    return strTemp;
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //======================================================================================================
        public static string LerMaxima(string Tabela, string sPk)
        {
            try
            {
                string sSql = "SELECT MAX([" + sPk + "] + 1) AS Maximo FROM [" + Tabela + "]";
                using (oConexao = new SqlConnection(sConexao))
                {
                    oConexao.Open();
                    oComando = new SqlCommand(sSql, oConexao);

                    oDa = new SqlDataAdapter();
                    oDr = oComando.ExecuteReader();

                    string strTemp = "";

                    while (oDr.Read())
                    {
                        strTemp = oDr[0].ToString();
                    }

                    oDa.Dispose();
                    oDr.Dispose();
                    oComando.Dispose();
                    oConexao.Dispose();

                    if (strTemp == "") { return "1"; }
                    else { return strTemp; }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //======================================================================================================
        public static ArrayList PegarArrayListDados(string sSql)
        {
            ArrayList arr = new ArrayList();
            try
            {
                using (oConexao = new SqlConnection(sConexao))
                {
                    oConexao.Open();
                    oComando = new SqlCommand(sSql, oConexao);

                    foreach (SqlParameter p in Params)
                    {
                        oComando.Parameters.Add(p);
                    }
                    Params.Clear();

                    oDr = oComando.ExecuteReader();

                    while (oDr.Read())
                    {
                        arr.Add((string)oDr.GetSqlString(0).ToString());
                    }
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                oDa.Dispose();
                oDr.Dispose();
                oComando.Dispose();
                oConexao.Dispose();
            }
            return arr;
        }

        //======================================================================================================
        public static ArrayList ListarDados(string sSql, string campo = null, string filto = null)
        {
            ArrayList arr = new ArrayList();
            try
            {
                using (oConexao = new SqlConnection(sConexao))
                {

                    oConexao.Open();
                    //string commandText = $"@{sSql}";
                    string commandText = sSql;
                    oComando = new SqlCommand(commandText, oConexao);


                    oComando.CommandText = commandText;
                    oComando.Parameters.AddWithValue($"@{campo}", filto);

                    oDr = oComando.ExecuteReader();

                    //int c = 0;
                    //if (oDr.HasRows)
                    //{
                        while (oDr.Read())
                         {
                            for (int i = 0; i < oDr.FieldCount; i++)
                            {
                                string x = oDr.GetValue(i).ToString();
                                if (x == null) continue;
                                arr.Add(x);
                            }
                        }
                    
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw new Exception( ex.Message );
            }
            finally
            {
                oDa.Dispose();
                oDr.Dispose();
                oComando.Dispose();
                oConexao.Dispose();
            }
            return arr;

        }

        //***************************************************************//
//        public static ArrayList Demo(){
//    using (SqlConnection cn = new SqlConnection(ConnectionString))
//    {

//        string commandText = @"SELECT Identifier,CompanyName,ContactName " + 
//                                "FROM Customers " + 
//                                "WHERE ContactTitle = @ContactTitle AND Country = @Country";

//        using (SqlCommand cmd = new SqlCommand(commandText, cn))
//        {
//            cmd.CommandText = commandText;
//            cmd.Parameters.AddWithValue("@ContactTitle", "Owner");
//            cmd.Parameters.AddWithValue("@Country", "Mexico");

//            cn.Open();
//            SqlDataReader  reader = cmd.ExecuteReader();
//            if (reader.HasRows)
//            {
//                while (reader.Read())
//                {
//                    Console.WriteLine($"Id: {reader.GetInt64(0)} Company: {reader.GetString(1)}");
//                }
//            }
//        }
//    }
//}
        //***************************************************************//
        //======================================================================================================

        public static DataTable ListarDescontos(string sSql)
        {
            try
            {
                using (oConexao = new SqlConnection(sConexao))
                {

                    oConexao.Open();
                    oDt = new DataTable();
                    oDa = new SqlDataAdapter();
                    oDt.Locale = System.Globalization.CultureInfo.InvariantCulture;
                    SqlCommand oComando = new SqlCommand(sSql, oConexao);
                    oDa.SelectCommand = oComando;

                    oDa.Fill(oDt);

                    oComando.Dispose();
                    oDa.Dispose();
                    oConexao.Dispose();

                    return oDt;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                
            }
        }

        //======================================================================================================
        public static DataTable PegarDados(string sSql, bool b = false)
        {
            try
            {
                using (oConexao = new SqlConnection(sConexao))
                {
                    oConexao.Open();
                    oDt = new DataTable();
                    oDa = new SqlDataAdapter();
                    oDt.Locale = System.Globalization.CultureInfo.InvariantCulture;
                    SqlCommand oComando = new SqlCommand(sSql, oConexao);
                    oDa.SelectCommand = oComando;

                    if (b == true)
                    {
                        foreach (SqlParameter p in Params)
                        {
                            oComando.Parameters.Add(p);
                        }
                        Params.Clear();
                    }

                    oDa.Fill(oDt);

                    oComando.Dispose();
                    oDa.Dispose();
                    oConexao.Dispose();

                    return oDt;
                }
            }
            catch(Exception ex)
            {
                if (b == true)
                {
                    Params.Clear();
                }
                oDa.Dispose();
                oConexao.Dispose();
                throw new Exception(ex.Message);
            }
        }

        //======================================================================================================
        public static DataTable PegarDados(string sSql)
        {
            try
            {
                using (oConexao = new SqlConnection(sConexao))
                {
                    oConexao.Open();
                    oDt = new DataTable();
                    oDa = new SqlDataAdapter();
                    oDt.Locale = System.Globalization.CultureInfo.InvariantCulture;
                    SqlCommand oComando = new SqlCommand(sSql, oConexao);
                    oDa.SelectCommand = oComando;

                    oDa.Fill(oDt);

                    oComando.Dispose();
                    oDa.Dispose();
                    oConexao.Dispose();

                    return oDt;
                }
            }
            catch(Exception ex)
            {
                oDa.Dispose();
                oConexao.Dispose();
                MessageBox.Show(ex.Message);
                throw new Exception(ex.Message);
            }
        }

        //======================================================================================================
        #region Páginar registros.

        //======================================================================================================
        private static Int16 _Posicao = 0;
        private static Int16 _MaximaPosicao = 0;

        //======================================================================================================
        public static Int16 MaximaPosicao
        {
            get { return _MaximaPosicao; }
            set { _MaximaPosicao = value; }
        }

        //======================================================================================================
        public static Int16 Posicao
        {
            get { return _Posicao; }
            set { _Posicao = value; }
        }

        //======================================================================================================
        internal static bool ValidarPosicao(Enumeradores.eIrPara _Acao)
        {
            bool Result = false;
            try
            {
                if (MaximaPosicao > 0)
                {

                    if ((Posicao > 0) && Convert.ToBoolean(_Acao = Enumeradores.eIrPara.Primeiro))
                    {
                        Result = true;
                    }

                    else if (Cl_Dados.Posicao < (MaximaPosicao - 1) && Convert.ToBoolean(_Acao = Enumeradores.eIrPara.Proximo))
                    {
                        Result = true;
                    }

                    else if ((Posicao < MaximaPosicao) && Convert.ToBoolean(_Acao = Enumeradores.eIrPara.Ultimo))
                    {
                        Result = true;
                    }

                    else if ((Posicao > 0) && Convert.ToBoolean(_Acao = Enumeradores.eIrPara.Voltar))
                    {
                        Result = true;
                    }

                    else
                    {
                        Result = false;
                    }
                }
                return Result;
            }
            catch
            {
                return false;
            }
        }

        //======================================================================================================
        public static void Primeiro()
        {
            if (ValidarPosicao(Enumeradores.eIrPara.Primeiro))
            {
                Posicao = 0;
            }
            else
            {
                return;
            }
        }

        //======================================================================================================
        public static void Proximo()
        {
            if (ValidarPosicao(Enumeradores.eIrPara.Proximo))
            {
                Posicao += 1;
            }
            else
            {
                return;
            }
        }

        //======================================================================================================
        public static void Ultimo()
        {
            if (ValidarPosicao(Enumeradores.eIrPara.Ultimo))
            {
                Posicao = Convert.ToInt16(MaximaPosicao - 1);
            }
            else
            {
                return;
            }
        }

        //======================================================================================================
        public static void Voltar()
        {
            if (ValidarPosicao(Enumeradores.eIrPara.Voltar))
            {
                Posicao -= 1;
            }
            else
            {
                return;
            }
        }
        #endregion fim da região páginar registros.

        #endregion Fim da região,  Download de dados.

        //======================================================================================================
        #region Tratamento de imagens.

        //======================================================================================================78400922
        public static Image MontarImage(byte[] byteArrayIn)
        {
            // converte bytearray para image
            using (MemoryStream mStream = new MemoryStream(byteArrayIn))
            {
                return Image.FromStream(mStream);
            }
        }

        //======================================================================================================
        public static byte[] MontarByte(Image pImg)
        {
            System.Drawing.ImageConverter converter = new System.Drawing.ImageConverter();

            byte[] imageData = (byte[])converter.ConvertTo(pImg, typeof(byte[]));
            return imageData;
        }

        #endregion Fim da região,  tratamento de imagens.

        //======================================================================================================
        #region Manutenção de dados.
        //======================================================================================================
        private static void MontarQuerySql(List<String> Campos, byte b = 1)
        {
            string sCampos = null;
            string sVars = null;
            Int16 i;
            Int16 Count = Convert.ToInt16(Campos.Count - 1);
            switch (b)
            {
                case 1://Cadastar

                    for (i = 1; i <= Count; i++)
                    {
                        if (i < Count)
                        {
                            sVars += Campos[i].ToString() + ", ";
                            sCampos += "@" + Campos[i] + ", ";
                        }
                        else
                        {
                            sVars += Campos[i].ToString() + " ";
                            sCampos += "@" + Campos[i] + " ";
                        }
                    }

                    sSql = string.Concat("INSERT INTO ", Campos[0].ToString(), " (", sVars, ") VALUES (", sCampos, ")");
                    break;
                case 2://Atualizar

                    for (i = 2; i <= Count; i++)
                    {
                        if (i < Count)
                        {
                            sCampos += Campos[i] + " = " + "@" + Campos[i] + ", ";
                        }
                        else
                        {
                            sCampos += Campos[i] + " = " + "@" + Campos[i];
                        }
                    }

                    sSql = string.Concat("UPDATE ", Campos[0], " SET ", sCampos, " WHERE ", Campos[1].ToString(), " = @", Campos[1]);
                    break;
            }
        }

        //======================================================================================================
        public static void AdicionarParametro(string Name, Object Value)
        {
            //string s = string.Concat("'", Value, "'");
            if (Value == null) { return; }
            SqlParameter NewParam = new SqlParameter(Name, Value);
            Params.Add(NewParam);
        }

        //======================================================================================================
        public static void ExecutarQuery(string sSql)
        {
            try
            {
                oConexao = new SqlConnection(sConexao);
                if (oConexao.State == ConnectionState.Open) { oConexao.Close(); }
                oConexao.Open();

                oComando = new SqlCommand(sSql, oConexao);
                oTransacao = oConexao.BeginTransaction();
                oComando.Transaction = oTransacao;

                foreach (SqlParameter p in Params)
                {
                    oComando.Parameters.Add(p);
                }

                Params.Clear();
                Retorno = Convert.ToBoolean(oComando.ExecuteNonQuery());
                oTransacao.Commit();
                oComando.Dispose();
                oTransacao.Dispose();
                oConexao.Dispose();
            }
            catch (Exception ex)
            {
                Params.Clear();
                oTransacao.Rollback();
                oComando.Dispose();
                oTransacao.Dispose();
                oConexao.Dispose();
                Retorno = false;
                Classes.Estatica.clsGlobal.RegistrarLogDeErros(0, clsMensagens.M00031 + ": " + ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        //======================================================================================================
        public static void ExecutarQuery()
        {
            try
            {
                oConexao = new SqlConnection(sConexao);
                if (oConexao.State == ConnectionState.Open) { oConexao.Close(); }
                oConexao.Open();

                oComando = new SqlCommand(sSql, oConexao);
                oTransacao = oConexao.BeginTransaction();
                oComando.Transaction = oTransacao;

                foreach (SqlParameter p in Params)
                {
                    oComando.Parameters.Add(p);
                }

                Params.Clear();
                Retorno = Convert.ToBoolean(oComando.ExecuteNonQuery());
                oTransacao.Commit();
                oComando.Dispose();
                oTransacao.Dispose();
                oConexao.Dispose();
            }
            catch (Exception ex)
            {
                Params.Clear();
                oTransacao.Rollback();
                oComando.Dispose();
                oTransacao.Dispose();
                oConexao.Dispose();
                Retorno = false;
                Classes.Estatica.clsGlobal.RegistrarLogDeErros(0, clsMensagens.M00031 + ": " + ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        //======================================================================================================
        public static void ExecutarProcedimento(string Procedimento)
        {
            try
            {
                oConexao = new SqlConnection(sConexao);
                if (oConexao.State == ConnectionState.Open) { oConexao.Close(); }
                oConexao.Open();

                oComando = new SqlCommand(Procedimento, oConexao);
                oComando.CommandType = CommandType.StoredProcedure;
                oTransacao = oConexao.BeginTransaction();
                oComando.Transaction = oTransacao;

                foreach (SqlParameter p in Params)
                {
                    oComando.Parameters.Add(p);
                }

                Params.Clear();
                oComando.ExecuteNonQuery();
                oTransacao.Commit();
                oComando.Dispose();
                oTransacao.Dispose();
                oConexao.Dispose();
                clsMensagens.MostrarMensagem(1);
            }
            catch (Exception ex)
            {
                Params.Clear();
                oTransacao.Rollback();
                oComando.Dispose();
                oTransacao.Dispose();
                oConexao.Dispose();
                Retorno = false;
                Classes.Estatica.clsGlobal.RegistrarLogDeErros(0, clsMensagens.M00031 + ": " + ex.Message);
                MessageBox.Show(ex.Message);
            }
        }


        //======================================================================================================
        public static void AtualizarLote(string sSql)
        {
            try
            {
                oConexao = new SqlConnection(sConexao);
                if (oConexao.State == ConnectionState.Open) { oConexao.Close(); }
                oConexao.Open();

                oComando = new SqlCommand(sSql, oConexao);
                oTransacao = oConexao.BeginTransaction();
                oComando.Transaction = oTransacao;

                Retorno = Convert.ToBoolean(oComando.ExecuteNonQuery());
                oTransacao.Commit();
                oComando.Dispose();
                oTransacao.Dispose();
                oConexao.Dispose();
            }
            catch (Exception ex)
            {
                oTransacao.Rollback();
                oComando.Dispose();
                oTransacao.Dispose();
                oConexao.Dispose();
                Retorno = false;
                Classes.Estatica.clsGlobal.RegistrarLogDeErros(0, clsMensagens.M00031 + ": " + ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        //======================================================================================================
        private static bool ExecutarQuery(bool ComParametro)
        {
            try
            {
                oConexao = new SqlConnection(sConexao);
                if (oConexao.State == ConnectionState.Open) { oConexao.Close(); }
                oConexao.Open();
                oComando = new SqlCommand(sSql.Trim().ToLower(), oConexao);
                oTransacao = oConexao.BeginTransaction();
                oComando.Transaction = oTransacao;

                if (ComParametro)
                {
                    foreach (SqlParameter p in Params)
                    {
                        oComando.Parameters.Add(p);
                    }
                    Params.Clear();
                }

                Retorno = Convert.ToBoolean(oComando.ExecuteNonQuery());
                oTransacao.Commit();
                oComando.Dispose();
                oTransacao.Dispose();
                oConexao.Dispose();
            }
            catch (Exception ex)
            {
                Params.Clear();
                oTransacao.Rollback();
                oComando.Dispose();
                oTransacao.Dispose();
                oConexao.Dispose();
                Retorno = false;
                Classes.Estatica.clsGlobal.RegistrarLogDeErros(0, clsMensagens.M00031 + ": " + ex.Message);
                MessageBox.Show(ex.Message);
                throw new Exception(ex.Message);
            }
            return Retorno;

        }

        //======================================================================================================
        public static void ExecutarQueryVendas(string _sSql, bool ComParametro)
        {
            try
            {
                oConexao = new SqlConnection(sConexao);
                if (oConexao.State == ConnectionState.Open) { oConexao.Close(); }
                oConexao.Open();

                oComando = new SqlCommand(_sSql, oConexao);
                oTransacao = oConexao.BeginTransaction();
                oComando.Transaction = oTransacao;

                if (ComParametro)
                {
                    foreach (SqlParameter p in Params)
                    {
                        oComando.Parameters.Add(p);
                    }
                    if (Params.Count != 0) Params.Clear();
                }

                oComando.ExecuteNonQuery();

                oTransacao.Commit();
                oComando.Dispose();
                oTransacao.Dispose();
                oConexao.Dispose();
            }
            catch
            {
                if (Params.Count != 0) Params.Clear();
                oTransacao.Rollback();
                oComando.Dispose();
                oTransacao.Dispose();
                oConexao.Dispose();
            }
        }

        //======================================================================================================
        public static void Cadastrar(List<String> Campos, bool condicao)
        {
            MontarQuerySql(Campos, 1);

            try
            {
                if (ExecutarQuery(true))
                {
                    if (condicao.Equals(true))
                    {
                        clsMensagens.MostrarMensagem(1);
                    }
                }
                else
                {
                    clsMensagens.MostrarMensagem(32);
                }
            }
            catch (Exception ex)
            {
                clsMensagens.MostrarMensagem(33);
                Classes.Estatica.clsGlobal.RegistrarLogDeErros(0, clsMensagens.M00027 + ": " + ex.Message);
            }
        }

        //======================================================================================================
        public static void Atualizar(List<String> Campos, bool condicao)
        {
            MontarQuerySql(Campos, 2);
            try
            {
                if (ExecutarQuery(true))
                {
                    if (condicao.Equals(true))
                    {
                        clsMensagens.MostrarMensagem(2);
                    }
                }
                else
                {
                    if (condicao.Equals(true))
                    {
                        clsMensagens.MostrarMensagem(34);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(clsMensagens.M00040, clsMensagens.M00019, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Classes.Estatica.clsGlobal.RegistrarLogDeErros(0, clsMensagens.M00031 + ": " + ex.Message);
            }
        }

        //======================================================================================================
        public static void CadastrarVendas(List<String> Campos)
        {
            MontarQuerySql(Campos, 1);
            ExecutarQueryVendas(sSql, true);
        }

        //======================================================================================================
        public static void AtualizarVendas(List<String> Campos, bool S_N)
        {
            MontarQuerySql(Campos, 2);
            ExecutarQueryVendas(sSql, S_N);
        }

        //======================================================================================================
        public static void Excluir(string Tabela, string ChavePrimaria, string Filtro = "*")
        {
            DialogResult Resultado = MessageBox.Show(clsMensagens.M00003 + Environment.NewLine + clsMensagens.M00037, clsMensagens.M00020, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Resultado == DialogResult.Yes)
            {
                sSql = string.Concat("UPDATE [dbo].[", Tabela, "] SET [deleted_at] = NULL WHERE ", ChavePrimaria, " = '", Filtro, "';");
            
                try
                {
                    if (ExecutarQuery(true))
                    {
                        clsMensagens.MostrarMensagem(35);
                    }
                    else
                    {
                        clsMensagens.MostrarMensagem(36);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(clsMensagens.M00036, clsMensagens.M00020, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Classes.Estatica.clsGlobal.RegistrarLogDeErros(0, clsMensagens.M00031 + ": " + ex.Message);
                }
            }
        }

        #endregion Fim da região, manutenção de dados.

    }
}