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

namespace Marathon_Skills
{
    /// <summary>
    /// Логика взаимодействия для FindOutMore.xaml
    /// </summary>
    public partial class FindOutMore : Page
    {
        Random random = new Random();
        public static int days;
        public static int hours;
        public static int minutes;
        public static int seconds;
        private void MarathonStartTimer_Loaded(object sender, RoutedEventArgs e)
        {
            days = random.Next(0, 20);
            hours = random.Next(0, 24);
            minutes = random.Next(0, 60);
            seconds = random.Next(0, 60);
            MarathonStartTimer.Text = $"Начало марафона через: {days} Дней {hours} Часов {minutes} Минут {seconds} Секунд";
        }
        public FindOutMore()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MoreInfo());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SponsorsList());
        }

        private void MoreInfoClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MoreInfo());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new BMICalc());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new BMRCalc());
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PlaceHolder());
        }
    }
}
