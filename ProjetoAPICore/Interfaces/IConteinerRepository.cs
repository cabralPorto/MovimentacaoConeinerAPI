using ProjetoAPICore.Modelos;
namespace ProjetoAPICore.Interfaces
{
    public interface IConteinerRepository
    {
        void IncluirConteiner(Conteiner conteiner);

        Conteiner ObterConteinerPorId( Guid IdConteiner);
        Conteiner ObterConteinerPorNumero(string numero);
        void AlterarConteiner(Conteiner conteiner);
        IEnumerable<Conteiner> ObterConteiner();

       
    }
}
