using System;
using System.Collections.Generic;


// Clase base 
abstract class ProyectoEnergia
{
    public int ID { get; set; }
    public string NombreProyecto { get; set; }
    public string TipoEnergia { get; set; }
    public DateTime FechaInicio { get; set; }

    public abstract void MostrarDetalles();
    public abstract double CalcularRendimiento();
}
