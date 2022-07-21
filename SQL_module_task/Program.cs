namespace SQL_module_task
{
    using Microsoft.EntityFrameworkCore;
    using SQL_module_task.Models;

    internal class Program
    {
        static async Task Main(string[] args)
        {
            await using (ApplicationConfiguration configuration = new ApplicationConfigurationFactory().CreateDbContext(Array.Empty<string>()))
            {
                configuration
                    .Artists
                    .Add(new Artist
                    {
                        ArtistName = "frank",
                        ArtistID = 5,
                        ArtistEmail = "franko@gmail.com"
                    });

                configuration
                    .Genres
                    .Add(new Genre
                    {
                        GenreID = 4,
                        Title = "Jazz",
                    });
                await configuration.SaveChangesAsync();

                var artists = configuration.Artists;

                foreach (var a in artists)
                {
                    await configuration
                        .Entry(a)
                        .Reference(s => s.ArtistSong)
                        .LoadAsync();
                }

                var songs = configuration.Songs;
                foreach (var s in songs)
                {
                    await configuration
                        .Entry(s)
                        .Reference(s => s.SongGenre)
                        .LoadAsync();

                    await configuration
                        .Entry(s)
                        .Reference(s => s.Artist)
                        .LoadAsync();
                }

                configuration.SaveChanges();

            }
        }
    }
}