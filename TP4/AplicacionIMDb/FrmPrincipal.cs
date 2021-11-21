using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace AplicacionIMDb
{
    public partial class FrmPrincipal : Form
    {
        IMDb imdb = new IMDb();

        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private string ultimoArchivo;
        private ArchivoJson<List<Pelicula>> puntoJsonPeliculas;
        private ArchivoJson<List<Serie>> puntoJsonSeries;
        private List<Pelicula> peliculasCargadas;
        private List<Serie> seriesCargadas;


        /// <summary>
        /// Propiedad que permite leer y asignarle un valor al atributo
        /// </summary>
        private string UltimoArchivo
        {
            get
            {
                return ultimoArchivo;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    ultimoArchivo = value;
                }
            }
        }


        public FrmPrincipal()
        {
            InitializeComponent();

            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            puntoJsonPeliculas = new ArchivoJson<List<Pelicula>>();
            puntoJsonSeries = new ArchivoJson<List<Serie>>();
            saveFileDialog.Filter = "Archivo JSON|*.json";

            //Equipo equipoTitane = new Equipo("Julia Ducournau", "Julia Ducournau", new List<string> { "Agathe Rousselle", "Vincent Lindon", "Garance Marillier"});
            //Pelicula titane = new Pelicula(0, "Titane", 2021, 6.9F, "Horror", equipoTitane, 120);
            //Equipo equipoMidsommar = new Equipo("Ari Aster", "Ari Aster", new List<string> { "Florence Pugh", "Vilhelm Blomgren" , "Jack Reynor" });
            //Pelicula midsommar = new Pelicula(0, "Midsommar", 2019, 7.1F, "Horror", equipoMidsommar, 148);
            //Equipo equipoTedLasso = new Equipo("Declan Lowney", "Brendan Hunt", new List<string> { "Brendan Hunt", "Jason Sudeikis", "Brett Goldstein" });
            //Serie tedLasso = new Serie(0, "Ted Lasso", 2020, 8.8F, "Comedia", equipoTedLasso, 2, 0);

            //imdb.AgregarContenido(midsommar);
            //imdb.AgregarContenido(titane);
            //imdb.AgregarContenido(tedLasso);

        }

        /// <summary>
        /// Al cargar el formulario se cargan los data grid view con sus listas correspondientes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            lblConfirmacionArchivos.Text = "";
            ActualizarDataSourcePeliculas();
            ActualizarDataSourceSeries();
            
        }

        /// <summary>
        /// Al presionar el botón se instancia un nuevo formulario FrmLista y se muestra. Este forulario trabajará con las peliculas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPeliculas_Click(object sender, EventArgs e)
        {
            FrmLista frmLista = new FrmLista("Películas", imdb);
            frmLista.ShowDialog();
            ActualizarDataSourcePeliculas();
        }

        /// <summary>
        /// Al presionar el botón se instancia un nuevo formulario FrmLista y se muestra. Este forulario trabajará con las series
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSeries_Click_1(object sender, EventArgs e)
        {
            FrmLista frmLista = new FrmLista("Series", imdb);
            frmLista.ShowDialog();
            ActualizarDataSourceSeries();
        }
        

        /// <summary>
        /// Al seleccionar Abrir lista peliculas del menu se abre una ventana que permite seleccionar archivo con una lista de peliculas 
        /// utiliza el metodo leer de la clase ArchivoJson y carga en una lista lo que devuelve el metodo
        /// si esta lista no esta vacia se agregan a la lista de peliculas que contiene la clase IMDb
        /// se actualiza el datasource del datagrid para que se vean relfejados los cambios
        /// Si el archivo que se quiere abrir no es del tipo Json atrapa la excepcion correspondiente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listaPelículasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ultimoArchivo = openFileDialog.FileName;

                try
                {
                    peliculasCargadas = puntoJsonPeliculas.Leer(UltimoArchivo);
                    if(peliculasCargadas is not null)
                    {
                        foreach (Pelicula item in peliculasCargadas)
                        {
                            imdb.AgregarContenido(item);
                            item.Equipo.Id = imdb.BuscarNuevoIDEquipo();
                            imdb.Equipos.Add(item.Equipo);
                        }
                        lblConfirmacionArchivos.Text = "Listado de películas cargado";
                        ActualizarDataSourcePeliculas();
                    }
    
                }
                catch (ArchivoIncorrectoException ex)
                {
                    MessageBox.Show(ex.Message);
                    lblConfirmacionArchivos.Text = "Error al abrir el archivo";
                }
            }
        }

        /// <summary>
        /// Al seleccionar Abrir lista series del menu se abre una ventana que permite seleccionar archivo con una lista de series 
        /// utiliza el metodo leer de la clase ArchivoJson y carga en una lista lo que devuelve el metodo
        /// si esta lista no esta vacia se agregan a la lista de series que contiene la clase IMDb
        /// se actualiza el datasource del datagrid para que se vean relfejados los cambios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listaSeriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ultimoArchivo = openFileDialog.FileName;

                try
                {
                    seriesCargadas = puntoJsonSeries.Leer(UltimoArchivo);
                    if(seriesCargadas is not null)
                    {
                        foreach (Serie item in seriesCargadas)
                        {
                            imdb.AgregarContenido(item);
                        }
                        lblConfirmacionArchivos.Text = "Listado de series cargado";
                        ActualizarDataSourceSeries();
                    }
                    
                         
                }
                catch (ArchivoIncorrectoException ex)
                {
                    MessageBox.Show(ex.Message);
                    lblConfirmacionArchivos.Text = "Error al abrir el archivo";
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error al abrir el archivo. Intente nuevamente" + "Error: " + ex.Message);
                }
            }
        }

        /// <summary>
        /// Al presionar guardar lista peliculas del menu el metodo guarda el archivo en la ruta existente utilizando el metodo Guardar de la clase ArchivoJson
        /// Si la ruta no existe invoca al metodo GuardarComo permitiendo seleccionar en donde y el nombbre del archivo previamente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void guardarPelículasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (!File.Exists(UltimoArchivo))
            {
               UltimoArchivo = SeleccionarUbicacionGuardado();

               try
               {
                   puntoJsonPeliculas.GuardarComo(UltimoArchivo, imdb.Peliculas);
               }
               catch (Exception ex)
               {
                   MessageBox.Show(ex.Message);
               }
            }
            else
            {
                try
                {
                    puntoJsonPeliculas.Guardar(UltimoArchivo, imdb.Peliculas);
                    lblConfirmacionArchivos.Text = "Archivo guardado";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
                
        }

        /// <summary>
        /// Al presionar guardar lista series del menu el metodo guarda el archivo en la ruta existente utilizando el metodo Guardar de la clase ArchivoJson
        /// Si la ruta no existe invoca al metodo GuardarComo permitiendo seleccionar en donde y el nombbre del archivo previamente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param
        private void guardarSeriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
                if (!File.Exists(UltimoArchivo))
                {
                    UltimoArchivo = SeleccionarUbicacionGuardado();

                    try
                    {
                        puntoJsonSeries.GuardarComo(UltimoArchivo, imdb.Series);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    try
                    {
                        puntoJsonSeries.Guardar(UltimoArchivo, imdb.Series);
                        lblConfirmacionArchivos.Text = "Archivo guardado";

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            
            
        }

        /// <summary>
        /// al presionar guardar como Peliculas en el menu se llama al metodo SeleccionarUbicacionGuardado(); y se guarda en la ubicacion devuelta el contenido que se pasa por parametros
        /// en el metodo GuardarComo de la clase ArchivoJson. Si no se puede guardar el archivo se muesttra un mensaje con el error de la exepcion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void guardarComoPelículasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UltimoArchivo = SeleccionarUbicacionGuardado();

            try
            {
                puntoJsonPeliculas.GuardarComo(UltimoArchivo, imdb.Peliculas);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// al presionar guardar como Peliculas en el menu se llama al metodo SeleccionarUbicacionGuardado(); y se guarda en la ubicacion devuelta el contenido que se pasa por parametros
        /// en el metodo GuardarComo de la clase ArchivoJson. Si no se puede guardar el archivo se muesttra un mensaje con el error de la exepcion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void guardarComoSeriesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UltimoArchivo = SeleccionarUbicacionGuardado();

            try
            {
                puntoJsonSeries.GuardarComo(UltimoArchivo, imdb.Series);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        /// método que abre una ventana de dialogo que permite seleccionar una ubicacion para guardar un archivo y nombrarlo
        /// </summary>
        /// <returns>devuelve la ruta del archivo</returns>
        private string SeleccionarUbicacionGuardado()
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                return saveFileDialog.FileName;
            }

            return string.Empty;
        }

       
        /// <summary>
        /// metodo que actualiza el datagridview de peliculas
        /// </summary>
        private void ActualizarDataSourcePeliculas()
        {
            dataGridViewPeliculas.DataSource = null;
            dataGridViewPeliculas.DataSource = imdb.Peliculas;
        }

        /// <summary>
        /// metodo que actualiza el datagridview de series
        /// </summary>
        private void ActualizarDataSourceSeries()
        {
            dataGridViewSeries.DataSource = null;
            dataGridViewSeries.DataSource= imdb.Series;
        }

        /// <summary>
        /// Cuando se cierra el formulario principal si hay peliculas cargadas un mensaje permite elegir al usuario si guardar o no la lsta en una base de datos
        /// Si selecciona YES el programa guarda todas las peliculas en una base de datos y cierra el programa. 
        /// Si las peliculas ya estan cargadas no las guarda. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (imdb.Peliculas.Any())
            {
                if (MessageBox.Show("¿Desea guardar los datos en la base de datos antes de salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                {
                    try
                    {

                        foreach (Pelicula item in imdb.Peliculas)
                        {
                            AccesoBD.Guardar(item);

                        }

                        MessageBox.Show("Peliculas guardadas en la base de datos.");
                        

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error al guardar los elementos en la base de datos");
                    }
                }
            }
            else
            {
                MessageBox.Show("Adiós");
            }








        }
    }
}
