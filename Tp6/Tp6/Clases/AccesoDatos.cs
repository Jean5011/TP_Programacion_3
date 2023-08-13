using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Tp6.Clases
{
    public class AccesoDatos
    {
        string ruta = "Data Source=PCOK\\SQLEXPRESS;Initial Catalog=Neptuno;Integrated Security=True";
         public AccesoDatos() { }
         
        public SqlConnection ObtenerConexion()
        {
            SqlConnection nc = new SqlConnection(ruta);
            try
            {
                nc.Open();
                return nc;
            }
            catch(Exception ex)
            {
                return null;
            }

        }

        public SqlDataAdapter ObtenerAdaptador(string consulta)
        {
            SqlDataAdapter adap;
            try
            {
                adap = new SqlDataAdapter(consulta, ObtenerConexion());
                return adap;
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public int EjecutarProcedimientos(SqlCommand Comando, String NombreSP)
        {
            int FilaCambiadas;
            SqlConnection cn = ObtenerConexion();
            SqlCommand cmd = new SqlCommand();
            cmd = Comando;
            cmd.Connection =cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = NombreSP;
            FilaCambiadas = cmd.ExecuteNonQuery();
            return FilaCambiadas;
        }
    }
}