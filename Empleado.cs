using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reto_abstraccion_interfaces
{
    // Clase abstracta que representa a un empleado del restaurante
    public abstract class Empleado : IReportable
    {
        private string nombre;
        private int edad;

        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    nombre = value;
                else
                    throw new ArgumentException("El nombre no puede estar vacío.");
            }
        }

        public int Edad
        {
            get { return edad; }
            set
            {
                if (value > 0)
                    edad = value;
                else
                    throw new ArgumentException("La edad debe ser positiva.");
            }
        }

        public Empleado(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        public abstract void RealizarResponsabilidad();
        public virtual void Reportar()
        {
            Console.WriteLine($"{Nombre} está reportando su actividad.");
        }

        public virtual void GenerarReporte()
        {
            Console.WriteLine($"Reporte general de {Nombre}.");
        }
    }
}
