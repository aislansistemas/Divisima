using System.Threading.Tasks;
using Divisima.Repository.Contracts;
using Microsoft.AspNetCore.Mvc;
using Divisima.ViewModels;

namespace divisima.Areas.Admin.Controllers
{   
    [Area("Admin")]
    public class PedidoController : Controller
    {
        private readonly IPedidoRepository _pedidoRepository;
        public PedidoController(IPedidoRepository pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }

        [HttpGet, ActionName("Index")]
        public async Task<IActionResult> Index() {
            var pedidos = await _pedidoRepository.GetAll(1, 10);
            var pedidoVm = new PedidoViewModel() {
                PedidosList = pedidos
            };
            return View(pedidoVm);
        }
    }
}