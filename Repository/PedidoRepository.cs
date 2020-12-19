using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using divisima.Context;
using Divisima.Models;
using Divisima.Repository.Contracts;
using Microsoft.EntityFrameworkCore;

namespace Divisima.Repository
{
    public class PedidoRepository : IPedidoRepository
    {   
        private readonly AppDbContext _context;
        public PedidoRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Pedido>> GetAll(int numberPage = 0, int limit = 5)
        {
            var pedidos = await _context.Pedido
            .AsNoTrackingWithIdentityResolution()
            .Include(x => x.PedidoItem)
            .Include(u => u.Usuario)
            .OrderByDescending(x => x.PedidoId)
            .Skip((numberPage - 1) * limit)
            .Take(limit)
            .ToListAsync();
            
            return pedidos;
        }

        public async Task Cadastrar(Pedido pedido)
        {
            _context.Pedido.Add(pedido);
            await _context.SaveChangesAsync();
        }

        public async Task<Pedido> GetLastPedido() {
            return await _context.Pedido.AsNoTrackingWithIdentityResolution().OrderBy(x => x.PedidoId).LastOrDefaultAsync();
        }
    }
}