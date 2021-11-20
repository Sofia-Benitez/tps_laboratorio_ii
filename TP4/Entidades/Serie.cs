using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Serie : ContenidoAudiovisual
    {
        private int temporadas;
        private int añoFinalizacion;

        /// <summary>
        /// Consructor de la clase que permite instanciar un objeto con todos sus atributos
        /// </summary>
        /// <param name="id"></param>
        /// <param name="titulo"></param>
        /// <param name="añoLanzamiento"></param>
        /// <param name="puntuacion"></param>
        /// <param name="genero"></param>
        /// <param name="equipo"></param>
        /// <param name="temporadas"></param>
        /// <param name="añoFinalizacion"></param>
        public Serie(int id, string titulo, int añoLanzamiento, float puntuacion, string genero, Equipo equipo, int temporadas, int añoFinalizacion)
            : base(id, titulo, añoLanzamiento, puntuacion, genero, equipo)
        {
            this.temporadas = temporadas;
            this.añoFinalizacion = añoFinalizacion;
        }

       
        /// <summary>
        /// Propiedad Temporadas, permite leer y asignarle un valor al atributo
        /// </summary>
        public int Temporadas
        {
            get
            {
                return this.temporadas;
            }
            set
            {
                this.temporadas = value;
            }
        }

        /// <summary>
        /// Propiedad AñoFinalizacion, permite leer y asignarle un valor al atributo
        /// </summary>
        public int AñoFinalizacion
        {
            get
            {
                return this.añoFinalizacion;
            }
            set
            {
                this.añoFinalizacion = value;
            }
        }

        
        /// <summary>
        /// Metodo que permite mostrar los datos de un objeto
        /// </summary>
        /// <returns></returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Titulo: {this.Titulo}");
            sb.AppendLine("Serie de TV");
            sb.AppendLine($"{this.AñoLanzamiento}-");
            if(añoFinalizacion!=0)
            {
                sb.Append($"{this.AñoFinalizacion} ");
            }
            sb.AppendLine($"Temporadas emitidas: {this.Temporadas}");
            sb.AppendLine($"Género: {this.Genero}");
            sb.AppendLine($"Puntuación: {this.Puntuacion}");
            sb.AppendLine(this.equipo.Mostrar());


            return sb.ToString();
        }

        /// <summary>
        ///Sobrecarga del operador == para comparar dos instancias de la clase por su título y año de lanzamiento.
        /// Dos series son iguales si tienen el mismo titulo y año de lanzamiento
        /// </summary>
        /// <param name="serie1"></param>
        /// <param name="serie2"></param>
        /// <returns>Devuelve true si las dos series son iguales</returns>
        public static bool operator ==(Serie serie1, Serie serie2)
        {
            if (serie1.titulo == serie2.titulo && serie1.añoLanzamiento == serie2.añoLanzamiento)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        ///Sobrecarga del operador != para comparar dos instancias de la clase por su título y año de lanzamiento.
        /// Dos series son iguales si tienen el mismo titulo y año de lanzamiento
        /// </summary>
        /// <param name="serie1"></param>
        /// <param name="serie2"></param>
        /// <returns>Devuelve true si las dos series no son iguales</returns>
        public static bool operator !=(Serie serie1, Serie serie2)
        {
            return !(serie1 == serie2);
        }

        /// <summary>
        /// Sobrecarga del metodo Equals para que compare si dos series son iguales mediante la sobrecarga del ==
        /// </summary>
        /// <param name="obj">objeto que se quiere comparar</param>
        /// <returns>devuelve true si el objeto es igual</returns>
        public override bool Equals(object obj)
        {
            Serie serie = obj as Serie;

            return serie is not null && this == serie;
        }

        public override int GetHashCode()
        {
            return (titulo, añoLanzamiento).GetHashCode();
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
