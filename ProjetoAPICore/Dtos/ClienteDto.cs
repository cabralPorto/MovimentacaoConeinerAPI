namespace ProjetoAPICore.Dtos
{
    public class ClienteDto
    {
        public Guid Id { get; set; }
        public string NomeCliente { get; set; }
        public string Cpf { get; set; }
        public string Cnpj { get; set; }
        public string Email { get; set; }
        public List<string> Erros { get; set; }
    }
}
