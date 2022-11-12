using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Логика взаимодействия для RunnerRegister.xaml
    /// </summary>
    public class NewRunner
    {
        public string DateOfBirth,Email,Password,CountryCode,Name,Surname,Gender,PhotoSource;
    }
    public partial class RunnerRegister : Page
    {
        string[,] CountriesList;
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
        public RunnerRegister()
        {
            InitializeComponent();
            DataTable dataTable = new DataTable("dataBase");
            Connection.Open();
            SqlCommand sqlCommand = Connection.CreateCommand();
            sqlCommand.CommandText = "SELECT CountryName,CountryCode FROM Country";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);
            Connection.Close();
            CountriesList = new string[dataTable.Rows.Count, 2];
            for(int i = 0; i < dataTable.Rows.Count; i++)
            {
                CountriesList[i,0] = dataTable.Rows[i][0].ToString();
                CountriesList[i,1] = dataTable.Rows[i][1].ToString();
            }
            for(int i = 0;i<dataTable.Rows.Count;i++)
            {
                Countries.Items.Add(dataTable.Rows[i][0].ToString());
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Email.BorderBrush = new SolidColorBrush(Colors.LightGray);
            Password.BorderBrush = new SolidColorBrush(Colors.LightGray);
            RepeatPassword.BorderBrush = new SolidColorBrush(Colors.LightGray);
            Name.BorderBrush = new SolidColorBrush(Colors.LightGray);
            Surname.BorderBrush = new SolidColorBrush(Colors.LightGray);
            PhotoSource.BorderBrush = new SolidColorBrush(Colors.LightGray);
            Countries.BorderBrush = new SolidColorBrush(Colors.LightGray);

            NewRunner runner = new NewRunner();
            if (Email.Text != "" && new Regex("(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|\"(?:[\\x01-\\x08\\x0b\\x0c\\x0e-\\x1f\\x21\\x23-\\x5b\\x5d-\\x7f]|\\\\[\\x01-\\x09\\x0b\\x0c\\x0e-\\x7f])*\")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\\[(?:(?:(2(5[0-5]|[0-4][0-9])|1[0-9][0-9]|[1-9]?[0-9]))\\.){3}(?:(2(5[0-5]|[0-4][0-9])|1[0-9][0-9]|[1-9]?[0-9])|[a-z0-9-]*[a-z0-9]:(?:[\\x01-\\x08\\x0b\\x0c\\x0e-\\x1f\\x21-\\x5a\\x53-\\x7f]|\\\\[\\x01-\\x09\\x0b\\x0c\\x0e-\\x7f])+)\\])").IsMatch(Email.Text))
            {
                runner.Email = Email.Text;
            }
            else
            {
                Email.BorderBrush = new SolidColorBrush(Colors.Red);
                return;
            }
            if (Password.Password != "" && Password.Password.Length > 8)
            {
                if (Password.Password == RepeatPassword.Password)
                {
                    runner.Password = Password.Password;
                }
                else
                {
                    Password.BorderBrush = new SolidColorBrush(Colors.Red);
                    RepeatPassword.BorderBrush = new SolidColorBrush(Colors.Red);
                    return;
                }
            }
            else
            {
                Password.BorderBrush = new SolidColorBrush(Colors.Red);
                MessageBox.Show("Введите пароль длиннее 8и символов");
            }
            if (Name.Text != "")
            {
                runner.Name = Name.Text;
            }
            else
            {
                Name.BorderBrush = new SolidColorBrush(Colors.Red);
                return;
            }
            if (Surname.Text != "")
            {
                runner.Surname = Surname.Text;
            }
            else
            {
                Surname.BorderBrush = new SolidColorBrush(Colors.Red);
                return;
            }
            if (Gender.SelectedIndex != -1)
            {
                runner.Gender = (new string[] { "Male", "Female" }[Gender.SelectedIndex]);
            }
            if (PhotoSource.Text != "")
            {
                runner.PhotoSource = PhotoSource.Text;
            }
            else
            {
                PhotoSource.BorderBrush = new SolidColorBrush(Colors.Red);
                return;
            }
            if (Countries.Text != "")
            {
                for (int i = 0; i < Countries.Items.Count;i++)
                {
                    if (CountriesList[i, 0] == Countries.Text)
                    {
                        runner.CountryCode = CountriesList[i, 1];
                    }
                }
            }
            else
            {
                Countries.BorderBrush = new SolidColorBrush(Colors.Red);
                return;
            }
            runner.DateOfBirth = $"{Birthday.SelectedDate.Value.Day}.{Birthday.SelectedDate.Value.Month}.{Birthday.SelectedDate.Value.Year}";
            try
            {
                Connection.Open();
                SqlCommand sqlCommand = Connection.CreateCommand();
                sqlCommand.CommandText = $"Insert into Runner (Email,Gender,DateOfBirth,CountryCode) Values ('{runner.Email}', '{runner.Gender}', '{runner.DateOfBirth}', '{runner.CountryCode}')";
                sqlCommand.ExecuteNonQuery();
                sqlCommand.CommandText = $"Insert into [User] (Email,Password,FirstName,LastName,RoleId,PhotoSource) Values ('{runner.Email}', '{runner.Password}', '{runner.Name}', '{runner.Surname}','R','{PhotoSource.Text}')";
                sqlCommand.ExecuteNonQuery();
                Connection.Close();
                MessageBox.Show("Зарегистрирован!");
                NavigationService.Navigate(new StartPage());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter ="Image files(*.png)|*.png|All files(*.*)|*.*";
            fileDialog.Multiselect = false;
            fileDialog.ShowDialog();
            PhotoSource.Text=fileDialog.FileName;
            PhotoImage.Stretch = Stretch.Fill;
            Uri uri = new Uri(PhotoSource.Text);
            BitmapImage bi3 = new BitmapImage();
            bi3.BeginInit();
            bi3.UriSource =uri;
            bi3.EndInit();
            PhotoImage.Source = bi3;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new StartPage());
        }
    }
}
