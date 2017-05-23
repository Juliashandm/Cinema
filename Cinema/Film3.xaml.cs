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
    /// Interaction logic for Film3.xaml
    /// </summary>
    public partial class Film3 : Window
    {
        public Film3()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow start = new MainWindow();
            start.Show();
            Close();
        }

        private void ComdoBox_Selected(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
