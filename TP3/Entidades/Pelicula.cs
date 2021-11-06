using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Pelicula : ContenidoAudiovisual
    {
        private double duracion;
       
        public Pelicula(int id, string titulo, int añoLanzamiento, float puntuacion, string genero, Equipo equipo, double duracion)
            : base(id, titulo, añoLanzamiento, puntuacion, genero, equipo)
        {
            this.duracion = duracion;
        }

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
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Titulo: {this.Titulo}");
            sb.AppendLine("Película");
            sb.AppendLine($"{this.AñoLanzamiento}");
            sb.AppendLine($"Género: {this.Genero}");
            sb.AppendLine($"Duración: {this.Duracion}");
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

        public override bool Equals(object obj)
        {
            Pelicula pelicula = obj as Pelicula;

            return pelicula is not null && this == pelicula;
        }

        public override int GetHashCode()
        {
            return (titulo, añoLanzamiento).GetHashCode();
        }

    }
}
