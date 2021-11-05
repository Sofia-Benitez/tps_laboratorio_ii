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

        public FrmLista(string tipo, IMDb imdb)
        {
            InitializeComponent();
            this.Text = tipo;
            baseDeDatosSeriesYPeliculas = imdb;

        }



        private void FrmLista_Load(object sender, EventArgs e)
        {
            if(this.Text == "Películas")
            {
                ActualizarDataSourcePeliculas();
            }
            else
            {
                ActualizarDataSourceSeries();
            }

            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(this.Text == "Películas")
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

        private void ActualizarDataSourcePeliculas()
        {
            dataGridLista.DataSource = null;
            dataGridLista.DataSource = baseDeDatosSeriesYPeliculas.Peliculas;
        }

        private void ActualizarDataSourceSeries()
        {
            dataGridLista.DataSource = null;
            dataGridLista.DataSource = baseDeDatosSeriesYPeliculas.Series;
        }
    }
}