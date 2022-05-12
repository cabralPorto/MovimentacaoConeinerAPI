using ProjetoAPICore.Modelos;
namespace ProjetoAPICore.Interfaces
{
    public interface IConteinerRepository
    {
        void CriarConteiner(Conteiner conteiner);

        Conteiner ObterConteinerPorId( Guid IdConteiner);
        Conteiner ObterConteinerPorNome(String numero);
        void AlterarConteiner(Conteiner conteiner);
        IEnumerable<Conteiner> ObterConteiners();

       
    }
}
