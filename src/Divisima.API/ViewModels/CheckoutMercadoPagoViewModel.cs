using divisima.Models;
using Divisima.Models;

namespace Divisima.API.ViewModels
{
    public class CheckoutMercadoPagoViewModel
    {
        public Produto Produto { get; set; }
        public CarrinhoCompraItem CarrinhoCompraItem { get; set; }
    }
}