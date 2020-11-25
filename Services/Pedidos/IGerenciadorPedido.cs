using System.Threading.Tasks;
using Divisima.Models;

namespace Divisima.Services.Pedidos
{
    public interface IGerenciadorPedido
    {
        Task ExecutarPedido(Pedido pedido, CarrinhoCompraItem carrinhoCompraItem);
    }
}