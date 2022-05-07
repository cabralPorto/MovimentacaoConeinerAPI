using ProjetoAPICore.Dtos;
using ProjetoAPICore.Interfaces;
using ProjetoAPICore.Modelos;

namespace ProjetoAPICore.Servicos
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public ClienteDto? CriarCliente(ClienteDto clienteDto)
        {
            var cliente = _clienteRepository.ObterClientePorId(clienteDto.Id);

            if (cliente != null)
                return null;

            cliente = CriarEntidadeCliente(clienteDto);
            _clienteRepository.CriarCliente(cliente);

            return clienteDto;
        }

        public IEnumerable<Cliente> ObterClientes()
        {
            return _clienteRepository.ObterClientes();
        }

        private Cliente CriarEntidadeCliente(ClienteDto clienteDto)
        {
            return new Cliente
            {
                NomeCliente = clienteDto.NomeCliente,
                Cnpj = clienteDto.Cnpj,
                Cpf = clienteDto.Cpf,
                Email = clienteDto.Email,
                DataCriacao = DateTime.Now
            };
        }

    }
}
