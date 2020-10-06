using System.Collections.Generic;
using System.Threading.Tasks;
using divisima.Models;

namespace divisima.Repository.Contracts
{
    public interface IProdutoRepository
    {
         Task<List<Produto>> GetAll();
         Task Cadastrar(Produto produto);
         Task<Produto> GetById(int id);
         Task Editar(Produto produto);
         Task Deletar(Produto produto);
         Task<List<Produto>> GetProductosRecentes(int numberResults = 5);

    }
}