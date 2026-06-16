using ConexionBD;
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
    }
}

