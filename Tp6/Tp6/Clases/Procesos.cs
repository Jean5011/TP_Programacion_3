using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Tp6.Clases
{
    public class Procesos
    {
        public Procesos() { }

        private DataTable ObtenerTabal(string nombre, string sql)
        {
            DataSet ds = new DataSet();
            AccesoDatos datos = new AccesoDatos();
            SqlDataAdapter adap = datos.ObtenerAdaptador(sql);
            adap.Fill(ds, nombre);
            return ds.Tables[nombre];
        } 

        public DataTable ObtenerTodosLosProductos()
        {
            return ObtenerTabal("Procudto", "select * from Productos");
        }

        private void ArmarParametroProductoEliminar(ref SqlCommand Comando, Producto Producto)
        {
            SqlParameter sqlPametros = new SqlParameter();
            sqlPametros = Comando.Parameters.Add("@IdProducto", SqlDbType.Int);
            sqlPametros.Value = Producto.IdProducto; 
        }
            private void ArmarParametroProducto(ref SqlCommand Comando, Producto Producto)
        {
            SqlParameter sqlPametros = new SqlParameter();
            sqlPametros = Comando.Parameters.Add("@IdProducto", SqlDbType.Int);
            sqlPametros.Value = Producto.IdProducto;
            sqlPametros = Comando.Parameters.Add("@NombreProducto", SqlDbType.NVarChar ,40);
            sqlPametros.Value = Producto.NombreProducto;
            sqlPametros = Comando.Parameters.Add("@CantidadPorUnidad", SqlDbType.NVarChar, 20);
            sqlPametros.Value = Producto.CantidadPorUnidad;
            sqlPametros = Comando.Parameters.Add("@PrecioUnidad", SqlDbType.Money);
            sqlPametros.Value = Producto.PrecioUnidad;
        }

        public bool ActualizarProducto(Producto pro)
        {
            SqlCommand comado = new SqlCommand();
            ArmarParametroProducto(ref comado, pro);
            AccesoDatos ad = new AccesoDatos();
            int FilasInsertadas = ad.EjecutarProcedimientos(comado, "spActualizarProducto");
            if (FilasInsertadas == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool EliminarProcudto(Producto pro)
        {
            SqlCommand comado = new SqlCommand();
            ArmarParametroProductoEliminar(ref comado, pro);
            AccesoDatos ad = new AccesoDatos();
            int FilasInsertadas = ad.EjecutarProcedimientos(comado, "spEliminarProducto");
            if (FilasInsertadas == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
 

    }
}