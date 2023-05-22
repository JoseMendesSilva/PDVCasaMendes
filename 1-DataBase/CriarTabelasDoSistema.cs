using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasaMendes
{
    public class CriarTabelasDoSistema
    {
        public static void CriarTabelas()
        {
            try {
                new Funcionario().CriarTabela();
                new Cliente().CriarTabela();
                new Fornecedore().CriarTabela();
                new Categoria().CriarTabela();
                new SubCategoria().CriarTabela();
                new Produto().CriarTabela();
                new Estoque().CriarTabela();
                new TabelaDeMargen().CriarTabela();
                new PreVenda().CriarTabela();
            }catch(Exception ex)
            {
                MessageBox.Show($"Erro ao criar as tabelas e a seguinte mansagem foi gerada: {ex.Message}");
            }
        }
    }
}
