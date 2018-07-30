using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class Productos
    {
        [Key]
        public int ProductoId { get; set; }
        public string Descripcion { get; set; }
        public decimal Ganancia { get; set; }
        public decimal Costo { get; set; }
        public decimal Precio { get; set; }
        public DateTime FechaIngreso { get; set; }
        public decimal Inventario { get; set; }

        public Productos()
        {
            ProductoId = 0;
            Descripcion = string.Empty;
            Ganancia = 0;
            Costo = 0;
            Precio = 0;
            FechaIngreso = DateTime.Now;
            Inventario = 0;
        }

        //public override string ToString()
        //{
        //    return this.Descripcion;
        //}

        public Productos(int productoId, string descripcion, decimal ganancia, decimal costo, decimal precio, DateTime fechaIngreso, decimal inventario)
        {
            ProductoId = productoId;
            Descripcion = descripcion;
            Ganancia = ganancia;
            Costo = costo;
            Precio = precio;
            FechaIngreso = fechaIngreso;
            Inventario = inventario;
        }
    }
}
