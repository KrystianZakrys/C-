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
using System.Windows.Shapes;

namespace BetterNotepad
{
    /// <summary>
    /// Interaction logic for Options.xaml
    /// </summary>
    public partial class Options : Window
    {

        public List<ThemeModel> theme_list = new List<ThemeModel> {
            new ThemeModel("Light",Brushes.White,Brushes.Black),
            new ThemeModel("Dark",Brushes.Black,Brushes.White),
        };


        public Options()
        {
            InitializeComponent();
            cb_theme.SelectedItem = theme_list.Find(q => q.Name == Properties.Settings.Default["Theme"].ToString());
            DataContext = theme_list;
        }



     

        private void btn_save_options_Click(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default["Theme"] = (cb_theme.SelectedItem as ThemeModel).Name;
            Properties.Settings.Default.Save();
            ((MainWindow)Application.Current.MainWindow).reloadSettings();
            this.Close();
        }

        private void cb_theme_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var cb = sender as ComboBox;
            var item = cb.SelectedItem as ThemeModel;

            ((MainWindow)Application.Current.MainWindow).rtb_note.Background = item.TH_background;
            ((MainWindow)Application.Current.MainWindow).rtb_note.Foreground = item.TH_foreground;
        }
    }
}
