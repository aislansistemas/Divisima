using System;
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

        public async Task Deletar(Produto produto)
        {
            try{
                _context.Produtos.Remove(produto);
                await _context.SaveChangesAsync();
            } catch(Exception e) {
                throw new Exception(e.Message);
            }
        }

        public async Task<List<Produto>> GetAll()
        {
            var produtos = await _context.Produtos
            .AsNoTracking()
            .Where(x => x.Quantidade > 0)
            .Include(x => x.Categoria)
            .OrderByDescending(x => x.ProdutoId)
            .ToListAsync();
            return produtos;
        }

        public async Task<Produto> GetById(int id)
        {   
            try{
                return await _context.Produtos.AsNoTracking().FirstOrDefaultAsync(x => x.ProdutoId == id);
            } catch(Exception e) {
                throw new Exception(e.Message);
            }
        }
    }
}