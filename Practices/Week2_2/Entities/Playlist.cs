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
        private List<Song> Songs { get; set; }
        private Random random;

        public Playlist(Song firstSong)
        {
            Songs = new List<Song>();
            random = new Random();
            AddSong(firstSong);
        }

        public void AddSong(Song song)
        {
            if(song != null)
                Songs.Add(song);
        }

        public string GetSongs()
        {
            return string.Join("\n", Songs.Select(songs => $"{songs.Title} - {songs.Composer}"));
        }

        public void ShuffleSongs()
        {
            int songCount = Songs.Count;

            while (songCount > 0)
            {
                songCount--;
                Song song = Songs[songCount];
                
                int randomIndex = random.Next(songCount);
                Songs[songCount] = Songs[randomIndex];//songCount = maxValue 
                Songs[randomIndex] = song;
            }
        }
    }
}
