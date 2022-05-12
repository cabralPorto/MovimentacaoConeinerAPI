using ProjetoAPICore.Modelos;

namespace ProjetoAPICore.Interfaces
{
    public interface ITipoMovimentacaoRepository
    {
        void CriarTipoMovimentacao(TipoMovimentacao tipoMovimentacao);

        TipoMovimentacao ObterTipoMovimentacaoPorId(Guid IdTipoMovimentacao);

        IEnumerable<TipoMovimentacao> ObterTipoMovimentacoes();
    }
}
