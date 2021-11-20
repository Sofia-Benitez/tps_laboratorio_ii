using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        private string director;
        private string escritor;
        private List<string> actores;

        /// <summary>
        /// Constructor de la clase Equipo, permite instancias un objeto con todos sus atributos
        /// </summary>
        /// <param name="director"></param>
        /// <param name="escritor"></param>
        /// <param name="actores"></param>
        public Equipo(string director, string escritor, List<string> actores)
        {
            this.director = director;
            this.escritor = escritor;
            this.actores = actores;
        }

        /// <summary>
        /// Propiedad Director, permite leer y editar el atributo
        /// </summary>
        public string Director
        {
            get
            {
                return this.director;
            }
            set
            {
                this.director = value;
            }
        }

        /// <summary>
        /// Propiedad Escritor, permite leer y editar el atributo
        /// </summary>
        public string Escritor
        {
            get
            {
                return this.escritor;
            }
            set
            {
                this.escritor = value;
            }
        }

        /// <summary>
        /// Propiedad Actores, permite leer y editar la lista
        /// </summary>
        public List<string> Actores
        {
            get
            {
                return this.actores;
            }
            set
            {
                this.actores = value;
            }
        }


        /// <summary>
        /// Metodo que permite mostrar los datos del objeto
        /// </summary>
        /// <returns></returns>
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Director/a: {this.director} ");
            sb.AppendLine($"Escritor/a: {this.escritor} ");
            sb.AppendLine("Actores y actrices: ");
            foreach (string actor in actores)
            {
                sb.AppendLine(actor + " ");
            }

            return sb.ToString();
        }

        /// <summary>
        /// sobrecarga del metodo para que devuelva el metodo Mostrar()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Mostrar();
        }




    }
}
