using Microsoft.EntityFrameworkCore;
using MovieRecommendations.Domain.Entities;

namespace MovieRecommendations.Infrastructure
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext()
        {
        }

        public MovieDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
