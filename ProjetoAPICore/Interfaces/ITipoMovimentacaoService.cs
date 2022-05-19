using ProjetoAPICore.Dtos;
using ProjetoAPICore.Modelos;

namespace ProjetoAPICore.Interfaces
{
    public interface ITipoMovimentacaoService
    {
        TipoMovimentacaoDto? IncluirTipoMovimentacao(TipoMovimentacaoDto tipoMovimentacaoDto);

        IEnumerable<TipoMovimentacao> ObterTipoMovimentacoes();
    }
}
