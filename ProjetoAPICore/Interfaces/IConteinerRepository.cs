using ProjetoAPICore.Modelos;
namespace ProjetoAPICore.Interfaces
{
    public interface IConteinerRepository
    {
        void CriarConteiner(Conteiner conteiner);

        Conteiner ObterConteinerPorId( Guid IdConteiner);

        IEnumerable<Conteiner> ObterConteiners();
    }
}
