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
    /// Logika interakcji dla klasy Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2(int rodzaj)
        {
            InitializeComponent();

            if (Properties.Settings.Default.langue == "PL")
            {
                labWaz.Text = "Wybierz ważność biletu";
                butZw.Content = "Linie zwykłe";
                butSp.Content = "Linie nocne, pospieszne \n specjalne i zwykłe";
            }
            if (Properties.Settings.Default.langue == "EN")
            {
                labWaz.Text = "Choose ticket validity";
                butZw.Content = "Normal lines";
                butSp.Content = "Night lines, hurried special and normal";
            }

            if (rodzaj == 1)
            {
                cenaNorm = 3.2f;
                cenaSpec = 4.2f;
            }
            if (rodzaj == 2)
            {
                cenaNorm = 3.4f;
                cenaSpec = 4.4f;
            }
            if (rodzaj == 3)
            {
                cenaNorm = 72.0f;
                cenaSpec = 86.0f;
            }
            if(rodzaj == 4)
            {
                cenaNorm = 10.0f;
                cenaSpec = 13.0f;
            }
            if(rodzaj == 5)
            {
                cenaNorm = 20.0f;
                cenaSpec = 26.0f;
            }
            if(rodzaj == 6)
            {
                cenaNorm = 156.0f;
                cenaSpec = 179.0f;
            }
            if(rodzaj == 7)
            {
                cenaNorm = 195.0f;
                cenaSpec = 223.0f;
            }
            if(rodzaj == 8)
            {
                cenaNorm = 94.0f;
                cenaSpec = 104.0f;
            }
            if(rodzaj == 9)
            {
                cenaNorm = 15.0f;
                cenaSpec = 23.0f;
            }
            if(rodzaj == 10)
            {
                cenaNorm = 30.0f;
                cenaSpec = 46.0f;
            }
            if(rodzaj == 11)
            {
                cenaNorm = 160.0f;
                cenaSpec = 198.0f;
            }
            if(rodzaj == 12)
            {
                cenaNorm = 200.0f;
                cenaSpec = 247.0f;
            }
        }
        private static float cenaNorm;
        private static float cenaSpec;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Page3 p3 = new Page3(cenaNorm);
            this.NavigationService.Navigate(p3);
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            Page3 p3 = new Page3(cenaSpec);
            this.NavigationService.Navigate(p3);
        }
    }
}
