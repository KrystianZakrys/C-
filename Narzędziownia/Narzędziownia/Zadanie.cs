using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Narzędziownia
{
    public class Zadanie
    {
        public string Name { get; set; }
        public bool Done { get; set; }
        public Brush Color { get
            {
                return (Done)? Brushes.Green : Brushes.White;
            } }

        public Zadanie(string n, bool d)
        {
            Name = n;
            Done = d;
        }
    }
}
