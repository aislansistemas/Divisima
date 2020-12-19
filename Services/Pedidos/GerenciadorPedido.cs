using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using divisima.Repository.Contracts;
using Divisima.Enums.PagamentoEnums;
using Divisima.Models;
using Divisima.Repository.Contracts;
using Divisima.Services.Exceptions;

namespace Divisima.Services.Pedidos
{
    public class GerenciadorPedido : IGerenciadorPedido
    {   
        private readonly IPedidoRepository _pedidoRepository;
        private readonly ICarrinhoCompraItemRepository _carrinhoCompraRepository;
        private readonly IPedidoItemRepository _pedidoItemRepository;
        private readonly IProdutoRepository _produtoRepository;
        public GerenciadorPedido(
            IPedidoRepository pedidoRepository,
            IPedidoItemRepository pedidoItemRepository,
            ICarrinhoCompraItemRepository carrinhoCompraRepository,
            IProdutoRepository produtoRepository
        ) {
            _pedidoRepository = pedidoRepository;
            _pedidoItemRepository = pedidoItemRepository;
            _carrinhoCompraRepository = carrinhoCompraRepository;
            _produtoRepository = produtoRepository;
        }

        public async Task ExecutarPedido(Pedido pedido, List<CarrinhoCompraItem> carrinhoCompraItens)
        {
            try {
                pedido.ValorTotal = _carrinhoCompraRepository.GetValorTotalDeItems(carrinhoCompraItens);
                pedido.Status = PagamentoStatusEnum.Pendente;
                pedido.Data = DateTime.Now;
                await _pedidoRepository.Cadastrar(pedido);
                var pedidoCadastrado = await _pedidoRepository.GetLastPedido();
                await this.InserirPedidoItens(pedidoCadastrado.PedidoId, carrinhoCompraItens);
            } catch(Exception) {
                throw new CreatedException("Não por possível cadastrar o pedido no momento, Por favor tente novamente mais tarde.");
            }
        }

        private async Task InserirPedidoItens(int pedidoId, List<CarrinhoCompraItem> carrinhoCompraItens){
            foreach(CarrinhoCompraItem carrinhoItem in carrinhoCompraItens) {
                var pedidoItem = new PedidoItem(){
                    PedidoId = pedidoId,
                    ProdutoId = carrinhoItem.ProdutoId,
                    Quantidade = carrinhoItem.Quantidade
                };
                await _produtoRepository.BaixarQuantidadeProduto(carrinhoItem.ProdutoId, carrinhoItem.Quantidade);
                await _pedidoItemRepository.Cadastrar(pedidoItem);
                var carrinhoResult = await _carrinhoCompraRepository.GetCarrinhoItemById(carrinhoItem.CarrinhoCompraId);
                await _carrinhoCompraRepository.Remover(carrinhoResult);
            }
        }

    }
}