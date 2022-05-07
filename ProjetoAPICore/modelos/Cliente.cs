namespace ProjetoAPICore.Modelos
{
    public class Cliente : Entidade
    {        
        public string NomeCliente { get; set; }
        public string Cpf { get; set; }
        public string Cnpj { get; set; }
        public string Email { get; set; }        
    }
}
