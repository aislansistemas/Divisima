using System;
using System.IO;
using System.Threading.Tasks;
using divisima.Models;
using divisima.Repository.Contracts;
using divisima.Services;
using divisima.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace divisima.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProdutoController: Controller
    {   
        private readonly IProdutoRepository _produtoRepository;
        private readonly ICategoriaRepository _categoriaRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IUploadFile _uploadSystem;

        public ProdutoController(
            IProdutoRepository produtoRepository,
            ICategoriaRepository categoriaRepository,
            IHttpContextAccessor httpContextAccessor,
            IUploadFile uploadSystem
        ) {
            this._produtoRepository = produtoRepository;
            this._categoriaRepository = categoriaRepository;
            this._httpContextAccessor = httpContextAccessor;
            this._uploadSystem = uploadSystem;
        }

        [HttpGet]
        public IActionResult Index(){
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetProdutos(){
            var ProdutoVm = new ProdutoViewModel(){
                Produtos = await _produtoRepository.GetAll(),
                CategoriasAtivas = await _categoriaRepository.GetAllAtiva()
            };
            return Json(ProdutoVm);
        }

        [HttpPost, ActionName("Cadastrar")]
        public async Task<IActionResult> Cadastrar(Produto produto){
            try{
                var formFile = _httpContextAccessor.HttpContext.Request.Form.Files["Foto"];
                var nomeArquivo = _uploadSystem.Upload(formFile);
                produto.Foto = nomeArquivo;
                produto.CategoriaId = 2;
                if(ModelState.IsValid){
                    await _produtoRepository.Cadastrar(produto);
                    var produtoVm = new ProdutoViewModel(){
                        Produtos = await _produtoRepository.GetAll(),
                        Mensagem = "Produto Cadastrado com sucesso!"
                    };
                    return Json(produtoVm);
                }
                return Json(ModelState/*"Preencha os dados corretamente"*/);
            } catch(Exception e) {
                return Json("Erro ao realizar a operação",e);
            }
        }
    }
}