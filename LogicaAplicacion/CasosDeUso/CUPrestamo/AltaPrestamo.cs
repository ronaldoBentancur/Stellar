//using logicaaplicacion.dtos;
//using logicaaplicacion.interfacescasosuso;
//using logicaaplicacion.mappers;
//using logicanegocio.entidades;
//using logicanegocio.interfacesrepositorio;
//using system;
//using system.collections.generic;
//using system.text;

//namespace logicaaplicacion.casosdeuso
//    // ver capacidad dto y los repo
//{
//    public class altaprestamo
//    {
//        public interface icualtaprestamo
//        {
//            void ejecutar(prestamoaltadto dto);
//        }
//    }



//    public class cualtaprestamo : icualtaprestamo
//    {
//        private readonly irepositorioprestamos _repoprestamos;
//        private readonly irepositorioequipos _repoequipos;
//        //private readonly irepositoriosocios _reposocios; // clase socios

//        public cualtaprestamo(irepositorioprestamos repop, irepositorioequipos repoe) //irepositoriosocios repos)
//        {
//            _repoprestamos = repop;
//            _repoequipos = repoe;
//            //_reposocios = repos;
//        }

//        public void ejecutaralta(prestamoaltadto dto)
//        {
//            // 1. validaciones 
//            if (dto.socioid == 0) throw new exception("debe seleccionar un socio.");
//            if (dto.telescopioid == 0) throw new exception("debe seleccionar un telescopio.");
//            if (dto.monturaid == 0) throw new exception("debe seleccionar una montura.");
//            if (dto.fechafin <= dto.fechainicio) throw new exception("la fecha de fin debe ser posterior a la de inicio.");

            
//            if (dto.camaraid == null && dto.ocularid == null) throw new exception("debe solicitar al menos una cámara o un ocular.");

//            base de datos para validar cuando tengamos la bd
//            var telescopio = _repoequipos.getbyid(dto.telescopioid) as telescopio;
//            var montura = _repoequipos.getbyid(dto.monturaid) as montura;

//            if (telescopio == null || montura == null) throw new exception("equipo no encontrado.");

           

//            // regla de peso
//            if (telescopio.peso > montura.cargautil) throw new exception("la montura no soporta el peso del telescopio solicitado.");

//            // regla de stock
//            if (telescopio.cantidad <= 0) throw new exception("no hay stock disponible del telescopio.");
//            if (montura.cantidad <= 0) throw new exception("no hay stock disponible de la montura.");

//            // regla de cámara 
//            if (dto.camaraid != null)
//            {
//                var camara = _repoequipos.getbyid(dto.camaraid.value) as camara;
//                if (camara == null) throw new exception("cámara no encontrada.");
//                if (camara.cantidad <= 0) throw new exception("no hay stock de la cámara.");

//                if (montura.tipo != "ecuatorial" && montura.tipo != "hibrida")
//                    throw new exception("para prestar una cámara, la montura debe ser ecuatorial o híbrida.");
//            }

//            // 4. mapeo ver dto
           
//            prestamo nuevoprestamo = mapperprestamo.fromdtoalta(dto, telescopio, montura);

//            // actualizamos el stock 
//            telescopio.cantidad--;
//            montura.cantidad--;
//            // (hacer lo mismo con cámara u ocular)

//            _repoprestamos.add(nuevoprestamo);
//            _repoprestamos.savechanges();
//        }
//    }

//}
