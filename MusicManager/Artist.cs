namespace MusicManager
{
    public class Artist
    {
        public int ArtistId { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }

        public Artist(int artistId, string name)
        {
            ArtistId = artistId;
            Name = name;
            Country = "";
        }

        public string GetDisplayInfo()
        {
            return Name + " - " + Country;
        }
    }
}