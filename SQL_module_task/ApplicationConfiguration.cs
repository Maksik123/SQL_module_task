namespace SQL_module_task
{
    using Microsoft.EntityFrameworkCore;
    using SQL_module_task.Configs;
    using SQL_module_task.Models;
    public class ApplicationConfiguration : DbContext
    {
        public ApplicationConfiguration(DbContextOptions<ApplicationConfiguration> options) : base(options)
        {
        }

        public DbSet<Artist> Artists { get; set; }

        public DbSet<Song> Songs { get; set; }

        public DbSet<Genre> Genres { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ArtistConfiguration());
            modelBuilder.ApplyConfiguration(new SongConfiguration());
            modelBuilder.ApplyConfiguration(new GenreConfiguration());
        }
    }
}
