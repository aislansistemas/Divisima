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
                if(ModelState.IsValid){
                    var formFile = _httpContextAccessor.HttpContext.Request.Form.Files["Foto"];
                    var nomeArquivo = _uploadSystem.Upload(formFile);
                    produto.Foto = nomeArquivo;
                    await _produtoRepository.Cadastrar(produto);
                    var produtoVm = new ProdutoViewModel(){
                        Produtos = await _produtoRepository.GetAll(),
                        Mensagem = "Produto Cadastrado com sucesso!"
                    };
                    return Json(produtoVm);
                }
                var errors = new ErroViewModel(){Erros = ModelState};
                return Json(errors);
            } catch(Exception e) {
                return Json("Erro ao realizar a operação",e);
            }
        }

        [HttpPost, ActionName("Editar")]
        public async Task<IActionResult> Editar(Produto produto){
            try{
                var produtoResult = await _produtoRepository.GetById(produto.ProdutoId);
                if(produtoResult != null){
                    var formFile = _httpContextAccessor.HttpContext.Request.Form.Files["Foto"];
                    produto.Foto = formFile != null ? _uploadSystem.Upload(formFile) : produtoResult.Foto;
                    await _produtoRepository.Editar(produto);
                    var produtoVm = new ProdutoViewModel(){
                        Produtos = await _produtoRepository.GetAll(),
                        Mensagem = "Produto Cadastrado com sucesso!"
                    };
                    return Json(produtoVm);
                }
                var errors = new ErroViewModel(){Erros = "Produto não encontrado"};
                return Json(errors);
            } catch(Exception e) {
                return Json("Erro ao realizar a operação",e);
            }
        }
        
        [HttpPost, ActionName("Deletar")]
        public async Task<IActionResult> Deletar(int id){
            try{
                var produtoResult = await _produtoRepository.GetById(id);
                if(produtoResult != null){
                    await _produtoRepository.Deletar(produtoResult);
                    var produtoVm = new ProdutoViewModel(){
                        Produtos = await _produtoRepository.GetAll(),
                        Mensagem = "Produto Cadastrado com sucesso!"
                    };
                    return Json(produtoVm);
                }
                var errors = new ErroViewModel(){Erros = "Produto não encontrado"};
                return Json(errors);
            } catch(Exception e) {
                return Json("Erro ao realizar a operação",e);
            }
        }
    }
}