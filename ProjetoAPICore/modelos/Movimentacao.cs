namespace ProjetoAPICore.Modelos
{
    public class Movimentacao : Entidade
    {
     
        public Guid IdCliente { get; set; }
        public Guid IdTipoMovimentacao { get; set; }
        public Guid IdPassagemConteiner { get; set; }
        public string PauNaCara { get; set; }
        public DateTime DataHoraInicial { get; set; }
        public DateTime DataHoraFinal { get; set; }
        
    }
}
