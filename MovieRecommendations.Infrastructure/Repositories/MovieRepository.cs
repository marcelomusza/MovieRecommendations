using Microsoft.EntityFrameworkCore;
using MovieRecommendations.Domain.Entities;
using MovieRecommendations.Domain.Interfaces;

namespace MovieRecommendations.Infrastructure.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly MovieDbContext _dbContext;

        public MovieRepository(MovieDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task AddAsync(Movie book)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Movie>> GetAllAsync()
        {
            return await _dbContext.Movies
                                   .AsNoTracking()
                                   .ToListAsync();
        }

        public Task<Movie> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Movie book)
        {
            throw new NotImplementedException();
        }
    }
}
