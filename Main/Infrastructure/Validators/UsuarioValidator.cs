using Core.DTOs;
using FluentValidation;

namespace Infrastructure.Validators
{
    class UsuarioValidator : AbstractValidator<UsuarioDto>
    {
        public UsuarioValidator()
        {
            RuleFor(entity => entity.UsrPassword)
                .NotNull()
                .Matches("^(?=.*\\d)(?=.*[a-z])(?=.*[.,*?_#$%!=¡?)(/\\-+])(?=.*[A-Z]).{8,50}$")
                .WithMessage("La contraseña no puede ser nula");

            RuleFor(entity => entity.UsrPasswordSetter)
                .NotNull()
                .Matches("^(?=.*\\d)(?=.*[a-z])(?=.*[.,*?_#$%!=¡?)(/\\-+])(?=.*[A-Z]).{8,50}$")
                .WithMessage("La contraseña no puede ser nula");

            RuleFor(entity => entity.OldPassword)
                .NotNull()
                .Matches("^(?=.*\\d)(?=.*[a-z])(?=.*[.,*?_#$%!=¡?)(/\\-+])(?=.*[A-Z]).{8,50}$")
                .WithMessage("La contraseña no puede ser nula");

            RuleFor(entity => entity.UsrEmail)
                .Length(1, 256)
                .WithMessage("La longitud del correo debe estar entre 1 y 256 caracteres");
        }
    }
}
