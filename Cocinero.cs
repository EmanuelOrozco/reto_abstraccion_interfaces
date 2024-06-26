using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reto_abstraccion_interfaces
{
    // Clase derivada que representa a un cocinero
    public class Cocinero : Empleado
    {
        public Cocinero(string nombre, int edad) : base(nombre, edad) { }

        public override void RealizarResponsabilidad()
        {
            Console.WriteLine($"{Nombre} está cocinando.");
        }

        public override void Reportar()
        {
            Console.WriteLine($"{Nombre} el cocinero, está reportando el estado de la cocina.");
        }

        public override void GenerarReporte()
        {
            Console.WriteLine($"Reporte del cocinero {Nombre}.");
        }
    }
}
