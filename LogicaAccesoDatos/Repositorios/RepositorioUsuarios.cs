using LogicaNegocio.Entidades;
using LogicaNegocio.Enumerados;
using LogicaNegocio.InterfacesRepositorio;
using LogicaNegocio.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaAccesoDatos.Repositorios
{
    public class RepositorioUsuarios : IRepositorioUsuarios
    {
        private static List<Usuario> usuarios = new List<Usuario>()
        {
            new Usuario()
            {
                Id = 1,
                Nombre = "Admin",
                Apellido = "Sistema",
                NombreUsuario = "admin1",
                Direccion = "Calle 123",
                Telefono = "099111222",
                Email = new Email("admin@sistema.com"),
                Password = new Password("Admin1234"),
                Rol = Rol.Administrados
            },
            new Usuario()
            {
                Id = 2,
                Nombre = "Socio",
                Apellido = "Prueba",
                NombreUsuario = "socio1",
                Direccion = "Calle 456",
                Telefono = "099333444",
                Email = new Email("socio@sistema.com"),
                Password = new Password("Socio1234"),
                Rol = Rol.Socio
            }
        };

        public void Add(Usuario nuevo)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Usuario> FindAll()
        {
            return usuarios;
        }

        public Usuario FindById(int id)
        {
            throw new NotImplementedException();
        }

        public Usuario Login(string email, string password)
        {
            foreach (Usuario usu in usuarios)
            {
                if (usu.Email.Value == email && usu.Password.Value == password) return usu;
            }

            return null;
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Usuario obj)
        {
            throw new NotImplementedException();
        }


    }
}

