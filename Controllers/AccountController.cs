
using System.Threading.Tasks;
using Divisima.Enums.PerfilUsuarioEnums;
using Divisima.Models;
using Divisima.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace divisima.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<Usuario> _userManager;
        private readonly SignInManager<Usuario> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManeger;

        public AccountController(
            UserManager<Usuario> userManager,
            SignInManager<Usuario> signManager,
            RoleManager<IdentityRole> roleManeger
        ){
            _userManager = userManager;
            _signInManager = signManager;
            _roleManeger = roleManeger;
        }

        //implementar login, registro e logout
        public IActionResult Login(string returnUrl)
        {
            return View(new LoginViewModel(){ReturnUrl = returnUrl});
        }

        [HttpPost, ActionName("LoginAjax")]
        public async Task<IActionResult> LoginAjax(LoginViewModel loginVM)
        {
            if (!ModelState.IsValid)
                return Json(loginVM);
            var usuario = _userManager.FindByNameAsync(loginVM.UserName).Result;
            if (_userManager.CheckPasswordAsync(usuario, loginVM.Password).Result) {
                
                await _signInManager.SignInAsync(usuario,false);
                if (string.IsNullOrEmpty(loginVM.ReturnUrl))
                {
                    return Json("Redirect");
                }
                return Json(loginVM.ReturnUrl);
            }
            
            ModelState.AddModelError("", "Usuário/Senha inválidos ou não localizados!!");
            return Json(ModelState);
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
                var usuarioIsExistente = await _userManager.FindByNameAsync(usuarioVm.UserName);
                if(usuarioIsExistente == null){
                    var user = new Usuario() { 
                        UserName = usuarioVm.UserName, 
                    };
                    var result = await _userManager.CreateAsync(user, usuarioVm.Password);

                    if (result.Succeeded)
                    {
                        var perfilUsuario = PerfilUsuarioEnum.Comun;
                        await _userManager.AddToRoleAsync(user, perfilUsuario);
                        await _signInManager.SignInAsync(user, isPersistent: false);

                        return Json("Cadastro feito com sucesso!");
                    }
                }
                return Json("Já existe um usuario com o mesmo E-mail cadastrado");
            }
            return Json(usuarioVm);
        }

        public ViewResult LoggedIn() => View();

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult CreateRoles(){
            return View();
        }

        [HttpPost, ActionName("CreateRoles")]
        public async Task<IActionResult> CreateRoles(string role){
            await _roleManeger.CreateAsync(new IdentityRole(role));
            return RedirectToAction(nameof(Login));
        }
    }
}