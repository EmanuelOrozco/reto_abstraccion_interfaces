namespace reto_abstraccion_interfaces
{
    class Program
    {
        static void Main()
        {
            // Crear instancias de diferentes empleados
            Cocinero cocinero = new Cocinero("Carlos", 30);
            Mesero mesero = new Mesero("Ana", 25);
            Bartender bartender = new Bartender("Luis", 28);
            Recepcionista recepcionista = new Recepcionista("Lucia", 35);

            // Crear instancia del restaurante
            Restaurante restaurante = new Restaurante("Restaurante Gourmet");

            // Agregar empleados al restaurante
            restaurante.AgregarEmpleado(cocinero);
            restaurante.AgregarEmpleado(mesero);
            restaurante.AgregarEmpleado(bartender);
            restaurante.AgregarEmpleado(recepcionista);

            // Iniciar trabajo de todos los empleados
            Console.WriteLine("Iniciando el trabajo de todos los empleados:");
            restaurante.IniciarTrabajo();

            // Agregar órdenes
            restaurante.AgregarOrden("Pasta", 2, 12.99m);
            restaurante.AgregarOrden("Ensalada", 1, 6.50m);
            restaurante.AgregarOrden("Cóctel", 3, 8.75m);

            // Mostrar todas las órdenes
            Console.WriteLine("\nMostrando todas las órdenes:");
            restaurante.MostrarOrdenes();

            // Reportar actividad de todos los empleados
            Console.WriteLine("\nReportando la actividad de todos los empleados:");
            restaurante.ReportarActividad();

            // Generar reporte general
            Console.WriteLine("\nGenerando reporte general:");
            restaurante.GenerarReporteGeneral();
        }
    }
}