using System.ComponentModel.DataAnnotations;
using divisima.Models;

namespace Divisima.Models
{
    public class CarrinhoCompraItem
    {
        [Key]
        public int CarrinhoCompraId { get; set; }
        public int Quantidade { get; set; }
        public int ProdutoId { get; set; }
        public string UsuarioId { get; set; }
        public virtual Produto Produto { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}