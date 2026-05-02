using LogicaNegocio.Entidades;


public static class MapperPrestamo
{
    public static Prestamo FromDtoAlta(PrestamoAltaDTO dto, Telescopio t, Montura m)
    {    
        //VER 
        return new Prestamo
        {
            SocioId = dto.SocioId,
            Telescopio = t,
            Montura = m,
            FechaInicio = dto.FechaInicio,
            FechaFin = dto.FechaFin,
            Estado = "EN PRÉSTAMO" 
        };
    }
}