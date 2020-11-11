using System.Collections.Generic;
using System.Threading.Tasks;
using divisima.Models;

namespace divisima.ViewModels
{
    public class CategoriaViewModel: AbstractFeedbackViewModel
    {
        public List<Categoria> Categorias { get; set; }
        public Categoria Categoria { get; set; }

    }
}