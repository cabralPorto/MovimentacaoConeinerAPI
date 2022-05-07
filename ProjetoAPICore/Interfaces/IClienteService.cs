using ProjetoAPICore.Dtos;
using ProjetoAPICore.Modelos;

namespace ProjetoAPICore.Interfaces
{
    public interface IClienteService
    {
        ClienteDto? CriarCliente(ClienteDto clienteDto);
        IEnumerable<Cliente> ObterClientes();
    }
}
