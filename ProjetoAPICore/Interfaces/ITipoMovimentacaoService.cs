using ProjetoAPICore.Dtos;
using ProjetoAPICore.Modelos;

namespace ProjetoAPICore.Interfaces
{
    public interface ITipoMovimentacaoService
    {
        TipoMovimentacaoDto? CriarTipoMovimentacao(TipoMovimentacaoDto tipoMovimentacaoDto);

        IEnumerable<TipoMovimentacao> ObterTipoMovimentacoes();
    }
}
