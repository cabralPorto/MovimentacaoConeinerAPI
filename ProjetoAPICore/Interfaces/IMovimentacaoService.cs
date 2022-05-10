using ProjetoAPICore.Dtos;
using ProjetoAPICore.Modelos;

namespace ProjetoAPICore.Interfaces
{
    public interface IMovimentacaoService
    {
        MovimentacaoDto? CriarMovimentacao(MovimentacaoDto movimentacaoDto);
        IEnumerable<Movimentacao> ObterMovimentacoes();
    }
}
