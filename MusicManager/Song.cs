namespace MusicManager
{
    public class Song : MusicItem
    {
        public string ArtistName { get; set; }
        public string AlbumName { get; set; }
        public int TrackNumber { get; set; }
        public double Duration { get; set; }
        public int ReleaseYear { get; set; }
        public int Rating { get; set; }
        public bool IsFavorite { get; set; }

        public Song(int id, string title) : base(id, title)
        {
            ArtistName = "";
            AlbumName = "";
        }

        public override string GetDisplayInfo()
        {
            return Title + " - " + ArtistName;
        }

        public bool IsValidRating()
        {
            return Rating >= 1 && Rating <= 5;
        }
    }
}