//using LogicaNegocio.InterfacesRepositorio;
//using Exceptions;
//using System;
//using System.Collections.Generic;
//using System.Text;
//using CasosUso.InterfacesCU.ICUEquipo;

//namespace LogicaAplicacion.CasosDeUso.CUEquipo
//{
//    public class BajaEquipo : IBajaEquipo
//    {
//        public IRepositorioPrestamos Repo { get; set; }
//        public IRepositorioEquipos RepoEquipo { get; set; }
//        public BajaEquipo(IRepositorioPrestamos repo, IRepositorioEquipos repoEquipo)
//        {
//            Repo = repo;
//            RepoEquipo = repoEquipo;
//        }

//        public void EjecutarBajaEquipo(int idEquipo)
//        {
//            bool estado = Repo.EstadoPrestamo(idEquipo);
//            if (estado) throw new EnPrestamoException("No se puede eliminar el equipo porque tiene un préstamo activo");
//            //RepoEquipo.BajaEquipo(idEquipo); No implementado a nivel AccesoDatos.
//        }
//    }
//}