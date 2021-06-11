using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using divisima.Context;
using divisima.Enums.CategoriaEnums;
using divisima.Models;
using divisima.Repository.Contracts;
using Divisima.Services.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace divisima.Repository
{
    public class CategoriaRepository : ICategoriaRepository
    {   
        private readonly AppDbContext _dbContext; 

        public CategoriaRepository(AppDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task Cadastrar(Categoria categoria)
        {   
            categoria.Ativo = CategoriaAtivoEnum.Ativo;
            _dbContext.Categorias.Add(categoria);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<Categoria>> GetAll()
        {   
            try
            {
                var categorias = await _dbContext.Categorias
                                    .AsNoTrackingWithIdentityResolution()
                                    .OrderByDescending(x => x.CategoriaId)
                                    .ToListAsync();

                return categorias;
            } 
            catch(Exception) 
            {
                throw new NotFoundException("A categoria não foi encontrada.");
            }
        }

        public async Task<Categoria> GetById(long id)
        {
            try
            {
                var categoria = await _dbContext.Categorias
                                    .AsNoTrackingWithIdentityResolution()
                                    .FirstOrDefaultAsync(x => x.CategoriaId == id);

                return categoria;
            } 
            catch(Exception)
            {
                throw new NotFoundException("A categoria não foi encontrada.");
            }
        }

        public async Task Editar(Categoria categoria)
        {
            try
            {
                _dbContext.Categorias.Update(categoria);
                await _dbContext.SaveChangesAsync();
            } 
            catch(DbUpdateConcurrencyException) 
            {
                throw new DbUpdateConcurrencyException("Erro na operação.");
            }
        }

        public async Task Inativar(Categoria categoria)
        {
            try
            {
                categoria.Ativo = CategoriaAtivoEnum.Inativo;
                _dbContext.Update(categoria);
                await _dbContext.SaveChangesAsync();
            } 
            catch(DbUpdateConcurrencyException) 
            {
                throw new DbUpdateConcurrencyException("Erro na operação.");
            }
        }

        public async Task Ativar(Categoria categoria)
        {
            try
            {
                categoria.Ativo = CategoriaAtivoEnum.Ativo;
                _dbContext.Update(categoria);
                await _dbContext.SaveChangesAsync();
            } 
            catch(DbUpdateConcurrencyException) 
            {
                throw new DbUpdateConcurrencyException("Erro na operação.");
            }
        }

        public async Task<List<Categoria>> GetAllAtiva()
        {
            var categoriaAtivas = await _dbContext.Categorias
                                        .Where(x => x.Ativo == CategoriaAtivoEnum.Ativo)
                                        .OrderByDescending(x => x.CategoriaId)
                                        .ToListAsync();

            return categoriaAtivas;
        }
    }
}