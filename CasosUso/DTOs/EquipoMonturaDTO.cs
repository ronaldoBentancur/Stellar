using System;
using System.Collections.Generic;
using System.Text;
using LogicaNegocio.Enumerados;

namespace CasosUso.DTOs
{
    public class EquipoMonturaDTO : EquipoDTO
    {
        public TipoMontura TipoMontura { get; set; }
        public decimal CapacidadCarga { get; set; }
        public bool EsGoTo { get; set; }
    }
}
