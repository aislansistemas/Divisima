using divisima.Models;

namespace Divisima.Models
{
    public class PedidoItem
    {
        public int PedidoItemID { get; set; }
        public int Quantidade { get; set; }
        public int ProdutoId { get; set; }
        public int PedidoId { get; set; }
        public virtual Produto Produto { get; set; }
        public virtual Pedido Pedido { get; set; }
    }
}