using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions
{
    public class EnPrestamoException : Exception
    {
        public EnPrestamoException() { }
        public EnPrestamoException(string message) : base(message) { }// Constructor que acepta un mensaje personalizado
        public EnPrestamoException(string message, Exception inner) : base(message, inner) { }// Constructor que acepta un mensaje personalizado y una excepción interna (StackTrace)
    }
}
