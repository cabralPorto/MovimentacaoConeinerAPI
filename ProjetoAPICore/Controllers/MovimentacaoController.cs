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
        public ActionResult criarMovimentacao(MovimentacaoDto movimentacaoDto)
        {
            var movimentacao = _movimetacaoService.CriarMovimentacao(movimentacaoDto);
            if (movimentacao != null)
                return BadRequest("Movimentação já existente");

            return Ok(movimentacao);
        }
        
        
        [HttpGet("consultar-Movimentacao")]
        public ActionResult consultarconteiner()
        {
            var movimentacoes = _movimetacaoService.ObterMovimentacoes();
            return Ok(movimentacoes);
        }

    }
}
