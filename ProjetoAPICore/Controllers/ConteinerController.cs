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

        //[HttpGet ("consultar-conteiner")]
        //public ActionResult consultarconteiner()
        //{
        //    return BadRequest("teste");
        //}

        [HttpPost("criar-conteiner")]
        public ActionResult CriarConteiner(ConteinerDto conteinerDto)
        {
            var conteiner = _conteinerServico.CriarConteiner(conteinerDto);
            if (conteiner == null)
                return BadRequest("Conteiner já existe");

            return Ok(conteiner);
        }

        [HttpGet("consultar-conteiner")]
        public ActionResult ConsultarConteiners()
        {
            var conteiners = _conteinerServico.ObterConteiners();

            return Ok(conteiners);
        }
    }
}
