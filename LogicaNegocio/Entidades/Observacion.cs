using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LogicaNegocio.Entidades
{
    public class Observacion
    {
        public int id { get; set; }
        public int PrestamoId { get; set; }
        public int ObjetoCelesteId { get; set; }
        public DateTime FechaObservacion { get; set; }
        public string Indicador { get; set; }
        [MaxLength(300)]
        public string Detalle { get; set; }
    }
}
