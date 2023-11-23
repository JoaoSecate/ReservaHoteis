
using FluentValidation;
using ReservaHoteis.Domain.Entities;

namespace ReservaHoteis.Service.Validators
{
    public class ContratoValidator : AbstractValidator<Contrato>
    {
        public ContratoValidator()
        {
            RuleFor(c => c.ValorTotal)
                .NotEmpty().WithMessage("Por favor informe o Valor.")
                .NotNull().WithMessage("Por favor informe o Valor.");
            RuleFor(c => c.Data)
                .NotEmpty().WithMessage("Por favor informe a Data.")
                .NotNull().WithMessage("Por favor informe a Data.");
        }
    }
}