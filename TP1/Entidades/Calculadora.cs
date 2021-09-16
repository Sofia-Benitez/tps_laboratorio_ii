using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
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
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            char operadorValidado = Calculadora.ValidarOperador(operador);

            double resultado;

            switch(operadorValidado)
            {
                case '+':
                    resultado=num1 + num2;
                    break;
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
                    resultado = -999999999999;
                    break;
            }


            return resultado;
            
        }
    }
}
