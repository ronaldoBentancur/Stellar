using System;
using System.Collections.Generic;
using System.Text;

namespace CasosUso.DTOs.DTOEquipo
{
    public abstract class EquipoDTO
    {
        public int? Id { get; set; }
        public string TipoEquipo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int CantidadDisponible { get; set; }
    }
}
