using FluentValidation;
using ProjetoAPICore.Dtos;

namespace ProjetoAPICore.Validacoes
{
    public class ClienteValidacoes : AbstractValidator<ClienteDto>
    {
        public ClienteValidacoes()
        {
            RuleFor(cliente => cliente.NomeCliente)
                .NotNull().WithMessage("Campo {PropertyName} Precisa ser fornecido")
                .Length(2, 100)
                .WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");
            
            RuleFor(cliente => cliente.Cpf).NotNull().WithMessage("Campo {PropertyName} não pode ser nulo!");
        }
    }
}
