
namespace CasaMendes
{
    public class DatabaseService
    {
        //private readonly Repository<Categoria> _categoriaRepo;
        //private readonly Repository<Fornecedore> _fornecedorRepo;
        //private readonly Repository<Produto> _produtoRepo;

        //public DatabaseService(string connectionString)
        //{
        //    _categoriaRepo = new Repository<Categoria>(connectionString);
        //    _fornecedorRepo = new Repository<Fornecedore>(connectionString);
        //    _produtoRepo = new Repository<Produto>(connectionString);
        //}

        //public void InserirProduto(Produto produto)
        //{
        //    // Insere Categoria se ainda não existe
        //    var categoria = ObterCategoriaPorNome(produto.Categoria.NomeCategoria);
        //    if (categoria == null)
        //    {
        //        _categoriaRepo.Insert(produto.Categoria, "Categorias");
        //        categoria = ObterCategoriaPorNome(produto.Categoria.NomeCategoria);
        //    }

        //    // Insere Fornecedor se ainda não existe
        //    var fornecedor = ObterFornecedorPorNome(produto.Fornecedor.NomeFornecedor);
        //    if (fornecedor == null)
        //    {
        //        _fornecedorRepo.Insert(produto.Fornecedor, "Fornecedores");
        //        fornecedor = ObterFornecedorPorNome(produto.Fornecedor.NomeFornecedor);
        //    }

        //    // Atualiza as referências do produto
        //    produto.CategoriaID = categoria.CategoriaID;
        //    produto.FornecedorID = fornecedor.FornecedorID;

        //    // Insere o Produto
        //    _produtoRepo.Insert(produto, "Produtos");
        //}

        //private Categoria ObterCategoriaPorNome(string nomeCategoria)
        //{
        //    // Implementação para buscar categoria por nome
        //}

        //private Fornecedor ObterFornecedorPorNome(string nomeFornecedor)
        //{
        //    // Implementação para buscar fornecedor por nome
        //}
    }

}
