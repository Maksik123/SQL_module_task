namespace SQL_module_task.Configs
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using SQL_module_task.Models;
    internal class GenreConfiguration : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder
                .ToTable("Genre")
                .HasKey(g => g.GenreID);

            builder
                .Property(g => g.Title)
                .HasMaxLength(30);

            builder
                .HasData(new[]
                {
                    new Genre
                    {
                        Title = "Pop",
                        GenreID = 1
                    },

                    new Genre
                    {
                        GenreID = 2,
                        Title = "Rock"
                    },

                    new Genre
                    {
                        GenreID = 3,
                        Title = "Rap"
                    }
                });
        }
    }
}
