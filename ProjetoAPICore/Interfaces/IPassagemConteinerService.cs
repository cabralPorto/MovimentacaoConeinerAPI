using ProjetoAPICore.Dtos;
using ProjetoAPICore.Modelos;

namespace ProjetoAPICore.Interfaces
{
    public interface IPassagemConteinerService
    {
        PassagemConteiner? CriarPassagemConteiner(PassagemConteinerDto passagemConteinerDto);

        IEnumerable<PassagemConteiner> ObterPassagemConteiners();
    }
}
