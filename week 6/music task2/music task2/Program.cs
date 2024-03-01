using music_task2.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace music_task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Song song1 = new Song("Song1");
            Song song2 = new Song("Song2");
            Song song3 = new Song("Song3");
            Song song4 = new Song("Song4");
            PlayList playList = new PlayList("LoveSongs");
            playList.AddSong(song1);
            playList.AddSong(song2);
            playList.ShowPlayList();
            Console.ReadKey();
        }
    }
}
