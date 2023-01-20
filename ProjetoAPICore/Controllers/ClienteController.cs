using Microsoft.AspNetCore.Mvc;
using ProjetoAPICore.Dtos;
using ProjetoAPICore.Interfaces;

namespace ProjetoAPICore.Controllers
{
    [Route("api/v1")]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteService _clienteServico;

        public ClienteController(IClienteService clienteServico)
        {
            _clienteServico = clienteServico;
        }

       

        [HttpPost("criar-cliente")]        
        public ActionResult CriarCliente(ClienteDto clienteDto)
        {
            var cliente =  _clienteServico.AdicionarCliente(clienteDto);

            if(cliente == null)
                return BadRequest("Cliente já existe.");

            if(clienteDto.Erros.Any())
                return BadRequest(clienteDto.Erros);

            return Ok(cliente);
        }

        [HttpPut("atualizar-cliente")]
        public ActionResult AtualizarCliente(ClienteDto clienteDto)
        {
            var cliente = _clienteServico.AlterarCliente(clienteDto);

            if (cliente == null)
                return BadRequest("Cliente não encontrado.");

            return Ok(cliente);
        }


        [HttpGet("consultar-todos-clientes")]
        public ActionResult ConsultarTodosClientes()
        {
            var clientes = _clienteServico.ObterTodosClientes();
            return Ok(clientes);
        }

        [HttpGet("consultar-cliente/{nome}")]      
        public ActionResult ConsultarClientesPorNome(string nome)
        {
            if(string.IsNullOrEmpty(nome))
                return BadRequest("Cliente não informado.");

            var clientes = _clienteServico.ObterClientePorNome(nome);

            if (clientes == null)
                return BadRequest("Cliente não encontrado.");

            return Ok(clientes);
        }

    
        [HttpDelete("excluir-cliente/{id}")]
        public ActionResult ConsultarClientesPorNome(Guid id)
        {         

            var clientes = _clienteServico.ExcluirCliente(id);

            if (!clientes)
                return BadRequest("Cliente não encontrado.");

            return Ok(clientes);
        }
    }
}
