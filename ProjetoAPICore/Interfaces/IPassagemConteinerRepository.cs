using ProjetoAPICore.Dtos;
using ProjetoAPICore.Modelos;

namespace ProjetoAPICore.Interfaces
{
    public interface IPassagemConteinerRepository
    {
        void IncluirPassagemConteiner(PassagemConteiner passagemConteiner);

        PassagemConteiner ObterPassagemConteinerPorId(Guid IdPassagemConteiner);

        IEnumerable<PassagemConteiner> ObterPassagemConteiners();
        PassagemDto ObterPassagemConteiner(string conteiner);

    }
}
