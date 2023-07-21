using FluentValidation;
using MovieRecommendations.Application.Commands.Users;

namespace MovieRecommendations.Application.Validators
{
    public class UserCreateCommandValidator : AbstractValidator<UserCreateCommand>
    {
        public UserCreateCommandValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("User name can't be empty.");
        }
    }
}
