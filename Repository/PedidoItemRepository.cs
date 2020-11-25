using System.Threading.Tasks;
using divisima.Context;
using Divisima.Models;
using Divisima.Repository.Contracts;

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
    }
}