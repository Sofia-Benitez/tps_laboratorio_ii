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
        public FrmAltayModificacion(string titulo, string tipo, string textoConfirmar, Pelicula peliculaAModificar)
        {
            InitializeComponent();
            this.Text = titulo;
            lblTipoContenido.Text = tipo;
            btnConfirmar.Text = textoConfirmar;
            peliculaModificar = peliculaAModificar;
        }

        private void FrmAltayModificacion_Load(object sender, EventArgs e)
        {
            if(lblTipoContenido.Text == "Película")
            {
                txtAñoFinalizacion.Hide();
                txtTemporadas.Hide();
                if(peliculaModificar is not null)
                {
                    txtDirector.Text = peliculaModificar.Equipo.Director;
                    txtEscritor.Text = peliculaModificar.Equipo.Escritor;
                    txtActor1.Text= peliculaModificar.Equipo.Actores[0];
                    txtActor2.Text= peliculaModificar.Equipo.Actores[1]; 
                    txtActor3.Text = peliculaModificar.Equipo.Actores[2];
                    txtTitulo.Text = peliculaModificar.Titulo;
                    txtAño.Text =peliculaModificar.AñoDeLanzamiento.ToString();
                    txtDuracion.Text = peliculaModificar.DuracionEnMinutos.ToString(); 
                    cbxGenero.Text = peliculaModificar.Genero;
                    txtPuntuacion.Text = peliculaModificar.Puntuacion.ToString();
                }
            }
            else
            {
                txtDuracion.Hide();
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if(peliculaModificar is null)
            {
                if (lblTipoContenido.Text == "Película")
                {
                    AgregarPelicula();
                }
            }
            else
            {
                if (lblTipoContenido.Text == "Película")
                {
                    ModificarPelicula();
                    
                }
                
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void AgregarPelicula()
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

            if (string.IsNullOrWhiteSpace(director) || string.IsNullOrWhiteSpace(escritor) || string.IsNullOrWhiteSpace(actor1) ||
               string.IsNullOrWhiteSpace(actor2) || string.IsNullOrWhiteSpace(actor3) || string.IsNullOrWhiteSpace(titulo) || string.IsNullOrWhiteSpace(año) || string.IsNullOrWhiteSpace(genero) ||
               string.IsNullOrWhiteSpace(duracion) || string.IsNullOrWhiteSpace(puntuacion))
            {
                MessageBox.Show("Error. Todos los campos deben estar completos para agregar un nuevo elemento");
            }
            else
            {
                Equipo equipoAgregar = new Equipo(director, escritor, new List<string> { actor1, actor2, actor3 });
                nuevaPelicula = new Pelicula(titulo, int.Parse(año), float.Parse(puntuacion), genero, equipoAgregar, double.Parse(duracion));
                if (nuevaPelicula is not null)
                {
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void ModificarPelicula()
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

            if (string.IsNullOrWhiteSpace(director) || string.IsNullOrWhiteSpace(escritor) || string.IsNullOrWhiteSpace(actor1) ||
               string.IsNullOrWhiteSpace(actor2) || string.IsNullOrWhiteSpace(actor3) || string.IsNullOrWhiteSpace(titulo) || string.IsNullOrWhiteSpace(año) || string.IsNullOrWhiteSpace(genero) ||
               string.IsNullOrWhiteSpace(duracion) || string.IsNullOrWhiteSpace(puntuacion))
            {
                MessageBox.Show("Error. Todos los campos deben estar completos para agregar un nuevo elemento");
            }
            else
            {
                peliculaModificar.Equipo.Director = director;
                
                peliculaModificar.Equipo.Escritor= escritor;
                peliculaModificar.Equipo.Actores[0] = actor1;
                peliculaModificar.Equipo.Actores[1] = actor2;
                peliculaModificar.Equipo.Actores[2] = actor3;
                peliculaModificar.Titulo = titulo;
                peliculaModificar.AñoDeLanzamiento = int.Parse(año);
                peliculaModificar.DuracionEnMinutos = double.Parse(duracion);
                peliculaModificar.Genero = genero;
                peliculaModificar.Puntuacion = float.Parse(puntuacion);
                if (peliculaModificar is not null)
                {
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }
    }
}
