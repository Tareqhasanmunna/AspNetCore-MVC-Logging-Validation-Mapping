using FluentValidation;
using SerilogPractice.Models;

namespace SerilogPractice.Validators
{
    public class UserRegisterValidator : AbstractValidator<UserRegister>
    {
        public UserRegisterValidator() {
            RuleFor(x => x.Email)
                .NotEmpty()
                .EmailAddress();

            RuleFor(x => x.Password)
                .NotEmpty()
                .MinimumLength(8);

            RuleFor(x => x.Age)
                .InclusiveBetween(18, 60);
        }
    }
}
