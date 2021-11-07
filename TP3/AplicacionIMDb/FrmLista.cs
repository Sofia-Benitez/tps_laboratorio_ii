using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace AplicacionIMDb
{

    public partial class FrmLista : Form
    {
        IMDb baseDeDatosSeriesYPeliculas;
        List<Serie> seriesSinFinalizar = new List<Serie>();
        List<Serie> seriesComedia = new List<Serie>();
        List<Serie> seriesCompletas = new List<Serie>();
        List<Pelicula> peliculasTerror = new List<Pelicula>();
        List<Pelicula> peliculas2000 = new List<Pelicula>();
        List<Pelicula> peliculasMás8Puntos = new List<Pelicula>();

        /// <summary>
        /// constructor del formulario. para instanciarlo debe recibir el tipo de dato que se mostrara (pelicula o serie) y el objeto del tipo IMDb que se instancio en le frm pricipal
        /// </summary>
        /// <param name="tipo"></param>
        /// <param name="imdb"></param>
        public FrmLista(string tipo, IMDb imdb)
        {
            InitializeComponent();
            this.Text = tipo;
            baseDeDatosSeriesYPeliculas = imdb;

        }

        /// <summary>
        /// Cuando se carga el formulario se muestra la lista correspondiente y se cargan los textos de los botones de estadisticas
        /// segun el tipo de dato que se este mostrando en el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmLista_Load(object sender, EventArgs e)
        {
            if (this.Text == "Películas")
            {
                ActualizarDataSourcePeliculas();
                btnEstadistica1.Text = "Películas de terror";
                btnEstadistica2.Text = "Películas post 2000";
                btnEstadistica3.Text = "Películas con puntuación mayor a 8";
                btnVerTodas.Text = "Ver todas las películas";
            }
            else
            {
                ActualizarDataSourceSeries();
                btnEstadistica1.Text = "Series no finalizadas";
                btnEstadistica2.Text = "Series comedia";
                btnEstadistica3.Text = "Series completas";
                btnVerTodas.Text = "Ver todas las series";
            }


        }

        /// <summary>
        /// Al presionar el boton agregar se abre un nuevo formulario del tipo FrmAltayModificacion que se construye con distintos parametros
        /// segun el tipo de dato con el que se este trabajando (pelicula o serie) y el formulario se cierra con DialogResult.OK se agrega un nuevo elemento 
        /// a la lista correspondiente y se actualiza el datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (this.Text == "Películas")
            {
                FrmAltayModificacion frmAltaModificacion = new FrmAltayModificacion("Agregar película", "Película", "Agregar", null);

                frmAltaModificacion.ShowDialog();

                if (frmAltaModificacion.DialogResult == DialogResult.OK)
                {
                    baseDeDatosSeriesYPeliculas.AgregarContenido(frmAltaModificacion.nuevaPelicula);
                    ActualizarDataSourcePeliculas();
                }
            }
            else
            {
                FrmAltayModificacion frmAltaModificacion = new FrmAltayModificacion("Agregar serie", "Series", "Agregar", null);

                frmAltaModificacion.ShowDialog();

                if (frmAltaModificacion.DialogResult == DialogResult.OK)
                {
                    baseDeDatosSeriesYPeliculas.AgregarContenido(frmAltaModificacion.nuevaSerie);
                    ActualizarDataSourceSeries();
                }
            }

        }



        /// <summary>
        /// Al presionar el boton Eliminar si hay algun elemento del datagridview seleccionado se elimina ese objeto de la lista correspondiente
        /// y se actualiza la vista de la lista en el datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridLista.SelectedRows.Count > 0)
            {
                if (this.Text == "Películas")
                {
                    Pelicula pelicula = dataGridLista.SelectedRows[0].DataBoundItem as Pelicula;
                    baseDeDatosSeriesYPeliculas.Peliculas.Remove(pelicula);
                    ActualizarDataSourcePeliculas();
                }
                else
                {
                    Serie serie = dataGridLista.SelectedRows[0].DataBoundItem as Serie;
                    baseDeDatosSeriesYPeliculas.Series.Remove(serie);
                    ActualizarDataSourceSeries();
                }

            }
            else
            {
                MessageBox.Show("Debe seleccionar un elemento de la lista");
            }
        }

        /// <summary>
        /// Al presionar el boton Modificar si hay algun elemento seleccionado en el datagridview se abre un nuevo formulario FrmAltayModificacion
        /// que permite modificar los datos del objeto seleccionado pasandolo como parametro al construir el formulario
        /// Si al cerrar el formulario la propiedad DialogResult es OK se modifica el objeto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dataGridLista.SelectedRows.Count > 0)
            {
                if (this.Text == "Películas")
                {
                    Pelicula pelicula = dataGridLista.SelectedRows[0].DataBoundItem as Pelicula;
                    FrmAltayModificacion frmAltaModificacion = new FrmAltayModificacion("Modificar película", "Película", "Modificar", pelicula);

                    frmAltaModificacion.ShowDialog();

                    if (frmAltaModificacion.DialogResult == DialogResult.OK)
                    {
                        pelicula = frmAltaModificacion.peliculaModificar;
                        ActualizarDataSourcePeliculas();
                    }
                }
                else
                {
                    Serie serie = dataGridLista.SelectedRows[0].DataBoundItem as Serie;
                    FrmAltayModificacion frmAltaModificacion = new FrmAltayModificacion("Modificar serie", "Serie", "Modificar", serie);

                    frmAltaModificacion.ShowDialog();

                    if (frmAltaModificacion.DialogResult == DialogResult.OK)
                    {
                        serie = frmAltaModificacion.serieModificar;
                        ActualizarDataSourceSeries();
                    }
                }

            }
            else
            {
                MessageBox.Show("Debe seleccionar un elemento de la lista");
            }

        }

        /// <summary>
        /// Al presionar el Boton Se actualiza el datagrid con la lista completa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVerTodas_Click(object sender, EventArgs e)
        {
            if (this.Text == "Películas")
            {
                
                ActualizarDataSourcePeliculas();
            }
            else
            {
                
                ActualizarDataSourceSeries();
            }
        }

        /// <summary>
        /// Al presionar el primer boton de estadistica que muestra distinto texto segun el tipo de dato que se este trabajando 
        /// muestra todas las peliculas de terror y la cantidad o las series sin finalizar y la cantidad segun corresponda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEstadistica1_Click(object sender, EventArgs e)
        {
            dataGridLista.DataSource = null;
            peliculasTerror.Clear();
            seriesSinFinalizar.Clear();

            if (this.Text == "Películas")
            {
                int resultado = MostrarPeliculasTerror();
                dataGridLista.DataSource = null;
                dataGridLista.DataSource = this.peliculasTerror;
                lblResultado.Text = $"Cantidad de películas de terror: {resultado.ToString()}";
            }
            else
            {
                int resultado = MostrarSeriesSinFinalizar();
                dataGridLista.DataSource = null;
                dataGridLista.DataSource = this.seriesSinFinalizar;
                lblResultado.Text = $"Cantidad de series que no han finalizado: {resultado.ToString()}";
            }
        }

        /// <summary>
        /// Al presionar el primer boton de estadistica que muestra distinto texto segun el tipo de dato que se este trabajando 
        /// muestra todas las peliculas estrenadas despues del año 2000 y la cantidad o las series de comedia y la cantidad segun corresponda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEstadistica2_Click(object sender, EventArgs e)
        {
            dataGridLista.DataSource = null;
            peliculas2000.Clear();
            seriesComedia.Clear();
            if (this.Text == "Películas")
            {
                int resultado = MostrarPeliculasEstrenadasDespuesDel2000();
                dataGridLista.DataSource = null;
                dataGridLista.DataSource = this.peliculas2000;
                lblResultado.Text = $"Cantidad de películas posteriores al 2000: {resultado.ToString()}";
            }
            else
            {
                int resultado = MostrarSeriesComedia();
                dataGridLista.DataSource = null;
                dataGridLista.DataSource = this.seriesComedia;
                lblResultado.Text = $"Cantidad de series de comedia: {resultado.ToString()}";
            }
        }

        /// <summary>
        /// Al presionar el primer boton de estadistica que muestra distinto texto segun el tipo de dato que se este trabajando 
        /// muestra todas las peliculas con mas de 8 puntos y la cantidad o las series completas y la cantidad segun corresponda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEstadistica3_Click(object sender, EventArgs e)
        {
            dataGridLista.DataSource = null;
            peliculasMás8Puntos.Clear();
            seriesCompletas.Clear();
            if (this.Text == "Películas")
            {
                int resultado = MostrarPeliculasConMasDe8Puntos();
                dataGridLista.DataSource = null;
                dataGridLista.DataSource = this.peliculasMás8Puntos;
                lblResultado.Text = $"Cantidad de películas con puntuación mayor a 8: {resultado.ToString()}";
            }
            else
            {
                int resultado = MostrarSeriesCompletas();
                dataGridLista.DataSource = null;
                dataGridLista.DataSource = this.seriesComedia;
                lblResultado.Text = $"Cantidad de series completas: {resultado.ToString()}";
            }
        }

        /// <summary>
        /// Metodo que actualiza el datagrid de las peliculas con la propiedad Peliculas de la clase IMDb
        /// </summary>
        private void ActualizarDataSourcePeliculas()
        {
            dataGridLista.DataSource = null;
            dataGridLista.DataSource = baseDeDatosSeriesYPeliculas.Peliculas;
        }

        /// <summary>
        /// Metodo que actualiza el datagrid de las series con la propiedad Series de la clase IMDb
        /// </summary>
        private void ActualizarDataSourceSeries()
        {
            dataGridLista.DataSource = null;
            dataGridLista.DataSource = baseDeDatosSeriesYPeliculas.Series;
        }


        //ESTADISTICAS
       
        /// <summary>
        /// metodo que recorre la lista de series y agrega a una lista del formulario actual los elementos que no esten repetidos.
        /// cada vez que agrega un elemento suma una unidad a un contador
        /// solo agrega las series que no hayan finalizado, es decir que su año de finalizaccion este en su valor por default
        /// </summary>
        /// <returns>Devuelve la cantidad de series agregadas a la lista</returns>
        public int MostrarSeriesSinFinalizar()
        {
            int contadorSeries = 0;
            foreach (Serie item in baseDeDatosSeriesYPeliculas.Series)
            {
                if(item.AñoFinalizacion==0 && !(this.seriesSinFinalizar.Contains(item)))
                {
                    this.seriesSinFinalizar.Add(item);
                    contadorSeries++;
                }
            }

            return contadorSeries;
        }

        /// <summary>
        /// metodo que recorre la lista de series y agrega a una lista del formulario actual los elementos que no esten repetidos.
        /// cada vez que agrega un elemento suma una unidad a un contador
        /// solo agrega las series hayan finalizado, es decir que su año de finalizaccion sea distinto a su valor por default
        /// </summary>
        /// <returns>Devuelve la cantidad de series agregadas a la lista</returns>
        public int MostrarSeriesCompletas()
        {
            int contadorSeries = 0;
            foreach (Serie item in baseDeDatosSeriesYPeliculas.Series)
            {
                if (item.AñoFinalizacion != 0 && !(this.seriesCompletas.Contains(item)))
                {
                    this.seriesCompletas.Add(item);
                    contadorSeries++;
                }
            }

            return contadorSeries;
        }

        /// <summary>
        /// metodo que recorre la lista de series y agrega a una lista del formulario actual los elementos que no esten repetidos.
        /// cada vez que agrega un elemento suma una unidad a un contador
        /// solo agrega las series cuyo género sea Comedia
        /// </summary>
        /// <returns>Devuelve la cantidad de series agregadas a la lista</returns>
        public int MostrarSeriesComedia()
        {
            int contadorSeries = 0;
            foreach (Serie item in baseDeDatosSeriesYPeliculas.Series)
            {
                if (item.Genero=="Comedia" && !(this.seriesComedia.Contains(item)))
                {
                    this.seriesComedia.Add(item);
                    contadorSeries++;
                }
            }

            return contadorSeries;
        }

        /// <summary>
        /// metodo que recorre la lista de peliculas y agrega a una lista del formulario actual los elementos que no esten repetidos.
        /// cada vez que agrega un elemento suma una unidad a un contador
        /// solo agrega las películas cuyo genero sea Terror
        /// </summary>
        /// <returns>Devuelve la cantidad de peliculas agregadas a la lista</returns>
        public int MostrarPeliculasTerror()
        {
            int contadorPeliculas = 0;
            foreach (Pelicula item in baseDeDatosSeriesYPeliculas.Peliculas)
            {
                if(item.Genero=="Terror" && !(this.peliculasTerror.Contains(item)))
                {
                    this.peliculasTerror.Add(item);
                    contadorPeliculas++;
                }
            }
            return contadorPeliculas;
        }

        /// <summary>
        /// metodo que recorre la lista de peliculas y agrega a una lista del formulario actual los elementos que no esten repetidos.
        /// cada vez que agrega un elemento suma una unidad a un contador
        /// solo agrega las películas estrenadas despues del año 2000, es decir que su año de lanzamiento sea mayor o igual a 2000
        /// </summary>
        /// <returns>Devuelve la cantidad de peliculas agregadas a la lista</returns>
        public int MostrarPeliculasEstrenadasDespuesDel2000()
        {
            int contadorPeliculas = 0;
            foreach (Pelicula item in baseDeDatosSeriesYPeliculas.Peliculas)
            {
                if (item.AñoLanzamiento >= 2000 && !(this.peliculas2000.Contains(item)))
                {
                    this.peliculas2000.Add(item);
                    contadorPeliculas++;
                }
            }
            return contadorPeliculas;
        }

        /// <summary>
        /// metodo que recorre la lista de peliculas y agrega a una lista del formulario actual los elementos que no esten repetidos.
        /// cada vez que agrega un elemento suma una unidad a un contador
        /// solo agrega las películas cuyo puntaje sea mayor o igual a 8
        /// </summary>
        /// <returns>Devuelve la cantidad de peliculas agregadas a la lista</returns>
        public int MostrarPeliculasConMasDe8Puntos()
        {
            int contadorPeliculas = 0;
            foreach (Pelicula item in baseDeDatosSeriesYPeliculas.Peliculas)
            {
                if (item.Puntuacion >= 8 && !(this.peliculasMás8Puntos.Contains(item)))
                {
                    this.peliculasMás8Puntos.Add(item);
                    contadorPeliculas++;
                }
            }
            return contadorPeliculas;
        }

        
    }
}