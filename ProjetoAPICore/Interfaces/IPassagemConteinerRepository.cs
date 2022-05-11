using ProjetoAPICore.Modelos;

namespace ProjetoAPICore.Interfaces
{
    public interface IPassagemConteinerRepository
    {
        void CriarPassagemConteiner(PassagemConteiner passagemConteiner);

        PassagemConteiner ObterPassagemConteinerPorId(Guid IdPassagemConteiner);

        IEnumerable<PassagemConteiner> ObterPassagemConteiners();

    }
}
