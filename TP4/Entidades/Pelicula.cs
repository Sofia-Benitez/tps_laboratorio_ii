using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    
    public class Pelicula : ContenidoAudiovisual
    {
        private double duracion;

        /// <summary>
        /// Constructor de la clase Pelicula
        /// </summary>
        /// <param name="id"></param>
        /// <param name="titulo"></param>
        /// <param name="añoLanzamiento"></param>
        /// <param name="puntuacion"></param>
        /// <param name="genero"></param>
        /// <param name="equipo"></param>
        /// <param name="duracion"></param>
        public Pelicula(int id, string titulo, int añoLanzamiento, float puntuacion, string genero, Equipo equipo, double duracion)
            : base(id, titulo, añoLanzamiento, puntuacion, genero, equipo)
        {
            this.duracion = duracion;
        }

        /// <summary>
        /// Propiedad Duracion, permite leer y editar el atributo
        /// </summary>
        public double Duracion
        {
            get
            {
                return this.duracion;
            }
            set
            {
                this.duracion = value;
                
            }
        }

    

        /// <summary>
        /// Metodo que permite mostrar los datos de la clase Pelicula
        /// </summary>
        /// <returns></returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Titulo: {this.Titulo}");
            sb.AppendLine("Película");
            sb.AppendLine($"{this.AñoLanzamiento}");
            sb.AppendLine($"Género: {this.Genero}");
            sb.AppendLine($"Duración: {this.Duracion}");
            sb.AppendLine($"Puntuación: {this.Puntuacion}");
            sb.AppendLine(this.equipo.ToString());


            return sb.ToString();
        }

        /// <summary>
        /// sobrecarga del operador == para comparar dos instancias de la clase por su título y año de lanzamiento. 
        /// Dos peliculas son iguales si tienen el mismo titulo y año de lanzamiento
        /// </summary>
        /// <param name="pelicula1"></param>
        /// <param name="pelicula2"></param>
        /// <returns>Devuelve true si las dos películas son iguales</returns>
        public static bool operator ==(Pelicula pelicula1, Pelicula pelicula2)
        {
            if(pelicula1.titulo == pelicula2.titulo && pelicula1.añoLanzamiento==pelicula2.añoLanzamiento)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// sobrecarga del operador != para comparar dos instancias de la clase por su título y año de lanzamiento. 
        /// Dos peliculas son iguales si tienen el mismo titulo y año de lanzamiento
        /// </summary>
        /// <param name="pelicula1"></param>
        /// <param name="pelicula2"></param>
        /// <returns>Devuelve true si las dos películas son distintas </returns>
        public static bool operator !=(Pelicula pelicula1, Pelicula pelicula2)
        {
            return !(pelicula1 == pelicula2);
        }

        /// <summary>
        /// Sobrecarga del metodo Equals para que compare si dos peliculas son iguales mediante la sobrecarga del ==
        /// </summary>
        /// <param name="obj">objeto que se quiere comparar</param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            Pelicula pelicula = obj as Pelicula;

            return pelicula is not null && this == pelicula;
        }

        /// <summary>
        /// sobrecarga del metodo GetHashCode() para que devuelva el codigo hash del titulo y el año de lanzamiento
        /// </summary>
        /// <returns></returns>
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
