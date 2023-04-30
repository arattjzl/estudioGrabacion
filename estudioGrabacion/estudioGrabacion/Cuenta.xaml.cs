using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
        private bool admin;
        private string usuario;
        SqlConnection miConexionSql;


        public Cuenta(bool admin, string usuario)
        {
            InitializeComponent();
            this.admin = admin;
            this.usuario = usuario;
            string miConexion = ConfigurationManager.ConnectionStrings["estudioGrabacion.Properties.Settings.ESTUDIOGRABACIONConnectionString"].ConnectionString;
            miConexionSql = new SqlConnection(miConexion);
            if(usuario !=null)
            {
                mostrarCampos();
            }
        }

        private void inicio_Click(object sender, RoutedEventArgs e)
        {
            MainWindow venInicio = new MainWindow(admin, usuario);
            venInicio.Show();
            Visibility = Visibility.Hidden;
        }

        private void beat_Click(object sender, RoutedEventArgs e)
        {
            Beat venBeat = new Beat(admin, usuario);
            venBeat.Show();
            Visibility = Visibility.Hidden;
        }

        private void estudio_Click(object sender, RoutedEventArgs e)
        {
            Estudio venEstudio = new Estudio(admin, usuario);
            venEstudio.Show();
            Visibility = Visibility.Hidden;
        }

        private void mostrarCampos()
        {
            try
            {
                string consulta = "SELECT * FROM USUARIO WHERE usuario=@usuario";

                SqlCommand miSqlCommand = new SqlCommand(consulta, miConexionSql);
                SqlDataAdapter miAdaptadorSQL = new SqlDataAdapter(miSqlCommand);
                using (miAdaptadorSQL)
                {
                    miSqlCommand.Parameters.AddWithValue("@usuario", usuario);
                    DataTable tablaUsuarios = new DataTable();
                    miAdaptadorSQL.Fill(tablaUsuarios);
                    user.Text = tablaUsuarios.Rows[0]["usuario"].ToString();
                    correo.Text = tablaUsuarios.Rows[0]["correo"].ToString();
                    telefono.Text = tablaUsuarios.Rows[0]["telefono"].ToString();
                    contra.Password = tablaUsuarios.Rows[0]["contrasena"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void actualizar(object sender, RoutedEventArgs e)
        {
            try
            {
                string consulta = "UPDATE USUARIO SET usuario=@nombre, correo=@correo, contrasena=@contra, telefono=@telefono WHERE usuario=@usuario";
                SqlCommand miSqlCommand = new SqlCommand(consulta, miConexionSql);
                miConexionSql.Open();
                miSqlCommand.Parameters.AddWithValue("@usuario", usuario);
                miSqlCommand.Parameters.AddWithValue("@nombre", user.Text);
                miSqlCommand.Parameters.AddWithValue("@correo", correo.Text);
                miSqlCommand.Parameters.AddWithValue("@contra", contra.Password);
                miSqlCommand.Parameters.AddWithValue("@telefono", telefono.Text);
                miSqlCommand.ExecuteNonQuery();
                miConexionSql.Close();
                correcto.Visibility = Visibility.Visible;
            } catch(Exception ex)
            {
                incorrecto.Visibility = Visibility.Visible;
            }
        }

        private void ToggleButton_Click(object sender, RoutedEventArgs e)
        {
            if (contra.Visibility == Visibility.Visible)
            {
                contraSi.Text = contra.Password;
                contra.Visibility = Visibility.Collapsed;
                contraSi.Visibility = Visibility.Visible;
            }
            else
            {
                contra.Password = contraSi.Text;
                contra.Visibility = Visibility.Visible;
                contraSi.Visibility = Visibility.Collapsed;
            }
        }
    }
}
