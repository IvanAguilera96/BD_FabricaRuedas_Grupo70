using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Suministro
    {
        public int IdSuministro { get; set; }
        public int IdProveedor { get; set; }
        public string Descripcion { get; set; }
        public int CantdRecibida { get; set; }
        public DateTime FechaEntrega { get; set; }
    }
}
