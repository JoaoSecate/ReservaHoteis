
using FluentValidation;
using ReservaHoteis.Domain.Entities;

namespace ReservaHoteis.Service.Validators
{
    public class ServicoValidator : AbstractValidator<Servico>
    {
        public ServicoValidator()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Por favor informe o nome.")
                .NotNull().WithMessage("Por favor informe o nome.");

            RuleFor(c => c.Descricao)
                 .NotEmpty().WithMessage("Por favor informe o Descricao.")
                 .NotNull().WithMessage("Por favor informe o Descricao.");
        }
    }
}