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

namespace Cinema
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void ComdoBox_Selected(object sender, SelectionChangedEventArgs e)
        {
        }

        private void stranger_Click(object sender, RoutedEventArgs e)
        {
            Film1 Stranger = new Film1(); //обозначаем окно 1 в программе
            Stranger.Show(); //открываем окно 1
            Close();  //закрываем это окно (которое сейчас открыто)
        }

        private void pirats_Click(object sender, RoutedEventArgs e)
        {
            Film2 Pirats = new Film2(); //обозначаем окно 1 в программе
            Pirats.Show(); //открываем окно 1
            Close();  //закрываем это окно (которое сейчас открыто)
        }
    }
}
