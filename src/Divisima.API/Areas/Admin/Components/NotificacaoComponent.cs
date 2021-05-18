using Divisima.Repository.Contracts;
using Divisima.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Divisima.API.Areas.Admin.Components
{
    public class NotificacaoComponent : ViewComponent
    {
        private readonly IPedidoRepository _pedidoRepository;
        public NotificacaoComponent(IPedidoRepository pedidoRepository) 
        {
            _pedidoRepository = pedidoRepository;
        }

        public IViewComponentResult Invoke() 
        {
            var pedidoVm = new PedidoViewModel();
            try {
                var pedidos = _pedidoRepository.GetAll(1, 10).Result;
                pedidoVm.PedidosList = pedidos;
                
                return View(pedidoVm);
            } catch {
                return View(pedidoVm);
            }
        }
    }
}