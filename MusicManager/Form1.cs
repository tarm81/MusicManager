
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MusicManager
{
    public partial class Form1 : Form
    {
        private MusicLibrary library = new MusicLibrary("My Music");

        public Form1()
        {
            InitializeComponent();

            cmbSearchType.SelectedIndex = 0;
            dgvSongs.AutoGenerateColumns = true;
            dgvSongs.RowHeadersVisible = false;

            LoadSampleSongs();
            DisplaySongs(library.GetAllSongs());
        }


        private void LoadSampleSongs()
        {
            // Twenty One Pilots
            library.AddSong(new Song(1, "Car Radio")
            {
                ArtistName = "Twenty One Pilots",
                AlbumName = "Vessel",
                Genre = "Alternative",
                ReleaseYear = 2013,
                Rating = 5
            });

            library.AddSong(new Song(2, "Holding On to You")
            {
                ArtistName = "Twenty One Pilots",
                AlbumName = "Vessel",
                Genre = "Alternative",
                ReleaseYear = 2013,
                Rating = 5
            });

            library.AddSong(new Song(3, "Migraine")
            {
                ArtistName = "Twenty One Pilots",
                AlbumName = "Vessel",
                Genre = "Alternative",
                ReleaseYear = 2013,
                Rating = 5
            });

            library.AddSong(new Song(4, "Stressed Out")
            {
                ArtistName = "Twenty One Pilots",
                AlbumName = "Blurryface",
                Genre = "Alternative",
                ReleaseYear = 2015,
                Rating = 5
            });

            library.AddSong(new Song(5, "Ride")
            {
                ArtistName = "Twenty One Pilots",
                AlbumName = "Blurryface",
                Genre = "Alternative",
                ReleaseYear = 2015,
                Rating = 5
            });

            library.AddSong(new Song(6, "Heavydirtysoul")
            {
                ArtistName = "Twenty One Pilots",
                AlbumName = "Blurryface",
                Genre = "Alternative",
                ReleaseYear = 2015,
                Rating = 5
            });

            library.AddSong(new Song(7, "Jumpsuit")
            {
                ArtistName = "Twenty One Pilots",
                AlbumName = "Trench",
                Genre = "Alternative",
                ReleaseYear = 2018,
                Rating = 5
            });

            library.AddSong(new Song(8, "Chlorine")
            {
                ArtistName = "Twenty One Pilots",
                AlbumName = "Trench",
                Genre = "Alternative",
                ReleaseYear = 2018,
                Rating = 5
            });

            library.AddSong(new Song(9, "The Outside")
            {
                ArtistName = "Twenty One Pilots",
                AlbumName = "Scaled and Icy",
                Genre = "Alternative",
                ReleaseYear = 2021,
                Rating = 5
            });

            library.AddSong(new Song(10, "Overcompensate")
            {
                ArtistName = "Twenty One Pilots",
                AlbumName = "Clancy",
                Genre = "Alternative",
                ReleaseYear = 2024,
                Rating = 5
            });

            // The Doors
            library.AddSong(new Song(11, "Break On Through (To the Other Side)")
            {
                ArtistName = "The Doors",
                AlbumName = "The Doors",
                Genre = "Rock",
                ReleaseYear = 1967,
                Rating = 5
            });

            library.AddSong(new Song(12, "Light My Fire")
            {
                ArtistName = "The Doors",
                AlbumName = "The Doors",
                Genre = "Rock",
                ReleaseYear = 1967,
                Rating = 5
            });

            library.AddSong(new Song(13, "The End")
            {
                ArtistName = "The Doors",
                AlbumName = "The Doors",
                Genre = "Rock",
                ReleaseYear = 1967,
                Rating = 5
            });

            library.AddSong(new Song(14, "People Are Strange")
            {
                ArtistName = "The Doors",
                AlbumName = "Strange Days",
                Genre = "Rock",
                ReleaseYear = 1967,
                Rating = 5
            });

            library.AddSong(new Song(15, "Love Me Two Times")
            {
                ArtistName = "The Doors",
                AlbumName = "Strange Days",
                Genre = "Rock",
                ReleaseYear = 1967,
                Rating = 5
            });

            library.AddSong(new Song(16, "Hello, I Love You")
            {
                ArtistName = "The Doors",
                AlbumName = "Waiting for the Sun",
                Genre = "Rock",
                ReleaseYear = 1968,
                Rating = 5
            });

            library.AddSong(new Song(17, "Touch Me")
            {
                ArtistName = "The Doors",
                AlbumName = "The Soft Parade",
                Genre = "Rock",
                ReleaseYear = 1969,
                Rating = 5
            });

            library.AddSong(new Song(18, "Roadhouse Blues")
            {
                ArtistName = "The Doors",
                AlbumName = "Morrison Hotel",
                Genre = "Rock",
                ReleaseYear = 1970,
                Rating = 5
            });

            library.AddSong(new Song(19, "Riders on the Storm")
            {
                ArtistName = "The Doors",
                AlbumName = "L.A. Woman",
                Genre = "Rock",
                ReleaseYear = 1971,
                Rating = 5
            });

            library.AddSong(new Song(20, "L.A. Woman")
            {
                ArtistName = "The Doors",
                AlbumName = "L.A. Woman",
                Genre = "Rock",
                ReleaseYear = 1971,
                Rating = 5
            });

            // Nirvana
            library.AddSong(new Song(21, "About a Girl")
            {
                ArtistName = "Nirvana",
                AlbumName = "Bleach",
                Genre = "Grunge",
                ReleaseYear = 1989,
                Rating = 5
            });

            library.AddSong(new Song(22, "School")
            {
                ArtistName = "Nirvana",
                AlbumName = "Bleach",
                Genre = "Grunge",
                ReleaseYear = 1989,
                Rating = 5
            });

            library.AddSong(new Song(23, "Smells Like Teen Spirit")
            {
                ArtistName = "Nirvana",
                AlbumName = "Nevermind",
                Genre = "Grunge",
                ReleaseYear = 1991,
                Rating = 5
            });

            library.AddSong(new Song(24, "In Bloom")
            {
                ArtistName = "Nirvana",
                AlbumName = "Nevermind",
                Genre = "Grunge",
                ReleaseYear = 1991,
                Rating = 5
            });

            library.AddSong(new Song(25, "Come as You Are")
            {
                ArtistName = "Nirvana",
                AlbumName = "Nevermind",
                Genre = "Grunge",
                ReleaseYear = 1991,
                Rating = 5
            });

            library.AddSong(new Song(26, "Lithium")
            {
                ArtistName = "Nirvana",
                AlbumName = "Nevermind",
                Genre = "Grunge",
                ReleaseYear = 1991,
                Rating = 5
            });

            library.AddSong(new Song(27, "Heart-Shaped Box")
            {
                ArtistName = "Nirvana",
                AlbumName = "In Utero",
                Genre = "Grunge",
                ReleaseYear = 1993,
                Rating = 5
            });

            library.AddSong(new Song(28, "Rape Me")
            {
                ArtistName = "Nirvana",
                AlbumName = "In Utero",
                Genre = "Grunge",
                ReleaseYear = 1993,
                Rating = 5
            });

            library.AddSong(new Song(29, "All Apologies")
            {
                ArtistName = "Nirvana",
                AlbumName = "In Utero",
                Genre = "Grunge",
                ReleaseYear = 1993,
                Rating = 5
            });

            library.AddSong(new Song(30, "Dumb")
            {
                ArtistName = "Nirvana",
                AlbumName = "In Utero",
                Genre = "Grunge",
                ReleaseYear = 1993,
                Rating = 5
            });

            // Metallica
            library.AddSong(new Song(31, "Seek & Destroy")
            {
                ArtistName = "Metallica",
                AlbumName = "Kill 'Em All",
                Genre = "Metal",
                ReleaseYear = 1983,
                Rating = 5
            });

            library.AddSong(new Song(32, "For Whom the Bell Tolls")
            {
                ArtistName = "Metallica",
                AlbumName = "Ride the Lightning",
                Genre = "Metal",
                ReleaseYear = 1984,
                Rating = 5
            });

            library.AddSong(new Song(33, "Fade to Black")
            {
                ArtistName = "Metallica",
                AlbumName = "Ride the Lightning",
                Genre = "Metal",
                ReleaseYear = 1984,
                Rating = 5
            });

            library.AddSong(new Song(34, "Master of Puppets")
            {
                ArtistName = "Metallica",
                AlbumName = "Master of Puppets",
                Genre = "Metal",
                ReleaseYear = 1986,
                Rating = 5
            });

            library.AddSong(new Song(35, "Battery")
            {
                ArtistName = "Metallica",
                AlbumName = "Master of Puppets",
                Genre = "Metal",
                ReleaseYear = 1986,
                Rating = 5
            });

            library.AddSong(new Song(36, "One")
            {
                ArtistName = "Metallica",
                AlbumName = "...And Justice for All",
                Genre = "Metal",
                ReleaseYear = 1988,
                Rating = 5
            });

            library.AddSong(new Song(37, "Enter Sandman")
            {
                ArtistName = "Metallica",
                AlbumName = "Metallica",
                Genre = "Metal",
                ReleaseYear = 1991,
                Rating = 5
            });

            library.AddSong(new Song(38, "Nothing Else Matters")
            {
                ArtistName = "Metallica",
                AlbumName = "Metallica",
                Genre = "Metal",
                ReleaseYear = 1991,
                Rating = 5
            });

            library.AddSong(new Song(39, "The Unforgiven")
            {
                ArtistName = "Metallica",
                AlbumName = "Metallica",
                Genre = "Metal",
                ReleaseYear = 1991,
                Rating = 5
            });

            library.AddSong(new Song(40, "Fuel")
            {
                ArtistName = "Metallica",
                AlbumName = "Reload",
                Genre = "Metal",
                ReleaseYear = 1997,
                Rating = 5
            });
        }


        private void DisplaySongs(List<Song> songs)
        {
            dgvSongs.DataSource = null;
            dgvSongs.DataSource = songs;

            dgvSongs.Columns["Id"].Visible = false;
            dgvSongs.Columns["DateAdded"].Visible = false;
            dgvSongs.Columns["TrackNumber"].Visible = false;
            dgvSongs.Columns["Duration"].Visible = false;
            dgvSongs.Columns["Rating"].Visible = false;
            dgvSongs.Columns["IsFavorite"].Visible = false;
            dgvSongs.Columns["Genre"].Visible = false;

            dgvSongs.Columns["Title"].HeaderText = "Song Title";
            dgvSongs.Columns["ArtistName"].HeaderText = "Artist";
            dgvSongs.Columns["AlbumName"].HeaderText = "Album";
            dgvSongs.Columns["ReleaseYear"].HeaderText = "Year";

            dgvSongs.Columns["Title"].DisplayIndex = 0;
            dgvSongs.Columns["ArtistName"].DisplayIndex = 1;
            dgvSongs.Columns["AlbumName"].DisplayIndex = 2;
            dgvSongs.Columns["ReleaseYear"].DisplayIndex = 3;

            lblResults.Text = songs.Count + " song(s) loaded";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text.Trim();
            string searchType = cmbSearchType.Text;

            if (string.IsNullOrWhiteSpace(search))
            {
                MessageBox.Show("Please enter something to search.");
                return;
            }

            List<Song> results = new List<Song>();

            switch (searchType)
            {
                case "Song Title":
                    results = library.SearchSongs(search);
                    break;

                case "Artist Name":
                    results = library.GetAllSongs().Where(s => s.ArtistName.Contains(search, StringComparison.OrdinalIgnoreCase)).ToList();
                    break;

                case "Album Name":
                    results = library.GetAllSongs().Where(s => s.AlbumName.Contains(search, StringComparison.OrdinalIgnoreCase)).ToList();
                    break;

                case "Release Year":
                    if (!int.TryParse(search, out int year))
                    {
                        MessageBox.Show("Please enter a valid year");
                        return;
                    }

                    if (year < 1900 || year > DateTime.Now.Year)
                    {
                        MessageBox.Show("Please enter a valid year");
                        return;
                    }

                    results = library.SearchByYear(year);
                    break;
            }

            DisplaySongs(results);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            cmbSearchType.SelectedIndex = 0;

            DisplaySongs(library.GetAllSongs());
        }
    }
}
