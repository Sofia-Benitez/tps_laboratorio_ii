using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
        /// <summary>
        /// Valida que el operador seleccionado sea * / + o -. Si no es ninguno de estos devuelve +
        /// </summary>
        /// <param name="operador">char operador que se debe validar </param>
        /// <returns>devuelve el operador selecciondo</returns>
        private static char ValidarOperador(char operador)
        {
            if((operador == '+') || (operador == '-') || (operador == '/') || (operador == '*'))
            {
                return operador;
            }
            else
            {
                return '+';
            }
        }

        /// <summary>
        /// funcion que realiza la operacion correspondiente segun el operando que es validado previamente 
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="operador"></param>
        /// <returns></returns>
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            char operadorValidado = Calculadora.ValidarOperador(operador);

            double resultado;

            switch(operadorValidado)
            {
                case '-':
                    resultado = num1 - num2;
                    break;
                case '/':
                    resultado = num1 / num2;
                    break;
                case '*':
                    resultado = num1 * num2;
                    break;
                default:
                    resultado = num1 + num2;
                    break;
                
            }


            return resultado;
            
        }
    }
}
