using System;

namespace MusicManager
{
    public class Tests
    {
        public static void RunTests()
        {
            MusicLibrary library = new MusicLibrary("Test Library");

            library.AddSong(new Song(1, "Test Song"));

            if (library.GetAllSongs().Count == 1)
                MessageBox.Show("Add Song Test Passed!");

            if (library.SearchSongs("Test").Count == 1)
                MessageBox.Show("Search Test Passed!");
        }
    }
}