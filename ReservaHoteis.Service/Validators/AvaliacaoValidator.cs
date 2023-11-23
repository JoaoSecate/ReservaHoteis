using FluentValidation;
using ReservaHoteis.Domain.Entities;

namespace ReservaHoteis.Service.Validators
{
    public class AvaliacaoValidator : AbstractValidator<Avaliacao>
    {
        public AvaliacaoValidator()
        {
            RuleFor(c => c.Nota)
                .NotEmpty().WithMessage("Erro, nota vazia.")
                .LessThanOrEqualTo(5)
                .GreaterThanOrEqualTo(0)
                .NotNull().WithMessage("Erro, nota nulo.");
            
        }
    }
}