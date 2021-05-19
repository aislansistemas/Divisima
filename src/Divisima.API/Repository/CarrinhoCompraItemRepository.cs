using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using divisima.Context;
using divisima.Models;
using Divisima.Models;
using Divisima.Repository.Contracts;
using Divisima.Services.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace Divisima.Repository
{
    public class CarrinhoCompraItemRepository : ICarrinhoCompraItemRepository
    {
        private readonly AppDbContext _context;

        public CarrinhoCompraItemRepository(AppDbContext context)
        {
            _context = context;   
        }

        public async Task Adicionar(CarrinhoCompraItem carrinhoCompraItem)
        {
            try {
                _context.Add(carrinhoCompraItem);
                await _context.SaveChangesAsync();
            } catch(Exception) {
                throw new CreatedException("Não foi possível adicionar o produto ao carrinho!");
            }
        }

        public CarrinhoCompraItem CreateObject(long produtoId, int quantidade, string usuarioId)
        {
            var carrinhoCompraItem = new CarrinhoCompraItem(){
                Quantidade = quantidade,
                ProdutoId = produtoId,
                UsuarioId = usuarioId
            };
            return carrinhoCompraItem;
        }

        public async Task<CarrinhoCompraItem> GetCarrinhoItemById(long id)
        {
            try {
                return await _context.CarrinhoCompraItems.AsNoTrackingWithIdentityResolution().FirstOrDefaultAsync(x => x.CarrinhoCompraId == id);
            } catch(Exception) {
                throw new NotFoundException("Não foi possível localizar o item!");
            }
        }

        public async Task<List<CarrinhoCompraItem>> GetItemsForUserById(string id)
        {
            try {
                var carrinhoCompraItem = await _context.CarrinhoCompraItems
                .AsNoTrackingWithIdentityResolution()
                .Include(x => x.Produto)
                .Include(x => x.Produto.Foto)
                .Include(x => x.Usuario)
                .Where(x => x.UsuarioId == id && x.Quantidade > 0)
                .OrderByDescending(x => x.CarrinhoCompraId) 
                .ToListAsync();

                return carrinhoCompraItem;

            } catch(Exception ) {
                throw new NotFoundException("Não foi possível localizar os produtos!");
            }
        }

        public decimal GetValorTotalDeItems(List<CarrinhoCompraItem> carrinhoCompraItems)
        {
            decimal valorTotalDeItems = carrinhoCompraItems.Sum(x => x.Produto.Valor);
            return valorTotalDeItems;
        }

        public async Task Remover(CarrinhoCompraItem carrinhoCompraItem)
        {
            try{
                _context.CarrinhoCompraItems.Remove(carrinhoCompraItem);
                await _context.SaveChangesAsync();
            } catch(Exception) {
                throw new NotFoundException("Não foi possível localizar o item!");
            }
        }
    }
}