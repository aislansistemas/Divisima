using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Divisima.Models;
using Divisima.Repository.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace divisima.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class AdminController: Controller
    {
        private readonly SignInManager<Usuario> _signInManager;
        public AdminController(SignInManager<Usuario> signManager)
        {
            _signInManager = signManager;
        }

        public IActionResult Index() => View();

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return Redirect("~/");
        }
    }
}