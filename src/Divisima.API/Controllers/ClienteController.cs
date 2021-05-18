using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Divisima.API.Controllers
{
    public class ClienteController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
    }
}
