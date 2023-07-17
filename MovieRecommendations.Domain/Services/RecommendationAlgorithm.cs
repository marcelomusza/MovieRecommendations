using MovieRecommendations.Domain.Entities;

namespace MovieRecommendations.Domain.Services
{
    public class RecommendationAlgorithm : IRecommendationAlgorithm
    {
        public IEnumerable<Movie> GetRecommendations(User user, IEnumerable<Movie> movies)
        {
            //Just a random recommendation
            var random = new Random();
            return movies.OrderByDescending(x => x.Title).Take(random.Next(1, movies.Count()));
        }
    }
}
