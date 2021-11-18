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

namespace Wpf2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public double resultat;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int massa = Convert.ToInt32(but1.Text);
            if (b.IsChecked == true)
            {
                resultat = massa / 454;
            }
            if (b1.IsChecked == true)
            {
                resultat = massa / 16380;
            }
            if (bu.IsChecked == true)
            {
                resultat = massa / 28.35;
            }
            if (bu1.IsChecked == true)
            {
                resultat = massa / 1.772;
            }
            if (but.IsChecked == true)
            {
                resultat = massa / 0.0648;
            }
            butt.Text = Convert.ToString(resultat);
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            but1.Clear();
            butt.Clear();
        }
    }
}
