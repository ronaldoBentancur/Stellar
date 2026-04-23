using System;
using System.Collections.Generic;
using System.Text;
using CasosUso.DTOs.DTOEquipo;

namespace CasosUso.InterfacesCU.ICUEquipo
{
    public interface IListadoEquipos
    {
        IEnumerable<EquipoDTO> EjecutarListadoEquipos();
    }
}
