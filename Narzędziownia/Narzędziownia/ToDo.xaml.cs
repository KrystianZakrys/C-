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

namespace Narzędziownia
{
    /// <summary>
    /// Interaction logic for ToDo.xaml
    /// </summary>
    public partial class ToDo : Window
    {

        
        public ToDo()
        {
            InitializeComponent();
        }
        private void btn_dodaj_Click(object sender, RoutedEventArgs e)
        {
            TextBox notka = new TextBox();
            Grid.SetColumn(notka, 0);
            notka.HorizontalAlignment = HorizontalAlignment.Stretch;
            CheckBox ptaszek = new CheckBox() { HorizontalAlignment = HorizontalAlignment.Right };
            Grid.SetColumn(ptaszek, 1);
            notka.MaxWidth = 450d;
            notka.Width = 427d;
            notka.Margin = new Thickness(1, 1, 1, 1);
            ptaszek.Margin = new Thickness(1, 1, 1, 1);
            ptaszek.HorizontalAlignment = HorizontalAlignment.Right;
            ptaszek.Background = Brushes.White;



            Grid wiersz = new Grid() { ColumnDefinitions = { new ColumnDefinition() { Width = GridLength.Auto }, new ColumnDefinition() { Width = new GridLength(100, GridUnitType.Star) } } };// new GridLength(100, GridUnitType.Star)
            Brush staryGridColor = wiersz.Background;

            ptaszek.Checked += delegate
            {
                wiersz.Background = Brushes.LimeGreen;
                
                notka.IsEnabled = false;
            };

            ptaszek.Unchecked += delegate
            {
                wiersz.Background = staryGridColor;
                notka.Foreground = Brushes.Black;
                notka.IsEnabled = true;
            };

            ptaszek.Checked += delegate (object s, RoutedEventArgs ee) {
                string lines = notka.Text + ";" + ((CheckBox)s).IsChecked.ToString() + "\n";
             
                //System.IO.File.AppendAllText(@"C:\\Users\user\Desktop\tekst.txt",
                //   lines + Environment.NewLine);
            };

            notka.LostFocus += delegate (object s, RoutedEventArgs ee) {
                string lines = ((TextBox)s).Text + ";" + ptaszek.IsChecked.ToString() + "\n";

                // Write the string to a file.
                System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\\Users\user\Desktop\tekst.txt", true);
                file.WriteLine(lines);

                file.Close();
            };

            wiersz.Children.Add(notka);
            wiersz.Children.Add(ptaszek);


            listbox_doZdrobienia.Items.Add(wiersz);
        }

        private void btn_wyczysc_Click(object sender, RoutedEventArgs e)
        {
            listbox_doZdrobienia.Items.Clear();
            System.IO.File.WriteAllText(@"C:\\Users\user\Desktop\tekst.txt", string.Empty);
        }

    }
}
