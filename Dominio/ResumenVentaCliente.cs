using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ResumenVentaCliente
    {
        public int IdCliente { get; set; }
        public string NombreCliente { get; set; }
        public string Cuit { get; set; }
        public string Telefono { get; set; }
        public string Mail { get; set; }
      
        public int TotalUnidadesVendidas { get; set; }
        public decimal MontoTotalVendido { get; set; }
        public int IdVenta { get; set; }
    }
}
