using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Divisima.Models;
using Divisima.Repository.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace divisima.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class AdminController: Controller
    {
        public IActionResult Index() => View();

    }
}