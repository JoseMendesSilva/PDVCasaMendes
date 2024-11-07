using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CasaMendes
{

    static class Program
    {
        //IServiceCollection services;
        
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //string connectionString = Conexao.GetConnectionString();

            ////var categoriaRepository = new Repository<Categoria>(connectionString);
            ////var fornecedorRepository = new Repository<Fornecedore>(connectionString);
            //var produtoRepository = new Repository<Produto>(connectionString);


            //// Inserir um novo produto
            ////var novoFornecedor = new Fornecedore
            ////{
            ////    FornecedorID = 0,
            ////    NomeFornecedor = "Produto Exemplo",
            ////    CNPJ = "123456789",
            ////    CPF = "01012565",
            ////    Endereco = "Rua 2, N: 39",
            ////    Email = "123456789@25.com",
            ////    Telefone = "1152526387",
            ////    Observacoes = "Observação do produto"
            ////};
            ////fornecedorRepository.Insert(novoFornecedor, "Fornecedores");

            ////// Inserir um novo produto
            ////var novaCategoria = new Categoria
            ////{
            ////    CategoriaID = 0,
            ////    NomeCategoria = "Categoria Exemplo",
            ////    Descricao = "Descrição do categoria"
            ////};
            ////categoriaRepository.Insert(novaCategoria, "Categorias");

            //// Inserir um novo produto
            //var novoProduto = new Produto
            //{
            //    NomeProduto = "Produto Exemplo",
            //    Descricao = "Descrição do produto",
            //    CategoriaID = 1,
            //    FornecedorID = 1,
            //    CodigoBarras = "123456789",
            //    QuantidadeEstoque = 50,
            //    UnidadeMedida = "Unidade",
            //    PrecoCusto = 10.00M,
            //    PrecoVenda = 15.00M,
            //    DataCadastro = DateTime.Now,
            //    Observacoes = "Observação do produto"
            //};
            //produtoRepository.Insert(novoProduto, "");
            ////produtoRepository.Insert(novoProduto, "Produtos");

            //// Listar todos os produtos
            //List<Produto> produtos = produtoRepository.GetAll("Produtos");

            //// Atualizar um produto
            //novoProduto.PrecoVenda = 20.00M;
            //produtoRepository.Update(novoProduto, "Produtos", "ProdutoID");

            //// Excluir um produto
            //produtoRepository.Delete(novoProduto.ProdutoID, "Produtos", "ProdutoID");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Dependencias.ConfigurarServicos();

            //var migrar = new MigracaoPreVendas();
            //migrar.MigrarDados();

            Application.Run(new FrmCasaMendes());
        }
    }
}
