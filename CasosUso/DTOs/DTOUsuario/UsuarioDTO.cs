using System;
using System.Collections.Generic;
using System.Text;

namespace CasosUso.DTOs
{
    public class UsuarioDTO
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Rol { get; set; }
    }
}

namespace LogicaAplicacion.DTOs
{
    public class AltaUsuarioDTO
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NombreUsuario { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        // nombre del rol ver si esta bien asi
        public string Rol { get; set; }
    }
}