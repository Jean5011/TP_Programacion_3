using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tp5
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Visible = false;
        }

        protected void Todo_Click(object sender, EventArgs e)
        {
            string Consulta = "select * from Sucursal";
            Base_datos cn = new Base_datos();
            GridView1.DataSource = cn.ObtenerDatos(Consulta);
            GridView1.DataBind();
        }


        protected void Por_Id_Click(object sender, EventArgs e)
        {
            string Consulta = "select * from Sucursal where Id_Sucursal = "+TextBox1.Text;
            Base_datos cn = new Base_datos();
            GridView1.DataSource = cn.ObtenerDatos(Consulta);
            GridView1.DataBind();
            if (GridView1.Rows.Count > 0)
            {
                GridView1.Visible = true;
            }
            else
            {
                Label1.Visible = true;
            }
           
        }
    }
}