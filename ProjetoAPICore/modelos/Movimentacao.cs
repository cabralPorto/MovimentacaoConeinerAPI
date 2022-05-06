namespace ProjetoAPICore.Modelos
{
    public class Movimentacao
    {
        public int IdMovimentacao { get; set; }
        public int IdCliente { get; set; }
        public int IdTipoMovimentacao { get; set; }
        public int IdPassagemConteiner { get; set; }
        public DateTime DataHoraInicial { get; set; }
        public DateTime DataHoraFinal { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataAlteracao { get; set; }
        public DateTime DataCancelamento { get; set; }
    }
}
