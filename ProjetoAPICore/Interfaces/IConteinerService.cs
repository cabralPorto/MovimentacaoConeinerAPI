using ProjetoAPICore.Modelos;
namespace ProjetoAPICore.Dtos.Interfaces
{
    public interface IConteinerService
    {
        ConteinerDto? CriarConteiner(ConteinerDto conteinerDTO);

        IEnumerable<Conteiner> ObterConteiner();

    }
}
