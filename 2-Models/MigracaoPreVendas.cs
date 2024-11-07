using System.Linq;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using DocumentFormat.OpenXml.Vml;

namespace CasaMendes
{


    class MigracaoPreVendas
    {
        private readonly string ConnectionString = Conexao.GetConnectionString();

        public void MigrarDados()
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                // Passo 1: Obtenha todos os registros de PreVendas
                var preVendas = ObterPreVendas(connection);

                // Agrupe por NumeroDaVenda para criar os pedidos
                var gruposDeVendas = preVendas.GroupBy(pv => pv["NumeroDaVenda"]);

                foreach (var grupo in gruposDeVendas)
                {
                    // Passo 2: Criar um pedido para cada grupo
                    var primeiroItem = grupo.First();
                    int pedidoId = InserirPedido(connection, primeiroItem, grupo);

                    // Passo 3: Inserir os itens do pedido no ItensPedidos
                    InserirItensPedido(connection, grupo, pedidoId);
                }

                Console.WriteLine("Migração concluída com sucesso!");
            }
        }

        private List<Dictionary<string, object>> ObterPreVendas(SqlConnection connection)
        {
            var preVendas = new List<Dictionary<string, object>>();
            var command = new SqlCommand("SELECT * FROM PreVendas", connection);
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var registro = new Dictionary<string, object>();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        registro[reader.GetName(i)] = reader.IsDBNull(i) ? null : reader.GetValue(i);
                    }
                    preVendas.Add(registro);
                }
            }
            return preVendas;
        }

        private int InserirPedido(SqlConnection connection, Dictionary<string, object> primeiroItem, IEnumerable<Dictionary<string, object>> grupo)
        {
            var dataPedido = DateTime.TryParse(primeiroItem["created_at"]?.ToString(), out var data) ? data : DateTime.Now;
            var total = grupo.Sum(item => decimal.TryParse(item["Valor"]?.ToString(), out var valor) ? valor : 0);

            using (var command = new SqlCommand("INSERT INTO Pedidos (NumeroPedido, ClienteID, DataPedido, Total, StatusPedido) VALUES (@NumeroPedido, @ClienteID, @DataPedido, @Total, @StatusPedido); SELECT SCOPE_IDENTITY();", connection))
            {
                command.Parameters.AddWithValue("@NumeroPedido", primeiroItem["NumeroDaVenda"] ?? DBNull.Value);
                command.Parameters.AddWithValue("@ClienteID", primeiroItem["ClienteId"] ?? DBNull.Value);
                command.Parameters.AddWithValue("@DataPedido", dataPedido);
                command.Parameters.AddWithValue("@Total", total);
                command.Parameters.AddWithValue("@StatusPedido", primeiroItem["TipoDeVenda"] ?? DBNull.Value);

                //NumeroPedido varchar(255)
                //ClienteID INT
                //DataPedido DATETIME
                //Total DECIMAL(10, 2)
                //StatusPedido varchar(20)


                return Convert.ToInt32(command.ExecuteScalar());
            }
        }

        private void InserirItensPedido(SqlConnection connection, IEnumerable<Dictionary<string, object>> grupo, int pedidoId)
        {
            foreach (var item in grupo)
            {
                using (var command = new SqlCommand("INSERT INTO ItensPedidos (NumeroPedido, Produto, Quantidade, PrecoUnitario) VALUES (@NumeroPedido, @Produto, @Quantidade, @PrecoUnitario);", connection))
                {
                    command.Parameters.AddWithValue("@NumeroPedido", pedidoId);
                    command.Parameters.AddWithValue("@Produto", item["Produto"] ?? DBNull.Value);
                    command.Parameters.AddWithValue("@Quantidade", item["Quantidade"] ?? 1);
                    command.Parameters.AddWithValue("@PrecoUnitario", decimal.TryParse(item["PrecoDeVenda"]?.ToString(), out var preco) ? preco : 0);
                    //   ItemPedidoID INT
                    //   NumeroPedido varchar(255)
                    //   ProdutoID INT
                    //   Produto varchar](255)
                    //   Quantidade INT
                    //   PrecoUnitario DECIMAL(10, 2)
                    command.ExecuteNonQuery();
                }
            }
        }
    }

}

//    public void MigrarDados()
//    {
//        using (var connection = new SqlConnection(ConnectionString))
//        {
//            connection.Open();

//            // Passo 1: Obtenha todos os registros de PreVendas
//            var preVendas = ObterPreVendas(connection);

//            // Agrupe por NumeroDaVenda para criar os pedidos
//            var gruposDeVendas = preVendas.GroupBy(pv => pv.GetType().GetProperty("NumeroDaVenda")?.GetValue(pv, null));

//            foreach (var grupo in gruposDeVendas)
//            {
//                // Passo 2: Criar um pedido para cada grupo
//                var primeiroItem = grupo.First();
//                int pedidoId = InserirPedido(connection, primeiroItem, grupo);

//                // Passo 3: Inserir os itens do pedido no ItensPedidos
//                InserirItensPedido(connection, grupo, pedidoId);
//            }

//            Console.WriteLine("Migração concluída com sucesso!");
//        }
//    }

//    private List<dynamic> ObterPreVendas(SqlConnection connection)
//    {
//        var preVendas = new List<dynamic>();
//        var command = new SqlCommand("SELECT * FROM PreVendas", connection);
//        using (var reader = command.ExecuteReader())
//        {
//            while (reader.Read())
//            {
//                var registro = new Dictionary<string, object>();
//                for (int i = 0; i < reader.FieldCount; i++)
//                {
//                    registro[reader.GetName(i)] = reader.IsDBNull(i) ? null : reader.GetValue(i);
//                }
//                preVendas.Add(registro);
//            }
//        }
//        return preVendas;
//    }

//    private int InserirPedido(SqlConnection connection, dynamic primeiroItem, IEnumerable<dynamic> grupo)
//    {
//        var dataPedido = DateTime.TryParse(primeiroItem["created_at"]?.ToString(), out DateTime data) ? data : DateTime.Now;
//        var total = grupo.Sum(item => decimal.TryParse(item["Valor"]?.ToString(), out decimal valor) ? valor : 0);

//        using (var command = new SqlCommand("INSERT INTO Pedidos (ClienteID, DataPedido, Total) VALUES (@ClienteID, @DataPedido, @Total); SELECT SCOPE_IDENTITY();", connection))
//        {
//            command.Parameters.AddWithValue("@ClienteID", primeiroItem["ClienteId"] ?? DBNull.Value);
//            command.Parameters.AddWithValue("@DataPedido", dataPedido);
//            command.Parameters.AddWithValue("@Total", total);

//            return Convert.ToInt32(command.ExecuteScalar());
//        }
//    }

//    private void InserirItensPedido(SqlConnection connection, IEnumerable<dynamic> grupo, int pedidoId)
//    {
//        foreach (var item in grupo)
//        {
//            using (var command = new SqlCommand("INSERT INTO ItensPedidos (PedidoID, Produto, Quantidade, PrecoUnitario) VALUES (@PedidoID, @Produto, @Quantidade, @PrecoUnitario);", connection))
//            {
//                command.Parameters.AddWithValue("@PedidoID", pedidoId);
//                command.Parameters.AddWithValue("@Produto", item["Produto"] ?? DBNull.Value);
//                command.Parameters.AddWithValue("@Quantidade", item["Quantidade"] ?? 1);
//                command.Parameters.AddWithValue("@PrecoUnitario", decimal.TryParse(item["PrecoDeVenda"]?.ToString(), out decimal preco) ? preco : 0);

//                command.ExecuteNonQuery();
//            }
//        }
//    }
//}