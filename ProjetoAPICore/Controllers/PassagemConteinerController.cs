using Microsoft.AspNetCore.Mvc;
using ProjetoAPICore.Dtos;
using ProjetoAPICore.Interfaces;
using ProjetoAPICore.Servicos;

namespace ProjetoAPICore.Controllers
{
    public class PassagemConteinerController : ControllerBase
    {
        private readonly IPassagemConteinerService _passagemConteinerService;

        public PassagemConteinerController (IPassagemConteinerService passagemConteinerService)
        {
            _passagemConteinerService = passagemConteinerService;
        }
        [HttpPost("Cadatrar-PassagemContteiner")]
        public ActionResult CriarPassagemConteiner(PassagemConteinerDto passagemConteinerDto)
        {
            var passagemConteiner = _passagemConteinerService.CriarPassagemConteiner(passagemConteinerDto);
            if (passagemConteiner == null)
                return BadRequest("Tipo Movimentação já Existe");

            return Ok(passagemConteiner);
        }

        [HttpGet("consultar-PassagemConteiner")]
        public ActionResult consultarPassagemConteiner(PassagemConteinerDto passagemConteinerDto)
        {
            var passagemConteiner = _passagemConteinerService.ObterPassagemConteiners();
            return Ok(passagemConteiner);
        }

    }
}
