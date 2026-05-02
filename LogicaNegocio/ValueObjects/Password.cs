using LogicaNegocio.InterfaceNegocio;
using Exceptions;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace LogicaNegocio.ValueObjects
{
    [ComplexType]
    public class Password : IEquatable<Password>
    {
        public string Value { get; private set; }

        public Password() { }

        public Password(string value)
        {
            Value = value;
            Validar();
        }

        private void Validar()
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
            if (!Value.Any(char.IsPunctuation))
            {

                throw new DatoInvalidoException("La contraseña no debe contener caracteres especiales.");
            }
            if (Value.Length < 8)
            {
                throw new DatoInvalidoException("La contraseña debe tener al menos 8 caracteres.");
            }
        }

        public bool Equals(Password other)
        {
            if (other == null) return false;
            return this.Value.Equals(other.Value);
        }
    }
}