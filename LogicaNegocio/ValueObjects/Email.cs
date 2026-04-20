using LogicaNegocio.InterfaceNegocio;
using Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaNegocio.ValueObjects
{
    public class Email : IValidable
    {
        public string Value { get; private set; }

        public Email() { }

        public Email(string value)
        {
            Value = value;
            Validar();
        }

        public void Validar()
        {
            if (string.IsNullOrEmpty(Value))
            {
                throw new DatoInvalidoException("El email no puede estar vacío.");
            }
            if (!Value.Contains("@"))
            {
                throw new DatoInvalidoException("El email debe contener '@'.");
            }
        }
    }
}
