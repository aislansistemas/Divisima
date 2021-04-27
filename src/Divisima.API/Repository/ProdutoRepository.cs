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

        public async Task BaixarQuantidadeProduto(int produtoId, int quantidade)
        {
            try {
                var produtoResult = await _context.Produtos.FirstOrDefaultAsync(x => x.ProdutoId == produtoId);
                produtoResult.Quantidade -= quantidade;
                await this.Editar(produtoResult);
            } catch(Exception) {
                throw new DbConcurrencyException("Não foi possível atualizar o produto.");
            }
        }

        public async Task<List<Produto>> BuscarProdutosByName(string nomeProduto) 
        {
            try {
                var produtos = await _context.Produtos
                .AsNoTrackingWithIdentityResolution()
                .Include(x => x.Categoria)
                .Include(x => x.Foto)
                .Where(p => EF.Functions.Like(p.Nome, "%" + nomeProduto + "%") && p.Quantidade > 0)
                .OrderByDescending(p => p.ProdutoId)
                .ToListAsync();

                return produtos;
            } catch(Exception) {
                throw new NotFoundException("Nenhum produto encontrado.");
            }
        }

        public async Task Cadastrar(Produto produto)
        {
            try {
                produto.DataCadastro = DateTime.Now;
                _context.Produtos.Add(produto);
                await _context.SaveChangesAsync();
            } catch(Exception) {
                throw new CreatedException("Não foi possível cadastrar o produto.");
            }
            
        }

        public async Task Deletar(Produto produto)
        {
            try{
                _context.Produtos.Remove(produto);
                await _context.SaveChangesAsync();
            } catch(Exception) {
                throw new DbConcurrencyException("Não foi possível deletar o produto.");
            }
        }

        public async Task Editar(Produto produto)
        {  
            try{
                _context.Produtos.Update(produto);
                await _context.SaveChangesAsync();
            } catch(DbUpdateConcurrencyException) {
                throw new DbConcurrencyException("Não foi possível atualizar o produto.");
            }
        }

        public async Task<List<Produto>> GetAll(int numberPage = 0, int limit = 5)
        {
            try {
                var produtos = await _context.Produtos
                .AsNoTrackingWithIdentityResolution()
                .Include(x => x.Categoria)
                .Include(x => x.Foto)
                .Where(x => x.Quantidade > 0)
                .OrderByDescending(x => x.ProdutoId)
                .Skip((numberPage - 1) * limit)
                .Take(limit)
                .ToListAsync();

                return produtos;
            } catch(Exception) {
                throw new NotFoundException("Nenhum produto encontrado.");
            }
            
        }

        public async Task<Produto> GetById(int id)
        {   
            try{
                return await _context.Produtos
                .AsNoTrackingWithIdentityResolution()
                .Include(x => x.Categoria)
                .Include(x => x.Foto)
                .FirstOrDefaultAsync(x => x.ProdutoId == id);
            } catch(Exception) {
                throw new NotFoundException("O Produto não foi encontrado");
            }
        }

        public async Task<Produto> GetLastProdutoCadastrado()
        {
            try{
                var lastProdutoCadastrado = await _context.Produtos
                .AsNoTrackingWithIdentityResolution()
                .OrderBy(x => x.ProdutoId)
                .LastOrDefaultAsync();

                return lastProdutoCadastrado;
            } catch(Exception) {
                throw new NotFoundException("Produto não encontrado");
            }
        }

        public async Task<List<Produto>> GetProductosRecentes(int numberResults = 5)
        {
            try {
                var lastProducts = await _context.Produtos
                .AsNoTracking()
                .Include(x => x.Categoria)
                .Include(x => x.Foto)
                .Where(x => x.Quantidade > 0)
                .OrderByDescending(x => x.ProdutoId)
                .Take(numberResults)
                .ToListAsync();

                return lastProducts;
            } catch(Exception) {
                throw new NotFoundException("Nenhum produto encontrado.");
            }
        }

        public async Task<List<Produto>> GetProdutosByCatergoriaId(int categoriaId, int numberPage = 1, int limit = 5)
        {
            try {
                var produtosPorCategoria = await _context.Produtos.AsNoTracking()
                .Where(p => p.CategoriaId == categoriaId && p.Quantidade > 0)
                .Include(x => x.Categoria)
                .Include(x => x.Foto)
                .OrderByDescending(x => x.ProdutoId)
                .Skip((numberPage - 1) * limit)
                .Take(limit)
                .ToListAsync();

                return produtosPorCategoria;
            } catch(Exception) {
                throw new NotFoundException("Nenhum produto encontrado.");
            }
        }
    }
}