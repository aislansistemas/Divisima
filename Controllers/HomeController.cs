using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using divisima.Models;
using divisima.Repository.Contracts;
using divisima.ViewModels;

namespace divisima.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProdutoRepository _produtoRepository;

        public HomeController(IProdutoRepository produtoRepository, ILogger<HomeController> logger)
        {
            _produtoRepository = produtoRepository;
        }

        public async Task<IActionResult> Index()
        {   
            var produtoVm = new ProdutoViewModel(){
                LastProducts = await _produtoRepository.GetProductosRecentes(),
                Produtos = await _produtoRepository.GetAll()
            };
            return View(produtoVm);
        }

        [HttpGet]
        public async Task<IActionResult> ListProductsJson()
        {   
            var produtoVm = new ProdutoViewModel(){
                LastProducts = await _produtoRepository.GetProductosRecentes(),
                Produtos = await _produtoRepository.GetAll()
            };
            return Json(produtoVm);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
