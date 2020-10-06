using System.Collections.Generic;
using divisima.Models;

namespace divisima.ViewModels
{
    public class ProdutoViewModel: AbstractFeedbackViewModel
    {
        public List<Produto> Produtos { get; set; }
        public List<Produto> LastProducts { get; set; }
        public List<Categoria> CategoriasAtivas { get; set; }
    }
}