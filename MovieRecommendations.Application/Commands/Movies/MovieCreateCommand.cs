using MediatR;

namespace MovieRecommendations.Application.Commands.Movies
{
    public class MovieCreateCommand : IRequest<int>
    {
        public string Title { get; set; }
    }
}
