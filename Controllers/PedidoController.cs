using System.Threading.Tasks;
using divisima.ViewModels;
using Divisima.Models;
using Divisima.Repository;
using Divisima.Repository.Contracts;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Divisima.Controllers
{
    public class PedidoController : Controller
    {
        private readonly UserManager<Usuario> _userManager;
        private readonly ICarrinhoCompraItemRepository _carrinhoCompraRepository;
        public PedidoController(
            UserManager<Usuario> userManager,
            ICarrinhoCompraItemRepository carrinhoCompraRepository
        ){
            _userManager = userManager;
            _carrinhoCompraRepository = carrinhoCompraRepository;
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
    }
}