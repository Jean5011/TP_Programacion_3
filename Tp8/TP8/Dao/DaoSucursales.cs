using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace Dao
{
   public class DaoSucursales
    {
        public DaoSucursales()
        {
             
        }

        public DataTable obtenersuscursal(string cons)
        {
            Accesos cn = new Accesos();
            return cn.ObtenerTabla("sur",cons);
        }

        public int EliminarSurcursal(Sucursal sur)
        {
            string cosulta = "delete from Sucursal where Id_Sucursal=" + sur.Id_Sucursal1;
            Accesos cn = new Accesos();
            int fila = cn.ejecutaTransaccion(cosulta);
            return fila;
        }

        public int agregarsucursal(Sucursal sur)
        {
            string Consulta = "insert into Sucursal(NombreSucursal,DescripcionSucursal,Id_ProvinciaSucursal,DireccionSucursal) values ('" + sur.NombreSucursal1 + "','" + sur.Direccion1 + "'," + sur.Id_ProvinciaSucursal1 + ",'" + sur.Direccion1 + "')";
            Accesos cn = new Accesos();
            int fila = cn.ejecutaTransaccion(Consulta);
            return fila;
        } 
        


    }
}
