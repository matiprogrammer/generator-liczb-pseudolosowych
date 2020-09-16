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

namespace BSK_liczby_pseudoLosowe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenZad1(object sender, RoutedEventArgs e)
        {
            Zad1Window zad1 = new Zad1Window();
            zad1.Show();

        }

        private void OpenZad3(object sender, RoutedEventArgs e)
        {
            Zad3Window zad3 = new Zad3Window();
            zad3.Show();
        }

        private void OpenZa2(object sender, RoutedEventArgs e)
        {
            Zad2Window zad2 = new Zad2Window();
            zad2.Show();
        }
    }
}
