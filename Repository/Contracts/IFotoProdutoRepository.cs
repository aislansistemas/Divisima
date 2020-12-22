using System.Threading.Tasks;
using Divisima.Models;

namespace Divisima.Repository.Contracts
{
    public interface IFotoProdutoRepository
    {
         Task Cadastrar(FotoProduto fotoProduto);
    }
}