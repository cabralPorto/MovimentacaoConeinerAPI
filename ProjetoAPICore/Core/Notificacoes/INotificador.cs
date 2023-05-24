namespace ProjetoAPICore.Core.Notificacoes
{
    public interface INotificador
    {
        bool TemNotificacao();
        List<Notificacao> ObterNotificacoes();
        void handle(Notificacao notificacao);
    }
}
