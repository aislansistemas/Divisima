using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using divisima.Context;
using Divisima.Models;
using Divisima.Repository.Contracts;
using Microsoft.EntityFrameworkCore;

namespace Divisima.Repository
{
    public class PedidoItemRepository : IPedidoItemRepository
    {
        private readonly AppDbContext _context;
        public PedidoItemRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task Cadastrar(PedidoItem pedidoItem)
        {
            _context.PedidoItem.Add(pedidoItem);
            await _context.SaveChangesAsync();
        }

        public async Task<List<PedidoItem>> GetByPedido(int pedidoId)
        {
            var pedido = await _context.PedidoItem
            .AsNoTrackingWithIdentityResolution()
            .Include(x => x.Pedido)
            .Include(p => p.Produto)
            .Include(p => p.Pedido.Usuario)
            .Where(x => x.PedidoId == pedidoId)
            .ToListAsync();
            
            return pedido;
        }
    }
}