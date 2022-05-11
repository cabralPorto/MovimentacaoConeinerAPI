namespace ProjetoAPICore.Dtos
{
    public class PassagemConteinerDto
    {
        public Guid Id { get; set; }
       
        public int IdPassagemConteiner { get; set; }
       
        public int IdConteiner { get; set; }
        
        public string Categoria { get; set; }

        public string Status { get; set; }
    }
}
