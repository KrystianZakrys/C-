using System;
using System.Collections.Generic;
using System.IO;
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
        /// <summary>
        /// REDUNDANT ! NEED TO CREATE OWN SETTING TYPE
        /// </summary>
        public List<ThemeModel> theme_list = new List<ThemeModel> {
            new ThemeModel("Light",Brushes.White,Brushes.Black),
            new ThemeModel("Dark",Brushes.Black,Brushes.White),
            new ThemeModel("Matrix", Brushes.Black, Brushes.Green),
            new ThemeModel("Chocolate", Brushes.SaddleBrown, Brushes.DarkOrange),
        };

        string openedFile = "";
        string _title = "Better Notepad v0.01a";

        public MainWindow()
        {
            InitializeComponent();

            Loaded += MyWindow_Loaded;
            CommandBindings.Add(new CommandBinding(ApplicationCommands.Close,
                new ExecutedRoutedEventHandler(delegate (object sender, ExecutedRoutedEventArgs args) { this.Close(); })));
        }


        private void MyWindow_Loaded(object sender, RoutedEventArgs e)
        {
            rtb_note.FontFamily = (FontFamily)Properties.Settings.Default["FontFamily"];
            rtb_note.FontSize = (double)Properties.Settings.Default["Size"];
            rtb_note.FontWeight = ((bool)Properties.Settings.Default["Bold"]) ? FontWeights.Bold : FontWeights.Normal;
            rtb_note.FontStyle = ((bool)Properties.Settings.Default["Italic"]) ? FontStyles.Italic : FontStyles.Normal;

            ThemeModel th = theme_list.Find(q => q.Name == Properties.Settings.Default["Theme"].ToString());
            rtb_note.Background = th.TH_background;
            rtb_note.Foreground = th.TH_foreground;
        }


        public void DragWindow(object sender, MouseButtonEventArgs args)
        {
            DragMove();
        }


        private void Opacity_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            rtb_note.Opacity = opacity_slider.Value;
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

            ThemeModel th = theme_list.Find(q => q.Name == Properties.Settings.Default["Theme"].ToString());
            rtb_note.Background = th.TH_background;
            rtb_note.Foreground = th.TH_foreground;
        }

        private void btn_maximize_Click(object sender, RoutedEventArgs e)
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

        private void btn_minimize_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }

        private void btn_newFile_Click(object sender, RoutedEventArgs e)
        {
            rtb_note.Document.Blocks.Clear();
            openedFile = "";
            this.Title = _title;

        }

        private void btn_openFile_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();



            // Set filter for file extension and default file extension 


            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = dlg.ShowDialog();
            string filename = "";

            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                // Open document 
                filename = dlg.FileName;
                openedFile = filename;
                this.Title = _title + "  -  " + openedFile;

                TextRange t = new TextRange(rtb_note.Document.ContentStart,
                                    rtb_note.Document.ContentEnd);
                FileStream file = new FileStream(filename, FileMode.Open);
                t.Load(file, System.Windows.DataFormats.Text);
                file.Close();
            }



        }


        private void btn_saveFile_Click(object sender, RoutedEventArgs e)
        {
            if (openedFile == null || openedFile == "")
            {
                SaveFileAs();
            }
            else
            {
                SaveToFile(openedFile);
            }

        }

        private void btn_saveFileAs_Click(object sender, RoutedEventArgs e)
        {
            SaveFileAs();
        }

        private bool IsRichTextBoxEmpty(RichTextBox rtb)
        {
            if (rtb.Document.Blocks.Count == 0) return true;
            TextPointer startPointer = rtb.Document.ContentStart.GetNextInsertionPosition(LogicalDirection.Forward);
            TextPointer endPointer = rtb.Document.ContentEnd.GetNextInsertionPosition(LogicalDirection.Backward);
            return startPointer.CompareTo(endPointer) == 0;
        }

        private void SaveToFile(string file_path)
        {
            if (file_path == null || file_path == "")
            {
                SaveFileAs();
            }
            else
            {
                TextRange t = new TextRange(rtb_note.Document.ContentStart,
                                    rtb_note.Document.ContentEnd);
                FileStream file = new FileStream(file_path, FileMode.Create);
                openedFile = file_path;
                this.Title = _title + "  -  " + openedFile;
                t.Save(file, System.Windows.DataFormats.Text);
                file.Close();
            }

        }

        private void SaveFileAs()
        {
            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();



            // Set filter for file extension and default file extension 


            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = dlg.ShowDialog();
            string filename = "";

            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                // Open document 
                filename = dlg.FileName;
                openedFile = filename;
                this.Title = _title + "  -  " + openedFile;
                TextRange t = new TextRange(rtb_note.Document.ContentStart,
                                  rtb_note.Document.ContentEnd);
                FileStream file = new FileStream(filename, FileMode.Create);
                t.Save(file, System.Windows.DataFormats.Text);
                file.Close();
            }


        }

        private void btn_close_Click(object sender, RoutedEventArgs e)
        {
            if (IsRichTextBoxEmpty(rtb_note))
            {
                MessageBoxResult mb = MessageBox.Show("Are you sure?", "Closing...", MessageBoxButton.YesNoCancel, MessageBoxImage.Exclamation);
                switch (mb)
                {
                    case MessageBoxResult.None:
                        return;
                    case MessageBoxResult.Cancel:
                        return;
                    case MessageBoxResult.Yes:
                        SaveToFile(openedFile);
                        break;
                    case MessageBoxResult.No:
                        break;
                    default:
                        break;
                }
            }
            Application.Current.Shutdown();

        }
    }
}
