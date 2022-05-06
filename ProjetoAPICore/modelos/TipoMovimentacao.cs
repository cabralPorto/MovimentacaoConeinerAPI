namespace ProjetoAPICore.Modelos
{
    public class TipoMovimentacao
    {
        public int IdTipoMovimentacao { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataAlteracao { get; set; }
        public DateTime DataCancelamento { get; set; }
    }
}
