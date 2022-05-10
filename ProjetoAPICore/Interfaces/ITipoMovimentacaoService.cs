using ProjetoAPICore.Dtos;

namespace ProjetoAPICore.Interfaces
{
    public interface ITipoMovimentacaoService
    {
        TipoMovimentacaoDto? CriarTipoMovimentacao(TipoMovimentacaoDto tipoMovimentacaoDto);

        IEnumerable<TipoMovimentacaoDto> ObterTipoMovimentacoes();
    }
}
