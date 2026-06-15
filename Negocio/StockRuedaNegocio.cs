using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using ConexionBD;

namespace Negocio
{
    public class StockRuedaNegocio
    {
        public List<Rueda> Listar()
        {
            List<Rueda> lista = new List<Rueda>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT IdRueda, Modelo, Medida, CantDisponible, PrecioUnitario FROM StockRuedas");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Rueda aux = new Rueda();
                    aux.IdRueda = (int)datos.Lector["IdRueda"];
                    aux.Modelo = (string)datos.Lector["Modelo"];
                    aux.Medida = (string)datos.Lector["Medida"];
                    aux.CantDisponible = (int)datos.Lector["CantDisponible"];
                    aux.PrecioUnitario = (decimal)datos.Lector["PrecioUnitario"];

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
        public List<Rueda> ListarStockCritico()
        {
            List<Rueda> lista = new List<Rueda>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select * from VW_StockCritico");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Rueda aux = new Rueda();
                    aux.IdRueda = (int)datos.Lector["IdRueda"];
                    aux.Modelo = (string)datos.Lector["Modelo"];
                    aux.Medida = (string)datos.Lector["Medida"];
                    aux.CantDisponible = (int)datos.Lector["CantDisponible"];
                    aux.PrecioUnitario = (decimal)datos.Lector["PrecioUnitario"];

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
