using LogicaAccesoDatos.EF;
using LogicaNegocio.Entidades;
using LogicaNegocio.Enumerados;
using LogicaNegocio.InterfacesRepositorio;
using LogicaNegocio.ValueObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaAccesoDatos.Repositorios
{
    public class RepositorioUsuarios : IRepositorioUsuarios
    {
        public StellarMindsContext Contexto { get; set; }

        public RepositorioUsuarios(StellarMindsContext ctx)
        {
            Contexto = ctx;
        }

        public void Add(Usuario nuevo)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Usuario> FindAll()
        {
            throw new NotImplementedException();
        }

        public Usuario FindById(int id)
        {
            throw new NotImplementedException();
        }

        public Usuario Login(string email, string password)
        {
            Usuario? buscado = null;
            buscado = Contexto.Usuarios
                        .Where(usuario => usuario.Email.Value == email && usuario.Password.Value == password) //Filtro para encontrar el usuario.
                        .Single();//Single() devuelve un solo elemento, si no encuentra ninguno o encuentra mas de uno, lanza una excepcion

            return buscado;
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

