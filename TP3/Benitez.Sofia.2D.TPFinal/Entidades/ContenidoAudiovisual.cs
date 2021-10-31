using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class ContenidoAudiovisual
    {
        protected int id;
        protected string titulo;
        protected int añoLanzamiento;
        protected float puntuacion;
        protected string genero;
        protected Equipo equipo;

        public ContenidoAudiovisual(string titulo, int año, float puntuacion, string genero, Equipo equipo)
        {
            this.id = 0;
            this.titulo = titulo;
            this.añoLanzamiento = año;
            this.puntuacion = puntuacion;
            this.genero = genero;
            this.equipo = equipo;
        }

        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }
        public string Titulo
        {
            get
            {
                return this.titulo;
            }
            set
            {
                this.titulo = value;
            }
        }

        public int AñoDeLanzamiento
        {
            get
            {
                return this.añoLanzamiento;
            }
            set
            {
                this.añoLanzamiento = value;
            }
        }

        public float Puntuacion
        {
            get
            {
                return this.puntuacion;
            }
            set
            {
                this.puntuacion = value;
            }
        }

        public string Genero
        {
            get
            {
                return this.genero;
            }
            set
            {
                this.genero = value;
            }
        }

        public Equipo Equipo
        {
            get
            {
                return this.equipo;
            }
            set
            {
                this.equipo = value;
            }
        }

        public abstract string Mostrar();
        
    }
}
