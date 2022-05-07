using ProjetoAPICore.Interfaces;
using ProjetoAPICore.Modelos;

namespace ProjetoAPICore.Data.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly DbContexto _dbContexto;
        public ClienteRepository(DbContexto dbContexto)
        {
            _dbContexto = dbContexto;
        }

        public void CriarCliente(Cliente cliente)
        {
            _dbContexto.Clientes.Add(cliente);
            _dbContexto.SaveChanges();
        }

        public Cliente ObterClientePorId(Guid idCliente)
        {
            return _dbContexto.Clientes.FirstOrDefault(c => c.Id == idCliente);
        }

        public IEnumerable<Cliente> ObterClientes()
        {
            return _dbContexto.Clientes.ToList();
        }
    }
}
