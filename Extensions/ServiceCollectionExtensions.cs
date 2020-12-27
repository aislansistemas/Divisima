using divisima.Repository;
using divisima.Repository.Contracts;
using divisima.Services;
using Divisima.Repository;
using Divisima.Repository.Contracts;
using Divisima.Services.Pedidos;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Divisima.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {

            services.AddScoped<ICategoriaRepository, CategoriaRepository>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IAccountRepository, AccountRepository>();
            services.AddScoped<ICarrinhoCompraItemRepository, CarrinhoCompraItemRepository>();
            services.AddScoped<IPedidoRepository, PedidoRepository>();
            services.AddScoped<IPedidoItemRepository, PedidoItemRepository>();
            services.AddScoped<IFotoProdutoRepository, FotoProdutoRepository>();

            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddSingleton<IUploadFile, UploadFile>();
            services.AddScoped<IGerenciadorPedido, GerenciadorPedido>();
            
            return services;
        }

    }
}