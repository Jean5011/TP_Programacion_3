using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Dao
{
    public class DaoProvincia
    {
        public SqlDataReader DatosProvincia(String consulta)/// Ejecutar condigo Sql
        {
            Accesos cn = new Accesos();
            return cn.ObtenerDatos(consulta);
        }
    }
}
