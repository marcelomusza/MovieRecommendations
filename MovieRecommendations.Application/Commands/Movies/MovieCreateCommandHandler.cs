using MediatR;
using MovieRecommendations.Domain.Entities;
using MovieRecommendations.Domain.Interfaces;

namespace MovieRecommendations.Application.Commands.Movies
{
    public class MovieCreateCommandHandler : IRequestHandler<MovieCreateCommand, int>
    {
        private readonly IMovieRepository _movieRepository;
        public MovieCreateCommandHandler(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public async Task<int> Handle(MovieCreateCommand request, CancellationToken cancellationToken)
        {           

            var movie = new Movie
            {
                Title = request.Title,
            };

            await _movieRepository.AddAsync(movie);
            await _movieRepository.SaveChangesAsync();

            return movie.Id;

        }
    }
}
