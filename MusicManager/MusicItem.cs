using System;

namespace MusicManager
{
    public abstract class MusicItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public DateTime DateAdded { get; set; }

        public MusicItem(int id, string title)
        {
            Id = id;
            Title = title;
            Genre = "";
            DateAdded = DateTime.Now;
        }

        public abstract string GetDisplayInfo();
    }
}