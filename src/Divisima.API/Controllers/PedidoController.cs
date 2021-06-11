using System;
using System.Threading.Tasks;
using divisima.ViewModels;
using Divisima.Models;
using Divisima.Repository;
using Divisima.Repository.Contracts;
using Divisima.Services.Pedidos;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using Divisima.Enums.PagamentoEnums;
using Divisima.Services.Exceptions;
using divisima.Repository.Contracts;
using Divisima.API.ViewModels;
using Divisima.Enums;
using Divisima.Services.ResponseMensageService;
using Divisima.Enums.StatusMensageEnums;
using Divisima.Services.CarrinhoCompra;
using System.Linq;

namespace Divisima.Controllers
{
    public class PedidoController : Controller
    {
        private readonly UserManager<Usuario> _userManager;
        private readonly ICarrinhoCompraItemRepository _carrinhoCompraRepository;
        private readonly IPedidoItemRepository _pedidoItemRepository;
        private readonly IPedidoRepository _pedidoRepository;
        private readonly IGerenciadorPedido _gerenciadorPedido;
        private readonly IProdutoRepository _produtoRepository;
        public PedidoController(
            UserManager<Usuario> userManager,
            ICarrinhoCompraItemRepository carrinhoCompraRepository,
            IPedidoItemRepository pedidoItemRepository,
            IPedidoRepository pedidoRepository,
            IGerenciadorPedido gerenciadorPedido,
            IProdutoRepository produtoRepository
        ) {
            _userManager = userManager;
            _carrinhoCompraRepository = carrinhoCompraRepository;
            _pedidoItemRepository = pedidoItemRepository;
            _pedidoRepository = pedidoRepository;
            _gerenciadorPedido = gerenciadorPedido;
            _produtoRepository = produtoRepository;
        }

        [Authorize]
        [HttpGet]
        public IActionResult Checkout() => View();

        [HttpGet, ActionName("ItensCarrinhoResumo")]
        public async Task<IActionResult> ItensCarrinhoResumo() 
        {
            Usuario usuario = await _userManager.GetUserAsync(HttpContext.User);
            var carrinhoVm = new CarrinhoCompraViewModel();
            if (usuario != null)
            {
                var produtosAdicionados = await _carrinhoCompraRepository.GetItemsForUserById(usuario.Id);
                carrinhoVm.CarrinhoCompraList = produtosAdicionados;
                carrinhoVm.ValorTotalItems = _carrinhoCompraRepository.GetValorTotalDeItems(produtosAdicionados);
            }
 
            return Json(carrinhoVm);
        }

        [Authorize]
        [HttpPost, ActionName("Checkout")]
        public async Task<IActionResult> CheckoutConfirm(Pedido pedido) 
        {
            try {
                
                Usuario usuario = await _userManager.GetUserAsync(HttpContext.User);
                var carrinhoCompraItems = await _carrinhoCompraRepository.GetItemsForUserById(usuario.Id);

                if(carrinhoCompraItems.Count < 1) {
                    throw new InvalidArgumentException("Não foi possível cadastrar o pedido pois seu carrinho de compras está vazio!");         
                }

                pedido.UsuarioId = usuario.Id;
                await _gerenciadorPedido.ExecutarPedido(pedido, carrinhoCompraItems);
                
                TempData["Mensagem"] = "Compra feita com sucesso, aguarde em breve você receberá sua encomenda !";
                return Json("Compra feita com sucesso, aguarde em breve você receberá sua encomenda !");
                
            } catch(Exception e) {
                TempData["Error"] = e.Message;
                return Json(e.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> CheckoutMercadoPago(long id)
        {
            var usuario = _userManager.GetUserAsync(HttpContext.User).Result;
            var produtoResult = await _produtoRepository.GetById(id);

            var produtosDoUsuario = await _carrinhoCompraRepository.GetItemsForUserById(usuario.Id);
            var isProdutoAdicionado = CarrinhoCompraService.VerificarProdutoAdicionadoAoCarrinho(produtosDoUsuario, (int)produtoResult.ProdutoId);

            var checkouMercadoPagoViewModel = new CheckoutMercadoPagoViewModel
            {
                Produto = produtoResult,
                CarrinhoCompraItem = produtosDoUsuario.FirstOrDefault(p => p.ProdutoId == produtoResult.ProdutoId)
            };

            if(!isProdutoAdicionado) {
                var carrinhoMontado = _carrinhoCompraRepository.CreateObject(produtoResult.ProdutoId, 1, usuario.Id);
                checkouMercadoPagoViewModel.CarrinhoCompraItem = await _carrinhoCompraRepository.Adicionar(carrinhoMontado);
            }

            return View(checkouMercadoPagoViewModel);
        }

        [HttpPost, ActionName("CheckoutMercadoPago")]
        public async Task<IActionResult> CheckoutMercadoPago(
            long produtoId,
            long carrinhoCompraId,
            string cep,
            string cidade,
            string estado,
            string bairro,
            string endereco,
            string numero,
            string complemento,
            decimal valorTotal
        ) 
        {
            var usuario = _userManager.GetUserAsync(HttpContext.User).Result;

            var pedidoCadastrado = await _pedidoRepository.Cadastrar(new Pedido 
                {
                    UsuarioId = usuario.Id,
                    Cep = cep,
                    Cidade = cidade,
                    Estado = estado,
                    Bairro = bairro,
                    Endereco = endereco,
                    Numero = numero,
                    Complemento = complemento,
                    ValorTotal = valorTotal,
                    Data = DateTime.UtcNow,
                    Status = PagamentoStatusEnum.Pago,
                    Entregue = BooleanoEnum.Nao
                }
            );

            var pedidoItem = new PedidoItem
            {
                PedidoId = pedidoCadastrado.PedidoId,
                ProdutoId = produtoId,
                Quantidade = 1
            };

            await _pedidoItemRepository.Cadastrar(pedidoItem);
            var carrinhoResult = await _carrinhoCompraRepository.GetCarrinhoItemById(carrinhoCompraId);
            await _carrinhoCompraRepository.Remover(carrinhoResult);
            await _produtoRepository.BaixarQuantidadeProduto(produtoId, 1);

            var produtoResult = await _produtoRepository.GetById(produtoId);

            return Json(ResponseMensage.GetMensage(StatusMensageEnum.warning, produtoResult.LinkMercadoPago));
        }

    }
}