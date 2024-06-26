using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reto_abstraccion_interfaces
{
    // Clase que representa una orden en el restaurante
    public class Orden
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public Empleado EmpleadoAsignado { get; set; }

        public Orden(int id, string descripcion, int cantidad, decimal precio, Empleado empleadoAsignado)
        {
            Id = id;
            Descripcion = descripcion;
            Cantidad = cantidad;
            Precio = precio;
            EmpleadoAsignado = empleadoAsignado;
        }

        public decimal CalcularCostoTotal()
        {
            return Cantidad * Precio;
        }

        public string MostrarDescripcion()
        {
            return $"Orden {Id}: {Descripcion}, Cantidad: {Cantidad}, Precio por unidad: {Precio:C}, Asignado a: {EmpleadoAsignado.Nombre}.";
        }
    }
}
