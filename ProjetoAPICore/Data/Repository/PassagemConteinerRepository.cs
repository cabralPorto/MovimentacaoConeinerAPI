using ProjetoAPICore.Dtos;
using ProjetoAPICore.Interfaces;
using ProjetoAPICore.Modelos;

namespace ProjetoAPICore.Data.Repository
{
    public class PassagemConteinerRepository : IPassagemConteinerRepository
    {
        private readonly DbContexto _dbContexto;
        private readonly IDapperBaseRepository _dapperBaseRepository;
        public PassagemConteinerRepository(DbContexto dbContexto,
                                 IDapperBaseRepository dapperBaseRepository)
        {
            _dbContexto = dbContexto;
            _dapperBaseRepository = dapperBaseRepository;
        }
        public void IncluirPassagemConteiner(PassagemConteiner passagemConteiner)
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

        public PassagemDto ObterPassagemConteiner(string conteiner)
        {
            return _dapperBaseRepository.Obter<PassagemDto>(
               @$"SELECT CONT.Numero Conteiner,
               CONT.Tipo Tipo, 
               PACO.Categoria Categoria,
               PACO.Status Status,
               PACO.DataCriacao DataPassagem
               FROM Conteiners CONT 
               INNER JOIN PassagemConteiners PACO ON CONT.Id = PACO.IdConteiner
               WHERE 
               CONT.Numero = '{conteiner}'").Result;
        }
    }
}
