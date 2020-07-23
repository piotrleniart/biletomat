using biletomat.ViewModels;
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
using System.Windows.Threading;

namespace biletomat
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        /*
        private void BtnClickP1(object sender, RoutedEventArgs e)
        {
            Main.Content = new Page1();
        }
        private void BtnClickP2(object sender, RoutedEventArgs e)
        {
            Main.Content = new Page2();
        }
        */

        private void Win_Loaded(object sender, RoutedEventArgs e)
        {
            DispatcherTimer dt = new DispatcherTimer();
            dt.Interval = TimeSpan.FromSeconds(1);
            dt.Tick += Dt_Tick;
            dt.Start();
            Page1 p1 = new Page1();
            Main.NavigationService.Navigate(p1);
            //DataContext = new Okno2();
        }

        private void Dt_Tick(object sender, EventArgs e)
        {
            dataiczas.Content = DateTime.Now.ToString("hh:mm:ss dddd dd MMMM yyyy");
        }

        private void UC1_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new Okno1();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Home(object sender, RoutedEventArgs e)
        {
            Page1 p1 = new Page1();
            Main.NavigationService.Navigate(p1);
        }

        private void polski(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.langue = "PL";
            Page1 p1 = new Page1();
            Main.NavigationService.Navigate(p1);
        }

        private void angielski(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.langue = "EN";
            Page1 p1 = new Page1();
            Main.NavigationService.Navigate(p1);
        }
    }
}
