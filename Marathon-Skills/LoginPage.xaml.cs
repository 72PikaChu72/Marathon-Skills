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
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        Random random = new Random();
        public static int days;
        public static int hours;
        public static int minutes;
        public static int seconds;
        public SqlConnection Connection = new SqlConnection("server=PIKACHU-LAPTOP;Trusted_Connection=yes;database=Marathon-Skills");
        public LoginPage()
        {
            InitializeComponent();
        }
        private void MarathonStartTimer_Loaded(object sender, RoutedEventArgs e)
        {
            days = random.Next(0, 20);
            hours = random.Next(0, 24);
            minutes = random.Next(0, 60);
            seconds = random.Next(0, 60);
            MarathonStartTimer.Text = $"Начало марафона через: {days} Дней {hours} Часов {minutes} Минут {seconds} Секунд";
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            DataTable dataTable = new DataTable("dataBase");
            Connection.Open();
            SqlCommand sqlCommand = Connection.CreateCommand();
            sqlCommand.CommandText = $"SELECT Email,Password,RoleId FROM [User] WHERE Email='{Email.Text}' and Password='{Password.Text}'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);
            Connection.Close();
            try
            {
                if (dataTable.Rows[0][0].ToString() == Email.Text && dataTable.Rows[0][1].ToString() == Password.Text)
                {
                    //Успешно залогинен
                    NavigationService.Navigate(new UserPage(dataTable.Rows[0][2].ToString(), dataTable.Rows[0][0].ToString()));
                }
            }
            catch
            {
                MessageBox.Show("Неправильный логин или пароль!");
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new StartPage());
        }
    }
}
