using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using divisima.Context;
using divisima.Models;
using divisima.Repository.Contracts;
using Microsoft.EntityFrameworkCore;

namespace divisima.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {   
        private readonly AppDbContext _context;
        public ProdutoRepository(AppDbContext context)
        {
            this._context = context;
        }

        public async Task Cadastrar(Produto produto)
        {
            _context.Produtos.Add(produto);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Produto>> GetAll()
        {
            var produtos = await _context.Produtos
            .Where(x => x.Quantidade > 0)
            .Include(x => x.Categoria)
            .OrderByDescending(x => x.ProdutoId)
            .ToListAsync();
            return produtos;
        }
    }
}