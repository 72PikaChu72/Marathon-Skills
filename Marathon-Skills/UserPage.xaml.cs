using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace Marathon_Skills
{
    /// <summary>
    /// Логика взаимодействия для UserPage.xaml
    /// </summary>
    public partial class UserPage : Page
    {
        public SqlConnection Connection = new SqlConnection("server=PIKACHU-LAPTOP;Trusted_Connection=yes;database=Marathon-Skills");
        Random random = new Random();
        public static int days;
        public static int hours;
        public static int minutes;
        public static int seconds;
        public static string userid;
        private void MarathonStartTimer_Loaded(object sender, RoutedEventArgs e)
        {
            days = random.Next(0, 20);
            hours = random.Next(0, 24);
            minutes = random.Next(0, 60);
            seconds = random.Next(0, 60);
            MarathonStartTimer.Text = $"Начало марафона через: {days} Дней {hours} Часов {minutes} Минут {seconds} Секунд";
        }
        public UserPage(string Role,string UserEmail)
        {
            InitializeComponent();
            userid = UserEmail;
            RunnerButton2.Visibility = Visibility.Hidden;
            RunnerButton3.Visibility = Visibility.Hidden;
            RunnerButton4.Visibility = Visibility.Hidden;
            RunnerButton5.Visibility = Visibility.Hidden;
            if (Role == "R")
            {
                RunnerButton2.Visibility = Visibility.Visible;
                RunnerButton3.Visibility = Visibility.Visible;
                RunnerButton4.Visibility = Visibility.Visible;
                RunnerButton5.Visibility = Visibility.Visible;
            }
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new StartPage());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PlaceHolder());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PlaceHolder());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RunnerSponsors(userid));
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Для всей информации обратитесь к координаторам марафона:\n\nТелефон:+78548488644\n\nEmail:qwertyuio@asdas.com","Information");
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MarathonRegistration());
        }
    }
}
