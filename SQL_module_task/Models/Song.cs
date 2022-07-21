namespace SQL_module_task.Models
{
    public class Song
    {
        public int SongID { get; set; }

        public string Title { get; set; }

        public DateTime ReleasedDate { get; set; }

        public string Duration { get; set; }

        public int ArtistID { get; set; }

        public Artist Artist { get; set; }

        public int GenreID { get; set; }

        public Genre SongGenre { get; set; }
    }
}
