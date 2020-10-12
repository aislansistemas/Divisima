using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Divisima.Enums.PerfilUsuarioEnums;
using Divisima.Models;
using Divisima.Repository.Contracts;
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

        public AccountRepository(
            UserManager<Usuario> userManager,
            RoleManager<IdentityRole> roleManeger
        ){
            _userManager = userManager;
            _roleManeger = roleManeger;
        } 
        public async Task CadastraRoles(string roleName)
        {
            if(roleName != null){
                await _roleManeger.CreateAsync(new IdentityRole(roleName));
            }
        }

        public async Task<Usuario> CadastraUsuario(CadastroUsuarioViewModel cadastroUsuarioVm)
        {
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
            await this.SetRoleForUsuario(user, PerfilUsuarioEnum.Comun);
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
            return await _userManager.FindByNameAsync(email);
        }

        public async Task<List<Usuario>> GetAll(){
            return await _userManager.Users.ToListAsync();
        }

        public async Task Atualizar(Usuario usuario)
        {
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
        }
    }
}