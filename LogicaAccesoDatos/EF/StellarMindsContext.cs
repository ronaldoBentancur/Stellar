using LogicaNegocio.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaAccesoDatos.EF
{
    public class StellarMindsContext:DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }


        public StellarMindsContext(DbContextOptions<StellarMindsContext> options) : base(options)
        {
        }
    }   
}
