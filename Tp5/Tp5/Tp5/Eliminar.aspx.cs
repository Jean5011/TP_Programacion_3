using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tp5
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string cosulta = "delete from Sucursal where Id_Sucursal=" + TextBox1.Text;
            Base_datos cn = new Base_datos();
            int fila = cn.ejecutaTransaccion(cosulta);
            if(fila == 0)
            {
                Label1.BackColor = System.Drawing.Color.Red;
                Label1.Text = "error ingrese un Id de sucursal";
            }
            else
            {
                Label1.BackColor = System.Drawing.Color.Red;
                Label1.Text = "La sucursal se ha eliminado con éxito";
            }
        }
    }
}