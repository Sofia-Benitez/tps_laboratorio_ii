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
    public partial class FrmAltayModificacion : Form
    {
        public Pelicula nuevaPelicula;
        public Pelicula peliculaModificar;
        public Serie serieModificar;
        public Serie nuevaSerie;
        public string nuevoTituloPelicula;
        public int nuevoAñoPelicula;
        public double nuevaDuracionPelicula;
        public string nuevoGeneroPelicula;
        public float nuevaPuntuacionPelicula;

        /// <summary>
        /// constructor que instancia el formulario con los atributos minimos que necesita 
        /// permite que funcione como un formulario para crear un objeto nuevo o para modificar un objeto que se pase por parámetros
        /// muestra el titulo y el texto del boton segun corresponda
        /// </summary>
        /// <param name="titulo"></param>
        /// <param name="tipo"></param>
        /// <param name="textoConfirmar"></param>
        /// <param name="contenidoModificar"></param>
        public FrmAltayModificacion(string titulo, string tipo, string textoConfirmar, ContenidoAudiovisual contenidoModificar)
        {
            InitializeComponent();
            this.Text = titulo;
            lblTipoContenido.Text = tipo;
            btnConfirmar.Text = textoConfirmar;
            peliculaModificar = contenidoModificar as Pelicula;
            serieModificar = contenidoModificar as Serie;
           
        }

        /// <summary>
        /// Cuando se carga el formulario se muestran los controles que corresponden al tipo de objeto que se va a crear o modificar 
        /// si se paso un objeto por parametros para modificar se mustran sus datos en los controles correspondientes 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAltayModificacion_Load(object sender, EventArgs e)
        {
            if(lblTipoContenido.Text == "Película")
            {
                txtAñoFinalizacion.Hide();
                lblAñofin.Hide();
                txtTemporadas.Hide();
                lblTempODuracion.Text = "Duración";
                if(peliculaModificar is not null)
                {
                    txtDirector.Text = peliculaModificar.Equipo.Director;
                    txtEscritor.Text = peliculaModificar.Equipo.Escritor;
                    txtActor1.Text= peliculaModificar.Equipo.Actores[0];
                    txtActor2.Text= peliculaModificar.Equipo.Actores[1]; 
                    txtActor3.Text = peliculaModificar.Equipo.Actores[2];
                    txtTitulo.Text = peliculaModificar.Titulo;
                    txtAño.Text =peliculaModificar.AñoLanzamiento.ToString();
                    txtDuracion.Text = peliculaModificar.Duracion.ToString(); 
                    cbxGenero.Text = peliculaModificar.Genero;
                    txtPuntuacion.Text = peliculaModificar.Puntuacion.ToString();
                }
            }
            else
            {
                txtDuracion.Hide();
                lblTempODuracion.Text = "Temporadas";
                if (serieModificar is not null)
                {
                    txtDirector.Text = serieModificar.Equipo.Director;
                    txtEscritor.Text = serieModificar.Equipo.Escritor;
                    txtActor1.Text = serieModificar.Equipo.Actores[0];
                    txtActor2.Text = serieModificar.Equipo.Actores[1];
                    txtActor3.Text = serieModificar.Equipo.Actores[2];
                    txtTitulo.Text = serieModificar.Titulo;
                    txtAño.Text = serieModificar.AñoLanzamiento.ToString();
                    txtAñoFinalizacion.Text = serieModificar.AñoFinalizacion.ToString();
                    txtTemporadas.Text = serieModificar.Temporadas.ToString();
                    cbxGenero.Text = serieModificar.Genero;
                    txtPuntuacion.Text = serieModificar.Puntuacion.ToString();
                }
            }
        }

        /// <summary>
        /// Al presionar el boton se modifica o se crea el objeto segun corresponda invocando a los metodos que ejecutan estas acciones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if(lblTipoContenido.Text == "Película")
            {
                if(peliculaModificar is null)
                {
                    nuevaPelicula = AgregarPelicula();
                    if (nuevaPelicula is not null)
                    {
                        DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                else
                {
                    peliculaModificar = ModificarPelicula();
                    if (peliculaModificar is not null)
                    {
                        DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
            else
            {
                if(serieModificar is null)
                {
                    nuevaSerie = AgregarSerie();
                    if(nuevaSerie is not null)
                    {
                        DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    
                }
                else
                {
                    serieModificar = ModificarSerie();
                    if (serieModificar is not null)
                    {
                        DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                
            }
            
        }

        /// <summary>
        /// Al presionar el boton cancelar se cierra el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        /// <summary>
        /// metodo que permite tomar los datos ingresados en los controles, los valida y si son correctos construye un objeto de tipo Pelicula
        /// este objeto es asignado al atributo nuevaPelicula del formulario. Si el objeto se construye correctamente 
        /// </summary>
        private Pelicula AgregarPelicula()
        {
            string director = txtDirector.Text;
            string escritor = txtEscritor.Text;
            string actor1 = txtActor1.Text;
            string actor2 = txtActor2.Text;
            string actor3 = txtActor3.Text;
            string titulo = txtTitulo.Text;
            string año = txtAño.Text;
            string puntuacion = txtPuntuacion.Text;
            string genero = cbxGenero.Text;
            string duracion = txtDuracion.Text;

            if (!(int.TryParse(año, out int añoNum) && double.TryParse(duracion, out double duracionNum) && float.TryParse(puntuacion, out float puntuacionNum)))
            {
                MessageBox.Show("Error. Algunos datos no se han ingresado correctamente");
            }
            else if (string.IsNullOrWhiteSpace(director) || string.IsNullOrWhiteSpace(escritor) || string.IsNullOrWhiteSpace(actor1) ||
               string.IsNullOrWhiteSpace(actor2) || string.IsNullOrWhiteSpace(actor3) || string.IsNullOrWhiteSpace(titulo) || string.IsNullOrWhiteSpace(año) || string.IsNullOrWhiteSpace(genero) ||
               string.IsNullOrWhiteSpace(duracion) || string.IsNullOrWhiteSpace(puntuacion))
            {
                MessageBox.Show("Error. Todos los campos deben estar completos para agregar un nuevo elemento");
            }
            else
            {
                Equipo equipoAgregar = new Equipo(0, director, escritor, new List<string> { actor1, actor2, actor3 });
                
                return nuevaPelicula = new Pelicula(0, titulo, añoNum, puntuacionNum, genero, equipoAgregar, duracionNum);
               
            }
            return null;
        }

        /// <summary>
        /// Metodo que recupera los datos de los controles para que el usuario los pueda modificar. Si son validados correctamente 
        /// devuelve el objeto modificado
        /// </summary>
        /// <returns></returns>
        private Pelicula ModificarPelicula()
        {
            string director = txtDirector.Text;
            string escritor = txtEscritor.Text;
            string actor1 = txtActor1.Text;
            string actor2 = txtActor2.Text;
            string actor3 = txtActor3.Text;
            string titulo = txtTitulo.Text;
            string año = txtAño.Text;
            string puntuacion = txtPuntuacion.Text;
            string genero = cbxGenero.Text;
            string duracion = txtDuracion.Text;

            if (!int.TryParse(año, out int añoNum) && !double.TryParse(duracion, out double duracionNum) && !float.TryParse(puntuacion, out float puntuacionNum))
            {
                MessageBox.Show("Error. Algunos datos no se han ingresado correctamente");
            }
            else if (string.IsNullOrWhiteSpace(director) || string.IsNullOrWhiteSpace(escritor) || string.IsNullOrWhiteSpace(actor1) ||
               string.IsNullOrWhiteSpace(actor2) || string.IsNullOrWhiteSpace(actor3) || string.IsNullOrWhiteSpace(titulo) || string.IsNullOrWhiteSpace(año) || string.IsNullOrWhiteSpace(genero) ||
               string.IsNullOrWhiteSpace(duracion) || string.IsNullOrWhiteSpace(puntuacion))
            {
                MessageBox.Show("Error. Todos los campos deben estar completos para modificar un elemento");
            }
            else
            {
                peliculaModificar.Equipo.Director = director;
                
                peliculaModificar.Equipo.Escritor= escritor;
                peliculaModificar.Equipo.Actores[0] = actor1;
                peliculaModificar.Equipo.Actores[1] = actor2;
                peliculaModificar.Equipo.Actores[2] = actor3;
                nuevoTituloPelicula = titulo;
                nuevoAñoPelicula = int.Parse(año);
                nuevaDuracionPelicula = double.Parse(duracion);
                nuevoGeneroPelicula = genero;
                nuevaPuntuacionPelicula = float.Parse(puntuacion);
                if (peliculaModificar is not null)
                {
                    return peliculaModificar;
                }
               
            }
            return null;
        }

        /// <summary>
        /// metodo que permite tomar los datos ingresados en los controles, los valida y si son correctos construye un objeto de tipo Serie
        /// este objeto es asignado al atributo nuevaPelicula del formulario. Si el objeto se construye correctamente 
        /// </summary>
        private Serie AgregarSerie()
        {
            string director = txtDirector.Text;
            string escritor = txtEscritor.Text;
            string actor1 = txtActor1.Text;
            string actor2 = txtActor2.Text;
            string actor3 = txtActor3.Text;
            string titulo = txtTitulo.Text;
            string año = txtAño.Text;
            string añoFin = txtAñoFinalizacion.Text;
            string puntuacion = txtPuntuacion.Text;
            string genero = cbxGenero.Text;
            string temporadas = txtTemporadas.Text;
            if(!(int.TryParse(año, out int añoNum) && int.TryParse(temporadas, out int temporadasNum) && float.TryParse(puntuacion, out float puntuacionNum) && (!int.TryParse(añoFin, out int añoFinNum) || !string.IsNullOrWhiteSpace(añoFin))) )
            {
                MessageBox.Show("Error. Algunos datos no se han ingresado correctamente");
            }
            else if(string.IsNullOrWhiteSpace(director) || string.IsNullOrWhiteSpace(escritor) || string.IsNullOrWhiteSpace(actor1) ||
               string.IsNullOrWhiteSpace(actor2) || string.IsNullOrWhiteSpace(actor3) || string.IsNullOrWhiteSpace(titulo) || string.IsNullOrWhiteSpace(año) || string.IsNullOrWhiteSpace(genero) ||
               string.IsNullOrWhiteSpace(puntuacion) || string.IsNullOrWhiteSpace(temporadas))
            {
                MessageBox.Show("Error. Todos los campos deben estar completos para agregar un nuevo elemento");
            }
            else
            {
                Equipo equipoAgregar = new Equipo(0, director, escritor, new List<string> { actor1, actor2, actor3 });
                
                nuevaSerie = new Serie(0, titulo, añoNum, puntuacionNum, genero, equipoAgregar, temporadasNum, añoFinNum);
                
                if (nuevaSerie is not null)
                {
                    return nuevaSerie;
                }
            }
            return null;
        }

        /// <summary>
        /// Metodo que recupera los datos de los controles para que el usuario los pueda modificar. Si son validados correctamente 
        /// devuelve el objeto modificado
        /// </summary>
        /// <returns></returns>
        private Serie ModificarSerie()
        {
            string director = txtDirector.Text;
            string escritor = txtEscritor.Text;
            string actor1 = txtActor1.Text;
            string actor2 = txtActor2.Text;
            string actor3 = txtActor3.Text;
            string titulo = txtTitulo.Text;
            string año = txtAño.Text;
            string añoFin = txtAñoFinalizacion.Text;
            string puntuacion = txtPuntuacion.Text;
            string genero = cbxGenero.Text;
            string temporadas = txtTemporadas.Text;

            if (!(int.TryParse(año, out int añoNum) && int.TryParse(temporadas, out int temporadasNum) && float.TryParse(puntuacion, out float puntuacionNum) && (!int.TryParse(añoFin, out int añoFinNum) || !string.IsNullOrWhiteSpace(añoFin))))
            {
                MessageBox.Show("Error. Algunos datos no se han ingresado correctamente");
            }
            else if (string.IsNullOrWhiteSpace(director) || string.IsNullOrWhiteSpace(escritor) || string.IsNullOrWhiteSpace(actor1) ||
               string.IsNullOrWhiteSpace(actor2) || string.IsNullOrWhiteSpace(actor3) || string.IsNullOrWhiteSpace(titulo) || string.IsNullOrWhiteSpace(año) || string.IsNullOrWhiteSpace(genero) ||
               string.IsNullOrWhiteSpace(temporadas) || string.IsNullOrWhiteSpace(puntuacion))
            {
                MessageBox.Show("Error. Todos los campos deben estar completos para modificar el elemento");
            }
            else
            {
                serieModificar.Equipo.Director = director;
                serieModificar.Equipo.Escritor = escritor;
                serieModificar.Equipo.Actores[0] = actor1;
                serieModificar.Equipo.Actores[1] = actor2;
                serieModificar.Equipo.Actores[2] = actor3;
                serieModificar.Titulo = titulo;
                serieModificar.AñoLanzamiento = int.Parse(año);
                serieModificar.AñoFinalizacion = int.Parse(añoFin);
                serieModificar.Temporadas = int.Parse(temporadas);
                serieModificar.Genero = genero;
                serieModificar.Puntuacion = float.Parse(puntuacion);
                if (serieModificar is not null)
                {
                    return serieModificar;
                }
            }
            return null;
        }



    }
}
