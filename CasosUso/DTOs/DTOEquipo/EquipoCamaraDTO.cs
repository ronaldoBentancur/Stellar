using System;
using System.Collections.Generic;
using System.Text;

namespace CasosUso.DTOs.DTOEquipo
{
    public class EquipoCamaraDTO : EquipoDTO
    {        
        public string TipoSensor { get; set; }
        public string Resolucion { get; set; }
        public decimal TamanioPixel { get; set; }
    }
}
