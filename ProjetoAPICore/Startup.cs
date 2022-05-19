using Dapper;
using ProjetoAPICore.Configuracoes;
using System.Text;

namespace CurrencyRates.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; set; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.BancoDadosConfiguracao(Configuration);
            services.ResolverInjecaoDependencia();
            services.AddSwaggerGen();
            SqlMapper.AddTypeHandler(new TratamentoGuidString());
            SqlMapper.RemoveTypeMap(typeof(Guid));
            SqlMapper.RemoveTypeMap(typeof(Guid?));
        }

        public void Configure(WebApplication app, IWebHostEnvironment environment)
        {           
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllers();
        }    
    }
}
