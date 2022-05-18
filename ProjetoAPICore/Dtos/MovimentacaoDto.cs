namespace ProjetoAPICore.Dtos

{
    public class MovimentacaoDto
    {
        public Guid Id { get; set; }
       
        public Guid IdCliente { get; set; }
        
        public Guid IdTipoMovimentacao { get; set; }
       
        public Guid IdPassagemConteiner { get; set; }

    }
}
