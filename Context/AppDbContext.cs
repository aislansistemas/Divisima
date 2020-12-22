using divisima.Models;
using Divisima.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace divisima.Context
{
    public class AppDbContext : IdentityDbContext<Usuario>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) {}

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<CarrinhoCompraItem> CarrinhoCompraItems { get; set; }
        public DbSet<PedidoItem> PedidoItem { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<FotoProduto> FotoProduto { get; set; }
    }
}