using System;
using System.Threading.Tasks;
using divisima.ViewModels;
using Divisima.Models;
using Divisima.Repository;
using Divisima.Repository.Contracts;
using Divisima.Services.Pedidos;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using Divisima.Enums.PagamentoEnums;
using Divisima.Services.Exceptions;

namespace Divisima.Controllers
{
    public class PedidoController : Controller
    {
        private readonly UserManager<Usuario> _userManager;
        private readonly ICarrinhoCompraItemRepository _carrinhoCompraRepository;
        private readonly IPedidoItemRepository _pedidoItemRepository;
        private readonly IPedidoRepository _pedidoRepository;
        private readonly IGerenciadorPedido _gerenciadorPedido;
        public PedidoController(
            UserManager<Usuario> userManager,
            ICarrinhoCompraItemRepository carrinhoCompraRepository,
            IPedidoItemRepository pedidoItemRepository,
            IPedidoRepository pedidoRepository,
            IGerenciadorPedido gerenciadorPedido
        ){
            _userManager = userManager;
            _carrinhoCompraRepository = carrinhoCompraRepository;
            _pedidoItemRepository = pedidoItemRepository;
            _pedidoRepository = pedidoRepository;
            _gerenciadorPedido = gerenciadorPedido;
        }

        [Authorize]
        [HttpGet]
        public IActionResult Checkout() {
            return View();
        }

        [HttpGet, ActionName("ItensCarrinhoResumo")]
        public async Task<IActionResult> ItensCarrinhoResumo() {
            Usuario usuario = await _userManager.GetUserAsync(HttpContext.User);
            var produtosAdicionados = await _carrinhoCompraRepository.GetItemsForUserById(usuario.Id);
            var carrinhoVm = new CarrinhoCompraViewModel(){ 
                CarrinhoCompraList = produtosAdicionados,
                ValorTotalItems = _carrinhoCompraRepository.GetValorTotalDeItems(produtosAdicionados)
            };
            return Json(carrinhoVm);
        }

        [Authorize]
        [HttpPost, ActionName("Checkout")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CheckoutConfirm(Pedido pedido) {
            try {
                
                if(!ModelState.IsValid){
                    return View(pedido);
                }
                
                Usuario usuario = await _userManager.GetUserAsync(HttpContext.User);
                var carrinhoCompraItems = await _carrinhoCompraRepository.GetItemsForUserById(usuario.Id);

                if(carrinhoCompraItems.Count < 1) {
                    TempData["Mensagem"] = "Não foi possível cadastrar o pedido pois seu carrinho de compras está vazio!";
                    return View();
                }

                pedido.UsuarioId = usuario.Id;
                await _gerenciadorPedido.ExecutarPedido(pedido, carrinhoCompraItems);
                
                TempData["Mensagem"] = "Compra feita com sucesso, aguarde em breve você receberá sua encomenda !";
                return RedirectToAction("Index", "Produto");
                
            } catch(Exception e) {
                TempData["Error"] = e.Message;
                return RedirectToAction("Error", "Error");
            }
        }

    }
}