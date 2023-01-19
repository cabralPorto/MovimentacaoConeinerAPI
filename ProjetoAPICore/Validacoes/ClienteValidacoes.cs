using FluentValidation;
using ProjetoAPICore.Core.DocsValidations;
using ProjetoAPICore.Dtos;
using ProjetoAPICore.Modelos;

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

            When(f => f.TipoCliente == TipoCliente.PessoaFisica, () =>
            {
                RuleFor(f => f.Cpf.Length).Equal(CpfValidacao.TamanhoCpf)
                    .WithMessage("O campo Documento precisa ter {ComparisonValue} caracteres e foi fornecido {PropertyValue}.");

                RuleFor(f => CpfValidacao.Validar(f.Cpf)).Equal(true)
                    .WithMessage("O documento fornecido é inválido.");
            });

            When(f => f.TipoCliente == TipoCliente.PessoaJuridica, () =>
            {
                RuleFor(f => f.Cnpj.Length).Equal(CnpjValidacao.TamanhoCnpj)
                    .WithMessage("O campo Documento precisa ter {ComparisonValue} caracteres e foi fornecido {PropertyValue}.");

                RuleFor(f => CnpjValidacao.Validar(f.Cnpj)).Equal(true)
                    .WithMessage("O documento fornecido é inválido.");
            });
        }
    }
}
