using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using divisima.Context;
using divisima.Enums.CategoriaEnums;
using divisima.Models;
using divisima.Repository.Contracts;
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
            return await _dbContext.Categorias.OrderByDescending(x => x.CategoriaId).ToListAsync();
        }

        public async Task<Categoria> GetById(int id)
        {
            try{
                var categoria = await _dbContext.Categorias.AsNoTracking().FirstOrDefaultAsync(x => x.CategoriaId == id);
                return categoria;
                
            } catch(Exception e){
                throw new Exception("Erro na operação", e);
            }
        }

        public async Task Editar(Categoria categoria){
            try{
                _dbContext.Categorias.Update(categoria);
                await _dbContext.SaveChangesAsync();
            } catch(DbUpdateConcurrencyException e) {
                throw new DbUpdateConcurrencyException("Erro na operação", e);
            }
        }

        public async Task Inativar(Categoria categoria)
        {
            try{
                categoria.Ativo = CategoriaAtivoEnum.Inativo;
                _dbContext.Update(categoria);
                await _dbContext.SaveChangesAsync();
            } catch(DbUpdateConcurrencyException e) {
                throw new DbUpdateConcurrencyException("Erro na operação", e);
            }
        }

        public async Task Ativar(Categoria categoria)
        {
            try{
                categoria.Ativo = CategoriaAtivoEnum.Ativo;
                _dbContext.Update(categoria);
                await _dbContext.SaveChangesAsync();
            } catch(DbUpdateConcurrencyException e) {
                throw new DbUpdateConcurrencyException("Erro na operação", e);
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