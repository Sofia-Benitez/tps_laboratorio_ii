using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// No podrá tener clases heredadas.
    /// </summary>
    public sealed class Taller
    {
        private List<Vehiculo> vehiculos;
        private int espacioDisponible;
        public enum ETipo
        {
            Ciclomotor, Sedan, SUV, Todos
        }

        
        #region "Constructores"
        /// <summary>
        /// Constructor que inicializa la lista de vehiculos.
        /// </summary>
        private Taller()
        {
            this.vehiculos = new List<Vehiculo>();
        }
        /// <summary>
        /// Constructor que recibe por parametro el espacio disponible
        /// </summary>
        /// <param name="espacioDisponible"></param>
        public Taller(int espacioDisponible):this()
        {
            this.espacioDisponible = espacioDisponible;
        }
        #endregion

        #region "Sobrecargas"
        /// <summary>
        /// Sobrecarha del metodo ToString(). Llama al metodo listar pasando como tipo todos los vehiculos. Muestro el estacionamiento y TODOS los vehículos
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Taller.Listar(this, ETipo.Todos);
        }
        #endregion

        #region "Métodos"

        /// <summary>
        /// Expone los datos del elemento y su lista (incluidas sus herencias)
        /// SOLO del tipo requerido
        /// </summary>
        /// <param name="taller">Elemento a exponer</param>
        /// <param name="ETipo">Tipos de ítems de la lista a mostrar</param>
        /// <returns></returns>
        public static string Listar(Taller taller, ETipo tipo)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Tenemos {taller.vehiculos.Count} lugares ocupados de un total de {taller.espacioDisponible} disponibles");
            sb.AppendLine("");
            foreach (Vehiculo vehiculo in taller.vehiculos)
            {
                switch (tipo)
                {
                    case ETipo.SUV:
                        if(vehiculo is Suv)
                        {
                            sb.AppendLine(vehiculo.Mostrar());
                        }
                        
                        break;
                    case ETipo.Ciclomotor:
                        if(vehiculo is Ciclomotor)
                        {
                            sb.AppendLine(vehiculo.Mostrar());
                        }
                        
                        break;
                    case ETipo.Sedan:
                        if(vehiculo is Sedan)
                        {
                            sb.AppendLine(vehiculo.Mostrar());
                        }
                        
                        break;
                    default:
                        sb.AppendLine(vehiculo.Mostrar());
                        break;
                }
            }

            return sb.ToString();
        }
        #endregion

        #region "Operadores"
        /// <summary>
        /// Sobrecarga del operador +. Agregará un elemento a la lista
        /// </summary>
        /// <param name="taller">Objeto donde se agregará el elemento</param>
        /// <param name="vehiculo">Objeto a agregar</param>
        /// <returns></returns>
        public static Taller operator +(Taller taller, Vehiculo vehiculo)
        {
            if(taller.vehiculos.Count<taller.espacioDisponible)
            {
                foreach (Vehiculo v in taller.vehiculos)
                {
                    if (v == vehiculo)
                    {
                        return taller;
                    }
                }

                taller.vehiculos.Add(vehiculo);
                
            }
            return taller;
        }
        /// <summary>
        /// Sobrecarga del operador -. Quitará un elemento de la lista
        /// </summary>
        /// <param name="taller">Objeto donde se quitará el elemento</param>
        /// <param name="vehiculo">Objeto a quitar</param>
        /// <returns></returns>
        public static Taller operator -(Taller taller, Vehiculo vehiculo)
        {
            foreach (Vehiculo v in taller.vehiculos)
            {
                if (v == vehiculo)
                {
                    taller.vehiculos.Remove(vehiculo);
                    break;
                }
            }

            return taller;
        }
        #endregion
    }
}
