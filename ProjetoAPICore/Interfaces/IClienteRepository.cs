using ProjetoAPICore.Modelos;

namespace ProjetoAPICore.Interfaces
{
    public interface IClienteRepository
    {
        void IncluirCliente(Cliente cliente);
        Cliente ObterClientePorId(Guid idCliente);
        IEnumerable<Cliente> ObterTodosClientes();
        Cliente ObterClientePorNome(string nome);
        void AlterarCliente(Cliente cliente);
        void ExcluirCliente(Cliente cliente);
        Cliente ObterClientePorNomeSQL();
    }
}
