using Microsoft.AspNetCore.Mvc;
using ProjetoAPICore.Dtos;
using ProjetoAPICore.Interfaces;

namespace ProjetoAPICore.Controllers
{
    [Route("api/v1")]
    public class TipoMovimentacaoController: ControllerBase
    {
        private readonly ITipoMovimentacaoService _tipoMovimentacaoService;

        public TipoMovimentacaoController(ITipoMovimentacaoService tipoMovimentacaoService) 
        {
            _tipoMovimentacaoService = tipoMovimentacaoService;
        }

        [HttpPost("Cadatrar-TipoMovimentacao")]
        public ActionResult criarTipoMovimentacao( TipoMovimentacaoDto tipoMovimentacaoDto)
        {
            var tipoMovimentacao = _tipoMovimentacaoService.CriarTipoMovimentacao(tipoMovimentacaoDto);
            if (tipoMovimentacao == null)
                return BadRequest("Tipo Movimentação já Existe");

            return Ok(tipoMovimentacao);  
        }
        
        [HttpGet("consultar-TipoMovimentacao")]
        public ActionResult consultarTipoMovimentacao(TipoMovimentacaoDto tipoMovimentacaoDto)
        {
            var tipoMovimentacoes = _tipoMovimentacaoService.ObterTipoMovimentacoes();
            return Ok(tipoMovimentacoes);
        }

    }
}
