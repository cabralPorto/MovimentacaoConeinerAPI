namespace ProjetoAPICore.Modelos
{
    public class PassagemConteiner
    {
        public int IdPassagemConteiner { get; set; }
        public int IdConteiner { get; set; }
        public string Categoria { get; set; }

        public string Status { get; set; }

        public DateTime DataCriacao { get; set; }
        public DateTime DataAlteracao { get; set; }
        public DateTime DataCancelamento { get; set; }
    }
}
