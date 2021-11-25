using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operando
    {
        private double numero;

        /// <summary>
        /// Constructor que inicializa el atributo numero en 0
        /// </summary>
        public Operando():this(0)
        {
            
        }

        /// <summary>
        /// constructor que recibe un numero en string y lo asigna mediante la propiedad Numero
        /// </summary>
        /// <param name="strNumero"></param>
        public Operando(string strNumero)
        {
            this.Numero = strNumero;
        }

        /// <summary>
        /// Constructor que recibe un double y lo asigna al atributo numero
        /// </summary>
        /// <param name="numero"></param>
        public Operando(double numero)
        {
            this.numero = numero;
        }

        /// <summary>
        /// propiedad numero permite asignarle valor al atributo numero utilizando el metodo ValidarOperando();
        /// </summary>
        private string Numero
        {
            set
            {
                this.numero = ValidarOperando(value);
            }
        }

        


        /// <summary>
        /// Metodo que parsea un string y si es una cadena de numeros devuelve el numero en double, si no lo es devuelve 0
        /// </summary>
        /// <param name="strNumero">cadena a analizar</param>
        /// <returns></returns>
        private double ValidarOperando(string strNumero)
        {
            
            if(!double.TryParse(strNumero, out double numero))
            {
                return 0;
            }

            return numero;
        }


        //sobrecarga de operadores


        /// <summary>
        /// sobrecarga del operador - para restar los atributos numero de objetos del tipo Operando
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator -(Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }


        /// <summary>
        /// sobrecarga del operador + para sumar los atributos numero de objetos del tipo Operando
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }


        /// <summary>
        /// sobrecarga del operador / para dividir los atributos numero de objetos del tipo Operando, 
        /// si el operando 2 es 0 devuelve el valor minimo posible
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator /(Operando n1, Operando n2)
        {
            if(n2.numero==0)
            {
                return double.MinValue;
            }
            return n1.numero / n2.numero;
        }


        /// <summary>
        /// sobrecarga del operador * para multiplicar los atributos numero de objetos del tipo Operando
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }

        //calculos binarios

        /// <summary>
        /// analiza una cadena y devuelve true si todos sus caracteres son 0 o 1
        /// </summary>
        /// <param name="binario">cadena a analizar </param>
        /// <returns></returns>
        private static bool EsBinario(string binario)
        {
            foreach (char item in binario)
            {
                if (item != '0' && item != '1')
                {
                    return false;
                }
                
            }
            return true;
        }


        /// <summary>
        /// valida si la cadena es un numero binario,  y si lo es lo convierte a entero para convertirlo a decimal
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns>
        public static string BinarioDecimal(string binario)
        {
            

            if (Operando.EsBinario(binario) && binario.Length < 8)
            {
                ulong binarioInt = uint.Parse(binario);
                uint decimalResultado = Convert.ToUInt32(binarioInt.ToString(), 2);
                return decimalResultado.ToString();
            }
            
            return "Valor invalido";
        }


        /// <summary>
        /// convierte un numero decimal double a binario y lo devuelve como string
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public static string DecimalBinario(double numero)
        {
            uint numeroInt = (uint)numero;
            string binarioResultado = Convert.ToString(numeroInt, 2);
            return binarioResultado;
        }

        /// <summary>
        /// sobrecarga del metodo DecimalBinario() que recibe una cadena y devuelve una cadena
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public static string DecimalBinario(string numero)
        {
            if(numero != "Valor invalido")
            {
                double numeroDouble = double.Parse(numero);
                return DecimalBinario(numeroDouble);
            }
            return "Valor invalido";

        }


    }
}
