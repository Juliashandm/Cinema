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

namespace Cinema
{
    /// <summary>
    /// Interaction logic for Admins.xaml
    /// </summary>
    public partial class Admins : Window
    {
        AdminSettings _settings = null;


        public Admins()
        {
            InitializeComponent();

            _settings = AdminSettings.DetSettings();

            _initControlls();
        }

        private void _initControlls()
        {
            textBoxName.Text = _settings.Name;
            textBoxGenre.Text = _settings.Genre;
            textBoxCountry.Text = _settings.Country;
            textBoxAge.Text = _settings.Age;
            textBoxActors.Text = _settings.Actors;

        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow start = new MainWindow();
            start.Show();
            Close();
        }

        private void back1_Click(object sender, RoutedEventArgs e)
        {
            MainWindow start = new MainWindow();
            start.Show();
            Close();

            _settings.Name = textBoxName.Text;
            _settings.Genre = textBoxGenre.Text;
             _settings.Country=textBoxCountry.Text ;
             _settings.Age=textBoxAge.Text ;
              _settings.Actors=textBoxActors.Text;

            _settings.Save();
        }
    }
}
