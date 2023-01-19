using ProjetoAPICore.Interfaces;
using ProjetoAPICore.Modelos;

namespace ProjetoAPICore.Core.Data.Repository
{
    public class MovimentacaoRepository : IMovimentacaoRepository
    {
        private readonly DbContexto _dbContexto;

        public MovimentacaoRepository(DbContexto dbContexto)
        {
            _dbContexto = dbContexto;

        }
        public void CriarMovimentacao(Movimentacao movimentacao)
        {
            _dbContexto.Movimentacoes.Add(movimentacao);
            _dbContexto.SaveChanges();
        }
        public Movimentacao ObterMovimentacaoPorId(Guid idMovimentacao)
        {
            return _dbContexto.Movimentacoes.FirstOrDefault(c => c.Id == idMovimentacao);
        }

        public IEnumerable<Movimentacao> ObterMovimentacoes()
        {
            return _dbContexto.Movimentacoes.ToList();
        }


    }
}
