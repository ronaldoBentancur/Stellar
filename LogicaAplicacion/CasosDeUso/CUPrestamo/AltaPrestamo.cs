using LogicaAplicacion.DTOs;
using LogicaAplicacion.InterfacesCasosUso;
using LogicaAplicacion.Mappers;
using LogicaNegocio.Entidades;
using LogicaNegocio.InterfacesRepositorio;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaAplicacion.CasosDeUso
    // VER CAPACIDAD DTO y los REPO
{
    public class AltaPrestamo
    {
        public interface ICUAltaPrestamo
        {
            void Ejecutar(PrestamoAltaDTO dto);
        }
    }



    public class CUAltaPrestamo : ICUAltaPrestamo
    {
        private readonly IRepositorioPrestamos _repoPrestamos;
        private readonly IRepositorioEquipos _repoEquipos;
        //private readonly IRepositorioSocios _repoSocios; // CLASE SOCIOS

        public CUAltaPrestamo(IRepositorioPrestamos repoP, IRepositorioEquipos repoE, //IRepositorioSocios repoS)
        {
            _repoPrestamos = repoP;
            _repoEquipos = repoE;
            //_repoSocios = repoS;
        }

        public void EjecutarAlta(PrestamoAltaDTO dto)
        {
            // 1. Validaciones 
            if (dto.SocioId == 0) throw new Exception("Debe seleccionar un socio.");
            if (dto.TelescopioId == 0) throw new Exception("Debe seleccionar un telescopio.");
            if (dto.MonturaId == 0) throw new Exception("Debe seleccionar una montura.");
            if (dto.FechaFin <= dto.FechaInicio) throw new Exception("La fecha de fin debe ser posterior a la de inicio.");

            
            if (dto.CamaraId == null && dto.OcularId == null) throw new Exception("Debe solicitar al menos una cámara o un ocular.");

            // Base de datos para validar cuando tengamos la BD
            var telescopio = _repoEquipos.GetById(dto.TelescopioId) as Telescopio;
            var montura = _repoEquipos.GetById(dto.MonturaId) as Montura;

            if (telescopio == null || montura == null) throw new Exception("Equipo no encontrado.");

           

            // Regla de peso
            if (telescopio.Peso > montura.CargaUtil) throw new Exception("La montura no soporta el peso del telescopio solicitado.");

            // Regla de stock
            if (telescopio.Cantidad <= 0) throw new Exception("No hay stock disponible del telescopio.");
            if (montura.Cantidad <= 0) throw new Exception("No hay stock disponible de la montura.");

            // Regla de Cámara 
            if (dto.CamaraId != null)
            {
                var camara = _repoEquipos.GetById(dto.CamaraId.Value) as Camara;
                if (camara == null) throw new Exception("Cámara no encontrada.");
                if (camara.Cantidad <= 0) throw new Exception("No hay stock de la cámara.");

                if (montura.Tipo != "Ecuatorial" && montura.Tipo != "Hibrida")
                    throw new Exception("Para prestar una cámara, la montura debe ser Ecuatorial o Híbrida.");
            }

            // 4. Mapeo ver dto
           
            Prestamo nuevoPrestamo = MapperPrestamo.FromDtoAlta(dto, telescopio, montura);

            // Actualizamos el stock 
            telescopio.Cantidad--;
            montura.Cantidad--;
            // (Hacer lo mismo con cámara u ocular)

            _repoPrestamos.Add(nuevoPrestamo);
            _repoPrestamos.SaveChanges();
        }
    }

}
