using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class DetalleVenta
    {
        public int IdDetalle { get; set; }
        public int IdVenta { get; set; }
        public int IdRueda { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }

        //Calcula el subtotal por producto/s que registra la venta.
        public decimal Subtotal
        {
            get
            {
                return Cantidad * PrecioUnitario;
            }
        }
    }
}
