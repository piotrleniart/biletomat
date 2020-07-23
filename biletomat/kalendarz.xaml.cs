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
    /// Logika interakcji dla klasy kalendarz.xaml
    /// </summary>
    public partial class kalendarz : Page
    {
        public kalendarz(int rodzaj)
        {
            InitializeComponent();
            rodz = rodzaj;
            kale.SelectedDate = DateTime.Now.Date;
            od.Content = kale.SelectedDate;

            if (rodzaj == 4 || rodzaj == 9)
            {
                dni = 1;
                ile.Content = "24h";
            }
            if (rodzaj == 5 || rodzaj == 10)
            {
                dni = 3;
                ile.Content = "72h";
            }

            DateTime? da = kale.SelectedDate;
            DateTime t = (DateTime)da;
            dokiedy.Content = t.AddDays(dni);


            if (Properties.Settings.Default.langue == "PL")
            {
                labOkrWaz.Content = "OKRES WAŻNOŚCI";
                labDo.Content = "Do";
                labOd.Content = "Od";

                //kale.Language = "PL";

                if (rodzaj == 3 || rodzaj == 8)
                {
                    dni = 30;
                    ile.Content = "30 dni";
                }

            }
            if (Properties.Settings.Default.langue == "EN")
            {
                labOkrWaz.Content = "VALIDITY PERIOD";
                labDo.Content = "From";
                labOd.Content = "To";

                //kale.Language = "EN";

                if (rodzaj == 3 || rodzaj == 8)
                {
                    dni = 30;
                    ile.Content = "30 days";
                }

            }


        }

        private static int rodz;
        private static int dni;

        private void dalej_Click(object sender, RoutedEventArgs e)
        {
            Page2 p = new Page2(rodz);
            this.NavigationService.Navigate(p);
        }

        private void zmiana(object sender, SelectionChangedEventArgs e)
        {
            od.Content = kale.SelectedDate;
            DateTime? da = kale.SelectedDate;
            DateTime t = (DateTime) da;
            dokiedy.Content = t.AddDays(dni);
        }
    }
}
