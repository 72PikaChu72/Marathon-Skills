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
    /// Логика взаимодействия для BMICalc.xaml
    /// </summary>
    
    public partial class BMICalc : Page
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
        public BMICalc()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Age_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {


                double BMI = Convert.ToInt32(Ves.Text) / ((Convert.ToInt32(Rost.Text) / 100.0) * (Convert.ToInt32(Rost.Text) / 100.0));
                StatusBar.Value = BMI;
                BmiCount.Content = Math.Round(BMI,3);
                if (BMI <= 16)
                {
                    StatusBar.Foreground = new SolidColorBrush(Colors.Red);
                    StatusText.Content = "Сильный недовес";
                }
                else if (BMI <= 17)
                {
                    StatusBar.Foreground = new SolidColorBrush(Colors.Orange);
                    StatusText.Content = "Умеренный недовес";
                }
                else if (BMI <= 18.5)
                {
                    StatusBar.Foreground = new SolidColorBrush(Colors.Yellow);
                    StatusText.Content = "Небольшой недовес";
                }
                else if (BMI <= 25)
                {
                    StatusBar.Foreground = new SolidColorBrush(Colors.Green);
                    StatusText.Content = "Идеальный вес";
                }
                else if (BMI <= 30)
                {
                    StatusBar.Foreground = new SolidColorBrush(Colors.Yellow);
                    StatusText.Content = "Перевес";
                }
                else if (BMI <= 35)
                {
                    StatusBar.Foreground = new SolidColorBrush(Colors.Orange);
                    StatusText.Content = "Ожирение 1 степени";
                }
                else
                {
                    StatusBar.Foreground = new SolidColorBrush(Colors.Red);
                    StatusText.Content = "Сильное Ожирение";
                }
            }
            catch
            {

            }
        }
    }
}
