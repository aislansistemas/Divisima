using Microsoft.AspNetCore.Mvc;

namespace Divisima.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Error() => View();
    }
}