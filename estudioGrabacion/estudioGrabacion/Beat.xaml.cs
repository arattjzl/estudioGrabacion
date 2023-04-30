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
    /// Lógica de interacción para Beat.xaml
    /// </summary>
    public partial class Beat : Window
    {
        private bool admin;
        private string usuario;

        public Beat(bool admin, string usuario)
        {
            InitializeComponent();
            this.admin = admin;
            this.usuario = usuario;
            MuestraBoton();
        }

        private void inicio_Click(object sender, RoutedEventArgs e)
        {
            MainWindow venInicio = new MainWindow(admin, usuario);
            venInicio.Show();
            Visibility = Visibility.Hidden;
        }

        private void estudio_Click(object sender, RoutedEventArgs e)
        {
            Estudio venEstudio = new Estudio(admin, usuario);
            venEstudio.Show();
            Visibility = Visibility.Hidden;
        }

        private void cuenta_Click(object sender, RoutedEventArgs e)
        {
            Cuenta venCuenta = new Cuenta(admin, usuario);    
            venCuenta.Show();
            Visibility = Visibility.Hidden;
        }

        private void MuestraBoton()
        {
            if (admin == true)
            {
                algo.Visibility= Visibility.Visible;
            }
        }
    }
}
