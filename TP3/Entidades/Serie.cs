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

        public Serie(int id, string titulo, int añoLanzamiento, float puntuacion, string genero, Equipo equipo, int temporadas, int añoFinalizacion)
            : base(id, titulo, añoLanzamiento, puntuacion, genero, equipo)
        {
            this.temporadas = temporadas;
            this.añoFinalizacion = añoFinalizacion;
        }

       

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

        public override bool Equals(object obj)
        {
            Serie serie = obj as Serie;

            return serie is not null && this == serie;
        }

        public override int GetHashCode()
        {
            return (titulo, añoLanzamiento).GetHashCode();
        }
    }
}
