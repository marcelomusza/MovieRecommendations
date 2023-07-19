using MediatR;

namespace MovieRecommendations.Application.Commands
{
    public class MovieCreateCommand : IRequest<int>
    {
        public string Title { get; set; }
    }
}
