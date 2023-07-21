using MovieRecommendations.Domain.Entities;

namespace MovieRecommendations.Domain.Interfaces
{
    public interface IMovieRepository
    {
        Task<Movie> GetByIdAsync(int id);
        Task<IEnumerable<Movie>> GetAllAsync();
        Task AddAsync(Movie movie);
        Task UpdateAsync(Movie book);
        Task DeleteAsync(int id);
        Task SaveChangesAsync();
    }
}
