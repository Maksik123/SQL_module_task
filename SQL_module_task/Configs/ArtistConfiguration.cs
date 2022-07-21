using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace SQL_module_task.Configs
{
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using SQL_module_task.Models;
    internal class ArtistConfiguration : IEntityTypeConfiguration<Artist>
    {
        public void Configure(EntityTypeBuilder<Artist> builder)
        {
            builder
                .ToTable("Artist")
                .HasKey(a => a.ArtistID);

            builder
                .Property(a => a.ArtistName)
                .HasMaxLength(50);

            builder
                .Property(a => a.ArtistPhoneNumber)
                .HasMaxLength(15);

            builder.HasData(new[]
                {
                    new Artist
                    {
                        ArtistID = 1,
                        ArtistName = "Petya",
                        ArtistInstagramUrl = "petya.com",
                        ArtistPhoneNumber = "+38000001",
                        ArtistEmail = "Petya@gmail.com"
                    },

                    new Artist
                    {
                        ArtistID = 2,
                        ArtistName = "Vasya",
                        ArtistInstagramUrl = "vasya.com",
                        ArtistPhoneNumber = "+38000002",
                        ArtistEmail = "Vasya@gmail.com"
                    },

                    new Artist
                    {
                        ArtistID = 3,
                        ArtistName = "Max",
                        ArtistInstagramUrl = "max.com",
                        ArtistPhoneNumber = "+38000003",
                        ArtistEmail = "Max@gmail.com"
                    },
                });
        }
    }
}
