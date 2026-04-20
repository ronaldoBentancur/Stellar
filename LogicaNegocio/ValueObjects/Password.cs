using LogicaNegocio.InterfaceNegocio;
using Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaNegocio.ValueObjects
{
    public class Password : IValidable
    {
        public string Value { get; private set; }

        public Password() { }

        public Password(string value)
        {
            Value = value;
            Validar();
        }

        public void Validar()
        {

            if (string.IsNullOrEmpty(Value))
            {
                throw new DatoInvalidoException("La contraseña no puede estar vacía.");
            }

            if (!Value.Any(char.IsUpper))
            {
                throw new DatoInvalidoException("La contraseña debe contener al menos una letra mayúscula.");
            }

            if (!Value.Any(char.IsLower))
            {
                throw new DatoInvalidoException("La contraseña debe contener al menos una letra minúscula.");
            }

            if (!Value.Any(char.IsDigit))
            {
                throw new DatoInvalidoException("La contraseña debe contener al menos un número.");
            }
            if (Value.Any(char.IsPunctuation))
            {

                throw new DatoInvalidoException("La contraseña no debe contener caracteres especiales.");
            }
            if (Value.Length < 6)
            {
                throw new DatoInvalidoException("La contraseña debe tener al menos 6 caracteres.");
            }
        }
    }
}