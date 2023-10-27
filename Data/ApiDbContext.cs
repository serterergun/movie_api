using Microsoft.EntityFrameworkCore;
using imdb_api.Models;

namespace imdb_api.Data
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Cast> Casts { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<Writer> Writers { get; set; }
        public DbSet<MovieGenre> MovieGenres { get; set; }
        public DbSet<MovieImage> MovieImages { get; set; }
        public DbSet<MovieVideo> MovieVideos { get; set; }
    }
}