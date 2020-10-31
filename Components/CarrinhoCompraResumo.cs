using System.Collections.Generic;
using divisima.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;

namespace Divisima.Components
{
    public class CarrinhoCompraResumo : ViewComponent
    {
        public IViewComponentResult Invoke(){
            ////implementação de teste ///
            TempData["numero_itens"] = 2;
            return View();
        }
    }
}