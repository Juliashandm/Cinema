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
            Film2 Pirats = new Film2(); 
            Pirats.Show(); 
            Close(); 
        }

        private void big_Click(object sender, RoutedEventArgs e)
        {
            Film3 Big = new Film3();
            Big.Show();
            Close();
        }

        private void hunter_Click(object sender, RoutedEventArgs e)
        {
            Film4 Hunters = new Film4();
            Hunters.Show();
            Close();
        }

        private void rescuers_Click(object sender, RoutedEventArgs e)
        {
            Film5 Rescuers = new Film5();
            Rescuers.Show();
            Close();
        }

        private void admin_Click(object sender, RoutedEventArgs e)
        {
            password.Visibility = Visibility.Visible; //окно для пароля и кнопка входа 
            login.Visibility = Visibility.Visible; //становятся видимыми
        }

        private void login_Click(object sender, RoutedEventArgs e)
        {
            Admins administrator = new Admins();
            string pass = password.Password; //так считывается пароль из passwordbox
            string code = "admin_cinemaforall2017";  //это сам пароль
            string message = "Чтобы родолжить работу как Пользователь, нажмите ОК";
            string mess = "Неверный пароль";
            if (pass == code) administrator.ShowDialog(); //проверка введенного пароля, если он верный,
            else { MessageBox.Show(message, mess); }   //открываем окно админа
            password.Password = null;    //стираем введенный пароль из passwordbox
            password.Visibility = Visibility.Hidden;  //прячем кнопку входа и passwordbox
            login.Visibility = Visibility.Hidden;
        }
    }
}
