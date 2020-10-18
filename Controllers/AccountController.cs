
using System.Threading.Tasks;
using Divisima.Enums.PerfilUsuarioEnums;
using Divisima.Models;
using Divisima.Repository.Contracts;
using Divisima.ViewModels;
using Divisima.ViewModels.Account;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace divisima.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<Usuario> _signInManager;
        private readonly IAccountRepository _accRepository;

        public AccountController(
            SignInManager<Usuario> signManager,
            IAccountRepository accRepository
        ){
            _signInManager = signManager;
            _accRepository = accRepository;
        }

        public IActionResult Login(string returnUrl)
        {
            return View(new LoginViewModel(){ReturnUrl = returnUrl});
        }

        [HttpPost, ActionName("LoginAjax")]
        public async Task<IActionResult> LoginAjax(LoginViewModel loginVM)
        {
            if (!ModelState.IsValid)
                return Json("Por favor preencha os dados corretamente !");
                
            var usuario = await _accRepository.GetUserByEmail(loginVM.UserName);
            if (await _accRepository.PasswordIsValid(usuario, loginVM.Password)) {
                
                await _signInManager.SignInAsync(usuario,false);
                if (string.IsNullOrEmpty(loginVM.ReturnUrl))
                {
                    return Json("sucesso");
                }
                return Json(loginVM.ReturnUrl);
            }
           
            return Json("Úsuario não encontrado !");
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost, ActionName("CadastroAjax")]
        public async Task<IActionResult> CadastroAjax(CadastroUsuarioViewModel usuarioVm)
        {
            if (ModelState.IsValid)
            {   
                var usuarioIsExistente = await _accRepository.GetUserByEmail(usuarioVm.UserName);
                if(usuarioIsExistente == null){

                    var usuarioCadastrado = await _accRepository.CadastraUsuario(usuarioVm);
                    await _signInManager.SignInAsync(usuarioCadastrado, isPersistent: false);

                    return Json("sucesso");
                }
                return Json("existente");
            }
            return Json(usuarioVm);
        }

        public ViewResult LoggedIn() => View();

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Produto");
        }

    }
}