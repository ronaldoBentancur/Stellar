using LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaNegocio.InterfacesRepositorio
{
    public interface IRepositorioUsuarios: IRepositorio<Usuario>
    {
        Usuario Login(string email, string password);
    }

    public interface IRepositorioUsuario : IRepositorio<Usuario>
    {
        Usuario Add(string email, string password, string nombre, string apellido, string nombreUsuario, string direccion, string telefono, string rol);
    }
}
