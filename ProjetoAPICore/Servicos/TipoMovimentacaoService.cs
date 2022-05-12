using ProjetoAPICore.Dtos;
using ProjetoAPICore.Interfaces;
using ProjetoAPICore.Modelos;

namespace ProjetoAPICore.Servicos
{
    public class TipoMovimentacaoService : ITipoMovimentacaoService
    {
        private readonly ITipoMovimentacaoRepository _tipoMovimentacaoRepository;

        public TipoMovimentacaoService(ITipoMovimentacaoRepository tipoMovimentacaoRepository)
        {
            _tipoMovimentacaoRepository = tipoMovimentacaoRepository;
        }
        public TipoMovimentacaoDto? CriarTipoMovimentacao(TipoMovimentacaoDto tipoMovimentacaoDto)
        {
            var tipoMovimentacao = _tipoMovimentacaoRepository.ObterTipoMovimentacaoPorId(tipoMovimentacaoDto.Id);
                if (tipoMovimentacao != null)
                    return null;
            
            tipoMovimentacao = CriarEntidadeTipoMovimentacao(tipoMovimentacaoDto);
            _tipoMovimentacaoRepository.CriarTipoMovimentacao(tipoMovimentacao);

            return tipoMovimentacaoDto;   
        }
        public IEnumerable<TipoMovimentacao> ObterTipoMovimentacoes()
        {
            return _tipoMovimentacaoRepository.ObterTipoMovimentacoes();
        }

       

        private TipoMovimentacao CriarEntidadeTipoMovimentacao(TipoMovimentacaoDto tipoMovimentacaoDto)
        {
            return new TipoMovimentacao
                {
                    Descricao = tipoMovimentacaoDto.Descricao,
                    
                    DataCriacao = DateTime.Now
            };
        }
    }
}
