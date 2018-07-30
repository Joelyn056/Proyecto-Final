using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Entidades
{
    public class Facturas
    {
        [Key]
        public int FacturaId { get; set; }
        public int ClienteId { get; set; }
        public DateTime Fecha { get; set; }
        public Decimal SubTotal { get; set; }
        public Decimal Itbis { get; set; }
        public Decimal Total { get; set; }

        public virtual ICollection<FacturaDetalle> Detalle { get; set; }

        public Facturas()
        {
            this.Detalle = new List<FacturaDetalle>();
        }

        public void AgregarDetalle(int id, int facturaId,  int productoId, string desc, int cantidad,decimal precio, decimal importe)
        {
            this.Detalle.Add(new FacturaDetalle(id, facturaId, productoId, desc, cantidad,precio, importe));
        }

        public override string ToString()
        {
            return FacturaId.ToString();
        }
    }
}
