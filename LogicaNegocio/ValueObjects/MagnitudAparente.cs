using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LogicaNegocio.ValueObjects
{
    [ComplexType]
    public class MagnitudAparente:IEquatable<MagnitudAparente>
    {
       public decimal Value { get; private set; }
       
        public MagnitudAparente(decimal value)
        {
            Value = value;
            Validar();
        }

        public void Validar()
        {

        }

        public bool Equals(MagnitudAparente other)
        {
            if (other == null) return false;
            return this.Value.Equals(other.Value);
        }
    }
}
