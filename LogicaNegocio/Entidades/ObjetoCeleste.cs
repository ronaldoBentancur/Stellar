using LogicaNegocio.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaNegocio.Entidades
{
    public class ObjetoCeleste
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public MagnitudAparente MagnitudAparente { get; set; }
    }
}
