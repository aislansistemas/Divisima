using System;
using System.Threading.Tasks;
using divisima.Context;
using Divisima.Models;
using Divisima.Repository.Contracts;
using Divisima.Services.Exceptions;

namespace Divisima.Repository
{
    public class FotoProdutoRepository : IFotoProdutoRepository
    {
        private readonly AppDbContext _context;
        public FotoProdutoRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task Cadastrar(FotoProduto fotoProduto)
        {
            try {
                _context.FotoProduto.Add(fotoProduto);
                await _context.SaveChangesAsync();
            } catch(Exception) {
                throw new CreatedException("Não foi possível cadastrara as fotos do produto!");
            }
        }
    }
}