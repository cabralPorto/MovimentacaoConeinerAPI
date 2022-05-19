using ProjetoAPICore.Dtos;
using ProjetoAPICore.Interfaces;
using ProjetoAPICore.Modelos;

namespace ProjetoAPICore.Servicos
{
    public class PassagemConteinerService : IPassagemConteinerService
    {
        private readonly IPassagemConteinerRepository _passagemConteinerRepository;

        public PassagemConteinerService (IPassagemConteinerRepository passagemConteinerRepository) 
        {
            _passagemConteinerRepository = passagemConteinerRepository;
        }
       public PassagemConteinerDto? IncluirPassagemConteiner(PassagemConteinerDto passagemConteinerDto)
        {
            var passagemConteiner = _passagemConteinerRepository.ObterPassagemConteinerPorId(passagemConteinerDto.Id);
            if (passagemConteiner != null)
                return null;

            passagemConteiner = IncluirEntidadePassagemConteiner(passagemConteinerDto);
            _passagemConteinerRepository.IncluirPassagemConteiner(passagemConteiner);

            return passagemConteinerDto;
        }
      

        public IEnumerable<PassagemConteiner> ObterPassagemConteiners()
        {
            return _passagemConteinerRepository.ObterPassagemConteiners();
        }

        public PassagemDto ObterPassagemConteiner(string conteiner)
        {
            return _passagemConteinerRepository.ObterPassagemConteiner(conteiner);
        }

        private static PassagemConteiner IncluirEntidadePassagemConteiner(PassagemConteinerDto passagemConteinerDto )
        {
            return new PassagemConteiner
            {
               
                IdConteiner = passagemConteinerDto.IdConteiner,
                Categoria = passagemConteinerDto.Categoria,
                Status = passagemConteinerDto.Status,
                DataCriacao = DateTime.Now
                
            };
        }

      
    }
}
