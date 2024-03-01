using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace music_task2.BL
{
    internal class Song
    {
        private string Name;

        public Song(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }
    }
}
