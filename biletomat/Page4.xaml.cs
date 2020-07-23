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
    /// Logika interakcji dla klasy Page4.xaml
    /// </summary>
    public partial class Page4 : Page
    {
        public Page4(float x, int ileUlg, int ileNorm, float cena)
        {
            InitializeComponent();
            ilUlg.Content = ileUlg;
            ilNorm.Content = ileNorm;
            naleznosc.Content = cena.ToString("0.00") + "zł";


            if (Properties.Settings.Default.langue == "PL")
            {
                labPods.Content = "PODSUMOWANIE";
                labMetody.Content = "METODY PŁATNOŚCI";
                labGot.Content = "GOTÓWKA";
                labKarta.Content = "KARTA";
                gotowka.Content = "GOTÓWKA";
                karta.Content = "KARTA";
                labTyp.Content = "Typ biletu";
                labBN.Content = "Bilety normalne : ";
                labBU.Content = "Bilety ulgowe : ";
                labCena.Content = "CENA";




                if (x == 3.2f)
                {
                    typ.Content = "Jednorazowy";
                    przew.Content = "ZKM Gdynia";
                    linia.Content = "Zwykłe linie";
                }
                if (x == 4.2f)
                {
                    typ.Content = "Jednorazowy";
                    przew.Content = "ZKM Gdynia";
                    linia.Content = "Wszystkie linie";
                }
                if (x == 3.4f)
                {
                    typ.Content = "Jednorazowy";
                    przew.Content = "Metropolitarny";
                    linia.Content = "Zwykłe linie";
                }
                if (x == 4.4f)
                {
                    typ.Content = "Jednorazowy";
                    przew.Content = "Metropolitarny";
                    linia.Content = "Wszystkie linie";
                }

                //mies
                if (x == 72.0f)
                {
                    typ.Content = "Czasowy";
                    przew.Content = "ZKM Gdynia";
                    linia.Content = "Zwykłe linie";
                }
                if (x == 86.0f)
                {
                    typ.Content = "Czasowy";
                    przew.Content = "ZKM Gdynia";
                    linia.Content = "Wszystkie linie";
                }
                //24h
                if (x == 10.0f)
                {
                    typ.Content = "Czasowy";
                    przew.Content = "ZKM Gdynia";
                    linia.Content = "Zwykłe linie";
                }
                if (x == 13.0f)
                {
                    typ.Content = "Czasowy";
                    przew.Content = "ZKM Gdynia";
                    linia.Content = "Wszystkie linie";
                }



                //72h
                if (x == 20.0f)
                {
                    typ.Content = "Czasowy";
                    przew.Content = "ZKM Gdynia";
                    linia.Content = "Zwykłe linie";
                }
                if (x == 26.0f)
                {
                    typ.Content = "Czasowy";
                    przew.Content = "ZKM Gdynia";
                    linia.Content = "Wszystkie linie";
                }

                //sem4
                if (x == 156.0f)
                {
                    typ.Content = "Czasowy";
                    przew.Content = "ZKM Gdynia";
                    linia.Content = "Zwykłe linie";
                }
                if (x == 179.0f)
                {
                    typ.Content = "Czasowy";
                    przew.Content = "ZKM Gdynia";
                    linia.Content = "Wszystkie linie";
                }

                //sem5
                if (x == 195.0f)
                {
                    typ.Content = "Czasowy";
                    przew.Content = "ZKM Gdynia";
                    linia.Content = "Zwykłe linie";
                }
                if (x == 223.0f)
                {
                    typ.Content = "Czasowy";
                    przew.Content = "ZKM Gdynia";
                    linia.Content = "Wszystkie linie";
                }


                //mies
                if (x == 94.0f)
                {
                    typ.Content = "Czasowy";
                    przew.Content = "Metropolitarny";
                    linia.Content = "Zwykłe linie";
                }
                if (x == 104.0f)
                {
                    typ.Content = "Czasowy";
                    przew.Content = "Metropolitarny";
                    linia.Content = "Wszystkie linie";
                }
                //24h
                if (x == 15.0f)
                {
                    typ.Content = "Czasowy";
                    przew.Content = "Metropolitarny";
                    linia.Content = "Zwykłe linie";
                }
                if (x == 13.0f)
                {
                    typ.Content = "Czasowy";
                    przew.Content = "Metropolitarny";
                    linia.Content = "Wszystkie linie";
                }

                //72h
                if (x == 30.0f)
                {
                    typ.Content = "Czasowy";
                    przew.Content = "Metropolitarny";
                    linia.Content = "Zwykłe linie";
                }
                if (x == 46.0f)
                {
                    typ.Content = "Czasowy";
                    przew.Content = "Metropolitarny";
                    linia.Content = "Wszystkie linie";
                }
                //sem4
                if (x == 160.0f)
                {
                    typ.Content = "Czasowy";
                    przew.Content = "Metropolitarny";
                    linia.Content = "Zwykłe linie";
                }
                if (x == 198.0f)
                {
                    typ.Content = "Czasowy";
                    przew.Content = "Metropolitarny";
                    linia.Content = "Wszystkie linie";
                }

                //sem5
                if (x == 200.0f)
                {
                    typ.Content = "Czasowy";
                    przew.Content = "Metropolitarny";
                    linia.Content = "Zwykłe linie";
                }
                if (x == 247.0f)
                {
                    typ.Content = "Czasowy";
                    przew.Content = "Metropolitarny";
                    linia.Content = "Wszystkie linie";
                }





            }
            if (Properties.Settings.Default.langue == "EN")
            {
                labPods.Content = "SUMMARY";
                labMetody.Content = "Pay type";
                labGot.Content = "Cash";
                labKarta.Content = "Card";
                gotowka.Content = "CASH";
                karta.Content = "CARD";
                labTyp.Content = "Ticket type";
                labBN.Content = "Normal tickets : ";
                labBU.Content = "Reduced tickets : ";
                labCena.Content = "PRICE";





                if (x == 3.2f)
                {
                    typ.Content = "One ride";
                    przew.Content = "ZKM Gdynia";
                    linia.Content = "Zwykłe linie";
                }
                if (x == 4.2f)
                {
                    typ.Content = "One ride";
                    przew.Content = "ZKM Gdynia";
                    linia.Content = "Wszystkie linie";
                }
                if (x == 3.4f)
                {
                    typ.Content = "One ride";
                    przew.Content = "Metropolitarny";
                    linia.Content = "Zwykłe linie";
                }
                if (x == 4.4f)
                {
                    typ.Content = "One ride";
                    przew.Content = "Metropolitarny";
                    linia.Content = "Wszystkie linie";
                }

                //mies
                if (x == 72.0f)
                {
                    typ.Content = "Temporal";
                    przew.Content = "ZKM Gdynia";
                    linia.Content = "Zwykłe linie";
                }
                if (x == 86.0f)
                {
                    typ.Content = "Temporal";
                    przew.Content = "ZKM Gdynia";
                    linia.Content = "Wszystkie linie";
                }
                //24h
                if (x == 10.0f)
                {
                    typ.Content = "Temporal";
                    przew.Content = "ZKM Gdynia";
                    linia.Content = "Zwykłe linie";
                }
                if (x == 13.0f)
                {
                    typ.Content = "Temporal";
                    przew.Content = "ZKM Gdynia";
                    linia.Content = "Wszystkie linie";
                }



                //72h
                if (x == 20.0f)
                {
                    typ.Content = "Temporal";
                    przew.Content = "ZKM Gdynia";
                    linia.Content = "Zwykłe linie";
                }
                if (x == 26.0f)
                {
                    typ.Content = "Temporal";
                    przew.Content = "ZKM Gdynia";
                    linia.Content = "Wszystkie linie";
                }

                //sem4
                if (x == 156.0f)
                {
                    typ.Content = "Temporal";
                    przew.Content = "ZKM Gdynia";
                    linia.Content = "Zwykłe linie";
                }
                if (x == 179.0f)
                {
                    typ.Content = "Temporal";
                    przew.Content = "ZKM Gdynia";
                    linia.Content = "Wszystkie linie";
                }

                //sem5
                if (x == 195.0f)
                {
                    typ.Content = "Temporal";
                    przew.Content = "ZKM Gdynia";
                    linia.Content = "Zwykłe linie";
                }
                if (x == 223.0f)
                {
                    typ.Content = "Temporal";
                    przew.Content = "ZKM Gdynia";
                    linia.Content = "Wszystkie linie";
                }


                //mies
                if (x == 94.0f)
                {
                    typ.Content = "Temporal";
                    przew.Content = "Metropolitan";
                    linia.Content = "Zwykłe linie";
                }
                if (x == 104.0f)
                {
                    typ.Content = "Temporal";
                    przew.Content = "Metropolitan";
                    linia.Content = "Wszystkie linie";
                }
                //24h
                if (x == 15.0f)
                {
                    typ.Content = "Temporal";
                    przew.Content = "Metropolitan";
                    linia.Content = "Zwykłe linie";
                }
                if (x == 13.0f)
                {
                    typ.Content = "Temporal";
                    przew.Content = "Metropolitan";
                    linia.Content = "Wszystkie linie";
                }

                //72h
                if (x == 30.0f)
                {
                    typ.Content = "Temporal";
                    przew.Content = "Metropolitan";
                    linia.Content = "Zwykłe linie";
                }
                if (x == 46.0f)
                {
                    typ.Content = "Temporal";
                    przew.Content = "Metropolitan";
                    linia.Content = "Wszystkie linie";
                }
                //sem4
                if (x == 160.0f)
                {
                    typ.Content = "Temporal";
                    przew.Content = "Metropolitan";
                    linia.Content = "Zwykłe linie";
                }
                if (x == 198.0f)
                {
                    typ.Content = "Temporal";
                    przew.Content = "Metropolitan";
                    linia.Content = "Wszystkie linie";
                }

                //sem5
                if (x == 200.0f)
                {
                    typ.Content = "Temporal";
                    przew.Content = "Metropolitan";
                    linia.Content = "Zwykłe linie";
                }
                if (x == 247.0f)
                {
                    typ.Content = "Temporal";
                    przew.Content = "Metropolitan";
                    linia.Content = "Wszystkie linie";
                }




            }



            
        }

        private async void buttClick(object sender, RoutedEventArgs e)
        {
            koniec.IsOpen = true;
            await Task.Delay(5000);
            koniec.IsOpen = false;
            Page1 page = new Page1();
            this.NavigationService.Navigate(page);
        }

    }
}
