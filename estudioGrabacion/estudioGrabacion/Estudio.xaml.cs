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
using System.Windows.Shapes;

namespace estudioGrabacion
{
    /// <summary>
    /// Lógica de interacción para Estudio.xaml
    /// </summary>
    public partial class Estudio : Window
    {
        public Estudio()
        {
            InitializeComponent();
        }

        private void inicio_Click(object sender, RoutedEventArgs e)
        {
            MainWindow venInicio = new MainWindow();
            venInicio.Show();
            Visibility = Visibility.Hidden;
        }

        private void beat_Click(object sender, RoutedEventArgs e)
        {
            Beat venBeat = new Beat();
            venBeat.Show();
            Visibility = Visibility.Hidden;
        }

        private void cuenta_Click(object sender, RoutedEventArgs e)
        {
            Cuenta venCuenta = new Cuenta();
            venCuenta.Show();
            Visibility = Visibility.Hidden;
        }
    }
}
