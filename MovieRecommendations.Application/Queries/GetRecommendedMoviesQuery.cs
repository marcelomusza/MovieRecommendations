using MediatR;
using MovieRecommendations.Domain.Entities;

namespace MovieRecommendations.Application.Queries
{
    public class GetRecommendedMoviesQuery : IRequest<IEnumerable<Movie>>
    {
        public int UserId { get; set; }

        public GetRecommendedMoviesQuery(int userId)
        {
            UserId = userId;
        }
    }
}
