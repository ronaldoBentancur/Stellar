using CasosUso.DTOs;
using LogicaNegocio.Entidades;
using LogicaNegocio.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaAplicacion.Mappers
{
    public class MapperEquipo
    {
        public static EquipoDTO ToDTO(Equipo equipo)
        {
            if (equipo is Camara camara)
            {
                return new EquipoCamaraDTO()
                {
                    Id = camara.Id,
                    TipoEquipo = "Camara",
                    Marca = camara.Marca,
                    Modelo = camara.Modelo,
                    CantidadDisponible = camara.CantidadDisponible,
                    TipoSensor = camara.TipoSensor,
                    Resolucion = camara.Resolucion,
                    TamanioPixel = camara.TamanioPixel
                };
            }
            else if(equipo is Telescopio telescopio)
            {
                return new EquipoTelescopioDTO()
                {
                    Id = telescopio.Id,
                    TipoEquipo = "Telescopio",
                    Marca = telescopio.Marca,
                    Modelo = telescopio.Modelo,
                    CantidadDisponible = telescopio.CantidadDisponible,
                    Apertura = telescopio.Apertura,
                    RelacionFocal = telescopio.RelacionFocal.Value,//Aca con el .Value accedo al valor int que guarda el VO.
                    DistanciaFocal = telescopio.DistanciaFocal,
                    Peso = telescopio.Peso,
                };
            }
            else if (equipo is Montura montura)
            {
                return new EquipoMonturaDTO()
                {
                    Id = montura.Id,
                    TipoEquipo = "Montura",
                    Marca = montura.Marca,
                    Modelo = montura.Modelo,
                    CantidadDisponible = montura.CantidadDisponible,
                    TipoMontura = montura.TipoMontura,
                    CapacidadCarga = montura.CargaUtil,
                    EsGoTo = montura.EsGoTo
                };
            }
            else if (equipo is Ocular ocular)
            {
                return new EquipoOcularDTO()
                {
                    Id = ocular.Id,
                    TipoEquipo = "Ocular",
                    Marca = ocular.Marca,
                    Modelo = ocular.Modelo,
                    CantidadDisponible = ocular.CantidadDisponible,
                    AnguloOcular = ocular.AnguloOcular,
                    Diametro = ocular.Diametro
                };
            }
            //Agregar una excepcion personalizada para el caso de que el tipo de equipo no sea reconocido
            return null;
        }

        public static Equipo ToEquipo(EquipoDTO equipoDTO)
        {
            if(equipoDTO is EquipoCamaraDTO camaraDTO)
            {
                return new Camara()
                {
                    Id = camaraDTO.Id??0,
                    Marca = camaraDTO.Marca,
                    Modelo = camaraDTO.Modelo,
                    CantidadDisponible = camaraDTO.CantidadDisponible,
                    TipoSensor = camaraDTO.TipoSensor,
                    Resolucion = camaraDTO.Resolucion,
                    TamanioPixel = camaraDTO.TamanioPixel
                };
            }
            else if(equipoDTO is EquipoTelescopioDTO telescopioDTO)
            {
                return new Telescopio()
                {
                    Id = telescopioDTO.Id??0,
                    Marca = telescopioDTO.Marca,
                    Modelo = telescopioDTO.Modelo,
                    CantidadDisponible = telescopioDTO.CantidadDisponible,
                    Apertura = telescopioDTO.Apertura,
                    RelacionFocal = new RelacionFocal(telescopioDTO.RelacionFocal),//Aca creo un nuevo VO relacion focal a partir del int que viene en el DTO.
                    DistanciaFocal = telescopioDTO.DistanciaFocal,
                    Peso = telescopioDTO.Peso
                };
            }
            else if(equipoDTO is EquipoMonturaDTO monturaDTO)
            {
                return new Montura()
                {
                    Id = monturaDTO.Id??0,
                    Marca = monturaDTO.Marca,
                    Modelo = monturaDTO.Modelo,
                    CantidadDisponible = monturaDTO.CantidadDisponible,
                    TipoMontura = monturaDTO.TipoMontura,
                    CargaUtil = monturaDTO.CapacidadCarga,
                    EsGoTo = monturaDTO.EsGoTo
                };
            }
            else if(equipoDTO is EquipoOcularDTO ocularDTO)
            {
                return new Ocular()
                {
                    Id = ocularDTO.Id??0,
                    Marca = ocularDTO.Marca,
                    Modelo = ocularDTO.Modelo,
                    CantidadDisponible = ocularDTO.CantidadDisponible,
                    AnguloOcular = ocularDTO.AnguloOcular,
                    Diametro = ocularDTO.Diametro
                };
            }

            return null;
        }
    }
}
