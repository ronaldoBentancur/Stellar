using CasosUso.DTOs;
using LogicaAplicacion.DTOs;
using LogicaNegocio.Entidades;
using LogicaNegocio.Enumerados;
using LogicaNegocio.ValueObjects;
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




        //  Alta Usuario

        public static Usuario FromDtoAltaU(AltaUsuarioDTO dto)
        {
            if (dto != null)
            {
                Usuario nuevoUsuario = new Usuario()
                {
                    Nombre = dto.Nombre,
                    Apellido = dto.Apellido,
                    NombreUsuario = dto.NombreUsuario,
                    Direccion = dto.Direccion,
                    Telefono = dto.Telefono,

                    // Usamos los paréntesis para pasar el dato
                    Email = new Email(dto.Email),
                    Password = new Password(dto.Password),
                    // Convierte el texto del DTO a enum con el Parse. 
                    Rol = Enum.Parse<Rol>(dto.Rol)

                };

                return nuevoUsuario;
            }
            return null;
        }




    }
}




