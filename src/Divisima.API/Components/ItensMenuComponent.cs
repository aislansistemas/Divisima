using divisima.Repository.Contracts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Divisima.API.Components
{
    public class ItensMenuComponent : ViewComponent
    {
        private readonly ICategoriaRepository _categoriaRepository;
        public ItensMenuComponent(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

        public IViewComponentResult Invoke()
        {
            var categorias = _categoriaRepository.GetAllAtiva().Result;
            return View(categorias);
        }
    }
}
