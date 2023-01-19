using Microsoft.AspNetCore.Http;
using ProjetoAPICore.Dtos;
using ProjetoAPICore.Interfaces;
using ProjetoAPICore.Modelos;
using ProjetoAPICore.Validacoes;

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
           
            var validator = new ClienteValidacoes();

            var result = validator.Validate(clienteDto);

            if (!result.IsValid)
            {
                clienteDto.Erros = new List<string>();
                foreach (var failure in result.Errors)
                {
                    clienteDto.Erros.Add(failure.ErrorMessage);
                    Console.WriteLine("Property " + failure.PropertyName + " failed validation. Error was: " + failure.ErrorMessage);
                }
                return clienteDto;
            }


            var cliente = _clienteRepository.ObterClientePorId(clienteDto.Id);

            if (cliente != null)
                return null;

            cliente = CriarEntidadeCliente(clienteDto);
            _clienteRepository.CriarCliente(cliente);

            return clienteDto;
        }

        public IEnumerable<Cliente> ObterTodosClientes()
        {
            return _clienteRepository.ObterTodosClientes();
        }

        public Cliente ObterClientePorNome(string nome)
        {
            return _clienteRepository.ObterClientePorNome(nome);
        }

        public ClienteDto? AlterarCliente(ClienteDto clienteDto)
        {
            var cliente = _clienteRepository.ObterClientePorId(clienteDto.Id);

            if (cliente == null)
                return null;

            cliente.NomeCliente = clienteDto.NomeCliente;
            cliente.Cpf = clienteDto.Cpf;
            cliente.Cnpj = clienteDto.Cnpj;
            cliente.Email = clienteDto.Email;
            cliente.DataAlteracao = DateTime.Now;

            _clienteRepository.AlterarCliente(cliente);

            return clienteDto;
        }

        public bool ExcluirCliente(Guid idCliente)
        {
            var cliente = _clienteRepository.ObterClientePorId(idCliente);

            if (cliente == null)
            {
                return cliente != null;
            }        

            _clienteRepository.ExcluirCliente(cliente);

            return cliente != null;
        }

        private static Cliente CriarEntidadeCliente(ClienteDto clienteDto)
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
