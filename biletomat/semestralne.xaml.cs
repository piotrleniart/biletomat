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

namespace biletomat
{
    /// <summary>
    /// Logika interakcji dla klasy semestralne.xaml
    /// </summary>
    public partial class semestralne : Page
    {
        public semestralne(int rodzaj)
        {
            InitializeComponent();
            rodz = rodzaj;

            if (Properties.Settings.Default.langue == "PL")
            {
                labOkr.Text = "Wybierz okres semestru";
                but4m.Content = "4 miesiące\n01.02-31.05";
                but5m.Content = "5 miesięcy\n01.02-30.06";
            }
            if (Properties.Settings.Default.langue == "EN")
            {
                labOkr.Text = "Choose semester period";
                but4m.Content = "4 months \n01.02-31.05";
                but5m.Content = "5 months \n01.02-30.06";
            }

        }

        private static int rodz;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //4miesace
            Page2 p = new Page2(rodz);
            this.NavigationService.Navigate(p);
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            //5miesace
            Page2 p = new Page2(rodz+1);
            this.NavigationService.Navigate(p);
        }
    }
}
