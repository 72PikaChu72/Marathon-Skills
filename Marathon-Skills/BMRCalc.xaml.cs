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
    /// Логика взаимодействия для BMRCalc.xaml
    /// </summary>
    public partial class BMRCalc : Page
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
        public BMRCalc()
        {
            InitializeComponent();
        }

        private void Age_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Gender.SelectedIndex == 0)
                {
                    Counter.Content = ((66 + (13.7 * Convert.ToInt32(Ves.Text)) + (5 * Convert.ToInt32(Rost.Text)) - (6.8 * Convert.ToInt32(Age.Text))));
                }
                else if (Gender.SelectedIndex == 1)
                {
                    Counter.Content = ((655 + (9.6 * Convert.ToInt32(Ves.Text)) + (1.8 * Convert.ToInt32(Rost.Text)) - (4.7 * Convert.ToInt32(Age.Text))));
                }
            }
            catch
            {

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Gender_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if (Gender.SelectedIndex == 0)
                {
                    Counter.Content = Math.Round((66 + (13.7 * Convert.ToInt32(Ves.Text)) + (5 * Convert.ToInt32(Rost.Text)) - (6.8 * Convert.ToInt32(Age.Text))));
                }
                else if (Gender.SelectedIndex == 1)
                {
                    Counter.Content = Math.Round(((655 + (9.6 * Convert.ToInt32(Ves.Text)) + (1.8 * Convert.ToInt32(Rost.Text)) - (4.7 * Convert.ToInt32(Age.Text)))));
                }
            }
            catch
            {

            }
        }
    }
}
