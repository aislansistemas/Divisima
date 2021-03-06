using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using divisima.Models;
using divisima.Repository.Contracts;
using divisima.ViewModels;
using Divisima.Enums.StatusMensageEnums;
using Divisima.Models;
using Divisima.Repository.Contracts;
using Divisima.Services.CarrinhoCompra;
using Divisima.Services.Exceptions;
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
        )
        {
            this._produtoRepository = produtoRepository;
            this._carrinhoCompraRepository = carrinhoCompraItemRepository;
            this._userManager = userManager;
            
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var usuario = await _userManager.GetUserAsync(HttpContext.User);
            var produtosAdicionados = await _carrinhoCompraRepository.GetItemsForUserById(usuario.Id);
            var carrinhoVm = new CarrinhoCompraViewModel
            { 
                CarrinhoCompraList = produtosAdicionados,
                ValorTotalItems = _carrinhoCompraRepository.GetValorTotalDeItems(produtosAdicionados)
            };

            return View(carrinhoVm);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Adicionar(int produtoId, int quantidade)
        {
            try
            {
                var produtoResult = await _produtoRepository.GetById(produtoId);
                if(produtoResult != null) 
                {
                    var usuario = _userManager.GetUserAsync(HttpContext.User).Result;
                    var produtosDoUsuario = await _carrinhoCompraRepository.GetItemsForUserById(usuario.Id);
                    var isProdutoAdicionado = CarrinhoCompraService.VerificarProdutoAdicionadoAoCarrinho(produtosDoUsuario, produtoId);
                    
                    if(isProdutoAdicionado) 
                    {
                        throw new InvalidArgumentException("Este produto ja foi adicionado em seu carrinho.");
                    }

                    var carrinhoMontado = _carrinhoCompraRepository.CreateObject(produtoId, quantidade, usuario.Id);
                    await _carrinhoCompraRepository.Adicionar(carrinhoMontado);
                    return Json(ResponseMensage.GetMensage(StatusMensageEnum.success, "Produto Adicionado ao carrinho!"));
                }

                return Json(ResponseMensage.GetMensage(StatusMensageEnum.warning, "O produto não foi encontrado!"));
                     
            } 
            catch(Exception e) 
            {
                return Json(ResponseMensage.GetMensage(StatusMensageEnum.error, e.Message));
            }
        } 

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Remover(int carrinhoId)
        {
            try
            {
                if(carrinhoId < 1)
                {
                    return Json(ResponseMensage.GetMensage(StatusMensageEnum.warning, "O produto não foi encontrado!"));
                }

                var carrinhoResult = await _carrinhoCompraRepository.GetCarrinhoItemById(carrinhoId);

                if(carrinhoResult == null)
                {
                    return Json(ResponseMensage.GetMensage(StatusMensageEnum.warning, "O produto não foi encontrado!"));
                }
                
                await _carrinhoCompraRepository.Remover(carrinhoResult);
                return Json(ResponseMensage.GetMensage(StatusMensageEnum.success, "Item removido com sucesso"));
            } 
            catch(Exception) 
            {
                return Json(ResponseMensage.GetMensage(StatusMensageEnum.error, "Desculpe ocorreu um erro no servidor"));
            }

        }

    }
}