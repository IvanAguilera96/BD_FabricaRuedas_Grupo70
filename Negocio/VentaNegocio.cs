using ConexionBD;
using Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class VentaNegocio
    {

        public int RegistrarVenta(int idCliente, int idRueda, int cantidad)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearProcedimiento("SP_RegistrarVenta");

                datos.setearParametros("@IdCliente", idCliente);
                datos.setearParametros("@IdRueda", idRueda);
                datos.setearParametros("@Cantidad", cantidad);

                // Configuro el parametro OUTPUT usando la nueva propiedad 'Comando'
                SqlParameter paramOutput = new SqlParameter("@IdVenta", SqlDbType.Int);
                paramOutput.Direction = ParameterDirection.InputOutput;
                paramOutput.Value = 0; // Le mandamos 0 para indicar nueva factura

                datos.Comando.Parameters.Add(paramOutput);

                datos.ejecutarAccion();

                int idVentaGenerado = Convert.ToInt32(paramOutput.Value);

                return idVentaGenerado;
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


        public int RegistrarVentaCompleta(Venta nuevaVenta)
        {
            int idVentaAsignado = 0; // Arranca en 0 para indicar "Nueva Venta"

            try
            {
                // Recorremos cada uno de los renglones que el usuario cargó en la grilla temporal
                foreach (DetalleVenta item in nuevaVenta.Detalle)
                {
                    AccesoDatos datos = new AccesoDatos();

                    try
                    {
                        // Seteamos el SP en cada iteración
                        datos.setearProcedimiento("SP_RegistrarVenta");

                        datos.setearParametros("@IdCliente", nuevaVenta.IdCliente);
                        datos.setearParametros("@IdRueda", item.IdRueda);
                        datos.setearParametros("@Cantidad", item.Cantidad);

                        SqlParameter paramOutput = new SqlParameter("@IdVenta", SqlDbType.Int);
                        paramOutput.Direction = ParameterDirection.InputOutput;

                        paramOutput.Value = idVentaAsignado;
                        datos.Comando.Parameters.Add(paramOutput);

                        datos.ejecutarAccion();

                        idVentaAsignado = Convert.ToInt32(paramOutput.Value);
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

                return idVentaAsignado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        
        }
    }
}

