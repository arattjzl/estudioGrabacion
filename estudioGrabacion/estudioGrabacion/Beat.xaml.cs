using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.IO;
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
using System.Windows.Threading;

namespace estudioGrabacion
{
    /// <summary>
    /// Lógica de interacción para Beat.xaml
    /// </summary>
    public partial class Beat : Window
    {
        private bool admin;
        private string usuario;
        private MediaPlayer mediaPlayer = new MediaPlayer();
        SqlConnection miConexionSql;


        public Beat(bool admin, string usuario)
        {
            InitializeComponent();
            this.admin = admin;
            this.usuario = usuario;

            string miConexion = ConfigurationManager.ConnectionStrings["estudioGrabacion.Properties.Settings.ESTUDIOGRABACIONConnectionString"].ConnectionString;
            miConexionSql = new SqlConnection(miConexion);

            if(usuario == "admin")
            {
                mostrarAgregarAdmin();

            }
            cargarBeats();
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

        private void nuevoBeatDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                // Obtener la lista de archivos arrastrados
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                // Agregar los archivos MP3 al ListBox
                foreach (string file in files)
                {
                    if (System.IO.Path.GetExtension(file) == ".mp3")
                    {
                        nuevoBeat.Items.Add(file);
                    }
                }
            }
        }

        private void lstFiles_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effects = DragDropEffects.Copy;
            }
            else
            {
                e.Effects = DragDropEffects.None;
            }
        }

        private void agregar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (nuevoBeat.SelectedItem != null)
                {
                    // Obtiene el archivo seleccionado en el ListBox
                    string filePath = (string)nuevoBeat.SelectedItem;

                    // Define la carpeta de destino
                    string carpetaProyecto = AppDomain.CurrentDomain.BaseDirectory;
                    string rutaRelativa = System.IO.Path.Combine(carpetaProyecto, "..\\..\\beats");
                    string destinationFolder = rutaRelativa;

                    // Obtiene el nombre del archivo
                    string fileName = nombreNuevoBeat.Text + ".mp3";

                    // Crea el nombre completo del archivo en la carpeta de destino
                    string destinationFilePath = System.IO.Path.Combine(destinationFolder, fileName);

                    // Copia el archivo al destino
                    System.IO.File.Copy(filePath, destinationFilePath, true);

                    string consulta = "INSERT INTO BEAT (nombre,bpm,escala,ruta) VALUES(@nombre,@bpm,@escala,@ruta)";
                    SqlCommand miSqlCommand = new SqlCommand(consulta, miConexionSql);
                    miConexionSql.Open();
                    miSqlCommand.Parameters.AddWithValue("@nombre", nombreNuevoBeat.Text);
                    miSqlCommand.Parameters.AddWithValue("@bpm", bpmNuevoBeat.Text);
                    miSqlCommand.Parameters.AddWithValue("@escala", escalaNuevoBeat.Text);
                    miSqlCommand.Parameters.AddWithValue("@ruta", destinationFilePath);
                    miSqlCommand.ExecuteNonQuery();
                    miConexionSql.Close();
                }

                correcto.Visibility = Visibility.Visible;
                cargarBeats();
            }
            catch (Exception)
            {
                incorrecto.Visibility = Visibility.Visible;
            }         
        }

        private void mostrarAgregarAdmin()
        {
            camposAgregar.Visibility = Visibility.Visible;
        }

        private void cargarBeats()
        {
            string consulta = "SELECT * FROM Beat";

            SqlDataAdapter miAdaptadorSql = new SqlDataAdapter(consulta, miConexionSql);

            using (miAdaptadorSql)
            {
                DataTable estudiosTabla = new DataTable();

                miAdaptadorSql.Fill(estudiosTabla);

                listaBeats.DisplayMemberPath = "nombre";
                listaBeats.SelectedValuePath = "ruta";
                listaBeats.ItemsSource = estudiosTabla.DefaultView;
            }
        }

        private void reprodBeats(object sender, SelectionChangedEventArgs e)
        {
            
            mediaPlayer.Open(new Uri(listaBeats.SelectedValue.ToString()));
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();

            mostrarDetallesBeats();

        }

        private void mostrarDetallesBeats()
        {
            string consulta = "SELECT * FROM Beat WHERE ruta=@ruta";

            SqlCommand miSqlCommand = new SqlCommand(consulta, miConexionSql);
            SqlDataAdapter miAdaptadorSQL = new SqlDataAdapter(miSqlCommand);
            using (miAdaptadorSQL)
            {
                miSqlCommand.Parameters.AddWithValue("@ruta", listaBeats.SelectedValue);
                DataTable tablaBeats = new DataTable();
                miAdaptadorSQL.Fill(tablaBeats);
                string nombre = tablaBeats.Rows[0]["nombre"].ToString();
                string bpm = tablaBeats.Rows[0]["bpm"].ToString();
                string escala = tablaBeats.Rows[0]["escala"].ToString();

                detallesNombre.Content = nombre;
                detallesBpm.Content = bpm;
                detallesEscala.Content = escala;

            }
        }

        private void btnOpenAudioFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "MP3 files (*.mp3)|*.mp3|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                mediaPlayer.Open(new Uri(openFileDialog.FileName));
                mediaPlayer.Play();
            }
        }

        void timer_Tick(object sender, EventArgs e)
        {
            if (mediaPlayer.Source != null)
                lblStatus.Content = String.Format("{0} / {1}", mediaPlayer.Position.ToString(@"mm\:ss"), mediaPlayer.NaturalDuration.TimeSpan.ToString(@"mm\:ss"));
            else
                lblStatus.Content = "No file selected...";
        }

        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Play();
        }

        private void btnPause_Click(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Pause();
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Stop();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string url = "https://www.instagram.com/diegoseishiro/";

            System.Diagnostics.Process.Start(url);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string url = "https://twitter.com/aratt_";

            System.Diagnostics.Process.Start(url);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            string url = "https://www.facebook.com/jeusujars.reveles";

            System.Diagnostics.Process.Start(url);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("No tenemos numero por el momento");
        }
    }
}
