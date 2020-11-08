using System.Collections.Generic;
using divisima.Models;
using Divisima.Models;

namespace divisima.ViewModels
{
    public class CarrinhoCompraViewModel
    {
        public List<CarrinhoCompraItem> CarrinhoCompraList { get; set; }
        public int TotalItems { get; set;}
        public decimal ValorTotalItems { get; set; }
    }
}