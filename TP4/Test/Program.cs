using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            IMDb imdb = new IMDb();
            ///abre un archivo que se encuentra en el escritorio
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ruta = Path.Combine(ruta, "basePeliculas.json");
            ArchivoJson<List<Pelicula>> puntoJsonPeliculas = new ArchivoJson<List<Pelicula>>();

            

            Console.WriteLine("Cargando base de datos de películas - Archivo basePeliculas.json en Desktop\n\n\n");
            Console.WriteLine("---------------------PRESIONE UNA TECLA PARA CONTINUAR--------------------------");
            Console.ReadKey();
            Console.Clear();

            

            List<Pelicula> peliculasCargadas;
            try
            {
                peliculasCargadas = puntoJsonPeliculas.Leer(ruta);
                if (peliculasCargadas is not null)
                {
                    foreach (Pelicula item in peliculasCargadas)
                    {
                        imdb.AgregarContenido(item);
                    }
                    
                }

            }
            catch (ArchivoIncorrectoException ex)
            {
                Console.WriteLine(ex.Message);
            }

            //muestra todas las peliculas del archivo
            foreach(Pelicula item in imdb.Peliculas)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------PRESIONE UNA TECLA PARA CONTINUAR-----------");
            Console.ReadKey();
            Console.Clear();


            ////Carga de pelicula manual
            //Console.WriteLine("------------Carga de datos de una película---------------");
            //Console.WriteLine("Nombre de la película:");
            //string titulo = Console.ReadLine();
            //Console.WriteLine("Año de lanzamiento:");
            //int año = int.Parse(Console.ReadLine());
            //Console.WriteLine("Puntuación:");
            //float puntuacion = float.Parse(Console.ReadLine());
            //Console.WriteLine("Género:");
            //string genero = Console.ReadLine();
            //Console.WriteLine("Director:");
            //string director = Console.ReadLine();
            //Console.WriteLine("Escritor:");
            //string escritor = Console.ReadLine();
            //Console.WriteLine("Actor 1:");
            //string actor1 = Console.ReadLine();
            //Console.WriteLine("Actor 2:");
            //string actor2 = Console.ReadLine();
            //Console.WriteLine("Actor 3:");
            //string actor3 = Console.ReadLine();
            //Console.WriteLine("Duración en minutos:");
            //double duracion = double.Parse(Console.ReadLine());

            //Equipo equipo = new Equipo(director, escritor, new List<string> { actor1, actor2, actor3 });
            //Pelicula pelicula = new Pelicula(0, titulo, año, puntuacion, genero, equipo, duracion);

            //imdb.AgregarContenido(pelicula);
            //Console.WriteLine("\n\nPelicula agregada correctamente\n");

            //Console.WriteLine(pelicula.ToString());

            //Console.WriteLine("-----------PRESIONE UNA TECLA PARA CONTINUAR-----------");
            //Console.ReadKey();
            //Console.Clear();

            //Console.WriteLine("Base de datos actualizada\n");
            /////muestra las peliculas incluyendo la agregada manualmente
            //foreach (Pelicula item in imdb.Peliculas)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("-----------PRESIONE UNA TECLA PARA CONTINUAR-----------");
            //Console.ReadKey();
            //Console.Clear();

            ////guardar en un nuevo archivo
            //Console.WriteLine("Guardando actualizaciones en basePeliculasActualizada.json");
            //string rutaNueva = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //rutaNueva = Path.Combine(rutaNueva, "basePeliculasActualizada.json");
            //puntoJsonPeliculas.GuardarComo(rutaNueva, imdb.Peliculas);

            //Console.WriteLine("-----------PRESIONE UNA TECLA PARA CONTINUAR-----------");
            //Console.ReadKey();
            //Console.Clear();

            Console.WriteLine("-----------Estadisticas-----------");

            string pelisTerror = imdb.MostrarPeliculasTerror();
            Console.WriteLine(pelisTerror);

            string pelisMejorPuntuacion = imdb.MostrarPeliculasConMasDe8Puntos();
            Console.WriteLine(pelisMejorPuntuacion);

            string pelisPost2000 = imdb.MostrarPeliculasEstrenadasDespuesDel2000();
            Console.WriteLine(pelisPost2000);

            try
            {
                AccesoBD.Guardar(imdb.Peliculas[0]);
            }
            catch(Exception)
            {
                Console.WriteLine("error exception");
            }
            

        }
    }
}
