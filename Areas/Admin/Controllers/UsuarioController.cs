using System.Threading.Tasks;
using Divisima.Repository.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Divisima.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UsuarioController: Controller
    {
        private readonly IAccountRepository _accRepository;

        public UsuarioController(IAccountRepository accRepository)
        {
            _accRepository = accRepository;
        }

        public IActionResult Index(){
            return View();
        }

        public async Task<IActionResult> GetUsers(){
            return Json(await _accRepository.GetAll());
        }
    }
}