using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dao;

namespace Negocio
{
    public class Negocio_Provincia
    {
        public SqlDataReader Provincia()
        {
            DaoProvincia prov = new DaoProvincia();
            string Consulta = "select * from Provincia";
            return prov.DatosProvincia(Consulta);
        } 
    }
}
