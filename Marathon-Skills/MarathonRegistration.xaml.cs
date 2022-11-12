using System;
using System.Collections.Generic;
using System.Data;
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
    /// Логика взаимодействия для MarathonRegistration.xaml
    /// </summary>
    public partial class MarathonRegistration : Page
    {
        public static DataTable Charities;
        public SqlConnection Connection = new SqlConnection("server=PIKACHU-LAPTOP;Trusted_Connection=yes;database=Marathon-Skills");
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
        public MarathonRegistration()
        {
            InitializeComponent();
            DataTable dataTable = new DataTable("dataBase");
            Connection.Open();
            SqlCommand sqlCommand = Connection.CreateCommand();
            sqlCommand.CommandText = "SELECT CharityId,CharityName,CharityDescription,CharityLogo FROM Charity";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);
            Connection.Close();
            Charities = dataTable;
            for(int i = 0; i < dataTable.Rows.Count; i++)
            {
                SponsorCombo.Items.Add(dataTable.Rows[i][1].ToString());
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
        public void Count()
        {
            int money = 0;
            if (Check1.IsChecked==true)
            {
                money += 10;
            }
            if (Check2.IsChecked == true)
            {
                money += 20;
            }
            if (Check3.IsChecked == true)
            {
                money += 22;
            }
            if (RadioB.IsChecked == true)
            {
                money += 5;
            }
            if (RadioC.IsChecked == true)
            {
                money += 10;
            }
            if (MoneySpent.Text != "")
            {
                money+=Convert.ToInt32(MoneySpent.Text);
            }
            Counter.Content = money + "$";
        }
        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            
            Count();
            
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            Count();
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Спасибо за регистрацию, координаторы свяжутся с вами для дальнейших действий");
            NavigationService.GoBack();
        }

        private void MoneySpent_TextChanged(object sender, TextChangedEventArgs e)
        {
            Count();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (SponsorCombo.SelectedIndex != -1)
            {
                Window window = new SponsorInfo(Charities.Rows[SponsorCombo.SelectedIndex][1].ToString(), Charities.Rows[SponsorCombo.SelectedIndex][2].ToString(), Charities.Rows[SponsorCombo.SelectedIndex][3].ToString());
                window.Show();
            }
        }
    }
}
