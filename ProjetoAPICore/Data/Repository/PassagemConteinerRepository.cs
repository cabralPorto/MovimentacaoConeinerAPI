using ProjetoAPICore.Interfaces;
using ProjetoAPICore.Modelos;

namespace ProjetoAPICore.Data.Repository
{
    public class PassagemConteinerRepository : IPassagemConteinerRepository
    {
        private readonly DbContexto _dbContexto;

        public PassagemConteinerRepository(DbContexto dbContexto)
        {
            _dbContexto = dbContexto;
        }
        public void CriarPassagemConteiner(PassagemConteiner passagemConteiner)
        {
            _dbContexto.PassagemConteiners.Add(passagemConteiner);
            _dbContexto.SaveChanges();
        }

        public PassagemConteiner ObterPassagemConteinerPorId(Guid IdPassagemConteiner)
        {
            return _dbContexto.PassagemConteiners.FirstOrDefault(c => c.Id == IdPassagemConteiner);
        }

        public IEnumerable<PassagemConteiner> ObterPassagemConteiners()
        {
            return _dbContexto.PassagemConteiners.ToList();
        }
    }
}
