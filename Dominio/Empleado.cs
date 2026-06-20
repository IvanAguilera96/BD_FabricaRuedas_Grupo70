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
        public string Cuit { get; set; }
        public int Legajo { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string Telefono { get; set; }
        public string Cargo { get; set; }
        public Area Area { get; set; }
        public Empleado Supervisor { get; set; }

        public string NombreArea
        {
            get
            {
                if(Area != null)
                    return Area.NombreArea;

                return "Sin Área";
            }
        }

        public string NombreSupervisor
        {
            get
            {
                if (Supervisor != null)
                    return Supervisor.Nombre + " " + Supervisor.Apellido;

                return "Sin Jefe";
            }
        }
        public string NombreCompleto
        {
            get { return Nombre + " " + Apellido; }
        }
    } 
}
