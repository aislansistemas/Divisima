using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using divisima.Context;
using divisima.Models;
using divisima.Repository.Contracts;
using Divisima.Services.Exceptions;
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
            produto.DataCadastro = DateTime.Now;
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

        public async Task Editar(Produto produto)
        {  
            try{
                _context.Produtos.Update(produto);
                await _context.SaveChangesAsync();
            } catch(DbUpdateConcurrencyException e) {
                throw new DbConcurrencyException(e.Message);
            }
        }

        public async Task<List<Produto>> GetAll(int numberPage = 0, int limit = 5)
        {
            var produtos = await _context.Produtos
            .AsNoTrackingWithIdentityResolution()
            .Where(x => x.Quantidade > 0)
            .Include(x => x.Categoria)
            .Skip((numberPage - 1) * limit)
            .Take(limit)
            .OrderByDescending(x => x.ProdutoId)
            .ToListAsync();
            return produtos;
        }

        public async Task<Produto> GetById(int id)
        {   
            try{
                return await _context.Produtos.AsNoTrackingWithIdentityResolution().FirstOrDefaultAsync(x => x.ProdutoId == id);
            } catch(Exception) {
                throw new NotFoundException("O Produto não foi encontrado");
            }
        }

        public async Task<List<Produto>> GetProductosRecentes(int numberResults = 5)
        {
            var lastProducts = await _context.Produtos
            .AsNoTracking()
            .Where(x => x.Quantidade > 0)
            .Include(x => x.Categoria)
            .OrderByDescending(x => x.ProdutoId)
            .Take(numberResults)
            .ToListAsync();

            return lastProducts;
        }

        public async Task<List<Produto>> GetProdutosByCatergoriaId(int categoriaId, int numberPage = 1, int limit = 5)
        {
            return await _context.Produtos.AsNoTracking()
            .Where(p => p.CategoriaId == categoriaId)
            .Include(x => x.Categoria)
            .Skip((numberPage - 1) * limit)
            .Take(limit)
            .OrderByDescending(x => x.ProdutoId)
            .ToListAsync();
        }
    }
}