using System;

namespace Entidades
{
    public class ArchivoIncorrectoException : Exception
    {
        public ArchivoIncorrectoException(string mensaje)
            : base(mensaje)
        {

        }
    }
}