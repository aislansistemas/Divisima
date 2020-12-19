using System.Collections.Generic;
using System.Threading.Tasks;
using Divisima.Models;
using Divisima.Repository.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Divisima.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UsuarioController: Controller
    {
        private readonly IAccountRepository _accountRepository;

        public UsuarioController(IAccountRepository accRepository)
        {
            _accountRepository = accRepository;
        }

        public IActionResult Index(){
            return View();
        }

        [HttpGet, ActionName("GetUsers")]
        public async Task<IActionResult> GetUsers(int numberPage, int limit){
            List<Usuario> usuario = await _accountRepository.GetAll(numberPage, limit);
            return Json(usuario);
        }
    }
}