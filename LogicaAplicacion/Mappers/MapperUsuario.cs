using CasosUso.DTOs;
using LogicaNegocio.Entidades;
using LogicaNegocio.Enumerados;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaAplicacion.Mappers
{
    public class MapperUsuario
    {
        public static UsuarioDTO ToDTO(Usuario usu)
        {
            if (usu != null)
            {
                UsuarioDTO dto = new UsuarioDTO()
                {
                    // Asumiendo que tus Value Objects Email y Password tienen una propiedad 'Valor'
                    Email = usu.Email.Value, 
                    Rol = usu.Rol.ToString(),
                    Password = usu.Password.Value
                };
                return dto;
            }

            return null;
        }
    }
}
