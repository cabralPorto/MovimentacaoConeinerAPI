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
            if (movimentacao != null)
                return BadRequest("Movimentação já existente");

            return Ok(movimentacao);
        }
        
        
        [HttpGet("consultar-movimentacao")]
        public ActionResult Consultarconteiner()
        {
            var movimentacoes = _movimetacaoService.ObterMovimentacoes();
            return Ok(movimentacoes);
        }

    }
}
