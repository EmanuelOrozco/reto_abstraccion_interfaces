using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reto_abstraccion_interfaces
{
    // Clase derivada que representa a un recepcionista
    public class Recepcionista : Empleado
    {
        public Recepcionista(string nombre, int edad) : base(nombre, edad) { }

        public override void RealizarResponsabilidad()
        {
            Console.WriteLine($"{Nombre} está recibiendo a los clientes.");
        }

        public override void Reportar()
        {
            Console.WriteLine($"{Nombre} el recepcionista, está reportando el estado de la recepción.");
        }

        public override void GenerarReporte()
        {
            Console.WriteLine($"Reporte del recepcionista {Nombre}.");
        }
    }
}
