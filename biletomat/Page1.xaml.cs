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
    /// Logika interakcji dla klasy Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
            //lange.Content = Properties.Settings.Default.langue; //Application.Current.Properties["langue"].ToString();
            if (Properties.Settings.Default.langue == "PL")
            {
                labRodz.Text = "Wybierz rodzaj biletu";
                butJZKM.Content = "Jednorazowy\nZKM Gdynia";
                butJM.Content = " Jednorazowy\nMetropolitarny";
                butCzZKM.Content = "   Czasowy\nZKM Gdynia";
                butCzM.Content = "     Czasowy\nMetropolitarny";
            }
            if (Properties.Settings.Default.langue == "EN")
            {
                labRodz.Text = "Choose ticket type";
                butJZKM.Content = "One ride \nZKM Gdynia";
                butJM.Content = " One ride\nMetropolitan";
                butCzZKM.Content = "   Temporal\nZKM Gdynia";
                butCzM.Content = "     Temporal\nMetropolitan";
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Page2 p2 = new Page2(1);
            this.NavigationService.Navigate(p2);
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            Page2 p2 = new Page2(2);
            this.NavigationService.Navigate(p2);
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            czasowe p2 = new czasowe(1);
            this.NavigationService.Navigate(p2);
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            czasowe p2 = new czasowe(2);
            this.NavigationService.Navigate(p2);
        }

    }
}
