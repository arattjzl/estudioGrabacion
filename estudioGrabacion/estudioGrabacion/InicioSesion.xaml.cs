using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// Lógica de interacción para InicioSesion.xaml
    /// </summary>
    public partial class InicioSesion : Window
    {
        SqlConnection miConexionSql;

        public InicioSesion()
        {
            InitializeComponent();
        }
        public void btnIniciarSesion_Click(object sender, RoutedEventArgs e)
        {
            string connectionString = "Data Source=LAPTOP-0UEE9OIC\\VSGESTION;Initial Catalog=ESTUDIOGRABACION;Integrated Security=True";
            string query = "SELECT COUNT(*) FROM Usuario WHERE usuario=@usuario AND contrasena=@contrasena";
            string nombreUsuario = tbUsuario.Text;
            string contrasena = pbContrasena.Password;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@usuario", nombreUsuario);
                command.Parameters.AddWithValue("@contrasena", contrasena);

                connection.Open();
                int count = (int)command.ExecuteScalar();
                connection.Close();

                if (count > 0)
                {
                    if(nombreUsuario == "admin")
                    {
                        MainWindow nueva = new MainWindow(true, nombreUsuario);
                        nueva.Show();
                        Close();
                    } else
                    {
                        MainWindow otraNueva = new MainWindow(false, nombreUsuario);
                        otraNueva.Show();
                        Close();
                    }
                    
                }
                else
                {
                    incorrecto.Visibility = Visibility.Visible;
                }
            }
        }
    }
}
