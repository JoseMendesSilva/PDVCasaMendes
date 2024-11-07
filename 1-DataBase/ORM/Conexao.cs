using System.Configuration;

namespace CasaMendes
{
    public class Conexao
    {
        private static readonly string connectionString = string.Concat(
        @ConfigurationManager.AppSettings["ServerDb"], @ConfigurationManager.AppSettings["DirDb"], ConfigurationManager.AppSettings["NameDb"]);

        public static string GetConnectionString() {
            return connectionString;
        }
    }
}
