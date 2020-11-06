using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using divisima.Models;
using divisima.Repository.Contracts;
using divisima.ViewModels;
using Divisima.Enums.StatusMensageEnums;
using Divisima.Models;
using Divisima.Repository.Contracts;
using Divisima.Services.ResponseMensageService;
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
            var carrinhoVm = new CarrinhoCompraViewModel(){ 
                CarrinhoCompraList = await _carrinhoCompraRepository.GetItemsForUserById(usuario.Id),
                ValorTotalItems = _carrinhoCompraRepository.GetValorTotalDeItems(usuario.Id)
            };
            return View(carrinhoVm);
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

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Remover(int carrinhoId){
            try{
                if(carrinhoId < 1){
                    return Json(ResponseMensage.GetMensage(StatusMensageEnum.warning, "O produto não foi encontrado!"));
                }

                var carrinhoResult = await _carrinhoCompraRepository.GetCarrinhoItemById(carrinhoId);

                if(carrinhoResult == null){
                    return Json(ResponseMensage.GetMensage(StatusMensageEnum.warning, "O produto não foi encontrado!"));
                }
                
                await _carrinhoCompraRepository.Remover(carrinhoResult);
                return Json(ResponseMensage.GetMensage(StatusMensageEnum.success, "Item removido com sucesso"));
            } catch(Exception) {
                return Json("Ocorreu um erro ao tentar realizar a operação!");
            }

        }

    }
}