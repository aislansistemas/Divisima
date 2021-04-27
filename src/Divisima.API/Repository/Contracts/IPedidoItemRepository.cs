using System.Collections.Generic;
using System.Threading.Tasks;
using Divisima.Models;

namespace Divisima.Repository.Contracts
{
    public interface IPedidoItemRepository
    {
         Task Cadastrar(PedidoItem pedidoItem);
         Task<List<PedidoItem>> GetByPedido(int pedidoId);
    }
}