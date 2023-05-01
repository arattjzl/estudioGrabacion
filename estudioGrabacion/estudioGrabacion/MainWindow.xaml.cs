using Microsoft.Win32;
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

namespace estudioGrabacion
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool admin;
        private string usuario;

        public MainWindow(bool admin, string usuario)
        {
            InitializeComponent();
            this.admin = admin;
            this.usuario = usuario; 
            if(usuario != null)
            {
                mostrarCampos();
            }
        }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Beat venBeat = new Beat(admin, usuario);
            venBeat.Show();
            Close();
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

        private void inicioSes_click(object sender, RoutedEventArgs e)
        {
            InicioSesion inicioSesionVen = new InicioSesion();
            inicioSesionVen.Show();
            Close();
        }

        private void registrase_click(object sender, RoutedEventArgs e)
        {
            Registro registroVent = new Registro();
            registroVent.Show();
        }

        public void mostrarCampos()
        {
            registrar.Visibility = Visibility.Hidden;
            inicioSes.Visibility = Visibility.Hidden;
        }
    }
}
