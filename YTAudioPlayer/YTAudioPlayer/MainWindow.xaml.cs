using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UniPlayer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {

        public List<Song> songList = new List<Song>()
        {
            new Song("xD",2,"brak"),
            new Song("xD2",2,"brak"),
            new Song("xD3",2,"brak"),
        };

        public MainWindow()
        {
            InitializeComponent();
            DataContext = songList;
            listbox_songs.ItemsSource = songList;
        }
    }
}
