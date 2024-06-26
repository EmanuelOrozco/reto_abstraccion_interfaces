using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reto_abstraccion_interfaces
{
    // Clase que representa el restaurante
    public class Restaurante
    {
        private List<Empleado> empleados;
        private List<Orden> ordenes;
        private int proximoIdOrden = 1;

        public string Nombre { get; set; }

        public Restaurante(string nombre)
        {
            Nombre = nombre;
            empleados = new List<Empleado>();
            ordenes = new List<Orden>();
        }

        public void AgregarEmpleado(Empleado empleado)
        {
            if (empleado != null)
                empleados.Add(empleado);
            else
                throw new ArgumentNullException("El empleado no puede ser nulo.");
        }

        public void AgregarOrden(string descripcion, int cantidad, decimal precio)
        {
            if (empleados.Count == 0)
            {
                Console.WriteLine("No hay empleados disponibles para asignar la orden.");
                return;
            }

            // Asignar la orden al primer empleado disponible
            Empleado empleadoAsignado = empleados[ordenes.Count % empleados.Count];
            Orden orden = new Orden(proximoIdOrden++, descripcion, cantidad, precio, empleadoAsignado);
            ordenes.Add(orden);

            Console.WriteLine($"Orden {orden.Id} asignada a {empleadoAsignado.Nombre}.");
        }

        public void MostrarOrdenes()
        {
            foreach (var orden in ordenes)
            {
                Console.WriteLine(orden.MostrarDescripcion());
            }
        }

        public void IniciarTrabajo()
        {
            foreach (var empleado in empleados)
            {
                empleado.RealizarResponsabilidad();
            }
        }

        public void ReportarActividad()
        {
            foreach (var empleado in empleados)
            {
                empleado.Reportar();
            }
        }

        public void GenerarReporteGeneral()
        {
            Console.WriteLine($"Reporte General de {Nombre}:");
            foreach (var empleado in empleados)
            {
                empleado.GenerarReporte();
            }
        }
    }
}
