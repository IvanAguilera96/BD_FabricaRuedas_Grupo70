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
                datos.setearConsulta("SELECT IdVenta, IdCliente, NombreCliente, FechaVenta, Cuit, Telefono, Mail, TotalUnidadesVendidas, MontoTotalVendido FROM VW_ResumenVentas");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    ResumenVentaCliente aux = new ResumenVentaCliente();

                    aux.IdCliente = (int)datos.Lector["IdCliente"];
                    aux.NombreCliente = (string)datos.Lector["NombreCliente"];
                    aux.Cuit = (string)datos.Lector["Cuit"];
                    aux.FechaVenta = (DateTime)datos.Lector["FechaVenta"];
                    aux.Telefono = (string)datos.Lector["Telefono"];
                    aux.Mail = (string)datos.Lector["Mail"];
                    aux.IdVenta = (int)datos.Lector["IdVenta"];

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

        public List<ResumenVentaCliente> ListarClientes()
        {
            List<ResumenVentaCliente> lista = new List<ResumenVentaCliente>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                // Traemos los datos directamente de la tabla, sin pasar por la vista de ventas
                datos.setearConsulta("SELECT IdCliente, NombreCliente, Cuit, Telefono, Mail FROM Clientes");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    ResumenVentaCliente aux = new ResumenVentaCliente();

                    aux.IdCliente = (int)datos.Lector["IdCliente"];
                    aux.NombreCliente = (string)datos.Lector["NombreCliente"];
                    aux.Cuit = (string)datos.Lector["Cuit"];

                    // Validamos nulos por si las dudas en los campos de contacto
                    aux.Telefono = !(datos.Lector["Telefono"] is DBNull) ? (string)datos.Lector["Telefono"] : "";
                    aux.Mail = !(datos.Lector["Mail"] is DBNull) ? (string)datos.Lector["Mail"] : "";

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
