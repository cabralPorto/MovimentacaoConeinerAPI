namespace ProjetoAPICore.Dtos
{
    public class PassagemDto
    {
        public string Conteiner { get; set; }
        public int Tipo { get; set; }
        public string Categoria { get; set; }
        public string Status { get; set; }
        public DateTime DataPassagem { get; set; }
    }
}
