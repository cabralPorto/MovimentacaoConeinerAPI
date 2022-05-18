
using ProjetoAPICore.Interfaces;
using ProjetoAPICore.Modelos;

namespace ProjetoAPICore.Data.Repository
{
    public class ConteinerRepository : IConteinerRepository
    {
        private readonly DbContexto _dbContexto;

        public ConteinerRepository(DbContexto dbContexto) 
        {
            _dbContexto = dbContexto;        
        }

        public void IncluirConteiner(Conteiner conteiner)
        {
            _dbContexto.Conteiners.Add(conteiner);
            _dbContexto.SaveChanges();
        }

   

        public Conteiner ObterConteinerPorId(Guid IdConteiner)
        {
            return _dbContexto.Conteiners.FirstOrDefault(c => c.Id == IdConteiner);
        }
        public IEnumerable<Conteiner> ObterConteiners()
        {
            
            return _dbContexto.Conteiners.ToList();
        }

        public Conteiner ObterConteinerPorNumero(string numero)
        {
            return _dbContexto.Conteiners.FirstOrDefault(c => c.Numero == numero);
        }

        public void AlterarConteiner(Conteiner conteiner)
        {
            _dbContexto.Conteiners.Update(conteiner);
            _dbContexto.SaveChanges();
        }

    }
}
