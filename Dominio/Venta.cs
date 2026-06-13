using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Venta
    {
        public int IdVenta { get; set; }
        public int IdCliente { get; set; }
        public DateTime FechaVenta { get; set; }
        public decimal MontoTotal { get; set; }

        
        public List<DetalleVenta> Detalle { get; set; }

        public Venta()
        {
            Detalle = new List<DetalleVenta>();
        }
    }
}
