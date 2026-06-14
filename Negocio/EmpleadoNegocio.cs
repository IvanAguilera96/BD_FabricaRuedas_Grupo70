using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using ConexionBD;

namespace Negocio
{
    public class EmpleadoNegocio
    {
        public List<Empleado> listar()
        {
            List<Empleado> lista = new List<Empleado>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select * From VW_AsignacionesPersonal");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Empleado aux = new Empleado();
                    aux.IdEmpleado = (int)datos.Lector["IdEmpleado"];
                    aux.Legajo = (int)datos.Lector["Legajo"];
                    aux.Nombre = (string)datos.Lector["NombreEmpleado"];
                    aux.Apellido = (string)datos.Lector["ApellidoEmpleado"];
                    aux.Cargo = (string)datos.Lector["Cargo"];
                    aux.Telefono = (string)datos.Lector["TelefonoEmpleado"];
                    aux.FechaIngreso = (DateTime)datos.Lector["FechaIngreso"];

                    aux.Area = new Area();
                    aux.Area.NombreArea = (string)datos.Lector["Area"];

                    if (!(datos.Lector["IdSupervisor"] is DBNull))
                    {
                        aux.Supervisor = new Empleado();
                        aux.Supervisor.IdEmpleado = (int)datos.Lector["IdSupervisor"];
                        aux.Supervisor.Nombre = (string)datos.Lector["NombreSupervisor"];  
                        aux.Supervisor.Apellido = (string)datos.Lector["ApellidoSupervisor"]; 
                    }
                    else
                    {
                        aux.Supervisor = null;
                    }

                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void Agregar(Empleado nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearProcedimiento("SP_NuevoEmpleado");
                datos.setearParametros("@Nombre", nuevo.Nombre);
                datos.setearParametros("@Apellido", nuevo.Apellido);
                datos.setearParametros("@Legajo", nuevo.Legajo);
                datos.setearParametros("@Telefono", nuevo.Telefono);
                datos.setearParametros("@Cargo", nuevo.Cargo);
                datos.setearParametros("@Area", nuevo.Area.IdArea);

                if (nuevo.Supervisor != null && nuevo.Supervisor.IdEmpleado > 0)
                    datos.setearParametros("@IdSupervisor", nuevo.Supervisor.IdEmpleado);
                else
                    datos.setearParametros("@IdSupervisor", DBNull.Value);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
