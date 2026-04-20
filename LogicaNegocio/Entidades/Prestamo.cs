using LogicaNegocio.Entidades;
using LogicaNegocio.Enumerados;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaNegocio.Entidades
{
    public class Prestamo
    {
        public int Id { get; set; }
        public int SocioId { get; set; }
        public Telescopio Telescopio { get; set; }
        public Montura Montura { get; set; }
        public Camara Camara { get; set; }
        public Ocular Ocular { get; set; }
        public EstadoPrestamo EstadoPrestamo { get; set; }

    }
}
