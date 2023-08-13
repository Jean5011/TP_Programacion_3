using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Entidades;

namespace Vistass
{
    public partial class Eliminar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Sucursal_Negocio sur = new Sucursal_Negocio();
            int id = int.Parse(TextBox1.Text);
            sur.EliminarSucusal(id);
        }
    }
}