
// El Main
class Program
{
    static void Main(string[] args)
    {
        GestorProyectos gestor = new GestorProyectos();

        int opcion;
        do
        {
            Console.WriteLine("\n--- Menú de Gestión de Proyectos ---");
            Console.WriteLine("1. Dar de alta un nuevo proyecto");
            Console.WriteLine("2. Eliminar un proyecto");
            Console.WriteLine("3. Listar proyectos por tipo de energía");
            Console.WriteLine("4. Consultar un proyecto específico (por ID)");
            Console.WriteLine("5. Ver un resumen de todos los proyectos");
            Console.WriteLine("6. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("\nDar de alta un nuevo proyecto...");
                    Console.Write("¿El proyecto es 'Solar' o 'Eólico'? ");
                    string tipo = Console.ReadLine();

                    if (tipo.Equals("Solar", StringComparison.OrdinalIgnoreCase))
                    {
                        try
                        {
                            ProyectoSolar nuevoSolar = new ProyectoSolar();
                            Console.Write("Ingrese el ID del proyecto: ");
                            nuevoSolar.ID = int.Parse(Console.ReadLine());
                            Console.Write("Ingrese el nombre del proyecto: ");
                            nuevoSolar.NombreProyecto = Console.ReadLine();
                            nuevoSolar.TipoEnergia = "Solar";
                            Console.Write("Ingrese la fecha de inicio (YYYY-MM-DD): ");
                            nuevoSolar.FechaInicio = DateTime.Parse(Console.ReadLine());
                            Console.Write("Ingrese el tipo de paneles: ");
                            nuevoSolar.TipoPaneles = Console.ReadLine();
                            Console.Write("Ingrese el área de instalación (m²): ");
                            nuevoSolar.AreaInstalacion = double.Parse(Console.ReadLine());
                            Console.Write("Ingrese la eficiencia de los paneles (%): ");
                            nuevoSolar.EficienciaPaneles = double.Parse(Console.ReadLine());
                            Console.Write("Ingrese la orientación de los paneles: ");
                            nuevoSolar.OrientacionPaneles = Console.ReadLine();

                            gestor.AltaProyecto(nuevoSolar);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error al dar de alta el proyecto solar: {ex.Message}");
                        }
                    }
                    else if (tipo.Equals("Eólico", StringComparison.OrdinalIgnoreCase))
                    {
                        try
                        {
                            ProyectoEolico nuevoEolico = new ProyectoEolico();
                            Console.Write("Ingrese el ID del proyecto: ");
                            nuevoEolico.ID = int.Parse(Console.ReadLine());
                            Console.Write("Ingrese el nombre del proyecto: ");
                            nuevoEolico.NombreProyecto = Console.ReadLine();
                            nuevoEolico.TipoEnergia = "Eólica";
                            Console.Write("Ingrese la fecha de inicio (YYYY-MM-DD): ");
                            nuevoEolico.FechaInicio = DateTime.Parse(Console.ReadLine());
                            Console.Write("Ingrese el número de turbinas: ");
                            nuevoEolico.NumeroTurbinas = int.Parse(Console.ReadLine());
                            Console.Write("Ingrese la potencia de cada turbina (MW): ");
                            nuevoEolico.PotenciaTurbina = double.Parse(Console.ReadLine());
                            Console.Write("Ingrese la velocidad promedio del viento (m/s): ");
                            nuevoEolico.VelocidadVientoPromedio = double.Parse(Console.ReadLine());
                            Console.Write("Ingrese la altura de la torre (m): ");
                            nuevoEolico.AlturaTorre = double.Parse(Console.ReadLine());

                            gestor.AltaProyecto(nuevoEolico);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error al dar de alta el proyecto eólico: {ex.Message}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Tipo de proyecto no válido. Debe ser 'Solar' o 'Eólico'.");
                    }
                    break;

                case 2:
                    Console.Write("\nIngrese el ID del proyecto a eliminar: ");
                    int idEliminar = int.Parse(Console.ReadLine());
                    gestor.EliminarProyecto(idEliminar);
                    break;

                case 3:
                    Console.Write("\nIngrese el tipo de energía (Solar/Eólica): ");
                    string tipoEnergia = Console.ReadLine();
                    gestor.ListarProyectosPorTipo(tipoEnergia);
                    break;

                case 4:
                    Console.Write("\nIngrese el ID del proyecto: ");
                    int idConsulta = int.Parse(Console.ReadLine());
                    gestor.ConsultarProyectoPorID(idConsulta);
                    break;

                case 5:
                    Console.WriteLine("\nResumen de todos los proyectos:");
                    gestor.ResumenProyectos();
                    break;

                case 6:
                    Console.WriteLine("\nSaliendo del programa...");
                    break;

                default:
                    Console.WriteLine("\nOpción no válida. Intente de nuevo.");
                    break;
            }
        } while (opcion != 6);
    }
}
