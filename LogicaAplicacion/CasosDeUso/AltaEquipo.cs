using CasosUso.DTOs;
using CasosUso.InterfacesCU;
using LogicaNegocio.InterfacesRepositorio;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaAplicacion.CasosDeUso
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
