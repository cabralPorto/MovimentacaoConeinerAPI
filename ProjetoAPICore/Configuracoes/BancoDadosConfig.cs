using Microsoft.EntityFrameworkCore;
using ProjetoAPICore.Data;

namespace ProjetoAPICore.Configuracoes
{
    public static class BancoDadosConfig
    {
        public static void BancoDadosConfiguracao(this IServiceCollection services, IConfiguration configuration)
        {
            var connection = configuration["DatabaseConnection:Sqlite"];
            services.AddDbContext<DbContexto>(options =>
                options.UseSqlite(connection));
        }
    }
}
