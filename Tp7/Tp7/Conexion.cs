using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Tp7
{
    public class Conexion
    {
        string Ruta = "Data Source=PCOK\\SQLEXPRESS;Initial Catalog=BDSucursales;Integrated Security=True";
        public Conexion()
        {

        }

        public SqlConnection ObtenerConexion()
        {
            SqlConnection cn = new SqlConnection(Ruta);
            try
            {
                cn.Open();
                return cn;
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public SqlDataAdapter ObtenerAdaptaor(string consulta)
        {
            SqlDataAdapter adp;
            try
            {
                adp = new SqlDataAdapter(consulta, ObtenerConexion());
                return adp;

            }
            catch (SqlException ex)
            {
                return null;
            }
        }

        public DataTable obtenerTabla()
        {
            DataTable tb = new DataTable();
            DataColumn colm = new DataColumn("ID",System.Type.GetType("System.String"));
            tb.Columns.Add(colm);
            colm = new DataColumn("Nombre", System.Type.GetType("System.String"));
            tb.Columns.Add(colm);
            colm = new DataColumn("Descriccion", System.Type.GetType("System.String"));
            tb.Columns.Add(colm);
            return tb;

        }


    }
}