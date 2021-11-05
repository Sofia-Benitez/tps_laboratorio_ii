using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class IMDb
    {
        private List<Pelicula> peliculas;
        private List<Serie> series;

        public IMDb()
        {
            peliculas = new List<Pelicula>();
            series = new List<Serie>();
        }

        public List<Pelicula> Peliculas
        {
            get
            {
                return this.peliculas;
            }
            set
            {
                this.peliculas = value;
            }
        }

        public List<Serie> Series
        {
            get
            {
                return this.series;
            }
            set
            {
                this.series = value;
            }
        }

        public bool AgregarContenido(Pelicula nuevaPelicula)
        {
            int nuevoID;
            

            foreach (Pelicula item in peliculas)
            {
                if(nuevaPelicula == item)
                {
                    return false;
                }
            }

            if(peliculas.Count == 0)
            {
                nuevoID = 1;
            }
            else
            {
                nuevoID = peliculas[peliculas.Count-1].Id + 1;
            }
           
            nuevaPelicula.Id = nuevoID;
            this.peliculas.Add(nuevaPelicula);
            return true;

        }

        public bool AgregarContenido(Serie nuevaSerie)
        {
            int nuevoID;


            foreach (Serie item in series)
            {
                if (nuevaSerie == item)
                {
                    return false;
                }
            }

            if (series.Count == 0)
            {
                nuevoID = 1;
            }
            else
            {
                nuevoID = series[series.Count - 1].Id + 1;
            }

            nuevaSerie.Id = nuevoID;
            this.series.Add(nuevaSerie);
            return true;

        }
    }
    

   
}

