using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Pelicula : ContenidoAudiovisual
    {
        private double duracion;
        public Pelicula(string titulo, int año, float puntuacion, string genero, Equipo equipo, double duracion) : base(titulo, año, puntuacion, genero, equipo)
        {
            this.duracion = duracion;
        }

        public double DuracionEnMinutos
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
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Titulo: {this.Titulo}");
            sb.AppendLine("Película");
            sb.AppendLine($"{this.AñoDeLanzamiento}");
            sb.AppendLine($"Género: {this.Genero}");
            sb.AppendLine($"Duración: {this.DuracionEnMinutos}");
            sb.AppendLine($"Puntuación: {this.Puntuacion}");
            sb.AppendLine(this.equipo.Mostrar());


            return sb.ToString();
        }


        public static bool operator ==(Pelicula pelicula1, Pelicula pelicula2)
        {
            if(pelicula1.titulo == pelicula2.titulo && pelicula1.añoLanzamiento==pelicula2.añoLanzamiento)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Pelicula pelicula1, Pelicula pelicula2)
        {
            return !(pelicula1 == pelicula2);
        }

        
    }
}
