using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reto_abstraccion_interfaces
{
    // Clase derivada que representa a un bartender
    public class Bartender : Empleado
    {
        public Bartender(string nombre, int edad) : base(nombre, edad) { }

        public override void RealizarResponsabilidad()
        {
            Console.WriteLine($"{Nombre} está preparando bebidas.");
        }

        public override void Reportar()
        {
            Console.WriteLine($"{Nombre} el bartender, está reportando el estado del bar.");
        }

        public override void GenerarReporte()
        {
            Console.WriteLine($"Reporte del bartender {Nombre}.");
        }
    }
}
