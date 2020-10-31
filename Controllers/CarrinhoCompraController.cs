using System.Collections.Generic;
using System.Threading.Tasks;
using divisima.Models;
using divisima.Repository.Contracts;
using Divisima.Repository.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Divisima.Controllers
{
    public class CarrinhoCompraController : Controller
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly ICarrinhoCompraItemRepository _carrinhoCompraRepository;

        public CarrinhoCompraController(
            IProdutoRepository produtoRepository,
            ICarrinhoCompraItemRepository carrinhoCompraItemRepository
        ){
            this._produtoRepository = produtoRepository;
            this._carrinhoCompraRepository = carrinhoCompraItemRepository;
        }
        public async Task<IActionResult> Adicionar(int id){
        
            return RedirectToAction("Index", "Produto");           
        } 
    }
}