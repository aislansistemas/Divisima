using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Divisima.Models;
using Divisima.Repository.Contracts;
using Divisima.Services.Exceptions;
using Divisima.ViewModels.Account;
using Microsoft.AspNetCore.Mvc;

namespace Divisima.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UsuarioController: Controller
    {
        private readonly IAccountRepository _accountRepository;

        public UsuarioController(IAccountRepository accRepository)
        {
            _accountRepository = accRepository;
        }

        public IActionResult Index() => View();

        [HttpGet, ActionName("GetUsers")]
        public async Task<IActionResult> GetUsers(int numberPage, int limit){
            List<Usuario> usuario = await _accountRepository.GetAll(numberPage, limit);
            return Json(usuario);
        }


        [HttpGet]
        public IActionResult CadastrarUsuario() => View();

        [HttpPost]
        public async Task<IActionResult> CadastrarUsuario(CadastroUsuarioViewModel usuarioVm) {
            try {
                if(!ModelState.IsValid){
                    throw new InvalidModelStateException("Por favor preencha os dados corretamente!");
                }
                await _accountRepository.CadastrarUsuario(usuarioVm, usuarioVm.Perfil);
                
                return RedirectToAction(nameof(Index));
            } catch(Exception) {
                return View();
            }
        }
    }
}