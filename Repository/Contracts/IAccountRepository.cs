using System.Collections.Generic;
using System.Threading.Tasks;
using Divisima.Models;
using Divisima.ViewModels;
using Divisima.ViewModels.Account;
using Microsoft.AspNetCore.Identity;

namespace Divisima.Repository.Contracts
{
    public interface IAccountRepository
    {
         Task<Usuario> GetUserByEmail(string email);
         Task<Usuario> CadastraUsuario(CadastroUsuarioViewModel cadastroUsuarioVm);
         Task CadastraRoles(string roleName);
         Task<bool> PasswordIsValid(Usuario usuario, string password);
         Task<List<Usuario>> GetAll(int numberPage, int limit);
         Task Atualizar(Usuario usuario);
    }
}