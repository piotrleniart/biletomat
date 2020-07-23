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
    /// Logika interakcji dla klasy czasowe.xaml
    /// </summary>
    public partial class czasowe : Page
    {
        public czasowe(int przewo)
        {
            InitializeComponent();
            if (przewo == 1)
            {
                rodzaj = 3;
            }
            else
            {
                rodzaj = 8;
            }

            if (Properties.Settings.Default.langue == "PL")
            {
                labOkrWaz.Text = "Wybierz okres ważności";
                but30.Content = "Miesięczne\n30 dniowe";
            }
            if (Properties.Settings.Default.langue == "EN")
            {
                labOkrWaz.Text = "Choose period of validity";
                but30.Content = "Months\n30 days";
            }

        }

        private static int rodzaj;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            kalendarz k = new kalendarz(rodzaj);
            this.NavigationService.Navigate(k);
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            kalendarz k = new kalendarz(rodzaj+1);
            this.NavigationService.Navigate(k);
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            kalendarz k = new kalendarz(rodzaj+2);
            this.NavigationService.Navigate(k);
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            semestralne k = new semestralne(rodzaj + 3);
            this.NavigationService.Navigate(k);
        }
    }
}
