using LogicaNegocio.Enumerados;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaNegocio.Entidades
{
    public class Montura : Equipo
    {
        public TipoMontura TipoMontura { get; set; }
        public decimal CargaUtil { get; set; }
        public bool EsGoTo { get; set; }
    }
}
