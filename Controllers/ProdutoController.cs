using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using divisima.Models;
using divisima.Repository.Contracts;
using divisima.ViewModels;

namespace divisima.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly ICategoriaRepository _categoriaRepository;
        private string Menssagem;

        public ProdutoController(
            IProdutoRepository produtoRepository,
            ICategoriaRepository categoriaRepository
        ){
            _produtoRepository = produtoRepository;
            _categoriaRepository = categoriaRepository;
        } 

        public async Task<IActionResult> Index()
        {   
            var produtoVm = new ProdutoViewModel(){
                LastProducts = await _produtoRepository.GetProductosRecentes(),
                CategoriasAtivas = await _categoriaRepository.GetAllAtiva()
            };
            return View(produtoVm);
        }

        [HttpGet, ActionName("BuscarProdutos")]
        public async Task<IActionResult> BuscarProdutos(string produto) {
            if(produto == null) {
                return RedirectToAction(nameof(Index));
            }
            
            var produtosResult = await _produtoRepository.BuscarProdutosByName(produto);
            var produtoVm = new ProdutoViewModel() {
                Produtos = produtosResult,
                TotalProdutos = produtosResult.Count()
            };

            return View(produtoVm);
        }

        [HttpGet]
        public async Task<IActionResult> ListProductsJson(int numberPage, int limit)
        {   
            var produtoVm = new ProdutoViewModel(){
                LastProducts = await _produtoRepository.GetProductosRecentes(),
                Produtos = await _produtoRepository.GetAll(numberPage, limit)
            };
          
            return Json(produtoVm);
        }

        [HttpGet]
        public async Task<IActionResult> Detalhes(int id){
            if(id <= 0){
                this.Menssagem = "Produto não encontrado";
                return View(this.Menssagem);
            }
            var produtoResult = await _produtoRepository.GetById(id);
            if(produtoResult == null){
                this.Menssagem = "Produto não encontrado";
                return View(this.Menssagem);
            }
            var produtoVm = new ProdutoViewModel(){
                Produto = produtoResult,
                LastProducts = await _produtoRepository.GetProductosRecentes()
            };
            return View(produtoVm);
        }

        [HttpGet]
        public async Task<IActionResult> ProdutosPorCategoria(int id) { 
            var categoriaVm = new CategoriaViewModel(){
                Categoria = await _categoriaRepository.GetById(id)
            };
            return View(categoriaVm);
        }

        [HttpGet]
        public async Task<IActionResult> ProdutosPorCategoriaAjax(int id, int numberPage, int limit){
            var produtoVm = new ProdutoViewModel(){
                Produtos = await _produtoRepository.GetProdutosByCatergoriaId(id, numberPage, limit)
            };
            return Json(produtoVm);
        }

    }
}
