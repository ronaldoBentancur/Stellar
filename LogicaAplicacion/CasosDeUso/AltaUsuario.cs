using LogicaAplicacion.DTOs;
using LogicaAplicacion.InterfacesCasosUso;
using LogicaAplicacion.Mappers; 
using LogicaNegocio.Entidades;
using LogicaNegocio.InterfacesRepositorio;
using System;

namespace LogicaAplicacion.CasosUso
{
    public class CUAltaUsuario : ICUAltaUsuario
    {
        private readonly IRepositorioUsuarios _repoUsuarios;

        public CUAltaUsuario(IRepositorioUsuarios repoUsuarios)
        {
            _repoUsuarios = repoUsuarios;
        }

        public void EjecutarAlta(AltaUsuarioDTO dto)
        {
            
            if (string.IsNullOrEmpty(dto.Email)) throw new Exception("El email no puede estar vacío.");

            if (string.IsNullOrEmpty(dto.Rol)) throw new Exception("Debe seleccionar un rol para el usuario.");

            // 2. Mapeo 
            Usuario nuevoUsuario = MapperUsuario.FromDtoAltaU(dto);

            
            _repoUsuarios.Add(nuevoUsuario);
        }
    }
}