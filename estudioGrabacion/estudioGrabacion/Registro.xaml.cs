using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
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
    /// Lógica de interacción para Registro.xaml
    /// </summary>
    public partial class Registro : Window
    {
        SqlConnection miConexionSql;
        public Registro()
        {
            InitializeComponent();
            string miConexion = ConfigurationManager.ConnectionStrings["estudioGrabacion.Properties.Settings.ESTUDIOGRABACIONConnectionString"].ConnectionString;
            miConexionSql = new SqlConnection(miConexion);
        }

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            InicioSesion inicioSesVen = new InicioSesion();
            inicioSesVen.Show();
            Visibility = Visibility.Hidden;
        }

        private void registrar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string consulta = "INSERT INTO USUARIO (usuario,correo,contrasena,telefono) VALUES(@usuario,@correo,@contrasena,@telefono)";
                SqlCommand miSqlCommand = new SqlCommand(consulta, miConexionSql);
                miConexionSql.Open();
                miSqlCommand.Parameters.AddWithValue("@usuario", user.Text);
                miSqlCommand.Parameters.AddWithValue("@correo", correo.Text);
                miSqlCommand.Parameters.AddWithValue("@contrasena", contra.Password);
                miSqlCommand.Parameters.AddWithValue("@telefono", telefono.Text);
                miSqlCommand.ExecuteNonQuery();
                miConexionSql.Close();
                correcto.Visibility = Visibility.Visible;
            }
            catch (Exception)
            {
                incorrecto.Visibility = Visibility.Visible;
            }

        }
    }
}
