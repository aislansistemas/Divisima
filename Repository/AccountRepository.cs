using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using divisima.Context;
using Divisima.Enums.PerfilUsuarioEnums;
using Divisima.Models;
using Divisima.Repository.Contracts;
using Divisima.Services.Exceptions;
using Divisima.ViewModels;
using Divisima.ViewModels.Account;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Divisima.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly UserManager<Usuario> _userManager;
        private readonly RoleManager<IdentityRole> _roleManeger;
        private readonly AppDbContext _context;

        public AccountRepository(
            UserManager<Usuario> userManager,
            RoleManager<IdentityRole> roleManeger,
            AppDbContext context
        ){
            _userManager = userManager;
            _roleManeger = roleManeger;
            _context = context;
        } 
        public async Task CadastraRoles(string roleName)
        {
            if(roleName != null){
                await _roleManeger.CreateAsync(new IdentityRole(roleName));
            }
        }

        public async Task<Usuario> CadastrarUsuario(
            CadastroUsuarioViewModel cadastroUsuarioVm, 
            string roleName
        ) {
            var user = new Usuario() { 
                UserName = cadastroUsuarioVm.UserName, 
                Nome = cadastroUsuarioVm.Nome,
                Sobrenome = cadastroUsuarioVm.Sobrenome,
                Cpf = cadastroUsuarioVm.Cpf,
            };
            var result = await _userManager.CreateAsync(user, cadastroUsuarioVm.Password);
            if(!result.Succeeded){
                throw new Exception("Erro ao tentar cadastrar um novo usuario");
            }
            await this.SetRoleForUsuario(user, roleName);
            return user;
        }
    
        private async Task SetRoleForUsuario(Usuario usuario, string roleName){
            var roleResult = await _roleManeger.FindByNameAsync(roleName);
            if(roleResult == null){
                await _roleManeger.CreateAsync(new IdentityRole(roleName));
            }
            await _userManager.AddToRoleAsync(usuario, roleName);
        }   

        public async Task<bool> PasswordIsValid(Usuario usuario, string password){
            bool result = await _userManager.CheckPasswordAsync(usuario, password);
            return result;
        }
        public async Task<Usuario> GetUserByEmail(string email)
        {
            try{
                return await _userManager.FindByNameAsync(email);
            } catch(Exception) {
                throw new NotFoundException("Erro ao procurar email");
            }
        }

        public async Task<List<Usuario>> GetAll(int numberPage, int limit){
            return await _context.Users
            .AsNoTrackingWithIdentityResolution()
            .OrderByDescending(x => x.Id)
            .Skip((numberPage - 1) * limit)
            .Take(limit)
            .ToListAsync();
        
        }

        public async Task Atualizar(Usuario usuario)
        {
            try{
                Usuario user = new Usuario(){
                    UserName = usuario.UserName, 
                    Nome = usuario.Nome,
                    Sobrenome = usuario.Sobrenome,
                    Cpf = usuario.Cpf,
                    Cep = usuario.Cep,
                    Cidade = usuario.Cidade,
                    Estado = usuario.Estado,
                    Endereco = usuario.Endereco,
                    Numero = usuario.Numero,
                    Complemento = usuario.Complemento,
                    Telefone = usuario.Telefone,
                    Foto = usuario.Foto,
                };
                await _userManager.UpdateAsync(usuario);
            } catch (DbUpdateConcurrencyException e) {
                throw new DbConcurrencyException(e.Message);
            }   
        }
    }
}