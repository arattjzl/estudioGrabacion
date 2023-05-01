using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
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
using System.Configuration;
using System.Diagnostics.Contracts;

namespace estudioGrabacion
{
    /// <summary>
    /// Lógica de interacción para Estudio.xaml
    /// </summary>
    public partial class Estudio : Window
    {
        private bool admin;
        private string usuario;
        SqlConnection miConexionSql;

        public Estudio(bool admin, string usuario)
        {
            InitializeComponent();
            this.admin = admin;
            this.usuario = usuario;
            string miConexion = ConfigurationManager.ConnectionStrings["estudioGrabacion.Properties.Settings.ESTUDIOGRABACIONConnectionString"].ConnectionString;
            miConexionSql = new SqlConnection(miConexion);
            MuestraEstudios();
            MostrarBotones();
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

        private void cuenta_Click(object sender, RoutedEventArgs e)
        {
            Cuenta venCuenta = new Cuenta(admin, usuario);
            venCuenta.Show();
            Visibility = Visibility.Hidden;
        }

        public void MuestraEstudios()
        {
            string consulta = "SELECT * FROM ESTUDIO";

            SqlDataAdapter miAdaptadorSql = new SqlDataAdapter(consulta, miConexionSql);

            using (miAdaptadorSql)
            {
                DataTable estudiosTabla = new DataTable();

                miAdaptadorSql.Fill(estudiosTabla);

                estudios.DisplayMemberPath = "nombre";
                estudios.SelectedValuePath = "IdEstudio";
                estudios.ItemsSource = estudiosTabla.DefaultView;
            }
        }

        private void MostrarDatosEstudio(object sender, SelectionChangedEventArgs e)
        {
            if(usuario != "admin")
            {
                try
                {
                    string consulta = "SELECT * FROM Estudio WHERE idEstudio=@id";

                    SqlCommand miSqlCommand = new SqlCommand(consulta, miConexionSql);
                    SqlDataAdapter miAdaptadorSQL = new SqlDataAdapter(miSqlCommand);
                    using (miAdaptadorSQL)
                    {
                        miSqlCommand.Parameters.AddWithValue("@id", estudios.SelectedValue);
                        DataTable tablaEstudios = new DataTable();
                        miAdaptadorSQL.Fill(tablaEstudios);
                        string nombreEst = tablaEstudios.Rows[0]["nombre"].ToString();
                        string newnom = nombreEst.Replace(" ", "");
                        string source = "imagenes/" + newnom + ".jpg";

                        imagen.Source = new BitmapImage(new Uri("imagenes/" + newnom + ".jpg", UriKind.RelativeOrAbsolute));
                        nombre.Content = "nombre " + tablaEstudios.Rows[0]["nombre"].ToString().ToUpper();
                        calle.Content = "calle " + tablaEstudios.Rows[0]["calle"].ToString().ToUpper();
                        numExterior.Content = "numero exterior " + tablaEstudios.Rows[0]["numExt"].ToString().ToUpper();
                        numInterior.Content = "numero interior " + tablaEstudios.Rows[0]["numInt"].ToString().ToUpper();
                    }
                    camposReserv.Visibility = Visibility.Visible;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void MostrarBotones()
        {
            if(usuario == "admin")
            {
                elimin.Visibility = Visibility.Visible;
            } else if(usuario != null)
            {
                reserv.Visibility = Visibility.Visible;
            }
        }

        private void elimin_Click(object sender, RoutedEventArgs e)
        {
            string consulta = "DELETE FROM ESTUDIO WHERE IdEstudio = @IdEstudio";

            SqlCommand miSqlCommand = new SqlCommand(consulta, miConexionSql);
            miConexionSql.Open();
            miSqlCommand.Parameters.AddWithValue("@IdEstudio", estudios.SelectedValue);
            miSqlCommand.ExecuteNonQuery();
            miConexionSql.Close();

            MuestraEstudios();
        }

        private void reserv_Click(object sender, RoutedEventArgs e)
        {
            try {
                miConexionSql.Open();

                string consultaUser = "SELECT IdUsuario FROM USUARIO WHERE usuario=@nombre";
                SqlCommand miSqlCommandUser = new SqlCommand(consultaUser, miConexionSql);
                miSqlCommandUser.Parameters.AddWithValue("@nombre", usuario);
                int idUsuario = (int)miSqlCommandUser.ExecuteScalar();

                string consultaReserv = "INSERT INTO RESERVACION (IdUsuario, IdEstudio, fecha, horaInicio, horas, precio) VALUES (@IdUsuario, @IdEstudio, @fecha, @horaInicio, @horas, @precio)";
                SqlCommand miSqlCommandReserv = new SqlCommand(consultaReserv, miConexionSql);
                miSqlCommandReserv.Parameters.AddWithValue("@IdUsuario", idUsuario);
                miSqlCommandReserv.Parameters.AddWithValue("@IdEstudio", estudios.SelectedValue);
                miSqlCommandReserv.Parameters.AddWithValue("@fecha", fecha.SelectedDate);
                miSqlCommandReserv.Parameters.AddWithValue("@horaInicio", horaIn.Text);
                miSqlCommandReserv.Parameters.AddWithValue("@horas", horas.Text);
                miSqlCommandReserv.Parameters.AddWithValue("@precio", precio.Content);
                miSqlCommandReserv.ExecuteNonQuery();

                corrReserv.Visibility = Visibility.Visible;
            } 
            catch (Exception ex)
            {
                errReserv.Visibility = Visibility.Visible;
            }
            finally
            {
                miConexionSql.Close();
            }
            
        }

        private void horas_TextChanged(object sender, TextChangedEventArgs e)
        {
            precio.Content = "precio a pagar -- " + Int32.Parse(horas.Text) * 800;
        }

        
    }

}
