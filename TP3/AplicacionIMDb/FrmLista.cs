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
        IMDb imdb;
        

        /// <summary>
        /// constructor del formulario. para instanciarlo debe recibir el tipo de dato que se mostrara (pelicula o serie) y el objeto del tipo IMDb que se instancio en le frm pricipal
        /// </summary>
        /// <param name="tipo"></param>
        /// <param name="imdb"></param>
        public FrmLista(string tipo, IMDb baseDatos)
        {
            InitializeComponent();
            this.Text = tipo;
            this.imdb = baseDatos;

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
                    imdb.AgregarContenido(frmAltaModificacion.nuevaPelicula);
                    ActualizarDataSourcePeliculas();
                }
            }
            else
            {
                FrmAltayModificacion frmAltaModificacion = new FrmAltayModificacion("Agregar serie", "Series", "Agregar", null);

                frmAltaModificacion.ShowDialog();

                if (frmAltaModificacion.DialogResult == DialogResult.OK)
                {
                    imdb.AgregarContenido(frmAltaModificacion.nuevaSerie);
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
                    imdb.Peliculas.Remove(pelicula);
                    ActualizarDataSourcePeliculas();
                }
                else
                {
                    Serie serie = dataGridLista.SelectedRows[0].DataBoundItem as Serie;
                    imdb.Series.Remove(serie);
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
            lblResultado.Text = "";
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
            imdb.PeliculasTerror.Clear();
            imdb.SeriesSinFinalizar.Clear();

            if (this.Text == "Películas")
            {
                string resultado = imdb.MostrarPeliculasTerror();
                dataGridLista.DataSource = null;
                dataGridLista.DataSource = imdb.PeliculasTerror;
                lblResultado.Text = resultado;
            }
            else
            {
                int resultado = imdb.MostrarSeriesSinFinalizar();
                dataGridLista.DataSource = null;
                dataGridLista.DataSource = imdb.SeriesSinFinalizar;
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
            imdb.Peliculas2000.Clear();
            imdb.SeriesComedia.Clear();
            if (this.Text == "Películas")
            {
                string resultado = imdb.MostrarPeliculasEstrenadasDespuesDel2000();
                dataGridLista.DataSource = null;
                dataGridLista.DataSource = imdb.Peliculas2000;
                lblResultado.Text = resultado;
            }
            else
            {
                int resultado = imdb.MostrarSeriesComedia();
                dataGridLista.DataSource = null;
                dataGridLista.DataSource = imdb.SeriesComedia;
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
            imdb.PeliculasMás8Puntos.Clear();
            imdb.SeriesCompletas.Clear();
            if (this.Text == "Películas")
            {
                string resultado = imdb.MostrarPeliculasConMasDe8Puntos();
                dataGridLista.DataSource = null;
                dataGridLista.DataSource = imdb.PeliculasMás8Puntos;
                lblResultado.Text =resultado;
            }
            else
            {
                int resultado = imdb.MostrarSeriesCompletas();
                dataGridLista.DataSource = null;
                dataGridLista.DataSource = imdb.SeriesCompletas;
                lblResultado.Text = $"Cantidad de series completas: {resultado.ToString()}";
            }
        }

        /// <summary>
        /// Metodo que actualiza el datagrid de las peliculas con la propiedad Peliculas de la clase IMDb
        /// </summary>
        private void ActualizarDataSourcePeliculas()
        {
            dataGridLista.DataSource = null;
            dataGridLista.DataSource = imdb.Peliculas;
        }

        /// <summary>
        /// Metodo que actualiza el datagrid de las series con la propiedad Series de la clase IMDb
        /// </summary>
        private void ActualizarDataSourceSeries()
        {
            dataGridLista.DataSource = null;
            dataGridLista.DataSource = imdb.Series;
        }


       

        
    }
}