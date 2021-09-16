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

        public Operando()
        {
            this.numero = 0;
        }

        private string Numero
        {
            set
            {
                this.numero = ValidarOperando(value);
            }
        }

        public Operando(string strNumero)
        {
            this.Numero = strNumero;
        }

        public Operando(double numero)
        {
            this.numero = numero;
        }

        private double ValidarOperando(string strNumero)
        {
            double numero;
            bool esNumerico = double.TryParse(strNumero, out numero);
            if(esNumerico==false)
            {
                return 0;
            }

            return numero;
        }

        //sobrecarga de operadores

        public static double operator -(Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }

        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }

        public static double operator /(Operando n1, Operando n2)
        {
            if(n2.numero==0)
            {
                return double.MinValue;
            }
            return n1.numero / n2.numero;
        }

        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }

        //calculos binarios

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

        public static string BinarioDecimal(string binario)
        {
            if(Operando.EsBinario(binario))
            {
                uint binarioInt = uint.Parse(binario);
                uint decimalResultado = Convert.ToUInt32(binarioInt.ToString(), 2);
                return decimalResultado.ToString();
            }
            
            return "Valor invalido";
        }

        public static string DecimalBinario(double numero)
        {
            uint numeroInt = (uint)numero;
            string binarioResultado = Convert.ToString(numeroInt, 2);
            return binarioResultado;
        }

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
