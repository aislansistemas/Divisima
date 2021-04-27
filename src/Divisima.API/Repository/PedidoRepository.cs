using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using divisima.Context;
using Divisima.Models;
using Divisima.Repository.Contracts;
using Divisima.Services.Exceptions;
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
            try {
                var pedidos = await _context.Pedido
                .AsNoTrackingWithIdentityResolution()
                .Include(x => x.PedidoItem)
                .Include(u => u.Usuario)
                .OrderByDescending(x => x.PedidoId)
                .Skip((numberPage - 1) * limit)
                .Take(limit)
                .ToListAsync();
                
                return pedidos;
            } catch(Exception) {
                throw new NotFoundException("Nenhum pedido encontrado.");
            }
        }

        public async Task<Pedido> Cadastrar(Pedido pedido)
        {
            try {
                _context.Pedido.Add(pedido);
                await _context.SaveChangesAsync();

                return pedido;
            } catch(Exception) {
                 throw new CreatedException("Não foi possível cadastrar o pedido.");
            }
        }

    }
}