using System.Collections.Generic;
using divisima.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;
using Divisima.Models;
using divisima.ViewModels;
using Divisima.Repository.Contracts;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System;

namespace Divisima.Components
{
    public class CarrinhoCompraResumo : ViewComponent
    {
        private readonly ICarrinhoCompraItemRepository _carrinhoRepository;
        private readonly UserManager<Usuario> _userManager;
        public CarrinhoCompraResumo(
            ICarrinhoCompraItemRepository carrinhoRepository,
            UserManager<Usuario> userManager
        )
        {
            this._carrinhoRepository = carrinhoRepository;
            this._userManager = userManager;
        }

        public IViewComponentResult Invoke()
        {
            try {
                var carrinhoVM = new CarrinhoCompraViewModel();
                if(User.Identity.IsAuthenticated) 
                {
                    Usuario usuario = _userManager.GetUserAsync(HttpContext.User).Result;
                    var carrinhoComprasForUser = _carrinhoRepository.GetItemsForUserById(usuario.Id).Result;
                    carrinhoVM.CarrinhoCompraList = carrinhoComprasForUser;
                    carrinhoVM.TotalItems = carrinhoComprasForUser.Count;
        
                    return View(carrinhoVM);
                }
                return View(carrinhoVM);
            } 
            catch(Exception) 
            {
                return View();
            }
        }

       
    }
}