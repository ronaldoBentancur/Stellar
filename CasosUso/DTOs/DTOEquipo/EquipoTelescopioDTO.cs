using System;
using System.Collections.Generic;
using System.Text;

namespace CasosUso.DTOs.DTOEquipo
{
    public class EquipoTelescopioDTO : EquipoDTO
    {
        public decimal Apertura { get; set; }
        public int RelacionFocal { get; set; }
        public decimal DistanciaFocal { get; set; }
        public decimal Peso { get; set; }
    }
}
