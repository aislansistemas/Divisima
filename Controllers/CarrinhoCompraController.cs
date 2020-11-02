using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using divisima.Models;
using divisima.Repository.Contracts;
using Divisima.Models;
using Divisima.Repository.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Divisima.Controllers
{
    public class CarrinhoCompraController : Controller
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly UserManager<Usuario> _userManager;
        private readonly ICarrinhoCompraItemRepository _carrinhoCompraRepository;

        public CarrinhoCompraController(
            IProdutoRepository produtoRepository,
            ICarrinhoCompraItemRepository carrinhoCompraItemRepository,
            UserManager<Usuario> userManager
        ){
            this._produtoRepository = produtoRepository;
            this._carrinhoCompraRepository = carrinhoCompraItemRepository;
            this._userManager = userManager;
            
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Index(){
            Usuario usuario = await _userManager.GetUserAsync(HttpContext.User);
            var itemsCarrinho = await _carrinhoCompraRepository.GetItemsForUserById(usuario.Id);
            return View(itemsCarrinho);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Adicionar(int produtoId, int quantidade){
            try{
                var produtoResult = await _produtoRepository.GetById(produtoId);
                if(produtoResult != null){
                    Usuario usuario = _userManager.GetUserAsync(HttpContext.User).Result;
                    var carrinhoMontado = _carrinhoCompraRepository.CreateObject(produtoId, quantidade, usuario.Id);
                    await _carrinhoCompraRepository.Adicionar(carrinhoMontado);
                }
                return RedirectToAction("Index", "Produto");           
            } catch(Exception) {
                throw new Exception("Desculpe ocorreu um erro no servidor");
            }
        } 


    }
}