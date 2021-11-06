using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades
{
    public abstract class Archivo
    {
        protected abstract string Extension { get; }

        public bool ValidarSiExisteElArchivo(string ruta)
        {
            if (!File.Exists(ruta))
            {
                throw new ArchivoIncorrectoException("No se encontró el archivo");
            }

            return true;
        }

        public bool ValidarExtension(string ruta)
        {
            if (Path.GetExtension(ruta) != Extension)
            {
                throw new ArchivoIncorrectoException($"El archivo debe tener la extensión {Extension}.");
            }

            return true;
        }
    }
}
