using ProjetoAPICore.Dtos;
using ProjetoAPICore.Modelos;

namespace ProjetoAPICore.Interfaces
{
    public interface IPassagemConteinerService
    {
        PassagemConteinerDto? CriarPassagemConteiner(PassagemConteinerDto passagemConteinerDto);

        IEnumerable<PassagemConteiner> ObterPassagemConteiners();
    }
}
