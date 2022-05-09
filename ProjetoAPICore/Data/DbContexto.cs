using Microsoft.EntityFrameworkCore;
using ProjetoAPICore.Modelos;

namespace ProjetoAPICore.Data
{
    public class DbContexto : DbContext
    {
        public DbContexto(DbContextOptions<DbContexto> configuration) : base (configuration)
        {
            Database.EnsureCreated();
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Conteiner> Conteiners { get; set; }
    }
}
