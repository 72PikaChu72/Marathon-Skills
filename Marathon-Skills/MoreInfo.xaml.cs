﻿using System;
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
    /// Логика взаимодействия для MoreInfo.xaml
    /// </summary>
    public partial class MoreInfo : Page
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
        public MoreInfo()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Информация о чекпоинте \n\n Информация о чекпоинтеИнформация о чекпоинтеИнформация о чекпоинтеИнформация о чекпоинтеИнформация о чекпоинтеИнформация о чекпоинтеИнформация о чекпоинтеИнформация о чекпоинтеИнформация о чекпоинтеИнформация о чекпоинтеИнформация о чекпоинтеИнформация о чекпоинтеИнформация о чекпоинтеИнформация о чекпоинтеИнформация о чекпоинте");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
