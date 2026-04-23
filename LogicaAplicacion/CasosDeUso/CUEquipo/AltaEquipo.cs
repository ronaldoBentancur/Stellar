using CasosUso.DTOs.DTOEquipo;
using CasosUso.InterfacesCU.ICUEquipo;
using LogicaNegocio.InterfacesRepositorio;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaAplicacion.CasosDeUso.CUEquipo
{
    public class AltaEquipo : IAltaEquipo
    {
        public IRepositorioEquipos Repo { get; set; }
        public AltaEquipo(IRepositorioEquipos repo)
        {
            Repo = repo;
        }
        public void EjecutarAltaEquipo(EquipoDTO equipo)
        {
            //falta implementar
            
        }
    }
}
