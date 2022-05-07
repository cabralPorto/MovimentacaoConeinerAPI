namespace ProjetoAPICore.Modelos
{
    public class Conteiner
    {
        public int IdConteiner { get; set; }
        public string Numero { get; set; }
        public string Tipo { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public DateTime? DataCancelamento { get; set; }
    }
}
