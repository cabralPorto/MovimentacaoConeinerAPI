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

        [HttpGet("consultar-cliente")]        
        public ActionResult ConsultarCliente()
        {
            return BadRequest("TESTE");
        }


        [HttpPost("criar-cliente")]        
        public ActionResult CriarCliente(ClienteDto clienteDto)
        {
            var cliente =  _clienteServico.CriarCliente(clienteDto);

            if(cliente == null)
                return BadRequest("Cliente já existe.");

            return Ok(cliente);
        }


        [HttpGet("consultar-clientes")]
        public ActionResult ConsultarClientes()
        {
            var clientes = _clienteServico.ObterClientes();
            return Ok(clientes);
        }
    }
}
