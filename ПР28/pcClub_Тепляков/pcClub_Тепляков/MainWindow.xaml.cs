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
using static pcClub_Тепляков.MainWindow;

namespace pcClub_Тепляков
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainWindow init;
        public MainWindow()
        {
            InitializeComponent();
            init = this;
            OpenPages(pages.login);
        }

        public enum pages
        {
            login, club, addclub, rent, addrent
        }

        public void OpenPages(pages _pages)
        {
            if (_pages == pages.login)
                frame.Navigate(new Pages.Login());
            if (_pages == pages.club)
                frame.Navigate(new Pages.Club());
            if (_pages == pages.addclub)
                frame.Navigate(new Pages.AddClub());
            if (_pages == pages.rent)
                frame.Navigate(new Pages.Rent());
            if (_pages == pages.addrent)
                frame.Navigate(new Pages.AddRent());
        }
    }
}
