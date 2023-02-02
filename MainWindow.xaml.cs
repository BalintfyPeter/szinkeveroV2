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

namespace betonkevero
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<int> szinlista = new List<int>();

        }

        public void Szinkeveres()
        {
            rctTeglalap.Fill = new SolidColorBrush(
                Color.FromRgb(
                    Convert.ToByte(sliPiros.Value), Convert.ToByte(sliZold.Value), Convert.ToByte(sliKek.Value)
                    )
                );
        }

        private void sliPiros_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Szinkeveres();
        }

        private void sliZold_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Szinkeveres();
        }

        private void sliKek_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Szinkeveres();
        }

        private void btnRogzit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnTorol_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnUrit_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
