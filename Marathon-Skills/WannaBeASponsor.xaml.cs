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
    /// Логика взаимодействия для WannaBeASponsor.xaml
    /// </summary>
    public class Runners
    {
        public string id, Name, Email;
    }
    public partial class WannaBeASponsor : Page
    {
        public SqlConnection Connection = new SqlConnection("server=PIKACHU-LAPTOP;Trusted_Connection=yes;database=Marathon-Skills");
        Random random = new Random();
        public static int days;
        public static int hours;
        public static int minutes;
        public static int seconds;
        public static string userid;
        public static List<Runners> RunnersList = new List<Runners>();
        private void MarathonStartTimer_Loaded(object sender, RoutedEventArgs e)
        {
            days = random.Next(0, 20);
            hours = random.Next(0, 24);
            minutes = random.Next(0, 60);
            seconds = random.Next(0, 60);
            MarathonStartTimer.Text = $"Начало марафона через: {days} Дней {hours} Часов {minutes} Минут {seconds} Секунд";
        }
        public WannaBeASponsor()
        {
            InitializeComponent();
            DataTable dataTable = new DataTable("dataBase");
            Connection.Open();
            SqlCommand sqlCommand = Connection.CreateCommand();
            sqlCommand.CommandText = $"SELECT Email,RunnerId FROM [Runner]";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);
            Connection.Close();
            for(int i = 0; i < dataTable.Rows.Count; i++)
            {
                Runners runner = new Runners();
                runner.id = dataTable.Rows[i][1].ToString();
                runner.Email= dataTable.Rows[i][0].ToString();
                DataTable dataTable1 = new DataTable("dataBase");
                Connection.Open();
                sqlCommand = Connection.CreateCommand();
                sqlCommand.CommandText = $"SELECT FirstName,LastName FROM [User] Where Email='{runner.Email}'";
                sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dataTable1);
                Connection.Close();
                runner.Name= dataTable1.Rows[0][0].ToString()+" " + dataTable1.Rows[0][1].ToString();
                RunnersList.Add(runner);
            }
            foreach(Runners runner in RunnersList)
            {
                RunnersCombo.Items.Add(runner.Name);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Connection.Open();
            SqlCommand sqlCommand = Connection.CreateCommand();
            sqlCommand.CommandText = $"Insert into RunnerSponsors (Name,RunnerId,MoneySpent) Values ('{MyName.Text}','{RunnersList[RunnersCombo.SelectedIndex].id}','{MoneySpent.Text}')";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlCommand.ExecuteNonQuery();
            Connection.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
