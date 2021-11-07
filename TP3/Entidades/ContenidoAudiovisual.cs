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

        /// <summary>
        /// Constructor de la clase abstracta ContenidoAudiovisual
        /// </summary>
        /// <param name="id"></param>
        /// <param name="titulo"></param>
        /// <param name="añoLanzamiento"></param>
        /// <param name="puntuacion"></param>
        /// <param name="genero"></param>
        /// <param name="equipo"></param>
        protected ContenidoAudiovisual(int id, string titulo, int añoLanzamiento, float puntuacion, string genero, Equipo equipo)
        {
            this.id=id;
            this.titulo = titulo;
            this.añoLanzamiento = añoLanzamiento;
            this.puntuacion = puntuacion;
            this.genero = genero;
            this.equipo = equipo;
        }

        /// <summary>
        /// Propiedad Id, permite leer y escribir el atributo
        /// </summary>
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

        /// <summary>
        /// Propiedad Titulo, permite leer y escribir el atributo
        /// </summary>
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

        /// <summary>
        /// Propiedad AñoLanzamiento, permite leer y escribir el atributo
        /// </summary>
        public int AñoLanzamiento
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

        /// <summary>
        /// Propiedad Puntuacion, permite leer y escribir el atributo
        /// </summary>
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

        /// <summary>
        /// Propiedad Genero, permite leer y escribir el atributo
        /// </summary>
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

        /// <summary>
        /// Propiedad Equipo, permite leer y escribir el atributo
        /// </summary>
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

        /// <summary>
        /// Método abstracto Mostrar() 
        /// </summary>
        /// <returns></returns>
        public abstract string Mostrar();
        
    }
}
