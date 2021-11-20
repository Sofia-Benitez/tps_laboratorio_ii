using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Entidades
{
    public class ArchivoJson<T> : IArchivo<T>
            where T : class
    {
        protected string Extension
        {
            get
            {
                return ".json";
            }
        }

        /// <summary>
        /// Metodo que comprueba si la ruta de un archivo existe implementando el metodo Exists() de la clase File. 
        /// En el caso contrario lanza la excepcion de Archivo incorrecto
        /// </summary>
        /// <param name="ruta"></param>
        /// <returns>Devuelve true si existe el archivo </returns>
        public bool ValidarSiExisteElArchivo(string ruta)
        {
            if (!File.Exists(ruta))
            {
                throw new ArchivoIncorrectoException("No se encontró el archivo");
            }

            return true;
        }

        /// <summary>
        /// Metodo que permite validar si la extension del archivo es correcta, lo realiza a traves del metodo GetExtension() de la clase Path
        /// Si la extension no es la correcta lanza la excepcion de Archivo incorrecto
        /// </summary>
        /// <param name="ruta"></param>
        /// <returns>Devuelve true si el archivo tiene la extension correspondiente</returns>
        public bool ValidarExtension(string ruta)
        {
            if (Path.GetExtension(ruta) != Extension)
            {
                throw new ArchivoIncorrectoException($"El archivo debe tener la extensión {Extension}.");
            }

            return true;
        }
        

        /// <summary>
        /// Metodo que serializa el contenido de determinada ruta si la ruta existe y es valida la extension
        /// </summary>
        /// <param name="ruta">ruta donde se guardara el contenido</param>
        /// <param name="contenido">contenido a serializar </param>
        public void Guardar(string ruta, T contenido)
        {
            if (ValidarSiExisteElArchivo(ruta) && ValidarExtension(ruta))
            {
                Serializar(ruta, contenido);
            }
        }

        /// <summary>
        /// Metodo que serializa el contenido de determinada ruta si es valida la extension de la ruta
        /// </summary>
        /// <param name="ruta">ruta donde se guardara el contenido</param>
        /// <param name="contenido">contenido a serializar</param>
        public void GuardarComo(string ruta, T contenido)
        {
            if (ValidarExtension(ruta))
            {
                Serializar(ruta, contenido);
            }
        }

        /// <summary>
        /// método que permite leer el contenido de un archivo y deserializarlo utilizando el método Deserialize() de la lclase JsonSerializer
        /// </summary>
        /// <param name="ruta"></param>
        /// <returns>devuelve el contenido del archivo </returns>
        public T Leer(string ruta)
        {
            if (ValidarSiExisteElArchivo(ruta) && ValidarExtension(ruta))
            {
                using (StreamReader streamReader = new StreamReader(ruta))
                {
                    string json = streamReader.ReadToEnd();
                    return JsonSerializer.Deserialize<T>(json);
                }
            }

            return null;
        }

        /// <summary>
        /// método uqe permite serializar el contenido de un archivo utilizando el metodo Serialize() de la clase JsomSerializer
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="contenido"></param>
        private void Serializar(string ruta, T contenido)
        {
            using (StreamWriter streamWriter = new StreamWriter(ruta))
            {
                string json = JsonSerializer.Serialize(contenido);
                streamWriter.Write(json);
            }
        }
    }
    
}
