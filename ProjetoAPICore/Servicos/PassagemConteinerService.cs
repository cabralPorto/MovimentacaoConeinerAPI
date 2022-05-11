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

        public PassagemConteinerDto? CriarPassagemConteiner(PassagemConteinerDto passagemConteinerDto)
        {
            var passagemConteiner = _passagemConteinerRepository.ObterPassagemConteinerPorId(passagemConteinerDto.Id);
                if (passagemConteiner != null)
                     return null;

            passagemConteiner = CriarEntidadePassagemConteiner(passagemConteinerDto);
            _passagemConteinerRepository.CriarPassagemConteiner(passagemConteiner);

            return passagemConteinerDto;

        }

        public IEnumerable<PassagemConteiner> ObterPassagemConteiners()
        {
            return _passagemConteinerRepository.ObterPassagemConteiners();
        }

        private PassagemConteiner CriarEntidadePassagemConteiner(PassagemConteinerDto passagemConteinerDto )
        {
            return new PassagemConteiner
            {
                IdPassagemConteiner = passagemConteinerDto.IdPassagemConteiner,
                IdConteiner = passagemConteinerDto.IdConteiner,
                Categoria = passagemConteinerDto.Categoria,
                Status = passagemConteinerDto.Status,
                DataCriacao = DateTime.Now
                
            };
        }

        PassagemConteiner? IPassagemConteinerService.CriarPassagemConteiner(PassagemConteinerDto passagemConteinerDto)
        {
            throw new NotImplementedException();
        }
    }
}
