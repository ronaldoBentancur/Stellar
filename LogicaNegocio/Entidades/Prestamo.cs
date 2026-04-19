using LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaNegocio.ClasesNegocio
{
    public class Prestamo
    {
        public int Id { get; set; }
        public int SocioId { get; set; }
        public Telescopio Telescopio { get; set; }
        public Montura Montura { get; set; }
        public Camara Camara { get; set; }
        public Ocular Ocular { get; set; }

    }
}
