using ProjetoAPICore.Modelos;

namespace ProjetoAPICore.Interfaces
{
    public interface IMovimentacaoRepository
    {
        void CriarMovimentacao(Movimentacao movimentacao);

        Movimentacao ObterMovimentacaoPorId(Guid idMovimentacao);
        IEnumerable<Movimentacao> ObterMovimentacoes();
    }
}
