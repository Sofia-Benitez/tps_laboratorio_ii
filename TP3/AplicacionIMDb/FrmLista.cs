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
            Equipo equipoTitane = new Equipo("Julia Ducournau", "Julia Ducournau");
            Pelicula titane = new Pelicula("Titane", 2021, 6.9F, "Horror", equipoTitane, 120);

            Equipo equipoMidsommar = new Equipo("Ari Aster", "Ari Aster");

            Pelicula midsommar = new Pelicula("Midsommar", 2019, 7.1F, "Horror", equipoMidsommar, 148);

            
            equipoTitane.Actores.Add("Agathe Rousselle");
            equipoTitane.Actores.Add("Vincent Lindon");
            equipoTitane.Actores.Add("Garance Marillier");

            equipoMidsommar.Actores.Add("Florence Pugh");
            equipoMidsommar.Actores.Add("Vilhelm Blomgren");
            equipoMidsommar.Actores.Add("Jack Reynor");

           
            baseDeDatosSeriesYPeliculas.AgregarPelicula(midsommar);
            baseDeDatosSeriesYPeliculas.AgregarPelicula(titane);


            ActualizarDataSourcePeliculas();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {


            FrmAltayModificacion frmAltaModificacion = new FrmAltayModificacion("Agregar película", "Película", "Agregar", null);

            frmAltaModificacion.ShowDialog();

            if (frmAltaModificacion.DialogResult == DialogResult.OK)
            {
                baseDeDatosSeriesYPeliculas.AgregarPelicula(frmAltaModificacion.nuevaPelicula);
                ActualizarDataSourcePeliculas();
            }


        }


        private void ActualizarDataSourcePeliculas()
        {
            dataGridLista.DataSource = null;
            dataGridLista.DataSource = baseDeDatosSeriesYPeliculas.Peliculas;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridLista.SelectedRows.Count > 0)
            {
                Pelicula pelicula = dataGridLista.SelectedRows[0].DataBoundItem as Pelicula;
                baseDeDatosSeriesYPeliculas.Peliculas.Remove(pelicula);
                ActualizarDataSourcePeliculas();
                
            }
            else
            {
                MessageBox.Show("Debe seleccionar un elemento de la lista");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(dataGridLista.SelectedRows.Count > 0)
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
                MessageBox.Show("Debe seleccionar un elemento de la lista");
            }
            
        }

    }
}
