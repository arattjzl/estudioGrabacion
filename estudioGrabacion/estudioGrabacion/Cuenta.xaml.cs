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
    /// Lógica de interacción para Cuenta.xaml
    /// </summary>
    public partial class Cuenta : Window
    {
        public Cuenta()
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

        private void estudio_Click(object sender, RoutedEventArgs e)
        {
            Estudio venEstudio = new Estudio();
            venEstudio.Show();
            Visibility = Visibility.Hidden;
        }
    }
}
