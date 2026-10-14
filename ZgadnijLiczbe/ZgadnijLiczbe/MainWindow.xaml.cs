using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Runtime.CompilerServices;

namespace ZgadnijLiczbe
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSprawdz_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            int losowaLiczba = random.Next(1, 10);
            int licznik = 0;
            int twojaLiczba = 0;
            do
            {
                //if(!int.TryParse(input, out twojaLiczba))
            } while (twojaLiczba != losowaLiczba);
        }

        private void btnNowaGra_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}