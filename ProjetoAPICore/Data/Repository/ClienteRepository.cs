using Microsoft.EntityFrameworkCore;
using ProjetoAPICore.Interfaces;
using ProjetoAPICore.Modelos;

namespace ProjetoAPICore.Data.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly DbContexto _dbContexto;
        private readonly IDapperBaseRepository _dapperBaseRepository;
        public ClienteRepository(DbContexto dbContexto,
                                 IDapperBaseRepository dapperBaseRepository)
        {
            _dbContexto = dbContexto;
            _dapperBaseRepository = dapperBaseRepository;
        }

        public void IncluirCliente(Cliente cliente)
        {
            _dbContexto.Clientes.Add(cliente);
            _dbContexto.SaveChanges();
        }

        public Cliente ObterClientePorId(Guid idCliente)
        {
            return _dbContexto.Clientes.FirstOrDefault(c => c.Id == idCliente);
        }

        public IEnumerable<Cliente> ObterTodosClientes()
        {
            return _dbContexto.Clientes.ToList();
        }

        public Cliente ObterClientePorNome(string nome)
        {
            return _dbContexto.Clientes.FirstOrDefault(c => c.NomeCliente == nome);
        }


        public void AlterarCliente(Cliente cliente)
        {
            _dbContexto.Clientes.Update(cliente);
            _dbContexto.SaveChanges();
        }

        public void ExcluirCliente(Cliente cliente)
        {
            _dbContexto.Clientes.Remove(cliente);
            _dbContexto.SaveChanges();
        }

        public Cliente ObterClientePorNomeSQL()
        {
            return _dapperBaseRepository.Obter<Cliente>("SELECT Id, NomeCliente, Cpf, Cnpj, Email FROM Clientes").Result;
        }
    }
}
