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

            ///Abrir un archivo json con peliculas guardadas
            IMDb imdb = new IMDb();
            ///abre un archivo que se encuentra en el escritorio
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ruta = Path.Combine(ruta, "basePeliculas.json");
            ArchivoJson<List<Pelicula>> puntoJsonPeliculas = new ArchivoJson<List<Pelicula>>();

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

            foreach(Pelicula item in imdb.Peliculas)
            {
                Console.WriteLine(item);
            }
        }
    }
}
