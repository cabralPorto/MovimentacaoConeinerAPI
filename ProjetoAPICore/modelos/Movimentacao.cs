namespace ProjetoAPICore.Modelos
{
    public class Movimentacao : Entidade
    {
        public Guid IdMovimentacao { get; set; }
        public Guid IdCliente { get; set; }
        public Guid IdTipoMovimentacao { get; set; }
        public Guid IdPassagemConteiner { get; set; }
        public DateTime DataHoraInicial { get; set; }
        public DateTime DataHoraFinal { get; set; }
        
    }
}
