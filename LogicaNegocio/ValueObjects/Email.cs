using LogicaNegocio.InterfaceNegocio;
using Exceptions;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace LogicaNegocio.ValueObjects
{
    [ComplexType]
    public class Email 
    {
        public string Value { get; private set; }

        public Email() { }

        public Email(string value)
        {
            Value = value;
            Validar();
        }

        private void Validar()
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
