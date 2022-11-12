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
using System.Windows.Shapes;

namespace Marathon_Skills
{
    /// <summary>
    /// Логика взаимодействия для SponsorInfo.xaml
    /// </summary>
    public partial class SponsorInfo : Window
    {
        public SponsorInfo(string SponsorName,string Charityinfo,string SponsorImageUri)
        {
            InitializeComponent();
            CharityName.Content = SponsorName;
            Info.Text = Charityinfo;
            CharityLogo.Stretch = Stretch.Fill;
            Uri uri = new Uri(@"C:\\Users\\72vla\\source\\repos\\Marathon-Skills\\Marathon-Skills\\Sponsors\"+SponsorImageUri);
            BitmapImage bi3 = new BitmapImage();
            bi3.BeginInit();
            bi3.UriSource = uri;
            bi3.EndInit();
            CharityLogo.Source = bi3;
        }
    }
}
