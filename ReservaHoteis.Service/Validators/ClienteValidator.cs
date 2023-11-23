
using FluentValidation;
using ReservaHoteis.Domain.Entities;

namespace ReservaHoteis.Service.Validators
{
    public class ClienteValidator : AbstractValidator<Cliente>
    {
        public ClienteValidator()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Por favor informe o nome.")
                .NotNull().WithMessage("Por favor informe o nome.");
            RuleFor(c => c.Documento)
                .NotEmpty().WithMessage("Por favor informe o estado.")
                .NotNull().WithMessage("Por favor informe o estado.");
            RuleFor(c => c.Email)
                .NotEmpty().WithMessage("Por favor informe o Email.")
                .NotNull().WithMessage("Por favor informe o Email.");
            RuleFor(c => c.Senha)
                .NotEmpty().WithMessage("Por favor informe o Senha.")
                .NotNull().WithMessage("Por favor informe o Senha.");
        }
    }
}