
using FluentValidation;
using ReservaHoteis.Domain.Entities;

namespace ReservaHoteis.Service.Validators
{
    public class HotelValidator : AbstractValidator<Hotel>
    {
        public HotelValidator()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Por favor informe o nome.")
                .NotNull().WithMessage("Por favor informe o nome.");
            RuleFor(c => c.Classificacao)
                .LessThanOrEqualTo(5)
                .GreaterThanOrEqualTo(0);
            RuleFor(c => c.Endereco)
                .NotEmpty().WithMessage("Por favor informe o Endereco.")
                .NotNull().WithMessage("Por favor informe o Endereco.");
        }
    }
}