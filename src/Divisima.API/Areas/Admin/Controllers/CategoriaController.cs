using System.Threading.Tasks;
using divisima.Models;
using divisima.Repository.Contracts;
using Microsoft.AspNetCore.Mvc;
using System;
using divisima.ViewModels;
using Microsoft.AspNetCore.Authorization;

namespace divisima.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
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
        public async Task<IActionResult> GetAllJson()
        {
            try 
            {
                var categorias = await _categoriaRepository.GetAll();

                return Json(categorias);
            } 
            catch(Exception e) 
            {
                return Json(e.Message);
            }
        }

        [HttpPost,ActionName("Cadastrar")]
        public async Task<IActionResult> CadastrarConfirme(Categoria categoria)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    await _categoriaRepository.Cadastrar(categoria);

                    var CategoriaVm = new CategoriaViewModel
                    {
                        Categorias = await _categoriaRepository.GetAll(),
                        Mensagem = "Cadastro feito com sucesso!"
                    };
                    
                    return Json(CategoriaVm);
                }
                return Json("Preencha os dados corretamente");

            } 
            catch (Exception e) 
            {
                return Json("error", e.Message);
            }    
        }

        [HttpPost, ActionName("Editar")]
        public async Task<IActionResult> Editar(Categoria categoria)
        {
           try
           {
                var categoriaResult = await _categoriaRepository.GetById(categoria.CategoriaId);
                if(categoriaResult == null)
                {
                    return Json("Categoria não encontrada");
                }

                await _categoriaRepository.Editar(categoriaResult);
                var CategoriaVm = new CategoriaViewModel
                {
                    Categorias = await _categoriaRepository.GetAll(),
                    Mensagem = "Categoria editada com sucesso!"
                };

                return Json(CategoriaVm);
               
           } 
           catch(Exception e) 
           {
               return Json("error", e.Message);
           }
        }

        [HttpPost, ActionName("Inativar")]
        public async Task<IActionResult> Inativar(int id)
        {
            try
            {
                var categoriaResult = await _categoriaRepository.GetById(id);
                if(categoriaResult == null)
                {
                    return Json("Categoria não encontrada");
                }
                await _categoriaRepository.Inativar(categoriaResult);

                var CategoriaVm = new CategoriaViewModel
                {
                    Categorias = await _categoriaRepository.GetAll(),
                    Mensagem = "Categoria Inativada com sucesso!"
                };

                return Json(CategoriaVm);

            } 
            catch(Exception e) 
            {
                return Json("error", e.Message);
            }   
        }

        [HttpPost, ActionName("Ativar")]
        public async Task<IActionResult> Ativar(int id)
        {
            try
            {
                var categoriaResult = await _categoriaRepository.GetById(id);
                if(categoriaResult == null)
                {
                    return Json("Categoria não encontrada");
                }
                await _categoriaRepository.Ativar(categoriaResult);

                var CategoriaVm = new CategoriaViewModel
                {
                    Categorias = await _categoriaRepository.GetAll(),
                    Mensagem = "Categoria ativada com sucesso!"
                };

                return Json(CategoriaVm);
                
            } 
            catch(Exception e) 
            {
                return Json("error", e.Message);
            }   
        }
    }
}