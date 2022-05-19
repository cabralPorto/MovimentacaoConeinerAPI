using ProjetoAPICore.Dtos;
using ProjetoAPICore.Modelos;

namespace ProjetoAPICore.Interfaces
{
    public interface IMovimentacaoService
    {
        MovimentacaoDto? IncluirMovimentacao(MovimentacaoDto movimentacaoDto);
        IEnumerable<Movimentacao> ObterMovimentacoes();
    }
}
