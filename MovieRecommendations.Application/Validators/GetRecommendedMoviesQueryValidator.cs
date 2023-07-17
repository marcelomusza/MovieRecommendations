using FluentValidation;
using MovieRecommendations.Application.Queries;

namespace MovieRecommendations.Application.Validators
{
    public class GetRecommendedMoviesQueryValidator : AbstractValidator<GetRecommendedMoviesQuery>
    {

        public GetRecommendedMoviesQueryValidator()
        {
            RuleFor(q => q.UserId)
                .NotEmpty()                
                .WithMessage("User ID is required.");
        }

    }
}
