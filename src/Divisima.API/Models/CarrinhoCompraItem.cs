using System.ComponentModel.DataAnnotations;
using divisima.Models;

namespace Divisima.Models
{
    public class CarrinhoCompraItem
    {
        [Key]
        public long CarrinhoCompraId { get; set; }
        public int Quantidade { get; set; }
        public long ProdutoId { get; set; }
        public string UsuarioId { get; set; }
        public virtual Produto Produto { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}