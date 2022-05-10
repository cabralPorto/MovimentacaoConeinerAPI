using ProjetoAPICore.Modelos;

namespace ProjetoAPICore.Interfaces
{
    public interface ITipoMovimentacaoRepository
    {
        void CriarTipoModificacao(TipoMovimentacao tipoMovimentacao);

        TipoMovimentacao ObterTipoMovimentacaoPorId(Guid IdTipoMovimentacao);

        IEnumerable<TipoMovimentacao> ObterTipoMovimentacoes();
    }
}
