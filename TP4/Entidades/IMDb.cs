using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public delegate void DelegadoMensajeModificacion(string msg);

    public class IMDb
    {
        public event DelegadoMensajeModificacion EventoModificacion;
        private List<Pelicula> peliculas;
        private List<Serie> series;
        private List<Equipo> equipos;

        List<Serie> seriesSinFinalizar;
        List<Serie> seriesComedia;
        List<Serie> seriesCompletas;
        List<Serie> seriesConJenniferAniston;
        List<Serie> seriesDrama;
        List<Pelicula> peliculasTerror;
        List<Pelicula> peliculas2000;
        List<Pelicula> peliculasMás8Puntos;
        List<Pelicula> peliculasComedia;
        List<Pelicula> peliculasKubrick;

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
            seriesConJenniferAniston = new List<Serie>();
            seriesDrama = new List<Serie>();

            peliculasTerror = new List<Pelicula>();
            peliculas2000 = new List<Pelicula>();
            peliculasMás8Puntos = new List<Pelicula>();
            peliculasComedia = new List<Pelicula>();
            peliculasKubrick = new List<Pelicula>();

            equipos = new List<Equipo>();
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
        public int CantidadDePeliculas
        {
            get
            {
                return this.Peliculas.Count();
            }
        }

        public int CantidadDeSeries
        {
            get
            {
                return this.Series.Count();
            }
        }

        public List<Serie> SeriesSinFinalizar { get => seriesSinFinalizar; set => seriesSinFinalizar = value; }
        public List<Serie> SeriesComedia { get => seriesComedia; set => seriesComedia = value; }
        public List<Serie> SeriesCompletas { get => seriesCompletas; set => seriesCompletas = value; }
        public List<Pelicula> PeliculasTerror { get => peliculasTerror; set => peliculasTerror = value; }
        public List<Pelicula> Peliculas2000 { get => peliculas2000; set => peliculas2000 = value; }
        public List<Pelicula> PeliculasMás8Puntos { get => peliculasMás8Puntos; set => peliculasMás8Puntos = value; }
        public List<Equipo> Equipos { get => equipos; set => equipos = value; }
        public List<Pelicula> PeliculasComediaMalPuntuadas { get => peliculasComedia; set => peliculasComedia = value; }
        public List<Pelicula> PeliculasKubrik { get => peliculasKubrick; set => peliculasKubrick = value; }
        public List<Serie> SeriesConJenniferAniston { get => seriesConJenniferAniston; set => seriesConJenniferAniston = value; }
        public List<Serie> SeriesDrama { get => seriesDrama; set => seriesDrama = value; }

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

        public int BuscarNuevoIDEquipo()
        {
            int nuevoID;
            if (this.equipos.Count == 0)
            {
                nuevoID = 1;
            }
            else
            {
                nuevoID = this.equipos[equipos.Count - 1].Id + 1;
            }

            return nuevoID;
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

        /// <summary>
        /// Metodo que permite modificar los atributos de una pelicula e invoca a un evento si se ha cambiado el valor del atributo
        /// </summary>
        /// <param name="pelicula"></param>
        /// <param name="titulo"></param>
        /// <param name="año"></param>
        /// <param name="puntuacion"></param>
        /// <param name="duracion"></param>
        /// <param name="genero"></param>
        public void ModificarPelicula(Pelicula pelicula, string titulo, int año, float puntuacion, double duracion, string genero)
        {

            if(pelicula.Titulo!=titulo)
            {
                EventoModificacion.Invoke($"Titulo {pelicula.Titulo} cambio a {titulo}");
                pelicula.Titulo = titulo;
            }
            if(pelicula.Puntuacion!=puntuacion)
            {
                EventoModificacion.Invoke($"Puntuación {pelicula.Puntuacion} cambio a {puntuacion}");
                pelicula.Puntuacion = puntuacion;
            }
            if(pelicula.AñoLanzamiento!=año)
            {
                EventoModificacion.Invoke($"Año {pelicula.AñoLanzamiento} cambio a {año}");
                pelicula.AñoLanzamiento = año;
            }
            if(pelicula.Duracion!=duracion)
            {
                EventoModificacion.Invoke($"Duración {pelicula.Duracion} cambio a {duracion}");
                pelicula.Duracion = duracion;
            }
            if(pelicula.Genero!=genero)
            {
                EventoModificacion.Invoke($"Género {pelicula.Genero} cambio a {genero}");
                pelicula.Genero = genero;
            }
           
        }


        //ESTADISTICAS

        /// <summary>
        /// metodo que recorre la lista de series y agrega a una lista del formulario actual los elementos que no esten repetidos.
        /// cada vez que agrega un elemento suma una unidad a un contador
        /// solo agrega las series que no hayan finalizado, es decir que su año de finalizaccion este en su valor por default
        /// </summary>
        /// <returns>Devuelve la cantidad de series agregadas a la lista</returns>
        public string MostrarSeriesSinFinalizar()
        {
            StringBuilder sb = new  StringBuilder();
            seriesSinFinalizar.Clear();
            int contadorSeries = 0;
            int contadorPuntajeMas8 = 0;
            int porcentajeSinFinalizar;
            int porcentajeMas8;
            foreach (Serie item in this.Series)
            {
                if (item.AñoFinalizacion == 0 && !(this.seriesSinFinalizar.Contains(item)))
                {
                    this.seriesSinFinalizar.Add(item);
                    contadorSeries++;
                    if(item.Puntuacion >=8)
                    {
                        contadorPuntajeMas8++;
                    }
                }
            }
            if (this.series.Any() && seriesSinFinalizar.Any())
            {
                porcentajeSinFinalizar = contadorSeries * 100 / this.CantidadDeSeries;
                
                porcentajeMas8 = contadorPuntajeMas8 * 100 / contadorSeries;
                sb.AppendLine($"Cantidad de series sin finalizar: {contadorSeries} - {porcentajeSinFinalizar}% del total");
                sb.AppendLine($"{contadorPuntajeMas8} tienen puntaje superior a 8. El %{porcentajeMas8} de las series en emisión");
                 
            }
            else
            {
                sb.AppendLine("No hay series cargadas para analizar");
            }

            return sb.ToString();
        }

        /// <summary>
        /// metodo que recorre la lista de series y agrega a una lista del formulario actual los elementos que no esten repetidos.
        /// cada vez que agrega un elemento suma una unidad a un contador
        /// solo agrega las series hayan finalizado, es decir que su año de finalizaccion sea distinto a su valor por default
        /// </summary>
        /// <returns>Devuelve la cantidad de series agregadas a la lista</returns>
        public string MostrarSeriesCompletas()
        {
            StringBuilder sb = new StringBuilder();
            seriesCompletas.Clear();
            int contadorSeries = 0;
            int porcentajeSeriesCompletas;
            int contadorMas5Temporadas=0;
            int porcentajeMas5Temporadas;
            foreach (Serie item in this.Series)
            {
                if (item.AñoFinalizacion != 0 && !(this.seriesCompletas.Contains(item)))
                {
                    this.seriesCompletas.Add(item);
                    contadorSeries++;
                    if(item.Temporadas>=5)
                    {
                        contadorMas5Temporadas++;
                    }
                }
            }

            if (this.series.Any() && seriesCompletas.Any())
            {
                porcentajeSeriesCompletas = contadorSeries * 100 / this.CantidadDeSeries;

                porcentajeMas5Temporadas = contadorMas5Temporadas * 100 / contadorSeries;

                sb.AppendLine($"Cantidad de series finalizadas: {contadorSeries} - {porcentajeSeriesCompletas}% del total");
                sb.AppendLine($"{contadorMas5Temporadas} tienen 5 temporadas o más. " +
                    $"El %{porcentajeMas5Temporadas} de las series finalizadas");

            }
            else
            {
                sb.AppendLine("No hay series cargadas para analizar");
            }
            return sb.ToString();
        }

        /// <summary>
        /// metodo que recorre la lista de series y agrega a una lista del formulario actual los elementos que no esten repetidos.
        /// cada vez que agrega un elemento suma una unidad a un contador
        /// solo agrega las series cuyo género sea Comedia
        /// </summary>
        /// <returns>Devuelve la cantidad de series agregadas a la lista</returns>
        public string MostrarSeriesComedia()
        {
            StringBuilder sb = new StringBuilder();
            SeriesComedia.Clear();
            int contadorSeries = 0;
            int contadorMasActuales = 0;
            int porcentajeSeriesComedia;
            int porcentajeMasActuales;
            foreach (Serie item in this.Series)
            {
                if (item.Genero == "Comedia" && !(this.seriesComedia.Contains(item)))
                {
                    this.seriesComedia.Add(item);
                    contadorSeries++;
                    if(item.AñoLanzamiento>=2020)
                    {
                        contadorMasActuales++;
                    }
                }
            }
            if (this.series.Any() && seriesComedia.Any())
            {
                porcentajeSeriesComedia = contadorSeries * 100 / this.CantidadDeSeries;

                porcentajeMasActuales = contadorMasActuales * 100 / contadorSeries;

                sb.AppendLine($"Cantidad de comedia: {contadorSeries} - {porcentajeSeriesComedia}% del total");
                sb.AppendLine($"{contadorMasActuales} se estrenaron en 2020 0 2021. " +
                    $"El %{porcentajeMasActuales} de las series de comedia");

            }
            else
            {
                sb.AppendLine("No hay series cargadas para analizar");
            }
            return sb.ToString();
        }

        /// <summary>
        /// Metodo que recorre las peliculas y agrega a una lista las que tienen a Jennifer Aniston de actriz
        /// Calcula el porcentaje de estas sobre el total
        /// </summary>
        /// <returns>devuelve un string con la infromacion obtenida</returns>
        public string MostrarSeriesConJenniferAniston()
        {
            StringBuilder sb = new StringBuilder();
            seriesConJenniferAniston.Clear();
            int contadorSeries = 0;
            
            int porcentajeSeriesJennifer;
            
            foreach (Serie item in this.Series)
            {
                if(!(this.seriesConJenniferAniston.Contains(item)))
                {
                    foreach (string actor in item.Equipo.Actores)
                    {
                        if (actor == "Jennifer Aniston")
                        {
                            contadorSeries++;
                            this.seriesConJenniferAniston.Add(item);
                        }
                    }
                    
                }
            }
            if (this.series.Any() && seriesConJenniferAniston.Any())
            {
                porcentajeSeriesJennifer = contadorSeries * 100 / this.CantidadDeSeries;

                sb.AppendLine($"Cantidad de series en las que actua Jennifer Aniston: {contadorSeries} - {porcentajeSeriesJennifer}% del total");
               

            }
            else
            {
                sb.AppendLine("No hay series cargadas para analizar");
            }
            return sb.ToString();
        }

        public string MostrarSeriesDrama()
        {
            StringBuilder sb = new StringBuilder();
            seriesDrama.Clear();
            int contadorSeries = 0;
            int contadorPuntajeMenos7 = 0;
            int porcentajeSeriesDrama;
            int porcentajePuntajeMenos7;
            foreach (Serie item in this.Series)
            {
                if (item.Genero == "Drama" && !(this.seriesDrama.Contains(item)))
                {
                    this.seriesDrama.Add(item);
                    contadorSeries++;
                    if (item.Puntuacion <= 7)
                    {
                        contadorPuntajeMenos7++;
                    }
                }
            }
            if (this.series.Any() && seriesDrama.Any())
            {
                porcentajeSeriesDrama = contadorSeries * 100 / this.CantidadDeSeries;

                porcentajePuntajeMenos7 = contadorPuntajeMenos7 * 100 / contadorSeries;

                sb.AppendLine($"Cantidad de series de drama: {contadorSeries} - {porcentajeSeriesDrama}% del total");
                sb.AppendLine($"{contadorPuntajeMenos7} tienen puntaje igual o menor a 7. " +
                    $"El %{porcentajePuntajeMenos7} de las series de drama");

            }
            else
            {
                sb.AppendLine("No hay series cargadas para analizar");
            }
            return sb.ToString();
        }

        /// <summary>
        /// metodo que recorre la lista de peliculas y agrega a una lista del formulario actual los elementos que no esten repetidos.
        /// cada vez que agrega un elemento suma una unidad a un contador
        /// solo agrega las películas cuyo genero sea Terror
        /// </summary>
        /// <returns>Devuelve la cantidad de peliculas agregadas a la lista</returns>
        public string MostrarPeliculasTerror()
        {
            StringBuilder sb = new StringBuilder();
            peliculasTerror.Clear();
            int contadorPeliculas = 0;
            int contadorMas8 = 0;
            int contadorAntes2000 = 0;
            int porcentajeTerror = 0;
            int porcentajeMas8 = 0;
            int porcentajeAntes2000 = 0;
            foreach (Pelicula item in this.Peliculas)
            {
                if (item.Genero == "Terror" && !(this.peliculasTerror.Contains(item)))
                {
                    this.peliculasTerror.Add(item);
                    contadorPeliculas++;
                    if (item.Puntuacion >= 8)
                    {
                        contadorMas8++;
                    }
                    if (item.AñoLanzamiento < 2000)
                    {
                        contadorAntes2000++;
                    }
                }

            }
           
            if(this.peliculas.Any() && peliculasTerror.Any())
            {
                porcentajeTerror = contadorPeliculas * 100 / this.CantidadDePeliculas;
                porcentajeAntes2000 = contadorAntes2000 * 100 / contadorPeliculas;
                porcentajeMas8 = contadorMas8 * 100 / contadorPeliculas;
                sb.AppendLine($"Cantidad de peliculas de terror: {contadorPeliculas} - {porcentajeTerror}% del total");
                sb.AppendLine($"{contadorAntes2000} son de antes del año 2000. El %{porcentajeAntes2000} de las películas de terror");
                sb.AppendLine($"{contadorMas8} tienen puntuación mayor a 8. El %{porcentajeMas8} de las películas de terror");
            }
            else
            {
                sb.AppendLine("No hay películas cargadas para analizar");
            }
           

            return sb.ToString();
        }

        /// <summary>
        /// metodo que recorre la lista de peliculas y agrega a una lista del formulario actual los elementos que no esten repetidos.
        /// cada vez que agrega un elemento suma una unidad a un contador
        /// solo agrega las películas estrenadas despues del año 2000, es decir que su año de lanzamiento sea mayor o igual a 2000
        /// </summary>
        /// <returns>Devuelve la cantidad de peliculas agregadas a la lista</returns>
        public string MostrarPeliculasEstrenadasDespuesDel2000()
        {
            peliculas2000.Clear();
            int contadorPeliculas = 0;
            int porcentaje2000;
            StringBuilder sb = new StringBuilder();

            foreach (Pelicula item in this.Peliculas)
            {
                if (item.AñoLanzamiento >= 2000 && !(this.peliculas2000.Contains(item)))
                {
                    this.peliculas2000.Add(item);
                    contadorPeliculas++;
                }
            }
            peliculas2000.Sort(PeliculaMejorPuntuada);
           
            if (this.peliculas.Any() && peliculas2000.Any())
            {
                porcentaje2000 = contadorPeliculas * 100 / this.CantidadDePeliculas;
                sb.AppendLine($"Cantidad de peliculas estrenadas despues del 2000: {contadorPeliculas} - {porcentaje2000}% del total");
                sb.AppendLine($"Pelicula mejor puntuada: {peliculas2000[0].Titulo}. Puntaje: {peliculas2000[0].Puntuacion}");
            }
            else
            {
                sb.AppendLine("No hay películas cargadas para analizar");
            }
            
            return sb.ToString();
            
        }

        /// <summary>
        /// metodo que permite comparar peliculas por su puntuacion para usar en Sort()
        /// </summary>
        /// <param name="pelicula1"></param>
        /// <param name="pelicula2"></param>
        /// <returns></returns>
        public int PeliculaMejorPuntuada(Pelicula pelicula1, Pelicula pelicula2)
        {

            if (pelicula2.Puntuacion > pelicula1.Puntuacion)
            {
                return 1;
            }
            else if (pelicula2.Puntuacion < pelicula1.Puntuacion)
            {
                return -1;
            }
            else
            {
                return 0;
            }
                
            
        }

        /// <summary>
        /// metodo que recorre la lista de peliculas y agrega a una lista del formulario actual los elementos que no esten repetidos.
        /// cada vez que agrega un elemento suma una unidad a un contador
        /// solo agrega las películas cuyo puntaje sea mayor o igual a 8
        /// </summary>
        /// <returns>Devuelve la cantidad de peliculas agregadas a la lista</returns>
        public string MostrarPeliculasConMasDe8Puntos()
        {
            StringBuilder sb = new StringBuilder();
            peliculasMás8Puntos.Clear();
            int contadorPeliculas = 0;
            int porcentajePelisMas8;
            int contadorMas120Min = 0;
            int porcentajeMas120Min; 
            foreach (Pelicula item in this.Peliculas)
            {
                if (item.Puntuacion >= 8 && !(this.peliculasMás8Puntos.Contains(item)))
                {
                    this.peliculasMás8Puntos.Add(item);
                    contadorPeliculas++;
                    if(item.Duracion >= 120)
                    {
                        contadorMas120Min++;
                    }
                }
            }
            if (this.peliculas.Any() && this.peliculasMás8Puntos.Any())
            {
                porcentajePelisMas8 = contadorPeliculas * 100 / this.CantidadDePeliculas;
                porcentajeMas120Min = contadorMas120Min * 100 / contadorPeliculas;
                sb.AppendLine($"Cantidad de peliculas con puntuación mayor a 8: {contadorPeliculas} - %{porcentajePelisMas8} del total");
                sb.AppendLine($"{contadorMas120Min} duran dos horas o más, el %{porcentajeMas120Min} de estas películas.");
            }
            else
            {
                sb.AppendLine("No hay películas cargadas para analizar");
            }

            return sb.ToString();

        }


        public string MostrarPeliculasComedia()
        {
            StringBuilder sb = new StringBuilder();
            peliculasComedia.Clear();
            int contadorPeliculas = 0;
            int contadorEpoca = 0;
            int contadorMenos7Puntos = 0;
            int porcentajeMenos7Puntos;
            int porcentajePelisComedia;
            int porcentajeEpoca;
            foreach (Pelicula item in this.Peliculas)
            {
                if ((item.Genero == "Comedia" || item.Genero == "Comedia romántica")  && !(this.peliculasComedia.Contains(item)))
                {
                    this.peliculasComedia.Add(item);
                    contadorPeliculas++;
                    if(item.Puntuacion <= 7)
                    {
                        contadorMenos7Puntos++;
                    }
                    if (item.AñoLanzamiento <= 2010 && item.AñoLanzamiento >= 1999)
                    {
                        contadorEpoca++;
                    }
                }
            }
            
            if (this.peliculas.Any() && this.peliculasComedia.Any())
            {
                porcentajePelisComedia = contadorPeliculas * 100 / this.CantidadDePeliculas;
                porcentajeEpoca = contadorEpoca * 100 / contadorPeliculas;
                porcentajeMenos7Puntos = contadorMenos7Puntos * 100 / contadorPeliculas;
                sb.AppendLine($"Cantidad de peliculas de comedia: {contadorPeliculas} - {porcentajePelisComedia}% del total");
                sb.AppendLine($"{contadorEpoca} de estas películas se estrenaron entre el 1999 y el 2010 (%{porcentajeEpoca})");
                sb.AppendLine($"{contadorMenos7Puntos} de estas películas tienen puntaje menor o igual a 7 (%{porcentajeMenos7Puntos})");
            }
            else
            {
                sb.AppendLine("No hay películas cargadas para analizar");
            }

            return sb.ToString();
        }


        public string MostrarPeliculasDirigidasPorStanleyKubrick()
        {
            StringBuilder sb = new StringBuilder();
            peliculasKubrick.Clear();
            int contadorPeliculas = 0;
            int porcentajePelisKubrick;
            foreach (Pelicula item in this.Peliculas)
            {
                if (item.Equipo.Director == "Stanley Kubrick" && !(this.peliculasKubrick.Contains(item)))
                {
                    this.peliculasKubrick.Add(item);
                    contadorPeliculas++;
                }
            }

            peliculasKubrick.Sort(PeliculaMejorPuntuada);
            
            
            if (this.peliculas.Any() && peliculasKubrick.Any())
            {
                porcentajePelisKubrick = contadorPeliculas * 100 / this.CantidadDePeliculas;
                sb.AppendLine($"Cantidad de peliculas dirigidas por Stanley Kubrick: {contadorPeliculas} - {porcentajePelisKubrick}% del total");
                sb.AppendLine($"Pelicula mejor puntuada: {peliculasKubrick[0].Titulo}. Puntaje: {peliculasKubrick[0].Puntuacion}");
            }
            else
            {
                sb.AppendLine("No hay películas cargadas para analizar");
            }

            return sb.ToString();
        }

    }
    

   
}

