
// Clase para gestionar proyectos

class GestorProyectos
{
    private Dictionary<int, ProyectoEnergia> proyectos = new Dictionary<int, ProyectoEnergia>();

    public void AltaProyecto(ProyectoEnergia proyecto)
    {
        double rendimiento = proyecto.CalcularRendimiento();

        // Verifica el rendimiento mínimo
        if (proyecto is ProyectoSolar && rendimiento < 50000)
        {
            throw new Exception("El rendimiento de un proyecto solar debe ser al menos de 50 MWh/año.");
        }
        else if (proyecto is ProyectoEolico && rendimiento < 100000)
        {
            throw new Exception("El rendimiento de un proyecto eólico debe ser al menos de 100 MWh/año.");
        }

        proyectos[proyecto.ID] = proyecto;
        Console.WriteLine("Proyecto registrado con éxito.");
    }

    public void EliminarProyecto(int id)
    {
        if (proyectos.Remove(id))
        {
            Console.WriteLine("Proyecto eliminado con éxito.");
        }
        else
        {
            Console.WriteLine("No se encontró un proyecto con ese ID.");
        }
    }

    public void ListarProyectosPorTipo(string tipo)
    {
        foreach (var proyecto in proyectos.Values)
        {
            if (proyecto.TipoEnergia.Equals(tipo, StringComparison.OrdinalIgnoreCase))
            {
                proyecto.MostrarDetalles();
                Console.WriteLine();
            }
        }
    }

    public void ConsultarProyectoPorID(int id)
    {
        if (proyectos.TryGetValue(id, out var proyecto))
        {
            proyecto.MostrarDetalles();
        }
        else
        {
            Console.WriteLine("No se encontró un proyecto con ese ID.");
        }
    }

    public void ResumenProyectos()
    {
        foreach (var proyecto in proyectos.Values)
        {
            Console.WriteLine($"ID: {proyecto.ID} - Nombre: {proyecto.NombreProyecto} - Tipo: {proyecto.TipoEnergia}");
        }
    }
}
