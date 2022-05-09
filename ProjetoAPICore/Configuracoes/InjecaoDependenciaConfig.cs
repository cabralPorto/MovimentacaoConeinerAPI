using ProjetoAPICore.Data.Repository;
using ProjetoAPICore.Dtos.Interfaces;
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
            
            services.AddScoped<IConteinerRepository, ConteinerRepository>();
            services.AddScoped<IConteinerService, ConteinerService>();

            return services;
        }
    }
}
