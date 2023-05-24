namespace ProjetoAPICore.Core.Notificacoes
{
    public class Notificacao
    {
        public Notificacao(string mensagem)
        {
            mensagem = mensagem.Trim();
        }

        public string mensagem { get; }
    }
}
