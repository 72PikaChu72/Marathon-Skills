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
    /// Логика взаимодействия для RunnerSponsors.xaml
    /// </summary>
    public partial class RunnerSponsors : Page
    {
        public SqlConnection Connection = new SqlConnection("server=PIKACHU-LAPTOP;Trusted_Connection=yes;database=Marathon-Skills");
        Random random = new Random();
        public static int days;
        public static int hours;
        public static int minutes;
        public static int seconds;
        public static string CurRunnerId;
        private void MarathonStartTimer_Loaded(object sender, RoutedEventArgs e)
        {
            days = random.Next(0, 20);
            hours = random.Next(0, 24);
            minutes = random.Next(0, 60);
            seconds = random.Next(0, 60);
            MarathonStartTimer.Text = $"Начало марафона через: {days} Дней {hours} Часов {minutes} Минут {seconds} Секунд";
        }
        public RunnerSponsors(string Email)
        {
            InitializeComponent();
            
            DataTable dataTable = new DataTable("dataBase");
            Connection.Open();
            SqlCommand sqlCommand = Connection.CreateCommand();
            sqlCommand.CommandText = $"SELECT RunnerId FROM Runner Where Email = '{Email}'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);
            Connection.Close();

            CurRunnerId = dataTable.Rows[0][0].ToString();
        }

        private void ListView_Loaded(object sender, RoutedEventArgs e)
        {
            int count = 0;
            DataTable dataTable = new DataTable("dataBase");
            Connection.Open();
            SqlCommand sqlCommand = Connection.CreateCommand();
            sqlCommand.CommandText = $"SELECT Name,RunnerId,MoneySpent FROM RunnerSponsors Where RunnerId = '{CurRunnerId}'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);
            Connection.Close();
            List<string> listsponsors = new List<string>();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {

                listsponsors.Add(dataTable.Rows[i][0].ToString()+" " + dataTable.Rows[i][2].ToString()+"$");
                count += Convert.ToInt32(dataTable.Rows[i][2].ToString());
            }
            Sponsors.ItemsSource = listsponsors;
            Count.Content = count + "$";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void MainSponsorImage_Loaded(object sender, RoutedEventArgs e)
        {
            DataTable dataTable = new DataTable("dataBase");
            Connection.Open();
            SqlCommand sqlCommand = Connection.CreateCommand();
            sqlCommand.CommandText = $"SELECT RunnerId,SponsorId FROM Runner Where RunnerId = '{CurRunnerId}'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);
            Connection.Close();
            
            if (dataTable.Rows.Count == 1)
            {
                string sponsorid = dataTable.Rows[0][1].ToString();
                dataTable = new DataTable("dataBase");
                Connection.Open();
                sqlCommand = Connection.CreateCommand();
                sqlCommand.CommandText = $"SELECT CharityId,CharityLogo,CharityName FROM Charity Where CharityId = '{sponsorid}'";
                sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dataTable);
                Connection.Close();
                try
                {


                    MainSponsor.Content = dataTable.Rows[0][2].ToString();
                    MainSponsorImage.Stretch = Stretch.Fill;
                    Uri uri = new Uri(@"C:\\Users\\72vla\\source\\repos\\Marathon-Skills\\Marathon-Skills\\Sponsors\" + dataTable.Rows[0][1]);
                    BitmapImage bi3 = new BitmapImage();
                    bi3.BeginInit();
                    bi3.UriSource = uri;
                    bi3.EndInit();
                    MainSponsorImage.Source = bi3;
                }
                catch
                {

                }
            }
        }
    }
}
