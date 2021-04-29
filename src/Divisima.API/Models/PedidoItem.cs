using System.ComponentModel.DataAnnotations;
using divisima.Enums.ProdutoEnums;
using divisima.Models;

namespace Divisima.Models
{
    public class PedidoItem
    {
        [Key]
        public long PedidoItemId { get; set; }
        public int Quantidade { get; set; }
        public long ProdutoId { get; set; }
        public long PedidoId { get; set; }
        public ProdutoTamanhoEnum Tamanho { get; set; }
        public virtual Produto Produto { get; set; }
        public virtual Pedido Pedido { get; set; }
    }
}