using ConexionBD;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class AreaNegocio
    {
        public List<Area> Listar()
        {
            List<Area> lista = new List<Area>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select IdArea, NombreArea From Areas");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Area aux = new Area();
                    aux.IdArea = (int)datos.Lector["IdArea"];
                    aux.NombreArea = (string)datos.Lector["NombreArea"];

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
