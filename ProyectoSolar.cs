
// Clase derivada para proyectos solares

class ProyectoSolar : ProyectoEnergia
{
    public string TipoPaneles { get; set; }
    public double AreaInstalacion { get; set; }
    public double EficienciaPaneles { get; set; }
    public string OrientacionPaneles { get; set; }

    public override double CalcularRendimiento()
    {
        return AreaInstalacion * (EficienciaPaneles / 100) * 1000 * 0.75;
    }

    public override void MostrarDetalles()
    {
        Console.WriteLine($"ID: {ID}");
        Console.WriteLine($"Nombre del Proyecto: {NombreProyecto}");
        Console.WriteLine($"Tipo de Energía: {TipoEnergia}");
        Console.WriteLine($"Fecha de Inicio: {FechaInicio.ToShortDateString()}");
        Console.WriteLine($"Tipo de Paneles: {TipoPaneles}");
        Console.WriteLine($"Área de Instalación: {AreaInstalacion} m²");
        Console.WriteLine($"Eficiencia de los Paneles: {EficienciaPaneles}%");
        Console.WriteLine($"Orientación de los Paneles: {OrientacionPaneles}");
        Console.WriteLine($"Rendimiento Anual: {CalcularRendimiento():F2} kWh/año");
    }
}
