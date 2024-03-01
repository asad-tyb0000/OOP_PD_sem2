using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace music_task2.BL
{
    internal class PlayList
    {
        private string Name;
        private List<Song> Songs = new List<Song>();

        public PlayList(string name)
        {
            Name = name;
        }

        public void AddSong(Song song)
        {
            Songs.Add(song);
        }

        public void ShowPlayList()
        {
            Console.WriteLine("PlayList: " + Name);
            foreach (Song song in Songs)
            {
                Console.WriteLine(song.GetName());
            }
        }
    }
}
