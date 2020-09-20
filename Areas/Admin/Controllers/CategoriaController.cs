using System.Threading.Tasks;
using divisima.Models;
using divisima.Repository.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace divisima.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoriaController: Controller
    {
        private readonly ICategoriaRepository _categoriaRepository;
        public CategoriaController(ICategoriaRepository categoriaRepository)
        {
            this._categoriaRepository = categoriaRepository;
        }

        [HttpGet]
        public IActionResult Index(){
        
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllJson(){
            var categorias = await _categoriaRepository.GetAll();
            return Json(categorias);
        }

        public IActionResult Cadastrar(){
            return View();
        }

        [HttpPost,ActionName("Cadastrar")]
        public IActionResult CadastrarConfirme(Categoria categoria){
            if(ModelState.IsValid){
                _categoriaRepository.Cadastrar(categoria);
                RedirectToAction(nameof(Index));
            }
            return View(ModelState);
        }
    }
}