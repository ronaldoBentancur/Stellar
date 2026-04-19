using LogicaNegocio.InterfaceNegocio;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaNegocio.ValueObjects
{
    public class Email : IValidable
    {
        public string Value { get; private set; }


        public void Validar()
        {
            if (string.IsNullOrWhiteSpace(Value))
            {
                throw new ArgumentException("El email no puede estar vacío.");
            }
            if (!Value.Contains("@"))
            {
                throw new ArgumentException("El email debe contener '@'.");
            }
        }
    }
}
