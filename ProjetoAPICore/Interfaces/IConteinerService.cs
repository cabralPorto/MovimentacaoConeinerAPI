using ProjetoAPICore.Modelos;
namespace ProjetoAPICore.Dtos.Interfaces
{
    public interface IConteinerService
    {
        ConteinerDto? CriarConteiner(ConteinerDto conteinerDto);

        IEnumerable<Conteiner> ObterConteiners();

    }
}
