using System.Collections.Generic;
using System.Threading.Tasks;
using divisima.Models;
using Divisima.Models;

namespace Divisima.Repository.Contracts
{
    public interface ICarrinhoCompraItemRepository
    {
        Task<CarrinhoCompraItem> Adicionar(CarrinhoCompraItem carrinhoCompraItem);
        Task<CarrinhoCompraItem> GetCarrinhoItemById(long id);
        Task<List<CarrinhoCompraItem>> GetItemsForUserById(string id);
        Task Remover(CarrinhoCompraItem carrinhoCompraItem);
        CarrinhoCompraItem CreateObject(long produtoId, int quantidade, string usuarioId);
        decimal GetValorTotalDeItems(List<CarrinhoCompraItem> carrinhoCompraItems);
    }
}