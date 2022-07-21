namespace SQL_module_task.Configs
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using SQL_module_task.Models;
    internal class SongConfiguration : IEntityTypeConfiguration<Song>
    {
        public void Configure(EntityTypeBuilder<Song> builder)
        {
            builder
                .ToTable("Song")
                .HasKey(s => s.SongID);

            builder
                .Property(s => s.Title)
                .HasColumnName("SongTitle")
                .HasMaxLength(30);

            builder
                .Property(s => s.Duration)
                .HasColumnType("datetime");

            builder
                .HasData(new[]
                {
                    new Song
                    {
                        SongID = 1,
                        Title = "test Song",
                        ReleasedDate = DateTime.UtcNow,
                        Duration = "4:20",
                    }
                });
        }
    }
}
