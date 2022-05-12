namespace ProjetoAPICore.Dtos

{
    public class MovimentacaoDto
    {
        public Guid Id { get; set; }
       
        public Guid IdCliente { get; set; }
        
        public Guid IdTipoMovimentacao { get; set; }
       
        public Guid IdPassagemConteiner { get; set; }

        public DateTime? DataHoraInicial { get; set; }
        
        public DateTime? DataHoraFinal { get; set; }


    }
}
