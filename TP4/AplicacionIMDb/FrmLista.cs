using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace AplicacionIMDb
{
    
    public partial class FrmLista : Form
    {
        IMDb imdb;
        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

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
                btnEstadistica4.Text = "Películas comedia";
                btnEstadistica5.Text = "Películas dirigidas por Stanley Kubrick";
                btnVerTodas.Text = "Ver todas las películas";
                lblCantidad.Show();

                CancellationToken cancelationToken = cancellationTokenSource.Token;
                Task hilo = Task.Run(ComprobarCambios, cancelationToken);
                imdb.EventoModificacion += NotificarModificacion;
                
            }
            else
            {
                ActualizarDataSourceSeries();
                btnEstadistica1.Text = "Series no finalizadas";
                btnEstadistica2.Text = "Series comedia";
                btnEstadistica3.Text = "Series completas";
                btnEstadistica4.Text = "Series con Jennifer Aniston";
                btnEstadistica5.Text = "Series drama";
                btnVerTodas.Text = "Ver todas las series";
                lblCantidad.Hide();
                lblCantidad.Hide();
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
                    frmAltaModificacion.nuevaPelicula.Equipo.Id = imdb.BuscarNuevoIDEquipo();
                    imdb.Equipos.Add(frmAltaModificacion.nuevaPelicula.Equipo);

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
                        imdb.ModificarPelicula(pelicula, frmAltaModificacion.nuevoTituloPelicula, frmAltaModificacion.nuevoAñoPelicula, frmAltaModificacion.nuevaPuntuacionPelicula, frmAltaModificacion.nuevaDuracionPelicula, frmAltaModificacion.nuevoGeneroPelicula);
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
            rtbxResultados.Text = "";
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

            if (this.Text == "Películas")
            {
                string resultado = imdb.MostrarPeliculasTerror();
                dataGridLista.DataSource = null;
                dataGridLista.DataSource = imdb.PeliculasTerror;
                rtbxResultados.Text = resultado;
            }
            else
            {
                string resultado = imdb.MostrarSeriesSinFinalizar();
                dataGridLista.DataSource = null;
                dataGridLista.DataSource = imdb.SeriesSinFinalizar;
                rtbxResultados.Text = resultado;
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
            
            if (this.Text == "Películas")
            {
                string resultado = imdb.MostrarPeliculasEstrenadasDespuesDel2000();
                dataGridLista.DataSource = null;
                dataGridLista.DataSource = imdb.Peliculas2000;
                rtbxResultados.Text = resultado;
            }
            else
            {
                string resultado = imdb.MostrarSeriesComedia();
                dataGridLista.DataSource = null;
                dataGridLista.DataSource = imdb.SeriesComedia;
                rtbxResultados.Text = resultado;
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
            
            if (this.Text == "Películas")
            {
                string resultado = imdb.MostrarPeliculasConMasDe8Puntos();
                dataGridLista.DataSource = null;
                dataGridLista.DataSource = imdb.PeliculasMás8Puntos;
                rtbxResultados.Text =resultado;
            }
            else
            {
                string resultado = imdb.MostrarSeriesCompletas();
                dataGridLista.DataSource = null;
                dataGridLista.DataSource = imdb.SeriesCompletas;
                rtbxResultados.Text = resultado;
            }
        }

        private void btnEstadistica4_Click(object sender, EventArgs e)
        {
            dataGridLista.DataSource = null;
            
            if (this.Text == "Películas")
            {
                string resultado = imdb.MostrarPeliculasComedia();
                dataGridLista.DataSource = null;
                dataGridLista.DataSource = imdb.PeliculasComediaMalPuntuadas;
                rtbxResultados.Text = resultado;
            }
            else
            {
                string resultado = imdb.MostrarSeriesConJenniferAniston();
                dataGridLista.DataSource = null;
                dataGridLista.DataSource = imdb.SeriesConJenniferAniston;
                rtbxResultados.Text = resultado;
            }

        }

        private void btnEstadistica5_Click(object sender, EventArgs e)
        {
            dataGridLista.DataSource = null;
            

            if (this.Text == "Películas")
            {
                string resultado = imdb.MostrarPeliculasDirigidasPorStanleyKubrick();
                dataGridLista.DataSource = null;
                dataGridLista.DataSource = imdb.PeliculasKubrik;
                rtbxResultados.Text = resultado;
            }
            else
            {
                string resultado = imdb.MostrarSeriesDrama();
                dataGridLista.DataSource = null;
                dataGridLista.DataSource = imdb.SeriesDrama;
                rtbxResultados.Text = resultado;
            }
        }

        private void btnMostrarEstadisticas_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            if (this.Text == "Películas")
            {
               
                sb.AppendLine(imdb.MostrarPeliculasConMasDe8Puntos());
                sb.AppendLine(imdb.MostrarPeliculasEstrenadasDespuesDel2000());
                sb.AppendLine(imdb.MostrarPeliculasTerror());
                sb.AppendLine(imdb.MostrarPeliculasComedia());
                sb.AppendLine(imdb.MostrarPeliculasDirigidasPorStanleyKubrick());

                MessageBox.Show(sb.ToString(), "Estadísticas", MessageBoxButtons.OK);
            }
            else
            {
                
                sb.AppendLine(imdb.MostrarSeriesComedia());
                sb.AppendLine(imdb.MostrarSeriesCompletas());
                sb.AppendLine(imdb.MostrarSeriesDrama());
                sb.AppendLine(imdb.MostrarSeriesSinFinalizar());
                sb.AppendLine(imdb.MostrarSeriesConJenniferAniston());

                MessageBox.Show(sb.ToString(), "Estadísticas", MessageBoxButtons.OK);
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



        private void ComprobarCambios()
        {
            while(true && !cancellationTokenSource.IsCancellationRequested)
            {
                if(imdb.Peliculas.Count().ToString() != lblCantidad.Text)
                { 
                    ActualizarContadorPeliculas();
                }
            }
        }
        private void ActualizarContadorPeliculas()
        {

            if (InvokeRequired)
            {
                Action delegado = ActualizarContadorPeliculas;
                Invoke(delegado);
            }
            else
            {
                lblCantidad.Text = $"Cantidad total de películas: {imdb.Peliculas.Count().ToString()}";
            }
        }

        /// <summary>
        /// metodo del evento
        /// </summary>
        /// <param name="mensaje"></param>
        public void NotificarModificacion(string mensaje)
        {
            MessageBox.Show(mensaje);
        }

        /// <summary>
        /// Evento que se ejecuta cuando se esta cerrando el formulario. Cancela el hilo y muestra un mensaje
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmLista_FormClosing(object sender, FormClosingEventArgs e)
        {
            cancellationTokenSource.Cancel();
            MessageBox.Show("Volver al inicio");
        }
    }
}