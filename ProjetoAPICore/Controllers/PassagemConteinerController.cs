using Microsoft.AspNetCore.Mvc;
using ProjetoAPICore.Dtos;
using ProjetoAPICore.Interfaces;


namespace ProjetoAPICore.Controllers
{
    public class PassagemConteinerController : ControllerBase
    {
        private readonly IPassagemConteinerService _passagemConteinerService;

        public PassagemConteinerController(IPassagemConteinerService passagemConteinerService)
        {
            _passagemConteinerService = passagemConteinerService;
        }
        [HttpPost("cadastrar-passagemConteiner")]
        public ActionResult IncluirPassagemConteiner([FromBody] PassagemConteinerDto passagemConteinerDto)
        {
            var passagemConteiner = _passagemConteinerService.IncluirPassagemConteiner(passagemConteinerDto);
            if (passagemConteiner == null)
                return BadRequest("Passagem Conteiner já Existe");

            return Ok(passagemConteiner);
        }

        [HttpGet("consultar-passagemConteiner")]
        public ActionResult ConsultarPassagemConteiner()
        {
            var passagemConteiner = _passagemConteinerService.ObterPassagemConteiners();
            return Ok(passagemConteiner);
        }

        [HttpGet("obter-passagemConteiner/{conteiner}")]
        public ActionResult ObterPassagemConteiner(string conteiner)
        {
            var passagemConteiner = _passagemConteinerService.ObterPassagemConteiner(conteiner);
            if (passagemConteiner == null)
                return BadRequest("Passagem não encontrada");

            return Ok(passagemConteiner);
        }

    }
}
