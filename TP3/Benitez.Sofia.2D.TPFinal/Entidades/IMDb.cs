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

        public bool AgregarPelicula(Pelicula nuevaPelicula)
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
    }
}
