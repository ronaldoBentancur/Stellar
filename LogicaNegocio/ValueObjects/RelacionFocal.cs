using LogicaNegocio.InterfaceNegocio;
using Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LogicaNegocio.ValueObjects
{
    [ComplexType]
    public class RelacionFocal : IEquatable<RelacionFocal>
    {
        public int Value { get; private set; }

        public RelacionFocal() { }

        public RelacionFocal(int value)
        {
            Value = value;
            Validar();
        }
        private void Validar()
        {
            //No chequeo el valor null ya que C# no permite que un int sea null, si se quisiera permitir null se debería usar int? y agregar la validación correspondiente.
            if (Value <= 0) throw new DatoInvalidoException("La relación focal debe ser un número entero positivo.");
        }
       
        public override string ToString()
        {
            return "f/" + Value.ToString();
        }

        public bool Equals(RelacionFocal other)
        {
            if (other == null) return false;
            return this.Value.Equals(other.Value);
        }
    }
}
