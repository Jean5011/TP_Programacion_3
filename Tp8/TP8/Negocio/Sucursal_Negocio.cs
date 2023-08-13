using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Dao;
using Entidades;

namespace Negocio
{
    public class Sucursal_Negocio
    {
        public int AgragarSucusal(Sucursal sur)
        {
            DaoSucursales serd = new DaoSucursales();
            return serd.agregarsucursal(sur);
            
        }

        public int EliminarSucusal(int id)
        {
            DaoSucursales daosuc = new DaoSucursales();
            Sucursal suc = new Sucursal();
            suc.Id_Sucursal1 = id;
            return daosuc.EliminarSurcursal(suc);
        }

        public DataTable  TodasSuscursal()
        {
            DaoSucursales sur = new DaoSucursales();
            string Consulta = "select * from Sucursal";
            return sur.obtenersuscursal(Consulta);
        }

        public DataTable IDSuscursal(int i)
        {
            DaoSucursales sur = new DaoSucursales();
            string Consulta = "select * from Sucursal where Id_Sucursal =" + i+"";
            return sur.obtenersuscursal(Consulta);
        }

    }
}
