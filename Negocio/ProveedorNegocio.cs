using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using ConexionBD;

namespace Dominio
{
    public class ProveedorNegocio
    {
        public List<Proveedor> Listar()
        {
            AccesoDatos datos = new AccesoDatos();
            List<Proveedor> lista = new List<Proveedor>();

            try
            {
                datos.setearConsulta("SELECT IdProveedor, NombreEmpresa, Cuit, Email FROM Proveedores");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Proveedor aux = new Proveedor();
                    aux.IdProveedor = (int)datos.Lector["IdProveedor"];
                    aux.NombreEmpresa = (string)datos.Lector["NombreEmpresa"];
                    aux.Cuit = (string)datos.Lector["Cuit"];
                    aux.Email = (string)datos.Lector["Email"];

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
