using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions
{
    public class DatoInvalidoException : Exception
    {
        public DatoInvalidoException() { }
        public DatoInvalidoException(string message) : base(message) { }// Constructor que acepta un mensaje personalizado
        public DatoInvalidoException(string message, Exception inner) : base(message, inner) { }// Constructor que acepta un mensaje personalizado y una excepción interna (StackTrace)

    }
}
