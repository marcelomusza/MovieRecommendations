using MediatR;
using MovieRecommendations.Domain.Entities;
using MovieRecommendations.Domain.Interfaces;
using MovieRecommendations.Domain.Services;

namespace MovieRecommendations.Application.Queries
{
    public class GetRecommendedMoviesQueriesHandler : IRequestHandler<GetRecommendedMoviesQuery, IEnumerable<Movie>>
    {
        private readonly IMovieRepository _movieRepository;
        private readonly IUserRepository _userRepository;
        private readonly IRecommendationAlgorithm _recoAlgorithm;

        public GetRecommendedMoviesQueriesHandler(IMovieRepository MovieRepository,
                                          IUserRepository UserRepository,
                                          IRecommendationAlgorithm RecoAlgorithm)
        {
            _movieRepository = MovieRepository;
            _userRepository = UserRepository;
            _recoAlgorithm = RecoAlgorithm;
        }

        public async Task<IEnumerable<Movie>> Handle(GetRecommendedMoviesQuery request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetByIdAsync(request.UserId);
            if (user == null)
                throw new ArgumentException("Invalid user Id.");

            var movies = await _movieRepository.GetAllAsync();

            var recommendedMovies = _recoAlgorithm.GetRecommendations(user, movies);

            return recommendedMovies;
        }
    }
}
