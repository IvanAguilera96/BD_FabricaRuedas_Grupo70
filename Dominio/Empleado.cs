using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Empleado
    {
        public int IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Legajo { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string Telefono { get; set; }
        public string Cargo { get; set; }
        public int IdArea { get; set; }
        // Nullable el jefe no tiene supervisor
        public int? IdSupervisor { get; set; }
    }
}
