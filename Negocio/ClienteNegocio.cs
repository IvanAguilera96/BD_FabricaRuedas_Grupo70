using ConexionBD;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ClienteNegocio
    {
        public List<ResumenVentaCliente> ListarResumenVentas()
        {
            List<ResumenVentaCliente> lista = new List<ResumenVentaCliente>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT IdCliente, NombreCliente, Cuit, Telefono, Mail, CantidadVentas, TotalUnidadesVendidas, MontoTotalVendido FROM VW_ResumenVentas");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    ResumenVentaCliente aux = new ResumenVentaCliente();

                    // Mapeamos uno a uno los campos de la vista
                    aux.IdCliente = (int)datos.Lector["IdCliente"];
                    aux.NombreCliente = (string)datos.Lector["NombreCliente"];
                    aux.Cuit = (string)datos.Lector["Cuit"];
                    aux.Telefono = (string)datos.Lector["Telefono"];
                    aux.Mail = (string)datos.Lector["Mail"];

                    // SQL devuelve estos calculados, los guardamos en sus variables
                    aux.CantidadVentas = (int)datos.Lector["CantidadVentas"];
                    aux.TotalUnidadesVendidas = (int)datos.Lector["TotalUnidadesVendidas"];
                    aux.MontoTotalVendido = (decimal)datos.Lector["MontoTotalVendido"];

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
    }
}
