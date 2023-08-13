using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace Tp5
{
    public class Base_datos
    {
        string Ruta = "Data Source=PCOK\\SQLEXPRESS;Initial Catalog=BDSucursales;Integrated Security=True";

        public SqlDataReader ObtenerDatos(String consulta)///Para rellenar Herramientas 
        {
            SqlConnection conexion = new SqlConnection(Ruta);
            SqlCommand command = new SqlCommand(consulta, conexion);
            conexion.Open();
            SqlDataReader reader = command.ExecuteReader();
            return reader;
        }

        public void cerrar(SqlDataReader cn)///Cerrar conexion que dejemos abierta 
        {
            cn.Close();
        }
        public int ejecutaTransaccion(String consulta)/// Ejecutar condigo Sql
        {
            SqlConnection conexion = new SqlConnection(Ruta);
            conexion.Open();
            SqlCommand comando = new SqlCommand(consulta, conexion);
            int filasAfectadas = comando.ExecuteNonQuery();
            return filasAfectadas;
        }

    }
}