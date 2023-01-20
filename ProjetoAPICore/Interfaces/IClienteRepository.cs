using ProjetoAPICore.Modelos;

namespace ProjetoAPICore.Interfaces
{
    public interface IClienteRepository
    {
        void AdicionarCliente(Cliente cliente);

        Cliente ObterClientePorId(Guid idCliente);
        IEnumerable<Cliente> ObterTodosClientes();
        Cliente ObterClientePorNome(string nome);
        void AlterarCliente(Cliente cliente);
        void RemoverCliente(Cliente cliente);
    }
}
