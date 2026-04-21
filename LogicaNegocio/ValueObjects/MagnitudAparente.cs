using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LogicaNegocio.ValueObjects
{
    [ComplexType]
    public class MagnitudAparente
    {
       public decimal Value { get; private set; }
        
    }
}
