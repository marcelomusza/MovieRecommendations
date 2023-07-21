using MovieRecommendations.Domain.Entities;
using MovieRecommendations.Domain.Interfaces;

namespace MovieRecommendations.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly MovieDbContext _dbContext;
        public UserRepository(MovieDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddAsync(User user)
        {
            await _dbContext.Users.AddAsync(user);
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<User> GetByIdAsync(int id)
        {
            return await _dbContext.Users.FindAsync(id);
        }

        public Task UpdateAsync(User user)
        {
            throw new NotImplementedException();
        }

        //There is surely a better way to handle this right? :)
        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
