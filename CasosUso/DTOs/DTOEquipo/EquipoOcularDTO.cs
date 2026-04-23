using System;
using System.Collections.Generic;
using System.Text;

namespace CasosUso.DTOs.DTOEquipo
{
    public class EquipoOcularDTO : EquipoDTO
    {
        public decimal AnguloOcular { get; set; }
        public decimal Diametro { get; set; }
    }
}
