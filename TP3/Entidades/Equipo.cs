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

        
        public Equipo(string director, string escritor, List<string> actores)
        {
            this.director = director;
            this.escritor = escritor;
            this.actores = actores;
        }

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

        public override string ToString()
        {
            return this.Mostrar();
        }




    }
}
