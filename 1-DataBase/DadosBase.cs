using CasaMendes.Classes.Estatica;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CasaMendes
{
    internal class DadosBase //: IDados
    {

        private SqlTransaction oTransacao;
        private List<SqlParameter> Params;
        private string MSG;

        private string diretorio { get; set; }

        internal DadosBase()
        {
            var Path = clsGlobal.ValidarDiretorio(ConfigurationManager.AppSettings["DbDiretorio"], ConfigurationManager.AppSettings["DbName"]);
             diretorio = ConfigurationManager.AppSettings["DbServer"] + Path;
            MSG = "Sucesso";
        }

        public void AdicionarParametro(string Name, object Value)
        {
            //if (Value == null)  return; 
            if (Params == null) Params = new List<SqlParameter>();
            SqlParameter NewParam = new SqlParameter(Name, Value);
            Params.Add(NewParam);
        }

        public string Cadastrar(string Procedimento = null)
        {
            try
            {
                using (SqlConnection oConexao = new SqlConnection(diretorio))
                {
                    oConexao.Open();
                    var oComando = new SqlCommand(Procedimento, oConexao);
                    oTransacao = oConexao.BeginTransaction();

                    oComando = new SqlCommand(Procedimento, oConexao);
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
                    return MSG;
                }
            }
            catch (Exception ex)
            {
                oTransacao.Rollback();
                if (Params != null) Params.Clear();
                return (MSG = ex.Message.ToString());
            }
        }

        public void Atualizar(string Procedimento)
        {
            try
            {
                using (SqlConnection oConexao = new SqlConnection(diretorio))
                {
                    oConexao.Open();
                    var oComando = new SqlCommand(Procedimento, oConexao);
                    oTransacao = oConexao.BeginTransaction();

                    oComando = new SqlCommand(Procedimento, oConexao);
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
                    //return MSG;
                }
            }
            catch//(Exception ex)
            {
                oTransacao.Rollback();
                if (Params != null) Params.Clear();
                //return (MSG = ex.Message.ToString());
            }

        }

        public void Excluir(string Procedimento)
        {
            try
            {
                using (SqlConnection oConexao = new SqlConnection(diretorio))
                {
                    oConexao.Open();
                    var oComando = new SqlCommand(Procedimento, oConexao);
                    oTransacao = oConexao.BeginTransaction();

                    oComando = new SqlCommand(Procedimento, oConexao);
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
                    //return MSG;
                }
            }
            catch //(Exception ex)
            {
                oTransacao.Rollback();
                if (Params != null) Params.Clear();
                //return (MSG = ex.Message.ToString());
            }
        }

        public ArrayList Selecionar(string Procedimento)
        {
            try
            {
                using (SqlConnection oConexao = new SqlConnection(diretorio))
                {
                    oConexao.Open();
                    var oComando = new SqlCommand(Procedimento, oConexao);
                    oComando.CommandType = CommandType.StoredProcedure;
                    oTransacao = oConexao.BeginTransaction();

                    oComando.Transaction = oTransacao;

                    foreach (SqlParameter p in Params)
                    {
                        oComando.Parameters.Add(p);
                    }

                    Params.Clear();
                    var ar = new ArrayList();
                    SqlDataReader oDr = oComando.ExecuteReader();

                    while (oDr.Read())
                    {
                        for (int i = 0; i < oDr.FieldCount; i++)
                        {
                            string x = oDr.GetValue(i).ToString();
                            if (x == null) continue;
                            ar.Add(x);
                        }
                    }

                    oDr.Close();
                    oTransacao.Dispose();
                    oComando.Dispose();
                    return ar;

                }
            }
            catch (Exception ex)
            {
                if (oTransacao != null) oTransacao.Rollback();
                if (Params.Count > 0) Params.Clear();
                throw new Exception(ex.Message);
                //return null;//(MSG = ex.Message.ToString());
            }
        }

        public DataTable Carregar(string Procedimento)
        {
            try
            {
                using (SqlConnection oConexao = new SqlConnection(diretorio))
                {
                    oConexao.Open();
                    DataTable oDt = new DataTable();
                    using (SqlDataAdapter oDa = new SqlDataAdapter(null,oConexao))
                    {
                        oDt.Locale = System.Globalization.CultureInfo.InvariantCulture;
                        //SqlCommand oComando = new SqlCommand(Procedimento, oConexao);
                        //oComando.CommandType = CommandType.StoredProcedure;

                        oDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                        oDa.SelectCommand.CommandText = Procedimento;

                        foreach (SqlParameter p in Params)
                        {
                            oDa.SelectCommand.Parameters.Add(p);
                        }

                        Params.Clear();

                        // oDa.SelectCommand = oComando;

                        oDa.Fill(oDt);

                        //oComando.Dispose();
                        oDa.Dispose();
                        oConexao.Dispose();
                    }
                    return oDt;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
