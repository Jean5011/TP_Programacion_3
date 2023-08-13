using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Dao
{
    class Accesos
    {
        string ruta = "Data Source=JEAN5011\\SQLEXPRESS;Initial Catalog=BDSucursales;Integrated Security=True";
        public Accesos()
        {

        }

        private SqlConnection conexion()
        {
            SqlConnection cn = new SqlConnection(ruta);
            try
            {
                cn.Open();
                return cn;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        private SqlDataAdapter ObtenerAdaptador(String consultaSql, SqlConnection cn)
        {
            SqlDataAdapter adaptador;
            try
            {
                adaptador = new SqlDataAdapter(consultaSql, cn);
                return adaptador;
            }
            catch (Exception ex)
            {
                return null;
            }
        }


        public DataTable ObtenerTabla(String NombreTabla, String Sql)
        {
            DataSet ds = new DataSet();
            SqlConnection Conexion = conexion();
            SqlDataAdapter adp = ObtenerAdaptador(Sql, Conexion);
            adp.Fill(ds, NombreTabla);
            Conexion.Close();
            return ds.Tables[NombreTabla];
        }

        public void cerrar(SqlDataReader cn)///Cerrar conexion que dejemos abierta 
        {
            cn.Close();
        }
        public int ejecutaTransaccion(String consulta)/// Ejecutar condigo Sql
        {
            SqlCommand comando = new SqlCommand(consulta, conexion());
            int filasAfectadas = comando.ExecuteNonQuery();
            return filasAfectadas;
        }

        public SqlDataReader ObtenerDatos(String consulta)///Para rellenar Herramientas 
        {
            SqlCommand command = new SqlCommand(consulta, conexion());
            SqlDataReader reader = command.ExecuteReader();
            return reader;
        }
    }
}
