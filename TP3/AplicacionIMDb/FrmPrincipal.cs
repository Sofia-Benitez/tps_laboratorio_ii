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
        private Json<List<Pelicula>> puntoJsonPeliculas;
        private Json<List<Serie>> puntoJsonSeries;
        private List<Pelicula> peliculasCargadas;
        private List<Serie> seriesCargadas;


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
            puntoJsonPeliculas = new Json<List<Pelicula>>();
            puntoJsonSeries = new Json<List<Serie>>();
            saveFileDialog.Filter = "Archivo JSON|*.json|Archivo XML|*.xml";




            Equipo equipoTitane = new Equipo("Julia Ducournau", "Julia Ducournau", new List<string> { "Agathe Rousselle", "Vincent Lindon", "Garance Marillier"});
            Pelicula titane = new Pelicula(0, "Titane", 2021, 6.9F, "Horror", equipoTitane, 120);
            Equipo equipoMidsommar = new Equipo("Ari Aster", "Ari Aster", new List<string> { "Florence Pugh", "Vilhelm Blomgren" , "Jack Reynor" });
            Pelicula midsommar = new Pelicula(0, "Midsommar", 2019, 7.1F, "Horror", equipoMidsommar, 148);
            Equipo equipoTedLasso = new Equipo("Declan Lowney", "Brendan Hunt", new List<string> { "Brendan Hunt", "Jason Sudeikis", "Brett Goldstein" });
            Serie tedLasso = new Serie(0, "Ted Lasso", 2020, 8.8F, "Comedia", equipoTedLasso, 2, 0);

            imdb.AgregarContenido(midsommar);
            imdb.AgregarContenido(titane);
            imdb.AgregarContenido(tedLasso);


        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            lblConfirmacionArchivos.Text = "";
        }

        private void btnPeliculas_Click(object sender, EventArgs e)
        {
            FrmLista frmLista = new FrmLista("Películas", imdb);
            frmLista.ShowDialog();
        }

        private void btnSeries_Click(object sender, EventArgs e)
        {
            FrmLista frmLista = new FrmLista("Series", imdb);
            frmLista.ShowDialog();
        }

        /// <summary>
        /// Abre una ubicación para cargar un archivo con una lista de peliculas 
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
                        CargarPeliculas();
                        lblConfirmacionArchivos.Text = "Listado de películas cargado";
                    }
    
                }
                catch (ArchivoIncorrectoException ex)
                {
                    MessageBox.Show(ex.Message);
                    lblConfirmacionArchivos.Text = "Error al abrir el archivo";
                }
            }
        }
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
                        CargarSeries();
                        lblConfirmacionArchivos.Text = "Listado de series cargado";
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


        private string SeleccionarUbicacionGuardado()
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                return saveFileDialog.FileName;
            }

            return string.Empty;
        }

        
        public void CargarPeliculas()
        {
            foreach (Pelicula item in peliculasCargadas)
            {
                imdb.AgregarContenido(item);
            }

        }

        public void CargarSeries()
        {
            foreach (Serie item in seriesCargadas)
            {
                imdb.AgregarContenido(item);
            }

        }

       
    }
}
