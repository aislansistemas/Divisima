using System.Collections.Generic;
using divisima.Models;

namespace divisima.ViewModels
{
    public class ProdutoViewModel: AbstractFeedbackViewModel
    {   
        public Produto Produto { get; set; }
        public int TotalProdutos { get; set; }
        public List<Produto> Produtos { get; set; }
        public List<Produto> LastProducts { get; set; }
        public List<Categoria> CategoriasAtivas { get; set; }
    }
}