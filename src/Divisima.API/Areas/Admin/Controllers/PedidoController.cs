using System.Threading.Tasks;
using Divisima.Repository.Contracts;
using Microsoft.AspNetCore.Mvc;
using Divisima.ViewModels;
using System;
using Microsoft.AspNetCore.Authorization;

namespace divisima.Areas.Admin.Controllers
{   
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class PedidoController : Controller
    {
        private readonly IPedidoRepository _pedidoRepository;
        private readonly IPedidoItemRepository _pedidoItemRepository;
        public PedidoController(
            IPedidoRepository pedidoRepository,
            IPedidoItemRepository pedidoItemRepository
        ) {
            _pedidoRepository = pedidoRepository;
            _pedidoItemRepository = pedidoItemRepository;
        }

        [HttpGet, ActionName("Index")]
        public IActionResult Index() => View();

        public async Task<IActionResult> CarregarPedidoAjax() 
        {
            try {
                var pedidos = await _pedidoRepository.GetAll(1, 10);
                var pedidoVm = new PedidoViewModel() {
                    PedidosList = pedidos
                };
                return PartialView("PartialViews/_carregar-pedidos", pedidoVm);
            } catch(Exception) {
                return PartialView("PartialViews/_carregar-pedidos");
            }
        }

        public async Task<IActionResult> DetalhesPedidoAjax(int pedidoId) 
        {
            try {
                var pedidoItens = await _pedidoItemRepository.GetByPedido(pedidoId);
                var pedidoVm = new PedidoViewModel() {
                    PedidoItemList = pedidoItens
                };
                return PartialView("PartialViews/_detalhe", pedidoVm);
            } catch(Exception) {
                return View();
            }
        }
    }
}