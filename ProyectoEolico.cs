
// Clase derivada para proyectos eólicos

class ProyectoEolico : ProyectoEnergia
{
    public int NumeroTurbinas { get; set; }
    public double PotenciaTurbina { get; set; }
    public double VelocidadVientoPromedio { get; set; }
    public double AlturaTorre { get; set; }

    public override double CalcularRendimiento()
    {
        return NumeroTurbinas * PotenciaTurbina * 8760 * 0.35;
    }

    public override void MostrarDetalles()
    {
        Console.WriteLine($"ID: {ID}");
        Console.WriteLine($"Nombre del Proyecto: {NombreProyecto}");
        Console.WriteLine($"Tipo de Energía: {TipoEnergia}");
        Console.WriteLine($"Fecha de Inicio: {FechaInicio.ToShortDateString()}");
        Console.WriteLine($"Número de Turbinas: {NumeroTurbinas}");
        Console.WriteLine($"Potencia por Turbina: {PotenciaTurbina} MW");
        Console.WriteLine($"Velocidad Promedio del Viento: {VelocidadVientoPromedio} m/s");
        Console.WriteLine($"Altura de la Torre: {AlturaTorre} m");
        Console.WriteLine($"Rendimiento Anual: {CalcularRendimiento():F2} MWh/año");
    }
}
