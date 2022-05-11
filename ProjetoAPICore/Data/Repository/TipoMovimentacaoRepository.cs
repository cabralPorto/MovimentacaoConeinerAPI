using ProjetoAPICore.Interfaces;
using ProjetoAPICore.Modelos;

namespace ProjetoAPICore.Data.Repository
{
    public class TipoMovimentacaoRepository : ITipoMovimentacaoRepository
    {
        private readonly DbContexto _dbContexto;
        public TipoMovimentacaoRepository(DbContexto dbContexto)
        {
            _dbContexto = dbContexto;
        }
        public void CriarTipoModificacao(TipoMovimentacao tipoMovimentacao)
        {
            _dbContexto.TipoMovimentacoes.Add(tipoMovimentacao);
            _dbContexto.SaveChanges();
        }

        public TipoMovimentacao ObterTipoMovimentacaoPorId(Guid IdTipoMovimentacao)
        {
            return _dbContexto.TipoMovimentacoes.FirstOrDefault(c => c.Id == IdTipoMovimentacao);
        }

        public IEnumerable<TipoMovimentacao> ObterTipoMovimentacoes()
        {
            return _dbContexto.TipoMovimentacoes.ToList();
        }
    }
}
