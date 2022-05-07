using ProjetoAPICore.Data.Repository;
using ProjetoAPICore.Interfaces;
using ProjetoAPICore.Servicos;

namespace ProjetoAPICore.Configuracoes
{
    public static class InjecaoDependenciaConfig
    {
        public static IServiceCollection ResolverInjecaoDependencia(this IServiceCollection services)
        {           
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IClienteService, ClienteService>();

            return services;
        }
    }
}
