using Microsoft.AspNetCore.Mvc;
using ProjetoAPICore.Dtos;
using ProjetoAPICore.Interfaces;


namespace ProjetoAPICore.Controllers
{
    public class PassagemConteinerController : ControllerBase
    {
        private readonly IPassagemConteinerService _passagemConteinerService;

        public PassagemConteinerController (IPassagemConteinerService passagemConteinerService)
        {
            _passagemConteinerService = passagemConteinerService;
        }
        [HttpPost("cadastrar-passagemConteiner")]
        public ActionResult CriarPassagemConteiner(PassagemConteinerDto passagemConteinerDto)
        {
            var passagemConteiner = _passagemConteinerService.CriarPassagemConteiner(passagemConteinerDto);
            if (passagemConteiner == null)
                return BadRequest("Passagem Conteiner já Existe");

            return Ok(passagemConteiner);
        }

        [HttpGet("consultar-passagemConteiner")]
        public ActionResult ConsultarPassagemConteiner(PassagemConteinerDto passagemConteinerDto)
        {
            var passagemConteiner = _passagemConteinerService.ObterPassagemConteiners();
            return Ok(passagemConteiner);
        }

    }
}
