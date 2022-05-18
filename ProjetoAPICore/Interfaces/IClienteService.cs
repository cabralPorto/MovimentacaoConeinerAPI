using ProjetoAPICore.Dtos;
using ProjetoAPICore.Modelos;

namespace ProjetoAPICore.Interfaces
{
    public interface IClienteService
    {
        ClienteDto? IncluirCliente(ClienteDto clienteDto);
        IEnumerable<Cliente> ObterTodosClientes();
        Cliente ObterClientePorNome(string nome);
        ClienteDto AlterarCliente(ClienteDto clienteDto);
        bool ExcluirCliente(Guid idCliente);
    }
}
