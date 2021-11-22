using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class ExtensionFloat
    {
        /// <summary>
        /// metodo de extension que permite comparar un float con otro 
        /// </summary>
        /// <param name="numero"></param>
        /// <param name="numero2"></param>
        /// <returns>devuelve 1 si el numero de la instancia en donde se utiliza el metodo es menor que 
        /// el numero que se pasa por parametros</returns>
        public static int CompararSiEsMenor(this float numero, float numero2)
        {
            if(numero < numero2)
            {
                return 1;
            }
            else if(numero > numero2)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
