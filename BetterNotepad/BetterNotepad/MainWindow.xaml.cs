using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BetterNotepad
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CommandBindings.Add(new CommandBinding(ApplicationCommands.Close,
                new ExecutedRoutedEventHandler(delegate (object sender, ExecutedRoutedEventArgs args) { this.Close(); })));
        }
        public void DragWindow(object sender, MouseButtonEventArgs args)
        {
            DragMove();
        }


        private void Opacity_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            rtb_note.Opacity = opacity_slider.Value;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Application.Current.MainWindow.WindowState == WindowState.Maximized)
            {
                Application.Current.MainWindow.WindowState = WindowState.Normal;
            }
            else
            {
                Application.Current.MainWindow.WindowState = WindowState.Maximized;
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }

        private void btn_options_Click(object sender, RoutedEventArgs e)
        {
            Options opt_window = new Options();
            opt_window.ShowDialog();
        }

        private void btn_format_Click(object sender, RoutedEventArgs e)
        {
            Format format_window = new Format();
            format_window.ShowDialog();
        }

        public void reloadSettings()
        {
            rtb_note.FontFamily = (FontFamily)Properties.Settings.Default["FontFamily"];
            rtb_note.FontSize = (double)Properties.Settings.Default["Size"];
            rtb_note.FontWeight = ((bool)Properties.Settings.Default["Bold"]) ? FontWeights.Bold : FontWeights.Normal;
            rtb_note.FontStyle = ((bool)Properties.Settings.Default["Italic"]) ? FontStyles.Italic : FontStyles.Normal;
        }
    }
}
