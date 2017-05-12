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
    /// Interaction logic for Format.xaml
    /// </summary>
    public partial class Format : Window
    {
        public Format()
        {
            InitializeComponent();
            Loaded += MyWindow_Loaded;
            this.SizeToContent = SizeToContent.WidthAndHeight;
            slider_size.Value = 9;
        }

        private void MyWindow_Loaded(object sender, RoutedEventArgs e)
        {
            size_label.Content = "Size: " + (int)(double)Properties.Settings.Default["Size"];
            slider_size.Value = (double)Properties.Settings.Default["Size"];

            cb_fontFamily.SelectedValue = Properties.Settings.Default["FontFamily"];

            chckBox_bold.IsChecked = (bool)Properties.Settings.Default["Bold"];
            chckBox_italic.IsChecked = (bool)Properties.Settings.Default["Italic"];
        }

        private void btn_save_format_Click(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default["Size"] = example_label.FontSize;
            Properties.Settings.Default["FontFamily"] = example_label.FontFamily;
            Properties.Settings.Default["Bold"] = (example_label.FontWeight == FontWeights.Bold) ? true : false;
            Properties.Settings.Default["Italic"] = (example_label.FontStyle == FontStyles.Italic) ? true : false;
            Properties.Settings.Default.Save();
            ((MainWindow)Application.Current.MainWindow).reloadSettings();
        }

        private void slider_size_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            size_label.Content = "Size: " + (int)slider_size.Value;
            example_label.FontSize = slider_size.Value;
        }

        private void cb_fontFamily_Selected(object sender, RoutedEventArgs e)
        {
            example_label.FontFamily = (FontFamily)((ComboBox)sender).SelectedValue;
        }

        private void chckBox_bold_Checked(object sender, RoutedEventArgs e)
        {
            example_label.FontWeight = FontWeights.Bold;
        }

        private void chckBox_italic_Checked(object sender, RoutedEventArgs e)
        {
            example_label.FontStyle = FontStyles.Italic;
        }

        private void chckBox_bold_Unchecked(object sender, RoutedEventArgs e)
        {
            example_label.FontWeight = FontWeights.Normal;
        }

        private void chckBox_italic_Unchecked(object sender, RoutedEventArgs e)
        {
            example_label.FontStyle = FontStyles.Normal;
        }

        private void btn_cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
