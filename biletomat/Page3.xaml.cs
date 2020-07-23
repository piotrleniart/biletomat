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
    /// Logika interakcji dla klasy Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {

        public Page3(float x)
        {
            InitializeComponent();
            buttPlace.IsEnabled = false;
            ilBilNorm = 0;
            ilBilUlg = 0;
            labIle.Content = ilBilUlg + ilBilNorm;

            float tmp;

            tmp = x;
            CenaNormalny.Content = tmp.ToString("0.00") + "zł";
            tmp = x * 0.5f;
            CenaUlgowy.Content = tmp.ToString("0.00") + "zł";
            //CenaNormalny.Content = x;
            //CenaUlgowy.Content = 0.5f * x;
            //CenaNormalny.Content = CenaNormalny.Content + "0 zł";
            //CenaUlgowy.Content = CenaUlgowy.Content + "0 zł";

            mnoznik = x;



            if (Properties.Settings.Default.langue == "PL")
            {
                labBN.Content = "Bilet Normalny";
                labBU.Content = "Bilet Ulgowy";
                labLiczba.Content = "Liczba biletów :";
                labDoZapl.Content = "Do zapłaty :";
                buttPlace.Content = "PŁACĘ";
            }
            if (Properties.Settings.Default.langue == "EN")
            {
                labBN.Content = "Normal ticket";
                labBU.Content = "Reduced ticket";
                labLiczba.Content = "Ammount of tickets :";
                labDoZapl.Content = "To pay :";
                buttPlace.Content = "PAY";
            }

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private static int ilBilNorm;
        private static int ilBilUlg;
        private static float mnoznik;
        private static float temp;

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ilBilNorm++;
            if (ilBilNorm > 10) ilBilNorm = 10;
            iloscBilNorm.Text = ilBilNorm.ToString();
            labIle.Content = ilBilUlg + ilBilNorm;

            temp = (float)ilBilNorm * mnoznik + (float)ilBilUlg * mnoznik * 0.5f;
            labCena.Content = temp.ToString("0.00") + " zł";

            if (ilBilUlg + ilBilNorm > 0) buttPlace.IsEnabled = true;
            else
            {
                buttPlace.IsEnabled = false;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ilBilNorm--;
            if (ilBilNorm < 0) ilBilNorm = 0;
            iloscBilNorm.Text = ilBilNorm.ToString();
            labIle.Content = ilBilUlg + ilBilNorm;

            temp = (float)ilBilNorm * mnoznik + (float)ilBilUlg * mnoznik * 0.5f;
            labCena.Content = temp.ToString("0.00")+" zł";

            if (ilBilUlg + ilBilNorm > 0) buttPlace.IsEnabled = true;
            else
            {
                buttPlace.IsEnabled = false;
            }
        }


        private void Place(object sender, RoutedEventArgs e)
        {
            Page4 p4 = new Page4(mnoznik,ilBilUlg,ilBilNorm,temp);
            this.NavigationService.Navigate(p4);
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            ilBilUlg--;
            if (ilBilUlg < 0) ilBilUlg = 0;
            iloscBilUlg.Text = ilBilUlg.ToString();
            labIle.Content = ilBilUlg + ilBilNorm;

            temp = (float)ilBilNorm * mnoznik + (float)ilBilUlg * mnoznik * 0.5f;
            labCena.Content = temp.ToString("0.00") + " zł";

            if (ilBilUlg + ilBilNorm > 0) buttPlace.IsEnabled = true;
            else
            {
                buttPlace.IsEnabled = false;
            }
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            ilBilUlg++;
            if (ilBilUlg > 10) ilBilUlg = 10;
            iloscBilUlg.Text = ilBilUlg.ToString();
            labIle.Content = ilBilUlg + ilBilNorm;

            temp = (float)ilBilNorm * mnoznik + (float)ilBilUlg * mnoznik * 0.5f;
            labCena.Content = temp.ToString("0.00") + " zł";

            if (ilBilUlg + ilBilNorm > 0) buttPlace.IsEnabled = true;
            else
            {
                buttPlace.IsEnabled = false;
            }
        }

    }
}
