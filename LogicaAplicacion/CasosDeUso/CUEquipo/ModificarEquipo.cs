using System;
using System.Collections.Generic;
using System.Text;
using CasosUso.InterfacesCU.ICUEquipo;
using LogicaNegocio.InterfacesRepositorio;
using LogicaNegocio.Entidades;
using LogicaAplicacion.Mappers;
using CasosUso.DTOs.DTOEquipo;

namespace LogicaAplicacion.CasosDeUso.CUEquipo
{
    public class ModificarEquipo : IModificarEquipo
    {
        public IRepositorioEquipos Repo { get; set; }
        public ModificarEquipo(IRepositorioEquipos repo)
        {
            Repo = repo;
        }
        
        public void EjecutarModificarEquipo(EquipoDTO dto)
        {
            // Como el Mapper me puede devolver cualquiera de los tipos de equipo, guardo en un var para que no haya conflicto de tipos. El Mapper se encarga de devolver el tipo correcto según el TipoEquipo del DTO.
            var equipo = MapperEquipo.ToEquipo(dto);
            //Repo.UpDate(equipo);
        }
    }
   
}