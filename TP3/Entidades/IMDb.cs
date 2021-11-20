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

        List<Serie> seriesSinFinalizar;
        List<Serie> seriesComedia;
        List<Serie> seriesCompletas;
        List<Pelicula> peliculasTerror;
        List<Pelicula> peliculas2000;
        List<Pelicula> peliculasMás8Puntos;

        /// <summary>
        /// Constructor de la clase que instancia las listas que contiene
        /// </summary>
        public IMDb()
        {
            peliculas = new List<Pelicula>();
            series = new List<Serie>();

            seriesSinFinalizar = new List<Serie>();
            seriesComedia = new List<Serie>();
            seriesCompletas = new List<Serie>();
            peliculasTerror = new List<Pelicula>();
            peliculas2000 = new List<Pelicula>();
            peliculasMás8Puntos = new List<Pelicula>();
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

        public List<Serie> SeriesSinFinalizar { get => seriesSinFinalizar; set => seriesSinFinalizar = value; }
        public List<Serie> SeriesComedia { get => seriesComedia; set => seriesComedia = value; }
        public List<Serie> SeriesCompletas { get => seriesCompletas; set => seriesCompletas = value; }
        public List<Pelicula> PeliculasTerror { get => peliculasTerror; set => peliculasTerror = value; }
        public List<Pelicula> Peliculas2000 { get => peliculas2000; set => peliculas2000 = value; }
        public List<Pelicula> PeliculasMás8Puntos { get => peliculasMás8Puntos; set => peliculasMás8Puntos = value; }

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


        //ESTADISTICAS

        /// <summary>
        /// metodo que recorre la lista de series y agrega a una lista del formulario actual los elementos que no esten repetidos.
        /// cada vez que agrega un elemento suma una unidad a un contador
        /// solo agrega las series que no hayan finalizado, es decir que su año de finalizaccion este en su valor por default
        /// </summary>
        /// <returns>Devuelve la cantidad de series agregadas a la lista</returns>
        public int MostrarSeriesSinFinalizar()
        {
            int contadorSeries = 0;
            foreach (Serie item in this.Series)
            {
                if (item.AñoFinalizacion == 0 && !(this.seriesSinFinalizar.Contains(item)))
                {
                    this.seriesSinFinalizar.Add(item);
                    contadorSeries++;
                }
            }

            return contadorSeries;
        }

        /// <summary>
        /// metodo que recorre la lista de series y agrega a una lista del formulario actual los elementos que no esten repetidos.
        /// cada vez que agrega un elemento suma una unidad a un contador
        /// solo agrega las series hayan finalizado, es decir que su año de finalizaccion sea distinto a su valor por default
        /// </summary>
        /// <returns>Devuelve la cantidad de series agregadas a la lista</returns>
        public int MostrarSeriesCompletas()
        {
            int contadorSeries = 0;
            foreach (Serie item in this.Series)
            {
                if (item.AñoFinalizacion != 0 && !(this.seriesCompletas.Contains(item)))
                {
                    this.seriesCompletas.Add(item);
                    contadorSeries++;
                }
            }

            return contadorSeries;
        }

        /// <summary>
        /// metodo que recorre la lista de series y agrega a una lista del formulario actual los elementos que no esten repetidos.
        /// cada vez que agrega un elemento suma una unidad a un contador
        /// solo agrega las series cuyo género sea Comedia
        /// </summary>
        /// <returns>Devuelve la cantidad de series agregadas a la lista</returns>
        public int MostrarSeriesComedia()
        {
            int contadorSeries = 0;
            foreach (Serie item in this.Series)
            {
                if (item.Genero == "Comedia" && !(this.seriesComedia.Contains(item)))
                {
                    this.seriesComedia.Add(item);
                    contadorSeries++;
                }
            }

            return contadorSeries;
        }

        /// <summary>
        /// metodo que recorre la lista de peliculas y agrega a una lista del formulario actual los elementos que no esten repetidos.
        /// cada vez que agrega un elemento suma una unidad a un contador
        /// solo agrega las películas cuyo genero sea Terror
        /// </summary>
        /// <returns>Devuelve la cantidad de peliculas agregadas a la lista</returns>
        public string MostrarPeliculasTerror()
        {
            int contadorPeliculas = 0;
            foreach (Pelicula item in this.Peliculas)
            {
                if (item.Genero == "Terror" && !(this.peliculasTerror.Contains(item)))
                {
                    this.peliculasTerror.Add(item);
                    contadorPeliculas++;
                }
            }
            int pelisTotal = this.Peliculas.Count();
            int porcentajeTerror = contadorPeliculas * 100 / pelisTotal;
            

            return $"Cantidad de peliculas de terror: {contadorPeliculas}. {porcentajeTerror}% del total";
        }

        /// <summary>
        /// metodo que recorre la lista de peliculas y agrega a una lista del formulario actual los elementos que no esten repetidos.
        /// cada vez que agrega un elemento suma una unidad a un contador
        /// solo agrega las películas estrenadas despues del año 2000, es decir que su año de lanzamiento sea mayor o igual a 2000
        /// </summary>
        /// <returns>Devuelve la cantidad de peliculas agregadas a la lista</returns>
        public string MostrarPeliculasEstrenadasDespuesDel2000()
        {
            int contadorPeliculas = 0;
            foreach (Pelicula item in this.Peliculas)
            {
                if (item.AñoLanzamiento >= 2000 && !(this.peliculas2000.Contains(item)))
                {
                    this.peliculas2000.Add(item);
                    contadorPeliculas++;
                }
            }
            int pelisTotal = this.Peliculas.Count();
            int porcentaje2000 = contadorPeliculas * 100 / pelisTotal;


            return $"Cantidad de peliculas estrenadas despues del 2000: {contadorPeliculas}. {porcentaje2000}% del total";
            
        }

        /// <summary>
        /// metodo que recorre la lista de peliculas y agrega a una lista del formulario actual los elementos que no esten repetidos.
        /// cada vez que agrega un elemento suma una unidad a un contador
        /// solo agrega las películas cuyo puntaje sea mayor o igual a 8
        /// </summary>
        /// <returns>Devuelve la cantidad de peliculas agregadas a la lista</returns>
        public string MostrarPeliculasConMasDe8Puntos()
        {
            int contadorPeliculas = 0;
            foreach (Pelicula item in this.Peliculas)
            {
                if (item.Puntuacion >= 8 && !(this.peliculasMás8Puntos.Contains(item)))
                {
                    this.peliculasMás8Puntos.Add(item);
                    contadorPeliculas++;
                }
            }
            int pelisTotal = this.Peliculas.Count();
            int porcentajePelisMas8 = contadorPeliculas * 100 / pelisTotal;


            return $"Cantidad de peliculas con puntuación mayor a 8: {contadorPeliculas}. {porcentajePelisMas8}% del total";
        }
    }
    

   
}

