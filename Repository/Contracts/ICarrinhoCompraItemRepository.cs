using System.Collections.Generic;
using System.Threading.Tasks;
using Divisima.Models;

namespace Divisima.Repository.Contracts
{
    public interface ICarrinhoCompraItemRepository
    {
        Task Adicionar(CarrinhoCompraItem carrinhoCompraItem);
        Task<CarrinhoCompraItem> GetCarrinhoItemById(int id);
        Task<List<CarrinhoCompraItem>> GetItemsForUserById(string id);
        Task Remover(CarrinhoCompraItem carrinhoCompraItem);
        CarrinhoCompraItem CreateObject(int produtoId, int quantidade, string usuarioId);
    }
}