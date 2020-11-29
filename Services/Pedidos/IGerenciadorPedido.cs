using System.Collections.Generic;
using System.Threading.Tasks;
using Divisima.Models;

namespace Divisima.Services.Pedidos
{
    public interface IGerenciadorPedido
    {
        Task ExecutarPedido(Pedido pedido, List<CarrinhoCompraItem> carrinhoCompraItens);
    }
}