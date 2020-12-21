using System.Collections.Generic;
using System.Threading.Tasks;
using Divisima.Models;

namespace Divisima.Repository.Contracts
{
    public interface IPedidoRepository
    {
        Task<List<Pedido>> GetAll(int numberPage = 0, int limit = 5);
        Task Cadastrar(Pedido pedido);
        Task<Pedido> GetLastPedido();
    
    }
}