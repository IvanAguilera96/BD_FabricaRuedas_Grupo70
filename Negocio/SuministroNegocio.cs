using ConexionBD;
using Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class SuministroNegocio
    {
        public List<Suministro> Listar()
        {
            AccesoDatos datos = new AccesoDatos();
            List<Suministro> lista = new List<Suministro>();

            try
            {
                string consulta = @"SELECT S.IdSuministro, S.IdProveedor, P.NombreEmpresa, 
                                        S.Descripcion, S.CantdRecibida, S.FechaEntrega 
                                 FROM Suministros S
                                 INNER JOIN Proveedores P ON S.IdProveedor = P.IdProveedor";

                datos.setearConsulta(consulta);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Suministro aux = new Suministro();

                    aux.IdSuministro = (int)datos.Lector["IdSuministro"];
                    aux.IdProveedor = (int)datos.Lector["IdProveedor"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.CantdRecibida = (int)datos.Lector["CantdRecibida"];
                    aux.FechaEntrega = (DateTime)datos.Lector["FechaEntrega"];
                    aux.NombreEmpresa = (string)datos.Lector["NombreEmpresa"];

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
        public void Agregar(int idProveedor, string descripcion, int cantidadRecibida)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearProcedimiento("SP_IngresoSuministro");
                datos.setearParametros("@IdProveedor", idProveedor);
                datos.setearParametros("@Descripcion", descripcion);
                datos.setearParametros("@CantdRecibida", cantidadRecibida);

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
