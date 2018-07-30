using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Entidades
{
    public class FacturaDetalle
    {
        [Key]
        public int Id { get; set; }
        public int FacturaId { get; set; }
        public int ProductoId { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Importe { get; set; }   

        //[ForeignKey("FacturaId")]
        //public virtual Facturas Facturas { get; set; }

        //[ForeignKey("ProductoId")]
        //public virtual Productos Productos { get; set; }

        public FacturaDetalle()
        {
            this.Id = 0;
            this.FacturaId = 0;    
            this.ProductoId = 0;           
            this.Importe = 0;
            this.Cantidad = 0;
            Descripcion = string.Empty;
          
           
        }

        public FacturaDetalle(int id, int facturaId, int productoId,string desc, int cantidad, decimal precio, decimal importe)
        {
            Id = id;
            FacturaId = facturaId;         
            ProductoId = productoId;
            Descripcion = desc;
            Cantidad = cantidad;
            Precio = precio;
            Importe = importe;         
           
        }

    }
}
