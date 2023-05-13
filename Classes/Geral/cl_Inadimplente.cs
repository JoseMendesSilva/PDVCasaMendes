using System.Collections.Generic;
using System.Windows.Forms;


namespace CasaMendes.Classes
{
    public static class Inadimplente
    {
        //============================================= public static ===========================================
        public static void Gravar(List<string> ListaDeInadimplente)
        {
            try
            {

                Enumeradores.eAcao Acao;
                string sCodigoCliente = Classes.ADL.Cl_Dados.LerUmRegistro("SELECT CodigoCliente FROM tInadimplentes WHERE CodigoCliente = " + ListaDeInadimplente[1].ToString());

                if (sCodigoCliente == null) { Acao = Enumeradores.eAcao.Cadastrar; } else { Acao = Enumeradores.eAcao.Atualizar; }

                List<string> Camos = new List<string>();
                Camos.Add("tInadimplentes");
                Camos.Add("CodigotInadimplente");
                Camos.Add("CodigoCliente");
                Camos.Add("Status");
                Camos.Add("Data");
                Camos.Add("DividaAtiva");
                Camos.Add("Encargos");
                Camos.Add("Observacao");

                if (Classes.ADL.Cl_Dados.Params.Count != 0) Classes.ADL.Cl_Dados.Params.Clear();
                Classes.ADL.Cl_Dados.AdicionarParametro("@CodigoCliente", ListaDeInadimplente[1]);
                Classes.ADL.Cl_Dados.AdicionarParametro("@Status", ListaDeInadimplente[2]);
                Classes.ADL.Cl_Dados.AdicionarParametro("@Data", ListaDeInadimplente[3]);
                Classes.ADL.Cl_Dados.AdicionarParametro("@DividaAtiva", ListaDeInadimplente[4]);
                Classes.ADL.Cl_Dados.AdicionarParametro("@Encargos", ListaDeInadimplente[5]);
                Classes.ADL.Cl_Dados.AdicionarParametro("@Observacao", ListaDeInadimplente[6]);

                switch (Acao)
                {
                    case Enumeradores.eAcao.Cadastrar:
                        string iD = Classes.ADL.Cl_Dados.LerMaxima("tInadimplentes", "CodigotInadimplente");
                        Classes.ADL.Cl_Dados.AdicionarParametro("@CodigotInadimplente", iD);
                        Classes.ADL.Cl_Dados.Cadastrar(Camos, true);
                        break;
                    case Enumeradores.eAcao.Atualizar:
                        Classes.ADL.Cl_Dados.AdicionarParametro("@CodigotInadimplente", ListaDeInadimplente[0]);
                        Classes.ADL.Cl_Dados.Atualizar(Camos,true);
                        break;
                }

            }
            catch
            {

            }
        }

        public static void Excluir(string Filtro)
        {
            try
            {
                Classes.ADL.Cl_Dados.Excluir("tInadimplentes", "CodigotInadimplente", Filtro);
            }
            catch
            {

            }
        }

        public static void CarregarDataGridInadimplentes(DataGridView dgv)
        {
            try
            {
                string sSql;

                sSql = " SELECT [CodigotInadimplente] ";
                sSql += ",[CodigoCliente]";
                sSql += ",[Nome] ";
                sSql += ",[Status]";
                sSql += ",[Data]";
                sSql += ",[DividaAtiva]";
                sSql += ",[Encargos]";
                sSql += ",[Observacao]";
                sSql += "FROM [tClientes] INNER JOIN [tInadimplentes] ON [tClientes].[Codigo] = [tInadimplentes].[CodigoCliente] --WHERE [tInadimplentes].[Status] = 'ATIVO'";

                dgv.DataSource = Classes.ADL.Cl_Dados.PegarDados(sSql);
                Classes.Estatica.clsGlobal.SetUpDataGridView(dgv);
            }
            catch { }
        }
    }
}
