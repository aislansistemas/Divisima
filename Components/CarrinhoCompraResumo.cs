using Microsoft.AspNetCore.Mvc;

namespace Divisima.Components
{
    public class CarrinhoCompraResumo : ViewComponent
    {
        public IViewComponentResult Invoke(){
            ////implementação de teste ///
            TempData["numero_itens"] = 2;
            return View();
        }
    }
}