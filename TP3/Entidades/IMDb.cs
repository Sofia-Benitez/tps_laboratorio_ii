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

        /// <summary>
        /// Constructor de la clase que instancia las listas que contiene
        /// </summary>
        public IMDb()
        {
            peliculas = new List<Pelicula>();
            series = new List<Serie>();
        }

        /// <summary>
        /// Propiedad que permite leer y escribir la lista de películas 
        /// </summary>
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

        /// <summary>
        /// Propiedad que permite leer y escribir la lista de series 
        /// </summary>
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

        /// <summary>
        /// método que permite agregar una pelicula que se pasa por parametros a la lista de peliculas 
        /// solo la agrega si no esta ya en la lista. Antes de agregarla le asigna un id
        /// </summary>
        /// <param name="nuevaPelicula">objeto del tipo Pelicula que se desea agregar en la lista</param>
        /// <returns>Devuelve true si se agregó el objeto a la lista y false si no se agregó</returns>
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

        /// <summary>
        /// Sobrecarga del método AgregarContenido() para agregar una serie a la lista de series
        /// solo la agrega si no esta ya en la lista. Antes de agregarla le asigna un id
        /// </summary>
        /// <param name="nuevaSerie">objeto del tipo Serie que se desea agregar en la lista</param>
        /// <returns>Devuelve true si se agregó el objeto a la lista y false si no se agregó</returns>
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

