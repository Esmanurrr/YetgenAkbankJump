using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_2.Entities
{
    internal class Playlist
    {
        public Guid Id { get; set; }
        private List<string> Songs { get; set; }

        private Playlist()
        {
            Songs = new List<string>();
        }

        public Playlist(string firstSong):this() 
        {
            AddSong(firstSong);
        }

        public void AddSong(string song)
        {
            if(IsSongTitleValid(song))
                Songs.Add(song);
        }

        private bool IsSongTitleValid(string song)
        {
            return !string.IsNullOrEmpty(song)
                && song.Length > 2
                && song.Length < 20;
        }
    }
}
