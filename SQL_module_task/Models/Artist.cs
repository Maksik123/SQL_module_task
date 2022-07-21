namespace SQL_module_task.Models
{
    public class Artist
    {
        public int ArtistID { get; set; }

        public string ArtistName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string? ArtistPhoneNumber { get; set; }

        public string? ArtistEmail { get; set; }

        public string? ArtistInstagramUrl { get; set; }

        public int SongID { get; set; }

        public Song ArtistSong { get; set; }
    }
}