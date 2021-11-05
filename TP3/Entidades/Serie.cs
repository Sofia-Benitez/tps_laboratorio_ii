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

        public int CantidadDeTemporadas
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

        public int AñoDeFinalizacion
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

        public Serie(string titulo, int año, float puntuacion, string genero, Equipo equipo, int temporadas)
            : base(titulo, año, puntuacion, genero, equipo)
        {
            this.temporadas = temporadas;
        }

        public Serie(string titulo, int año, float puntuacion, string genero, Equipo equipo, int temporadas, int añoFinalizacion) 
            : this(titulo, año, puntuacion, genero, equipo, temporadas)
        {
            this.añoFinalizacion = añoFinalizacion;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Titulo: {this.Titulo}");
            sb.AppendLine("Serie de TV");
            sb.AppendLine($"{this.AñoDeLanzamiento}-");
            if(añoFinalizacion!=0)
            {
                sb.Append($"{this.AñoDeFinalizacion} ");
            }
            sb.AppendLine($"Temporadas emitidas: {this.CantidadDeTemporadas}");
            sb.AppendLine($"Género: {this.Genero}");
            sb.AppendLine($"Puntuación: {this.Puntuacion}");
            sb.AppendLine(this.equipo.Mostrar());


            return sb.ToString();
        }

        public static bool operator ==(Serie serie1, Serie serie2)
        {
            if (serie1.titulo == serie2.titulo && serie1.añoLanzamiento == serie2.añoLanzamiento)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Serie serie1, Serie serie2)
        {
            return !(serie1 == serie2);
        }
    }
}
