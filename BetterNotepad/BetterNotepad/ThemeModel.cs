using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace BetterNotepad
{

    public class ThemeModel
    {
        public string Name { get; set; }
        public SolidColorBrush TH_background { get; set; }
        public SolidColorBrush TH_foreground { get; set; }

        public ThemeModel()
        {
            Name = "Light";
            TH_background = Brushes.White;
            TH_foreground = Brushes.Black;
        }

        public ThemeModel(string _name, SolidColorBrush bg, SolidColorBrush fg)
        {
            Name = _name;
            TH_background = bg;
            TH_foreground = fg;
        }
    }
}
