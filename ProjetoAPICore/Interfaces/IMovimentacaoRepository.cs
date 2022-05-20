using ProjetoAPICore.Modelos;

namespace ProjetoAPICore.Interfaces
{
    public interface IMovimentacaoRepository
    {
        void IncluirMovimentacao(Movimentacao movimentacao);

        Movimentacao ObterMovimentacaoPorId(Guid idMovimentacao);
        IEnumerable<Movimentacao> ObterMovimentacao();
    }
}
