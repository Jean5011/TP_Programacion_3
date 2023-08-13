using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tp5
{
    public partial class Agregar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string Consulta = "select * from Provincia";
            Base_datos Datos = new Base_datos();
            DropDownList1.DataSource = Datos.ObtenerDatos(Consulta);
            DropDownList1.DataTextField = "DescripcionProvincia";
            DropDownList1.DataValueField = "Id_Provincia";
            DropDownList1.DataBind();
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
             
            string Consulta = "insert into Sucursal(NombreSucursal,DescripcionSucursal,Id_ProvinciaSucursal,DireccionSucursal) values ('"+TextBox1.Text+"','"+TextBox2.Text+"',"+DropDownList1.SelectedValue+",'"+TextBox4.Text+"')";

            Base_datos datos = new Base_datos();
            int FilasAfectadas = datos.ejecutaTransaccion(Consulta);
            if (FilasAfectadas  == 0)
            {
                Label1.Text = "Error";
            }
            else
            {
                Label1.Text = "fue cargado con exito";
            }
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox4.Text = "";
        }
    }
}