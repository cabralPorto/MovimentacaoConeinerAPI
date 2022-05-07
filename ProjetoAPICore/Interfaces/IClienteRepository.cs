using ProjetoAPICore.Modelos;

namespace ProjetoAPICore.Interfaces
{
    public interface IClienteRepository
    {
        void CriarCliente(Cliente cliente);

        Cliente ObterClientePorId(Guid idCliente);
        IEnumerable<Cliente> ObterClientes();
    }
}
