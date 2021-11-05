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
    public partial class FrmPrincipal : Form
    {
        IMDb imdb = new IMDb();

        

        public FrmPrincipal()
        {
            InitializeComponent();
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

            Equipo equipoTedLasso = new Equipo("Declan Lowney", "Brendan Hunt", new List<string> {"Brendan Hunt", "Jason Sudeikis", "Brett Goldstein"});
            Serie tedLasso = new Serie("Ted Lasso", 2020, 8.8F, "Comedia", equipoTedLasso, 2);

            imdb.AgregarContenido(midsommar);
            imdb.AgregarContenido(titane);
            imdb.AgregarContenido(tedLasso);


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
    }
}
