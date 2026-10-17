using System.Collections.Generic;
using System.Linq;

namespace MusicManager
{
    public class MusicLibrary
    {
        public string LibraryName { get; set; }

        private List<Song> songs;
        private List<Album> albums;
        private List<Artist> artists;

        public MusicLibrary(string libraryName)
        {
            LibraryName = libraryName;
            songs = new List<Song>();
            albums = new List<Album>();
            artists = new List<Artist>();
        }

        public void AddSong(Song song)
        {
            songs.Add(song);
        }

        public void AddAlbum(Album album)
        {
            albums.Add(album);
        }

        public void AddArtist(Artist artist)
        {
            artists.Add(artist);
        }

        public List<Song> SearchSongs(string title)
        {
            return songs.Where(s => s.Title.Contains(title, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public List<Album> SearchAlbums(string title)
        {
            return albums.Where(a => a.Title.Contains(title, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public List<Artist> SearchArtists(string name)
        {
            return artists.Where(a => a.Name.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public List<Song> SearchByYear(int year)
        {
            return songs.Where(s => s.ReleaseYear == year).ToList();
        }

        public List<Song> GetAllSongs()
        {
            return songs.ToList();
        }

        public void RemoveSong(int id)
        {
            Song song = songs.FirstOrDefault(s => s.Id == id);

            if (song != null)
            {
                songs.Remove(song);
            }
        }
    }
}