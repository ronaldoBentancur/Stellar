using LogicaNegocio.Entidades;
using LogicaNegocio.Enumerados;

public class Prestamo
{
    public Socio Socio { get; private set; }
    public Telescopio Telescopio { get; private set; }
    public Montura Montura { get; private set; }
    public Camara? Camara { get; private set; }
    public Ocular? Ocular { get; private set; }
    public DateTime FechaInicio { get; private set; }
    public DateTime FechaFin { get; private set; }
    public EstadoPrestamo Estado { get; set; }

    
    public Prestamo(Socio socio, Telescopio telescopio, Montura montura, DateTime inicio, DateTime fin, Camara? camara = null, Ocular? ocular = null)
    {
        Validar(telescopio, montura, camara);
        ValidarSeleccionMinima(camara, ocular);

        Socio = socio;
        Telescopio = telescopio;
        Montura = montura;
        FechaInicio = inicio;
        FechaFin = fin;
        Camara = camara;
        Ocular = ocular;
        Estado = EstadoPrestamo.EN_PRESTAMO;
    }

    private void Validar(Telescopio t, Montura m, Camara? c)
    {
        // peso con carga
        if (t.Peso > m.CargaUtil) throw new Exception("La montura no soporta el peso del telescopio.");

        // Cámara  vs Tipo de montura
        if (c != null && (m.TipoMontura != TipoMontura.Ecuatorial && m.TipoMontura != TipoMontura.Hibrida)) throw new Exception("Para usar una cámara se requiere una montura Ecuatorial o Híbrida.");
    }

    private void ValidarSeleccionMinima(Camara? c, Ocular? o)
    {
        if (c == null && o == null) throw new Exception("Debe seleccionar al menos una cámara o un ocular.");
    }
}