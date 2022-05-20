using Microsoft.AspNetCore.Mvc;
using ProjetoAPICore.Dtos.Interfaces;
using ProjetoAPICore.Dtos;

namespace ProjetoAPICore.Controllers
{   
    [Route("api/v1")]
    public class ConteinerController : ControllerBase
    {
        private readonly IConteinerService _conteinerServico;

        public ConteinerController(IConteinerService conteinerServico)
        {
            _conteinerServico = conteinerServico;
        }

        [HttpPost("incluir-conteiner")]
        public ActionResult IncluirConteiner([FromBody] ConteinerDto conteinerDto)
        {
            var conteiner = _conteinerServico.IncluirConteiner(conteinerDto);
            if (conteiner == null)
                
                return BadRequest("Conteiner já existe");

            return Ok(conteiner);
            

        }

        [HttpGet("consultar-conteiner")]
        public ActionResult ConsultarConteiner()
        {
            var conteiners = _conteinerServico.ObterConteiner();

            return Ok(conteiners);
        }
        
        [HttpGet("consultar-conteiner/{numero}")]
        public ActionResult ConsultarConteinerPorNome(string numero) 
        {
            if (string.IsNullOrEmpty(numero))
                return BadRequest("Conteiner não informado.");

            var conteiners = _conteinerServico.ObterConteinerPorNome(numero);

            if (conteiners == null)
                return BadRequest("Cliente não encontrado.");

            return Ok(conteiners);
        }
        [HttpPut("alterar-conteiner")]
        public ActionResult AlterarConteiner([FromBody]ConteinerDto conteinerDto)
        {
            var conteiner = _conteinerServico.AlterarConteiner(conteinerDto);
           
            if (conteiner == null)
                return BadRequest("Conteiner não encontrado.");

            return Ok(conteiner);
        }
    }
}
