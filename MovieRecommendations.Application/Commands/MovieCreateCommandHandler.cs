using MediatR;
using MovieRecommendations.Domain.Entities;
using MovieRecommendations.Domain.Interfaces;

namespace MovieRecommendations.Application.Commands
{
    public class MovieCreateCommandHandler : IRequestHandler<MovieCreateCommand, int>
    {
        private readonly IMovieRepository _movieRepository;
        public MovieCreateCommandHandler(IMovieRepository MovieRepository)
        {
            _movieRepository = MovieRepository;
        }

        public async Task<int> Handle(MovieCreateCommand request, CancellationToken cancellationToken)
        {           

            var movie = new Movie
            {
                Title = request.Title,
            };

            _movieRepository.Add(movie);
            await _movieRepository.SaveChangesAsync();

            return movie.Id;

        }
    }
}
