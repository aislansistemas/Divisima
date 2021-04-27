using System.Collections.Generic;
using Divisima.Models;

namespace Divisima.Services.CarrinhoCompra
{
    public static class CarrinhoCompraService
    {
        public static bool VerificarProdutoAdicionadoAoCarrinho(List<CarrinhoCompraItem> carrinhoCompraItem, int produtoId)
        {
            var isProdutoExistenteNoCarrinho = carrinhoCompraItem.Find(x => x.ProdutoId == produtoId);
            return isProdutoExistenteNoCarrinho != null ? true : false;
        }
    }
}