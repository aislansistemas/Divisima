using Microsoft.AspNetCore.Mvc;

namespace divisima.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProdutoController: Controller
    {
        [HttpGet]
        public IActionResult Index(){
            return View();
        }
    }
}