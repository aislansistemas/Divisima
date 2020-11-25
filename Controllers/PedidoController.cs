using System.Threading.Tasks;
using divisima.ViewModels;
using Divisima.Models;
using Divisima.Repository;
using Divisima.Repository.Contracts;
using Divisima.Services.Pedidos;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Divisima.Controllers
{
    public class PedidoController : Controller
    {
        private readonly UserManager<Usuario> _userManager;
        private readonly ICarrinhoCompraItemRepository _carrinhoCompraRepository;
        private readonly IGerenciadorPedido _gerenciadorPedido;
        public PedidoController(
            UserManager<Usuario> userManager,
            ICarrinhoCompraItemRepository carrinhoCompraRepository,
            IGerenciadorPedido gerenciadorPedido
        ){
            _userManager = userManager;
            _carrinhoCompraRepository = carrinhoCompraRepository;
            _gerenciadorPedido = gerenciadorPedido;
        }
        public async Task<IActionResult> Checkout() {
            Usuario usuario = await _userManager.GetUserAsync(HttpContext.User);
            var produtosAdicionados = await _carrinhoCompraRepository.GetItemsForUserById(usuario.Id);
            var carrinhoVm = new CarrinhoCompraViewModel(){ 
                CarrinhoCompraList = produtosAdicionados,
                ValorTotalItems = _carrinhoCompraRepository.GetValorTotalDeItems(produtosAdicionados)
            };
            return View(carrinhoVm);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> Comprar() {
           
            return View();
        }
    }
}