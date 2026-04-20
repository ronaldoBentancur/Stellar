using CasosUso.DTOs;
using CasosUso.InterfacesCU;
using LogicaAplicacion.Mappers;
using LogicaAccesoDatos.Repositorios;
using LogicaNegocio.Entidades;
using LogicaNegocio.InterfacesRepositorio;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaAplicacion.CasosDeUso
{
    public class Login : ILogin
    {
        public IRepositorioUsuarios Repo { get; set; }

        public Login(IRepositorioUsuarios repo)
        {
            Repo = repo;
        }

        public UsuarioDTO EjecutarLogin(string email, string password)
        {
            Usuario usuario = Repo.Login(email, password);
            UsuarioDTO dto = MapperUsuario.ToDTO(usuario);
            return dto;
        }
    }
}
