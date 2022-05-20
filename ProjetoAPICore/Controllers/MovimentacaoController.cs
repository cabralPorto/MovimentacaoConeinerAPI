using Microsoft.AspNetCore.Mvc;
using ProjetoAPICore.Dtos;
using ProjetoAPICore.Interfaces;

namespace ProjetoAPICore.Controllers
{
    [Route("api/v1")]
    public class MovimentacaoController: ControllerBase
    {
        
            private readonly IMovimentacaoService _movimetacaoService;


            public MovimentacaoController(IMovimentacaoService movimentacaoService) 
            {
                _movimetacaoService = movimentacaoService;
            
            }
        [HttpPost("criar-Movimentacao")]
        public ActionResult IncluirMovimentacao([FromBody]MovimentacaoDto movimentacaoDto)
        {
            var movimentacao = _movimetacaoService.IncluirMovimentacao(movimentacaoDto);
            if (movimentacao == null)
                return BadRequest("Movimentação já existente");

            return Ok(movimentacao);
        }
        //[HttpPost("incluir-conteiner")]
        //public ActionResult IncluirConteiner([FromBody] ConteinerDto conteinerDto)
        //{
        //    var conteiner = _conteinerServico.IncluirConteiner(conteinerDto);
        //    if (conteiner == null)

        //        return BadRequest("Conteiner já existe");

        //    return Ok(conteiner);


        //}


        [HttpGet("consultar-movimentacao")]
        public ActionResult ConsultarMovimentacao()
        {
            var movimentacoes = _movimetacaoService.ObterMovimentacao();
            return Ok(movimentacoes);
        }

    }
}
