using ProjetoAPICore.Dtos;
using ProjetoAPICore.Modelos;

namespace ProjetoAPICore.Interfaces
{
    public interface IPassagemConteinerService
    {
        PassagemConteinerDto? IncluirPassagemConteiner(PassagemConteinerDto passagemConteinerDto);

        IEnumerable<PassagemConteiner> ObterPassagemConteiners();
    }
}
