using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion.Dominio
{
    public class Rueda
    {
        public int IdRueda { get; set; }
        public string Modelo { get; set; }
        public string Medida { get; set; }
        public int CantDisponible { get; set; }
        public decimal PrecioUnitario { get; set; }
    }
}
