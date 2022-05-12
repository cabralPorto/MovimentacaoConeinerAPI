namespace ProjetoAPICore.Dtos
{
    public class PassagemConteinerDto
    {
        public Guid Id { get; set; }
       
        public Guid IdConteiner { get; set; }
        
        public string Categoria { get; set; }

        public string Status { get; set; }
    }
}
