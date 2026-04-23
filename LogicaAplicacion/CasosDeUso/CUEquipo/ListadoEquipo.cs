using CasosUso.DTOs.DTOEquipo;
using CasosUso.InterfacesCU.ICUEquipo;
using LogicaAplicacion.Mappers;
using LogicaNegocio.InterfacesRepositorio;
using LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
namespace LogicaAplicacion.CasosDeUso.CUEquipo;

public class ListadoEquipo : IListadoEquipos
{
    public IRepositorioEquipos Repo { get; set; }
    public ListadoEquipo(IRepositorioEquipos repo)
    {
        Repo = repo;
    }
    public IEnumerable<EquipoDTO> EjecutarListadoEquipos()
    {

        IEnumerable<Equipo> equipos = Repo.FindAll();
        List<EquipoDTO> dtos = new List<EquipoDTO>();
        foreach (Equipo equipo in equipos)
        {
            dtos.Add(MapperEquipo.ToDTO(equipo));
        }
        return dtos;
    }
}

