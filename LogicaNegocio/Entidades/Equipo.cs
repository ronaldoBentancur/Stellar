using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaNegocio.Entidades
{
    public abstract class Equipo
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int CantidadDisponible { get; set; }
    }
}
