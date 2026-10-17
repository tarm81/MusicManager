namespace MusicManager
{
    public class Album : MusicItem
    {
        public string ArtistName { get; set; }
        public int ReleaseYear { get; set; }
        public int NumberOfTracks { get; set; }

        public Album(int id, string title) : base(id, title)
        {
            ArtistName = "";
        }

        public override string GetDisplayInfo()
        {
            return Title + " - " + ArtistName;
        }
    }
}