using MovieRecommendations.Domain.Entities;

namespace MovieRecommendations.Domain.Services
{
    public interface IRecommendationAlgorithm
    {
        IEnumerable<Movie> GetRecommendations(User user, IEnumerable<Movie> movies);
    }
}
