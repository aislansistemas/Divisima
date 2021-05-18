using System;
using System.IO;
using System.Threading.Tasks;
using divisima.Models;
using divisima.Repository.Contracts;
using divisima.Services;
using divisima.ViewModels;
using Divisima.Enums.PerfilUsuarioEnums;
using Divisima.Models;
using Divisima.Repository.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace divisima.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = PerfilUsuarioEnum.Admin)]
    public class ProdutoController: Controller
    {   
        private readonly IProdutoRepository _produtoRepository;
        private readonly ICategoriaRepository _categoriaRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IUploadFile _uploadSystem;
        private readonly IFotoProdutoRepository _fotoProdutoRepository;

        public ProdutoController(
            IProdutoRepository produtoRepository,
            ICategoriaRepository categoriaRepository,
            IHttpContextAccessor httpContextAccessor,
            IUploadFile uploadSystem,
            IFotoProdutoRepository fotoProdutoRepository
        ) 
        {
            this._produtoRepository = produtoRepository;
            this._categoriaRepository = categoriaRepository;
            this._httpContextAccessor = httpContextAccessor;
            this._uploadSystem = uploadSystem;
            this._fotoProdutoRepository = fotoProdutoRepository;
        }

        [HttpGet]
        public IActionResult Index() => View();

        [HttpGet]
        public async Task<IActionResult> GetProdutos(int numberPage, int limit)
        {
            try 
            {
                var ProdutoVm = new ProdutoViewModel()
                {
                    Produtos = await _produtoRepository.GetAll(numberPage, limit),
                    CategoriasAtivas = await _categoriaRepository.GetAllAtiva()
                };

                return Json(ProdutoVm);
            } 
            catch(Exception e) 
            {
                return Json(e.Message);
            }
        }

        [HttpPost, ActionName("Cadastrar")]
        public async Task<IActionResult> Cadastrar(Produto produto)
        {
            try{

                if(ModelState.IsValid)
                {
                    await _produtoRepository.Cadastrar(produto);
                    var ProdutoCadastrado = await _produtoRepository.GetLastProdutoCadastrado();
                    var formFileList = _httpContextAccessor.HttpContext.Request.Form.Files;
                    foreach(FormFile formFile in formFileList) {
                        var nomeArquivo = _uploadSystem.Upload(formFile, Functions.GetPathUploadProdutos());
                        var fotoProduto = new FotoProduto();
                        fotoProduto.Foto = nomeArquivo;
                        fotoProduto.ProdutoId = ProdutoCadastrado.ProdutoId;
                        await _fotoProdutoRepository.Cadastrar(fotoProduto);
                    }
            
                    var produtoVm = new ProdutoViewModel(){
                        Produtos = await _produtoRepository.GetAll(1, 6),
                        Mensagem = "Produto Cadastrado com sucesso!"
                    };
                    return Json(produtoVm);
                }

                var errors = new ErroViewModel(){Erros = ModelState};

                return Json(errors);
            } 
            catch(Exception e) 
            {
                return Json("error", e.Message);
            }
        }

        [HttpPost, ActionName("Editar")]
        public async Task<IActionResult> Editar(Produto produto)
        {
            try
            {
                var produtoResult = await _produtoRepository.GetById(produto.ProdutoId);
                if(produtoResult != null)
                {
                    var formFile = _httpContextAccessor.HttpContext.Request.Form.Files["Foto"];
                   // produto.Foto = formFile != null ? _uploadSystem.Upload(formFile, Functions.GetPathUploadProdutos()) : produtoResult.Foto;
                    await _produtoRepository.Editar(produto);

                    var produtoVm = new ProdutoViewModel(){
                        Produtos = await _produtoRepository.GetAll(1, 6),
                        Mensagem = "Produto Cadastrado com sucesso!"
                    };

                    return Json(produtoVm);
                }

                var errors = new ErroViewModel(){Erros = "Produto não encontrado"};
                return Json(errors);
            } 
            catch(Exception e) 
            {
                return Json("error", e.Message);
            }
        }
        
        [HttpPost, ActionName("Deletar")]
        public async Task<IActionResult> Deletar(int id)
        {
            try
            {
                var produtoResult = await _produtoRepository.GetById(id);
                if(produtoResult != null)
                {
                    foreach(var foto in produtoResult.Foto)
                    {
                        _uploadSystem.DeleteFileAsync(foto.Foto, Functions.GetPathUploadProdutos());
                    }
                    await _produtoRepository.Deletar(produtoResult);

                    var produtoVm = new ProdutoViewModel()
                    {
                        Produtos = await _produtoRepository.GetAll(1, 6),
                        Mensagem = "Produto Deletado com sucesso!"
                    };

                    return Json(produtoVm);
                }

                var errors = new ErroViewModel{Erros = "Produto não encontrado"};

                return Json(errors);
            } 
            catch(Exception e) 
            {
                return Json("error", e.Message);
            }
        }
    }
}