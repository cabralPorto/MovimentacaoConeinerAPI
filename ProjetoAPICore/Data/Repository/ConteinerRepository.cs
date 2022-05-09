﻿using ProjetoAPICore.Interfaces;
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

        public void CriarConteiner(Conteiner conteiner)
        {
            _dbContexto.Conteiners.Add(conteiner);
            _dbContexto.SaveChanges();
        }

        public IEnumerable<Conteiner> ObterConteineres()
        {
            return _dbContexto.Conteiners.ToList();
        }

        public Conteiner ObterConteinerPorId(Guid IdConteiner)
        {
            return _dbContexto.Conteiners.FirstOrDefault(c => c.Id == IdConteiner);
        }
    }
}