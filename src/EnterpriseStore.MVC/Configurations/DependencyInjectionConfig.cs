
using EnterpriseStore.Data.Context;
using EnterpriseStore.Data.Repository;
using EnterpriseStore.Domain.Intefaces;
using EnterpriseStore.Domain.Notificacoes;
using EnterpriseStore.MVC.Extensions;
using EnterpriseStore.MVC.Services;
using EnterpriseStore.Service.Services;
using Microsoft.AspNetCore.Mvc.DataAnnotations;

namespace EnterpriseStore.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<MeuDbContext>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IFornecedorRepository, FornecedorRepository>();
            services.AddScoped<IEnderecoRepository, EnderecoRepository>();
            services.AddSingleton<IValidationAttributeAdapterProvider, MoedaValidationAttributeAdapterProvider>();

            services.AddScoped<IEnderecoRepository, EnderecoRepository>();

            services.AddHttpClient<IAutenticacaoService, AutenticacaoService>();

            services.AddScoped<INotificador, Notificador>();

            services.AddScoped<IFornecedorService, FornecedorService>();
            services.AddScoped<IProdutoService, ProdutoService>();

            return services;
        }
    }
}