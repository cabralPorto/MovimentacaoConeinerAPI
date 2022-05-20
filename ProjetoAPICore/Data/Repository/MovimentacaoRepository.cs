using ProjetoAPICore.Interfaces;
using ProjetoAPICore.Modelos;

namespace ProjetoAPICore.Data.Repository
{
    public class MovimentacaoRepository : IMovimentacaoRepository
    {
        private readonly DbContexto _dbContexto;

        public MovimentacaoRepository(DbContexto dbContexto) 
        {
            _dbContexto = dbContexto;
        
        }

        public void IncluirMovimentacao(Movimentacao movimentacao)
        {
            _dbContexto.Movimentacoes.Add(movimentacao);
            _dbContexto.SaveChanges();
        }
        public Movimentacao ObterMovimentacaoPorId(Guid idMovimentacao)
        {
            return _dbContexto.Movimentacoes.FirstOrDefault(c => c.Id == idMovimentacao);
        }

        public IEnumerable<Movimentacao> ObterMovimentacao()
        {
            return _dbContexto.Movimentacoes.ToList();
        }

       
    }
}
