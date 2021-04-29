using System.Collections.Generic;
using System.Threading.Tasks;
using divisima.Models;

namespace divisima.Repository.Contracts
{
    public interface IProdutoRepository
    {
         Task<List<Produto>> GetAll(int numberPage = 0, int limit = 5);
         Task Cadastrar(Produto produto);
         Task<Produto> GetById(long id);
         Task Editar(Produto produto);
         Task Deletar(Produto produto);
         Task<List<Produto>> GetProductosRecentes(int numberResults = 5);
         Task<List<Produto>> GetProdutosByCatergoriaId(long categoriaId, int numberPage = 1, int limit = 5);
         Task BaixarQuantidadeProduto(long produtoId, int quantidade);
         Task<List<Produto>> BuscarProdutosByName(string nomeProduto);
         Task<Produto> GetLastProdutoCadastrado();
    }
}