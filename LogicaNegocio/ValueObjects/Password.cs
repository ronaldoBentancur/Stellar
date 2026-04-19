using LogicaNegocio.InterfaceNegocio;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaNegocio.ValueObjects
{
    public class Password : IValidable
    {
        public string Value { get; private set; }

        
        public void Validar()
        {
            //Borrar no va, solo para prueba
            if (string.IsNullOrWhiteSpace(Value))
            {
                throw new ArgumentException("La contraseña no puede estar vacía.");
            }
            
            
        }


    }
}
