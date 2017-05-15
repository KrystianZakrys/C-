using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniPlayer
{
    public class Song
    {
        public string Name { get; set; }
        public int Lenght { get; set; }
        public string FilePath { get; set; }

        public Song(string _name, int _lenght, string _path)
        {
            Name = _name;
            Lenght = _lenght;
            FilePath = _path;
        }

        public void Play()
        {

        }
    }
}
